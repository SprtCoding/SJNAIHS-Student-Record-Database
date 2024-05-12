using Google.Cloud.Firestore;
using Student_Record.Firebase.Model;
using Student_Record.Firebase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OfficeOpenXml;
using System.Globalization;
using System.Reflection;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Student_Record.TeachersModule.GenerateRecords
{
    public partial class SF10Generated : Form
    {
        string faculty_id, student_id;
        private List<string> studentList = new List<string>();

        public SF10Generated(string faculty_id)
        {
            InitializeComponent();
            this.faculty_id = faculty_id;
        }

        private async void SF10Generated_Load(object sender, EventArgs e)
        {
            await getStudentName();
            setAutoCompleteTB(student_cbx);
        }

        private async void setAutoCompleteTB(ComboBox cb)
        {
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            source.AddRange(await getItem());
            cb.AutoCompleteCustomSource = source;
            cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private async Task<string[]> getItem()
        {
            // Clear the existing list
            studentList.Clear();

            try
            {
                var db = FirestoreHelper.database;
                if (db != null)
                {
                    CollectionReference colRef = db.Collection("students");

                    Query q = colRef.WhereEqualTo("faculty_id", this.faculty_id);

                    QuerySnapshot qSnap = await q.GetSnapshotAsync();

                    foreach (DocumentSnapshot snapshot in qSnap.Documents)
                    {
                        if (snapshot.Exists)
                        {
                            Students students = snapshot.ConvertTo<Students>();
                            studentList.Add(students.name);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Convert the list to an array and return
            return studentList.ToArray();
        }

        private async Task getStudentName()
        {
            // Clear the existing items in the ComboBox
            student_cbx.Items.Clear();

            try
            {
                var db = FirestoreHelper.database;
                if (db != null)
                {
                    CollectionReference colRef = db.Collection("students");

                    Query q = colRef.WhereEqualTo("faculty_id", this.faculty_id);

                    QuerySnapshot qSnap = await q.GetSnapshotAsync();

                    foreach (DocumentSnapshot snapshot in qSnap.Documents)
                    {
                        if (snapshot.Exists)
                        {
                            Students students = snapshot.ConvertTo<Students>();
                            // Capitalize the first letter of last_name
                            string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                            // Capitalize the first letter of last_name
                            string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);
                            // Capitalize the first letter of last_name
                            string capitalizedMiddleName = char.ToUpper(students.middle_name[0]) + students.middle_name.Substring(1);
                            // Concatenate the student's name
                            string studentName = capitalizedFirstName + " " + capitalizedMiddleName + " " + capitalizedLastName;

                            // Add the student's name to the ComboBox
                            student_cbx.Items.Add(studentName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string CapitalizeEachWord(string input)
        {
            // Split the input into words
            string[] words = input.Split(' ');

            // Capitalize the first letter of each word
            for (int i = 0; i < words.Length; i++)
            {
                // Ensure the word is not empty before capitalizing
                if (!string.IsNullOrEmpty(words[i]))
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower(); // Capitalize first letter and convert the rest to lowercase
                }
            }

            // Join the words back into a single string
            return string.Join(" ", words);
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private async void generate_btn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(student_cbx.Text))
            {
                lbl.Visible = true;
                loadingProgress.Visible = true;
                loadingProgress.Value = 25;

                string name = CapitalizeEachWord(student_cbx.Text);

                var db = FirestoreHelper.database;
                if (db != null)
                {
                    CollectionReference colRef = db.Collection("students");

                    // Query the student collection to find the document with the matching name
                    QuerySnapshot querySnapshot = await colRef
                        .WhereEqualTo("faculty_id", faculty_id)
                        .WhereEqualTo("name", name)
                        .GetSnapshotAsync();

                    // Determine the total number of documents in the query snapshot
                    int totalDocuments = querySnapshot.Documents.Count;
                    int processedDocuments = 0;

                    foreach (DocumentSnapshot doc in querySnapshot.Documents)
                    {
                        Students student = doc.ConvertTo<Students>();
                        // Process the student document here
                        student_id = student.id;
                        // Update progress bar
                        processedDocuments++;
                        double progress = (double)processedDocuments / totalDocuments * 100;
                        loadingProgress.Value = (int)progress;
                    }

                    if (processedDocuments > 0)
                    {
                        // At least one document was processed successfully
                        await generateRCardToExcel(this.student_id, name);
                    }
                    else
                    {
                        MessageBox.Show("Selected student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lbl.Visible = false;
                        loadingProgress.Visible = false;
                        loadingProgress.Value = 0;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select student before generating...");
                lbl.Visible = false;
                loadingProgress.Visible = false;
            }
        }

        private async void student_cbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrEmpty(student_cbx.Text))
                {
                    lbl.Visible = true;
                    loadingProgress.Visible = true;
                    loadingProgress.Value = 25;

                    string name = CapitalizeEachWord(student_cbx.Text);

                    var db = FirestoreHelper.database;
                    if (db != null)
                    {
                        CollectionReference colRef = db.Collection("students");

                        // Query the student collection to find the document with the matching name
                        QuerySnapshot querySnapshot = await colRef
                            .WhereEqualTo("faculty_id", faculty_id)
                            .WhereEqualTo("name", name)
                            .GetSnapshotAsync();

                        // Determine the total number of documents in the query snapshot
                        int totalDocuments = querySnapshot.Documents.Count;
                        int processedDocuments = 0;

                        foreach (DocumentSnapshot doc in querySnapshot.Documents)
                        {
                            Students student = doc.ConvertTo<Students>();
                            // Process the student document here
                            student_id = student.id;
                            // Update progress bar
                            processedDocuments++;
                            double progress = (double)processedDocuments / totalDocuments * 100;
                            loadingProgress.Value = (int)progress;
                        }

                        if (processedDocuments > 0)
                        {
                            // At least one document was processed successfully
                            await generateRCardToExcel(this.student_id, name);
                        }
                        else
                        {
                            MessageBox.Show("Selected student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            lbl.Visible = false;
                            loadingProgress.Visible = false;
                            loadingProgress.Value = 0;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select student before generating...");
                    lbl.Visible = false;
                    loadingProgress.Visible = false;
                }
            }
        }

        private async Task generateRCardToExcel(string id, string name)
        {
            string resourceName = "sf10_temp.xlsx";
            string relativeFilePath = Path.Combine("ExcelTemplate", resourceName);

            string assemblyPath = Assembly.GetExecutingAssembly().Location;
            string projectDirectory = Path.GetDirectoryName(assemblyPath);
            string sf10FilePath = Path.Combine(projectDirectory, relativeFilePath);

            //MessageBox.Show(sf10FilePath);

            // Specify the path to save the generated Excel file
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Save Generated Excel File",
                Filter = "Excel Files|*.xlsx;*.xls",
                FileName = name + "_SF10.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string saveFilePath = saveFileDialog.FileName;

                using (var package = new ExcelPackage(new FileInfo(sf10FilePath)))
                {
                    var db = FirestoreHelper.database;

                    if (db != null)
                    {
                        CollectionReference colRef = db.Collection("students");

                        Query q = colRef.WhereEqualTo("faculty_id", this.faculty_id)
                            .WhereEqualTo("id", id);

                        QuerySnapshot snap = await q.GetSnapshotAsync();

                        foreach (DocumentSnapshot snapshot in snap.Documents)
                        {
                            if (snapshot.Exists)
                            {
                                Students students = snapshot.ConvertTo<Students>();

                                // Access the "grade" subcollection for the current student
                                CollectionReference gradeRef = snapshot.Reference.Collection("Grades");

                                QuerySnapshot gradeSnap = await gradeRef.GetSnapshotAsync();

                                // Get the worksheet in your Excel template (by name or index)
                                var worksheet = package.Workbook.Worksheets[0]; // Adjust the index or name as needed
                                var worksheet2 = package.Workbook.Worksheets[1]; // Adjust the index or name as needed

                                if (students.grade_level == 11)
                                {
                                    int row = 16; // Start at row 15 in Excel (B15)
                                                  // Assuming you have student names in a DataGridView

                                    foreach (DocumentSnapshot gradeDoc in gradeSnap.Documents)
                                    {
                                        if (gradeDoc.Exists)
                                        {
                                            // Access and use data from the "grade" document
                                            // Example:
                                            Students grade = gradeDoc.ConvertTo<Students>();

                                            if (grade.sem.Equals("1"))
                                            {
                                                worksheet.Cells[row + 15, 63].Value = grade.sem + "ST"; //BK31

                                                switch (grade.subject)
                                                {
                                                    case "Oral Communication":
                                                        worksheet.Cells[row + 23, 46].Value = grade.mid_term_grade; //AT39
                                                        worksheet.Cells[row + 23, 51].Value = grade.final_term_grade; //AY39
                                                        break;
                                                    case "Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino":
                                                        worksheet.Cells[row + 24, 46].Value = grade.mid_term_grade; //AT40
                                                        worksheet.Cells[row + 24, 51].Value = grade.final_term_grade; //AY40
                                                        break;
                                                    case "21st Century Literature from the Philippines and the World":
                                                        worksheet.Cells[row + 25, 46].Value = grade.mid_term_grade; //AT41
                                                        worksheet.Cells[row + 25, 51].Value = grade.final_term_grade; //AY41
                                                        break;
                                                    case "General Mathematics":
                                                        worksheet.Cells[row + 26, 46].Value = grade.mid_term_grade; //AT42
                                                        worksheet.Cells[row + 26, 51].Value = grade.final_term_grade; //AY42
                                                        break;
                                                    case "Introduction to the Philosophy of the Human Person/Pambungad sa Pilosopiya ng Tao":
                                                        worksheet.Cells[row + 27, 46].Value = grade.mid_term_grade; //AT43
                                                        worksheet.Cells[row + 27, 51].Value = grade.final_term_grade; //AY43
                                                        break;
                                                    case "Physical Education and Health":
                                                        worksheet.Cells[row + 28, 46].Value = grade.mid_term_grade; //AT44
                                                        worksheet.Cells[row + 28, 51].Value = grade.final_term_grade; //AY44
                                                        break;
                                                    case "Electrical Installation & Maintenance NCII":
                                                        worksheet.Cells[row + 29, 46].Value = grade.mid_term_grade; //AT45
                                                        worksheet.Cells[row + 29, 51].Value = grade.final_term_grade; //AY45
                                                        break;
                                                }
                                            }
                                            else if (grade.sem.Equals("2"))
                                            {
                                                worksheet.Cells[row + 15, 63].Value = grade.sem + "ND"; //BK31
                                                switch (grade.subject)
                                                {
                                                    case "Reading and Writing":
                                                        worksheet.Cells[row + 66, 46].Value = grade.mid_term_grade; //AT82
                                                        worksheet.Cells[row + 66, 51].Value = grade.final_term_grade; //AY82
                                                        break;
                                                    case "Pagbasa at Pagsusuri ng Ibat ibang teksto tungo sa pananaliksik":
                                                        worksheet.Cells[row + 67, 46].Value = grade.mid_term_grade; //AT83
                                                        worksheet.Cells[row + 67, 51].Value = grade.final_term_grade; //AY83
                                                        break;
                                                    case "Understanding Culture, Society and Politics":
                                                        worksheet.Cells[row + 68, 46].Value = grade.mid_term_grade; //AT84
                                                        worksheet.Cells[row + 68, 51].Value = grade.final_term_grade; //AY84
                                                        break;
                                                    case "Statistics and Probability":
                                                        worksheet.Cells[row + 69, 46].Value = grade.mid_term_grade; //AT85
                                                        worksheet.Cells[row + 69, 51].Value = grade.final_term_grade; //AY85
                                                        break;
                                                    case "Physical Education and Health":
                                                        worksheet.Cells[row + 70, 46].Value = grade.mid_term_grade; //AT86
                                                        worksheet.Cells[row + 70, 51].Value = grade.final_term_grade; //AY86
                                                        break;
                                                    case "Practical Research 1":
                                                        worksheet.Cells[row + 71, 46].Value = grade.mid_term_grade; //AT87
                                                        worksheet.Cells[row + 71, 51].Value = grade.final_term_grade; //AY87
                                                        break;
                                                    case "Electrical Installation & Maintenance NCII":
                                                        worksheet.Cells[row + 72, 46].Value = grade.mid_term_grade; //AT88
                                                        worksheet.Cells[row + 72, 51].Value = grade.final_term_grade; //AY88
                                                        break;
                                                }
                                            }

                                            //worksheet.Cells[currentExcelRow, 4].Value = grade.final_term_grade;
                                        }
                                        else
                                        {
                                            // Handle the case where there is no data in the "grade" subcollection
                                        }
                                    }

                                    // Convert the birth date string to a DateTime object
                                    //DateTime birthDate = DateTime.ParseExact(students.dob, "dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

                                    // Calculate the age
                                    int age = CalculateAge(students.dob, DateTime.Now);

                                    // Capitalize the first letter of last_name
                                    string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                                    // Capitalize the first letter of last_name
                                    string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);
                                    // Capitalize the first letter of last_name
                                    string capitalizedMiddleName = char.ToUpper(students.middle_name[0]) + students.middle_name.Substring(1);

                                    //1st row
                                    worksheet.Cells[row, 6].Value = capitalizedLastName; // F16
                                    worksheet.Cells[row, 25].Value = capitalizedFirstName; // Y16
                                    worksheet.Cells[row, 52].Value = capitalizedMiddleName; // Y16

                                    DateTime dateNow = DateTime.UtcNow;
                                    DateTime addedOn = students.addedOn;
                                    // Get the year from the DateTime object
                                    int yearNow = dateNow.Year;

                                    DateTime dob = students.dob;

                                    //2nd row
                                    worksheet.Cells[row + 1, 3].Value = students.lrn_number; //C17
                                    worksheet.Cells[row + 1, 27].Value = dob.ToString("MM/dd/yyyy"); //AA17
                                    worksheet.Cells[row + 1, 40].Value = students.gender; //AN17
                                    worksheet.Cells[row + 1, 60].Value = addedOn.ToString("MM/dd/yyyy"); //BH17

                                    //3rd row
                                    worksheet.Cells[row + 15, 45].Value = students.grade_level; //AS31
                                    worksheet.Cells[row + 15, 53].Value = yearNow; //BA31

                                    //4th row
                                    worksheet.Cells[row + 17, 7].Value = students.strand; //G33
                                    worksheet.Cells[row + 17, 45].Value = students.section; //AS33
                                }
                                else if (students.grade_level == 12)
                                {
                                    int row = 4; // Start at row 15 in Excel (B15)
                                                 // Assuming you have student names in a DataGridView

                                    int Firstrow = 16;

                                    foreach (DocumentSnapshot gradeDoc in gradeSnap.Documents)
                                    {
                                        if (gradeDoc.Exists)
                                        {
                                            // Access and use data from the "grade" document
                                            // Example:
                                            Students grade = gradeDoc.ConvertTo<Students>();

                                            if (grade.sem.Equals("1"))
                                            {
                                                worksheet.Cells[Firstrow + 15, 63].Value = grade.sem + "ST"; //BK31

                                                switch (grade.subject)
                                                {
                                                    case "Personal Development/Pansariling Kaunlaran":
                                                        worksheet2.Cells[row + 7, 46].Value = grade.mid_term_grade; //AT11
                                                        worksheet2.Cells[row + 7, 51].Value = grade.final_term_grade; //AY11
                                                        break;
                                                    case "Earth and Life Science":
                                                        worksheet2.Cells[row + 8, 46].Value = grade.mid_term_grade; //C18
                                                        worksheet2.Cells[row + 8, 51].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Media and Information Literacy":
                                                        worksheet2.Cells[row + 9, 46].Value = grade.mid_term_grade; //C18
                                                        worksheet2.Cells[row + 9, 51].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Physical Education and Health":
                                                        worksheet2.Cells[row + 10, 46].Value = grade.mid_term_grade; //C18
                                                        worksheet2.Cells[row + 10, 51].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "English for Academic and Professional Purposes":
                                                        worksheet2.Cells[row + 11, 46].Value = grade.mid_term_grade; //C18
                                                        worksheet2.Cells[row + 11, 51].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Practical Research 2":
                                                        worksheet2.Cells[row + 12, 46].Value = grade.mid_term_grade; //C18
                                                        worksheet2.Cells[row + 12, 51].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Animal Production NCII":
                                                        worksheet2.Cells[row + 13, 46].Value = grade.mid_term_grade; //C18
                                                        worksheet2.Cells[row + 13, 51].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Food Fish Processing NCII":
                                                        worksheet2.Cells[row + 14, 46].Value = grade.mid_term_grade; //C18
                                                        worksheet2.Cells[row + 14, 51].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Illustration NCII":
                                                        worksheet2.Cells[row + 15, 46].Value = grade.mid_term_grade; //C18
                                                        worksheet2.Cells[row + 15, 51].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Computer Systems Servicing NCII":
                                                        worksheet2.Cells[row + 16, 46].Value = grade.mid_term_grade; //C18
                                                        worksheet2.Cells[row + 16, 51].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Agricultural Crops Production NC II":
                                                        worksheet2.Cells[row + 17, 46].Value = grade.mid_term_grade; //C18
                                                        worksheet2.Cells[row + 17, 51].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Tailoring NCII":
                                                        worksheet2.Cells[row + 18, 46].Value = grade.mid_term_grade; //C18
                                                        worksheet2.Cells[row + 18, 51].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Electrical Installation & Maintenance NCII":
                                                        worksheet2.Cells[row + 19, 46].Value = grade.mid_term_grade; //C18
                                                        worksheet2.Cells[row + 19, 51].Value = grade.final_term_grade; //C18
                                                        break;
                                                }
                                            }
                                            else if (grade.sem.Equals("2"))
                                            {
                                                worksheet.Cells[Firstrow + 15, 63].Value = grade.sem + "ND"; //BK31
                                                switch (grade.subject)
                                                {
                                                    case "Contemporary Philippine Arts from the Regions":
                                                        worksheet.Cells[row + 51, 46].Value = grade.mid_term_grade; //AT55
                                                        worksheet.Cells[row + 51, 51].Value = grade.final_term_grade; //AY55
                                                        break;
                                                    case "Physical Science":
                                                        worksheet.Cells[row + 52, 46].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[row + 52, 51].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Physical Education and Health":
                                                        worksheet.Cells[row + 53, 46].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[row + 53, 51].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Filipino sa Piling Larang":
                                                        worksheet.Cells[row + 54, 46].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[row + 54, 51].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Empowerment Technologies":
                                                        worksheet.Cells[row + 55, 46].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[row + 55, 51].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Inquiries, Investigations and Immersion":
                                                        worksheet.Cells[row + 56, 46].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[row + 56, 51].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Entrepreneurship":
                                                        worksheet.Cells[row + 57, 46].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[row + 57, 51].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Work Immersion":
                                                        //worksheet.Cells[row + 58, 46].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[row + 58, 51].Value = grade.final_term_grade; //C18
                                                        break;
                                                }
                                            }

                                            //worksheet.Cells[currentExcelRow, 4].Value = grade.final_term_grade;
                                        }
                                        else
                                        {
                                            // Handle the case where there is no data in the "grade" subcollection
                                        }
                                    }

                                    // Convert the birth date string to a DateTime object
                                    //DateTime birthDate = DateTime.ParseExact(students.dob, "dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

                                    // Calculate the age
                                    int age = CalculateAge(students.dob, DateTime.Now);

                                    // Capitalize the first letter of last_name
                                    string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                                    // Capitalize the first letter of last_name
                                    string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);
                                    // Capitalize the first letter of last_name
                                    string capitalizedMiddleName = char.ToUpper(students.middle_name[0]) + students.middle_name.Substring(1);

                                    //1st row
                                    worksheet.Cells[Firstrow, 6].Value = capitalizedLastName; // F16
                                    worksheet.Cells[Firstrow, 25].Value = capitalizedFirstName; // Y16
                                    worksheet.Cells[Firstrow, 52].Value = capitalizedMiddleName; // Y16

                                    DateTime dateNow = DateTime.UtcNow;
                                    DateTime addedOn = students.addedOn;
                                    // Get the year from the DateTime object
                                    int yearNow = dateNow.Year;

                                    DateTime dob = students.dob;

                                    //2nd row
                                    worksheet.Cells[Firstrow + 1, 3].Value = students.lrn_number; //C17
                                    worksheet.Cells[Firstrow + 1, 27].Value = dob.ToString("MM/dd/yyyy"); //AA17
                                    worksheet.Cells[Firstrow + 1, 40].Value = students.gender; //AN17
                                    worksheet.Cells[Firstrow + 1, 60].Value = addedOn.ToString("MM/dd/yyyy"); //BH17

                                    //3rd row
                                    worksheet.Cells[Firstrow + 15, 45].Value = students.grade_level; //AS31
                                    worksheet.Cells[Firstrow + 15, 53].Value = yearNow; //BA31

                                    //4th row
                                    worksheet.Cells[Firstrow + 17, 7].Value = students.strand; //G33
                                    worksheet.Cells[Firstrow + 17, 45].Value = students.section; //AS33
                                }
                            }
                            else
                            {
                                MessageBox.Show("No data found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                        // Save the Excel file with the updated data
                        //var saveFilePath = "C:\\Users\\adrle\\source\\repos\\Student Record\\Student Record\\ExcelTemplate\\GRADING-SHEET-SUMMARY.xlsx"; // Specify the path for the updated file
                        package.SaveAs(new FileInfo(saveFilePath));
                        MessageBox.Show("form 137 generated and saved.");
                        lbl.Visible = false;
                        loadingProgress.Visible = false;
                        loadingProgress.Value = 0;
                    }
                }
            }
        }

        // Function to calculate age
        private int CalculateAge(DateTime birthDate, DateTime currentDate)
        {
            int age = currentDate.Year - birthDate.Year;

            // If the birth date hasn't occurred yet this year, subtract one year
            if (birthDate > currentDate.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        private void student_cbx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
