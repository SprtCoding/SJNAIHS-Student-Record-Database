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
using Student_Record.AdminModule.Student;
using OfficeOpenXml;
using Student_Record.Loaders;
using Student_Record.TeachersModule.GradingSheetNew;
using Bunifu.Framework.UI;
using Student_Record.TeachersModule.ReportSubmit;
using Student_Record.TeachersModule.GradingSheetPrint;
using System.IO;
using static Google.Cloud.Firestore.V1.StructuredQuery.Types;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using Student_Record.TeachersModule.GenerateRecords;

namespace Student_Record.TeachersModule
{
    public partial class GradingSheet : Form
    {
        private string? faculty_id, faculty_name;
        private BunifuFlatButton? currentBtn;
        private Color activeColor = Color.FromArgb(129, 142, 254);
        private Color originalColor = Color.FromArgb(43, 47, 84);

        int pageSize = 8; // Number of records per page
        int currentPage = 1, studentCount = 0; // Current page number

        public static string[] g11_1st_subject = new string[] {
                "Any",
                "Oral Communication",
                "Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino",
                "21st Century Literature from the Philippines and the World",
                "General Mathematics",
                "Introduction to the Philosophy of the Human Person/Pambungad sa Pilosopiya ng Tao",
                "Physical Education and Health",
                "TVE"
        };

        public static string[] g11_2nd_subject = new string[] {
                "Any",
                "Reading and Writing",
                "Pagbasa at Pagsusuri ng Ibat ibang teksto tungo sa pananaliksik",
                "Understanding Culture, Society and Politics",
                "Statistics and Probability",
                "Physical Education and Health",
                "Practical Research 1",
                "TVE"
        };

        public static string[] g12_1st_subject = new string[] {
                "Any",
                "Personal Development/Pansariling Kaunlaran",
                "Earth and Life Science",
                "Media and Information Literacy",
                "Physical Education and Health",
                "English for Academic and Professional Purposes",
                "Practical Research 2",
                "TVE"
        };

        public static string[] g12_2nd_subject = new string[] {
                "Any",
                "Contemporary Philippine Arts from the Regions",
                "Physical Science",
                "Physical Education and Health",
                "Filipino sa Piling Larang",
                "Empowerment Technologies",
                "Inquiries, Investigations and Immersion",
                "Entrepreneurship",
                "TVE"
        };

        public static string[] g11_tve_subject = new string[] {
                "Any",
                "Electrical Installation & Maintenance NCII"
        };

        public static string[] g11_tve2_subject = new string[] {
                "Any",
                "Electrical Installation & Maintenance NCII"
        };

        public static string[] g12_tve_subject = new string[] {
                "Any",
                "Animal Production NCII",
                "Food Fish Processing NCII",
                "Illustration NCII",
                "Computer Systems Servicing NCII",
                "Agricultural Crops Production NC II",
                "Tailoring NCII",
                "Electrical Installation & Maintenance NCII"
        };

        public static string[] g12_tve2_subject = new string[] {
                "Any",
                "Work Immersion"
        };

        public GradingSheet(string? id, string? name)
        {
            InitializeComponent();

            faculty_id = id;
            faculty_name = name;

            grade_level_cbx.SelectedIndex = 0;
        }

        #region get Student Pagination without filter

        /*// Method to handle loading data for the next page
        async void LoadNextPage()
        {
            no_data_panel.Visible = true;
            no_data_pb.Visible = false;
            loadingLbl.Text = "loading data...";

            currentPage++; // Increment the current page number
            await getStudents(currentPage, pageSize); // Load data for the next page
            UpdatePageNumberLabel();
            UpdatePaginationButtons();
        }

        // Method to handle loading data for the previous page
        async void LoadPreviousPage()
        {
            no_data_panel.Visible = true;
            no_data_pb.Visible = false;
            loadingLbl.Text = "loading data...";

            if (currentPage > 1)
            {
                currentPage--; // Decrement the current page number
                await getStudents(currentPage, pageSize); // Load data for the previous page
                UpdatePageNumberLabel();
                UpdatePaginationButtons();
            }
        }

        // Method to initialize or reload data for the first page
        public async Task LoadFirstPage()
        {
            currentPage = 1; // Reset the current page number to the first page
            await getStudents(currentPage, pageSize); // Load data for the first page
            UpdatePageNumberLabel();
            UpdatePaginationButtons();
        }

        // Method to update the pagination buttons (previous and next)
        async void UpdatePaginationButtons()
        {
            // Hide previous button if it's the first page
            previous_btn.Visible = currentPage > 1;

            int totalCount = await getStudentsCount();

            // Disable next button if there are no more pages
            next_btn.Enabled = (currentPage * pageSize) < totalCount;
        }

        // Method to update the page number label
        async void UpdatePageNumberLabel()
        {
            int totalCount = await getStudentsCount();
            data_count_lbl.Text = "Page " + currentPage + ", Total Students: " + totalCount; // Assuming pageNumberLabel is the label displaying the page number
        }

        private async Task<int> getStudentsCount()
        {
            var db = FirestoreHelper.database;

            if (db != null)
            {
                CollectionReference studentColRef = db.Collection("students");

                QuerySnapshot studentQSnap = await studentColRef
                    .WhereEqualTo("faculty_id", faculty_id)
                    .WhereEqualTo("hasGrade", true)
                    .GetSnapshotAsync();

                studentCount = studentQSnap.Documents.Count;

                *//*foreach (DocumentSnapshot snapshot in studentQSnap.Documents)
                {
                    if(snapshot.Exists)
                    {
                        Query gradeRef = snapshot.Reference.Collection("Grades");
                        QuerySnapshot gradeSnap = await gradeRef.GetSnapshotAsync();

                        studentCount = gradeSnap.Documents.Count;
                    }
                }*//*
            }

            return studentCount;
        }*/

        private async Task getStudents()
        {
            grading_sheet_dtg.DataSource = null;
            grading_sheet_dtg.Rows.Clear();

            var db = FirestoreHelper.database;
            if (db != null)
            {
                CollectionReference studentRef = db.Collection("students");

                // Calculate the offset based on the page number and page size
                //int offset = (pageNumber - 1) * pageSize;

                Query q = studentRef
                    .WhereEqualTo("faculty_id", this.faculty_id)
                    .OrderByDescending("addedOn");

                QuerySnapshot snap = await q.GetSnapshotAsync();

                bool isDataFound = false;

                foreach (DocumentSnapshot snapshot in snap.Documents)
                {
                    if (snapshot.Exists)
                    {
                        Students students = snapshot.ConvertTo<Students>();

                        // Access the "grade" subcollection for the current student
                        Query gradeRef = snapshot.Reference.Collection("Grades")
                            .OrderBy("gradeAddedOn");

                        QuerySnapshot gradeSnap = await gradeRef.GetSnapshotAsync();

                        // Capitalize the first letter of last_name
                        string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                        // Capitalize the first letter of last_name
                        string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);

                        // Add columns to the DataGridView if they are not already added
                        if (grading_sheet_dtg.Columns.Count == 0)
                        {
                            grading_sheet_dtg.Columns.Add("id", "ID");
                            grading_sheet_dtg.Columns.Add("name", "NAME");
                            grading_sheet_dtg.Columns.Add("subject", "SUBJECT");
                            grading_sheet_dtg.Columns.Add("sem", "SEMESTER");
                            grading_sheet_dtg.Columns.Add("mid_term", "MID TERM");
                            grading_sheet_dtg.Columns.Add("final_term", "FINAL TERM");
                            grading_sheet_dtg.Columns.Add("final_grade", "FINAL GRADE");
                        }

                        foreach (DocumentSnapshot gradeDoc in gradeSnap.Documents)
                        {
                            if (gradeDoc.Exists)
                            {
                                Students grade = gradeDoc.ConvertTo<Students>();

                                string semtxt = "";
                                if (grade.sem.Equals("1"))
                                {
                                    semtxt = "st Sem";
                                }
                                else if (grade.sem.Equals("2"))
                                {
                                    semtxt = "nd Sem";
                                }
                                // Access and use data from the "grade" document
                                // Example:
                                // string gradeValue = gradeDoc.GetValue<string>("grade_field");
                                // worksheet.Cells[currentExcelRow, 13].Value = gradeValue; // Assuming the column for grades is 13
                                grading_sheet_dtg.Rows.Add(
                                    students.id,
                                    capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".",
                                    grade.subject,
                                    grade.sem + semtxt,
                                    grade.mid_term_grade,
                                    grade.final_term_grade,
                                    grade.final_grade
                                );

                                isDataFound = true;
                            }
                            else
                            {
                                // Handle the case where there is no data in the "grade" subcollection
                                isDataFound = false;
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("No data found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                if (!isDataFound)
                {
                    no_data_panel.Visible = true;
                    loadingLbl.Text = "No data found!";
                    no_data_pb.Visible = true;
                    grading_sheet_dtg.Visible = false;
                }
                else
                {
                    no_data_panel.Visible = false;
                    grading_sheet_dtg.Visible = true;
                }
            }
        }

        #endregion

        private async Task getStudentsByGradeLevel(int grade_level, string sem)
        {
            grading_sheet_dtg.DataSource = null;
            grading_sheet_dtg.Rows.Clear();

            var db = FirestoreHelper.database;
            if (db != null)
            {
                CollectionReference studentRef = db.Collection("students");

                Query q = studentRef
                    .WhereEqualTo("faculty_id", faculty_id)
                    .WhereEqualTo("grade_level", grade_level);

                QuerySnapshot snap = await q.GetSnapshotAsync();

                bool isDataFound = false;

                foreach (DocumentSnapshot snapshot in snap.Documents)
                {
                    if (snapshot.Exists)
                    {
                        Students students = snapshot.ConvertTo<Students>();

                        // Remove non-numeric characters from the string
                        string semString = new string(sem.Where(char.IsDigit).ToArray());

                        // Access the "grade" subcollection for the current student
                        Query gradeRef = snapshot.Reference
                            .Collection("Grades")
                            .WhereEqualTo("sem", semString)
                            .OrderByDescending("gradeAddedOn");

                        QuerySnapshot gradeSnap = await gradeRef.GetSnapshotAsync();

                        // Capitalize the first letter of last_name
                        string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                        // Capitalize the first letter of last_name
                        string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);

                        // Add columns to the DataGridView if they are not already added
                        if (grading_sheet_dtg.Columns.Count == 0)
                        {
                            grading_sheet_dtg.Columns.Add("id", "ID");
                            grading_sheet_dtg.Columns.Add("name", "NAME");
                            grading_sheet_dtg.Columns.Add("subject", "SUBJECT");
                            grading_sheet_dtg.Columns.Add("sem", "SEMESTER");
                            grading_sheet_dtg.Columns.Add("mid_term", "MID TERM");
                            grading_sheet_dtg.Columns.Add("final_term", "FINAL TERM");
                            grading_sheet_dtg.Columns.Add("final_grade", "FINAL GRADE");
                        }

                        foreach (DocumentSnapshot gradeDoc in gradeSnap.Documents)
                        {
                            if (gradeDoc.Exists)
                            {
                                Students grade = gradeDoc.ConvertTo<Students>();

                                string semtxt = "";
                                if (grade.sem.Equals("1"))
                                {
                                    semtxt = "st Sem";
                                }
                                else if (grade.sem.Equals("2"))
                                {
                                    semtxt = "nd Sem";
                                }
                                // Access and use data from the "grade" document
                                // Example:
                                // string gradeValue = gradeDoc.GetValue<string>("grade_field");
                                // worksheet.Cells[currentExcelRow, 13].Value = gradeValue; // Assuming the column for grades is 13
                                grading_sheet_dtg.Rows.Add(
                                    students.id,
                                    capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".",
                                    grade.subject,
                                    grade.sem + semtxt,
                                    grade.mid_term_grade,
                                    grade.final_term_grade,
                                    grade.final_grade
                                );

                                isDataFound = true;
                            }
                            else
                            {
                                // Handle the case where there is no data in the "grade" subcollection
                                isDataFound = false;
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("No data found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                if (!isDataFound)
                {
                    no_data_panel.Visible = true;
                    loadingLbl.Text = "No data found!";
                    no_data_pb.Visible = true;
                    grading_sheet_dtg.Visible = false;
                }
                else
                {
                    no_data_panel.Visible = false;
                    grading_sheet_dtg.Visible = true;
                }
            }
        }

        private async Task getStudentsFilter(string subject, string sem, int gradeLevel)
        {
            grading_sheet_dtg.DataSource = null;
            grading_sheet_dtg.Rows.Clear();

            var db = FirestoreHelper.database;
            if (db != null)
            {
                CollectionReference studentRef = db.Collection("students");

                Query q = studentRef
                    .WhereEqualTo("faculty_id", faculty_id)
                    .WhereEqualTo("grade_level", gradeLevel);

                QuerySnapshot snap = await q.GetSnapshotAsync();

                bool isDataFound = false;

                foreach (DocumentSnapshot snapshot in snap.Documents)
                {
                    if (snapshot.Exists)
                    {
                        Students students = snapshot.ConvertTo<Students>();

                        // Remove non-numeric characters from the string
                        string semString = new string(sem.Where(char.IsDigit).ToArray());

                        // Access the "grade" subcollection for the current student
                        Query gradeRef = snapshot.Reference.Collection("Grades");

                        Query grade_q = gradeRef
                            .WhereEqualTo("subject", subject)
                            .WhereEqualTo("sem", semString)
                            .OrderByDescending("gradeAddedOn");

                        QuerySnapshot gradeSnap = await grade_q.GetSnapshotAsync();

                        // Capitalize the first letter of last_name
                        string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                        // Capitalize the first letter of last_name
                        string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);

                        // Add columns to the DataGridView if they are not already added
                        if (grading_sheet_dtg.Columns.Count == 0)
                        {
                            grading_sheet_dtg.Columns.Add("id", "ID");
                            grading_sheet_dtg.Columns.Add("name", "NAME");
                            grading_sheet_dtg.Columns.Add("subject", "SUBJECT");
                            grading_sheet_dtg.Columns.Add("sem", "SEMESTER");
                            grading_sheet_dtg.Columns.Add("mid_term", "MID TERM");
                            grading_sheet_dtg.Columns.Add("final_term", "FINAL TERM");
                            grading_sheet_dtg.Columns.Add("final_grade", "FINAL GRADE");
                        }

                        foreach (DocumentSnapshot gradeDoc in gradeSnap.Documents)
                        {
                            if (gradeDoc.Exists)
                            {
                                Students grade = gradeDoc.ConvertTo<Students>();
                                // Access and use data from the "grade" document
                                // Example:
                                // string gradeValue = gradeDoc.GetValue<string>("grade_field");
                                // worksheet.Cells[currentExcelRow, 13].Value = gradeValue; // Assuming the column for grades is 13
                                string semtxt = "";
                                if (grade.sem.Equals("1"))
                                {
                                    semtxt = "st Sem";
                                }
                                else if (grade.sem.Equals("2"))
                                {
                                    semtxt = "nd Sem";
                                }

                                grading_sheet_dtg.Rows.Add(
                                    students.id,
                                    capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".",
                                    grade.subject,
                                    grade.sem + semtxt,
                                    grade.mid_term_grade,
                                    grade.final_term_grade,
                                    grade.final_grade
                                );

                                isDataFound = true;
                            }
                            else
                            {
                                // Handle the case where there is no data in the "grade" subcollection
                                isDataFound = false;
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("No data found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                if (!isDataFound)
                {
                    no_data_panel.Visible = true;
                    loadingLbl.Text = "No data found!";
                    no_data_pb.Visible = true;
                    grading_sheet_dtg.Visible = false;
                }
                else
                {
                    no_data_panel.Visible = false;
                    grading_sheet_dtg.Visible = true;
                }
            }
        }

        private async void student_dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Perform the "Edit" action
                DataGridViewRow selectedRow = grading_sheet_dtg.Rows[e.RowIndex];
                string id = selectedRow.Cells["id"].Value.ToString();
                string grade_level = grade_level_cbx.Text;

                if (grading_sheet_dtg.Columns[e.ColumnIndex].Name == "generate")
                {
                    await generateRCardToExcel(id, grade_level);
                }
            }*/
        }

        private async Task generateRCardToExcel(string student_id, string selectedGrade)
        {
            string resourceName = "sf10_temp.xlsx";
            string resourceName2 = "sf9_temp_g12.xlsx";
            string relativeFilePath = Path.Combine("ExcelTemplate", resourceName);
            string relativeFilePath2 = Path.Combine("ExcelTemplate", resourceName2);

            string assemblyPath = Assembly.GetExecutingAssembly().Location;
            string projectDirectory = Path.GetDirectoryName(assemblyPath);
            string sf10FilePath = Path.Combine(projectDirectory, relativeFilePath);
            string filePath2 = Path.Combine(projectDirectory, relativeFilePath2);

            MessageBox.Show(sf10FilePath);

            // Specify the path to save the generated Excel file
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Save Generated Excel File",
                Filter = "Excel Files|*.xlsx;*.xls",
                FileName = "Generated_SF10.xlsx"
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

                        Query q = colRef.WhereEqualTo("faculty_id", faculty_id)
                            .WhereEqualTo("id", student_id);

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

                                if (selectedGrade.Equals("11"))
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
                                                worksheet.Cells[row + 15, 63].Value = grade.sem + "st"; //BK31

                                                switch (grade.subject)
                                                {

                                                }
                                            }
                                            else if (grade.sem.Equals("2"))
                                            {
                                                worksheet.Cells[row + 15, 63].Value = grade.sem + "nd"; //BK31
                                                switch (grade.subject)
                                                {

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

                                    //2nd row
                                    worksheet.Cells[row + 1, 3].Value = students.lrn_number; //C17
                                    worksheet.Cells[row + 1, 27].Value = students.dob; //AA17
                                    worksheet.Cells[row + 1, 40].Value = students.gender; //AN17
                                    worksheet.Cells[row + 1, 60].Value = addedOn.ToString("MM/dd/yyyy"); //BH17

                                    //3rd row
                                    worksheet.Cells[row + 15, 45].Value = students.grade_level; //AS31
                                    worksheet.Cells[row + 15, 53].Value = yearNow; //BA31

                                    //4th row
                                    worksheet.Cells[row + 3, 2].Value = students.strand; //B11
                                    worksheet.Cells[row + 3, 4].Value = students.lrn_number; //D11
                                }
                                else if (selectedGrade.Equals("12"))
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
                                                worksheet2.Cells[row, 63].Value = grade.sem + "st"; //BK31

                                                switch (grade.subject)
                                                {

                                                }
                                            }
                                            else if (grade.sem.Equals("2"))
                                            {
                                                worksheet2.Cells[row, 63].Value = grade.sem + "nd"; //BK31
                                                switch (grade.subject)
                                                {

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

                                    //2nd row
                                    worksheet.Cells[Firstrow + 1, 3].Value = students.lrn_number; //C17
                                    worksheet.Cells[Firstrow + 1, 27].Value = students.dob; //AA17
                                    worksheet.Cells[Firstrow + 1, 40].Value = students.gender; //AN17
                                    worksheet.Cells[Firstrow + 1, 60].Value = addedOn.ToString("MM/dd/yyyy"); //BH17

                                    //3rd row
                                    worksheet.Cells[Firstrow + 15, 45].Value = students.grade_level; //AS31
                                    worksheet.Cells[Firstrow + 15, 53].Value = yearNow; //BA31

                                    //4th row
                                    worksheet.Cells[Firstrow + 3, 2].Value = students.strand; //B11
                                    worksheet.Cells[Firstrow + 3, 4].Value = students.lrn_number; //D11
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
                        MessageBox.Show("sf9 generated and saved.");
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

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
            }
        }

        private void add_new_btn_Click(object sender, EventArgs e)
        {
            AddNewGrade addNew = new AddNewGrade(faculty_id, grading_sheet_dtg, no_data_panel);
            addNew.ShowDialog();
        }

        private async void grade_level_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            no_data_panel.Visible = true;
            no_data_pb.Visible = false;
            loadingLbl.Text = "loading data...";

            //clear object in major subject
            majorSubTb.Items.Clear();

            //hide major subject
            majorSubTb.Visible = false;
            majorSubLbl.Visible = false;

            string selectedGrade = grade_level_cbx.SelectedItem.ToString();

            if (selectedGrade != "Any")
            {
                subject_cbx.Enabled = true;
                sem_cbx.Enabled = true;
                sem_cbx.SelectedIndex = 0;
            }
            else
            {
                sem_cbx.Enabled = false;
                subject_cbx.Enabled = false;
                await getStudents();
            }
        }

        private async void subject_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string subject = subject_cbx.SelectedItem.ToString();
            string selectedSem = sem_cbx.SelectedItem.ToString();
            string selectedGrade = grade_level_cbx.SelectedItem.ToString();
            int gradeLevel = int.Parse(selectedGrade);

            no_data_panel.Visible = true;
            no_data_pb.Visible = false;
            loadingLbl.Text = "loading data...";

            if (!subject.Equals("Any"))
            {
                if (subject.Equals("TVE"))
                {
                    majorSubLbl.Visible = true;
                    majorSubTb.Visible = true;

                    if (selectedGrade.Equals("11") && selectedSem.Equals("1st"))
                    {
                        majorSubTb.Items.AddRange(g11_tve_subject);
                        majorSubTb.SelectedIndex = 0;
                    }
                    else if (selectedGrade.Equals("11") && selectedSem.Equals("2nd"))
                    {
                        majorSubTb.Items.AddRange(g11_tve2_subject);
                        majorSubTb.SelectedIndex = 0;
                    }
                    else if (selectedGrade.Equals("12") && selectedSem.Equals("1st"))
                    {
                        majorSubTb.Items.AddRange(g12_tve_subject);
                        majorSubTb.SelectedIndex = 0;
                    }
                    else if (selectedGrade.Equals("12") && selectedSem.Equals("2nd"))
                    {
                        majorSubTb.Items.AddRange(g12_tve2_subject);
                        majorSubTb.SelectedIndex = 0;
                    }
                }
                else
                {
                    majorSubLbl.Visible = false;
                    majorSubTb.Visible = false;

                    await getStudentsFilter(subject, selectedSem, gradeLevel);
                }
            }
            else
            {
                await getStudentsByGradeLevel(gradeLevel, selectedSem);
            }
        }

        private void printGradeBtn_Click(object sender, EventArgs e)
        {
            // Check if subject_cbx, majorSubTb, and grade_level_cbx are not null
            if (subject_cbx.SelectedItem != null && grade_level_cbx.SelectedItem != null)
            {
                string subject = subject_cbx.SelectedItem.ToString();
                string majorSubj = majorSubTb.Text;
                string selectedGrade = grade_level_cbx.SelectedItem.ToString();

                if (faculty_id != null)
                {
                    PrintPreview printPrev = new PrintPreview(faculty_id, subject, selectedGrade, majorSubj);
                    printPrev.ShowDialog();
                }
            }
            else
            {
                // Handle the case where one or more of the ComboBoxes are null
                MessageBox.Show("Please select values for all dropdowns before printing.");
            }
        }

        private void submitReportBtn_Click(object sender, EventArgs e)
        {
            SelectReportOption report = new SelectReportOption(faculty_id, faculty_name);
            report.ShowDialog();
        }

        private void add_new_btn_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(add_new_btn, "Add new Grade");
        }

        private void printGradeBtn_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(printGradeBtn, "Print");
        }

        private void submitReportBtn_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(submitReportBtn, "Submit Report");
        }

        private void sem_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            no_data_panel.Visible = true;
            no_data_pb.Visible = false;
            loadingLbl.Text = "loading data...";

            //clear subject in subject combo box
            subject_cbx.Items.Clear();

            //clear object in major subject
            majorSubTb.Items.Clear();

            //hide major subject
            majorSubTb.Visible = false;
            majorSubLbl.Visible = false;

            string selectedGrade = grade_level_cbx.SelectedItem.ToString();
            string selectedSem = sem_cbx.SelectedItem.ToString();

            if (selectedGrade.Equals("11"))
            {
                if (selectedSem.Equals("1st"))
                {
                    subject_cbx.Items.AddRange(g11_1st_subject);
                    subject_cbx.SelectedIndex = 0;
                }
                else if (selectedSem.Equals("2nd"))
                {
                    subject_cbx.Items.AddRange(g11_2nd_subject);
                    subject_cbx.SelectedIndex = 0;
                }
            }
            else if (selectedGrade.Equals("12"))
            {
                if (selectedSem.Equals("1st"))
                {
                    subject_cbx.Items.AddRange(g12_1st_subject);
                    subject_cbx.SelectedIndex = 0;
                }
                else if (selectedSem.Equals("2nd"))
                {
                    subject_cbx.Items.AddRange(g12_2nd_subject);
                    subject_cbx.SelectedIndex = 0;
                }
            }
        }

        private async void majorSubTb_SelectedIndexChanged(object sender, EventArgs e)
        {
            no_data_panel.Visible = true;
            no_data_pb.Visible = false;
            loadingLbl.Text = "loading data...";

            string selectedSem = sem_cbx.SelectedItem.ToString();
            string selectedGrade = grade_level_cbx.SelectedItem.ToString();
            string selectedMajor = majorSubTb.SelectedItem.ToString();

            int gradeLevel = int.Parse(selectedGrade);

            if (!selectedMajor.Equals("Any"))
            {
                await getStudentsFilter(selectedMajor, selectedSem, gradeLevel);
            }
            else
            {
                await getStudentsByGradeLevel(gradeLevel, selectedSem);
            }
        }

        private void genBtn_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(genBtn, "Generate SF10");
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            SF10Generated generate = new SF10Generated(faculty_id);
            generate.ShowDialog();
        }
    }
}
