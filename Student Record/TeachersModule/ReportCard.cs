using Google.Cloud.Firestore;
using Microsoft.Office.Interop.Word;
using OfficeOpenXml;
using Student_Record.AdminModule.Student;
using Student_Record.Firebase;
using Student_Record.Firebase.Model;
using Student_Record.TeachersModule.GeneratedCard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task = System.Threading.Tasks.Task;

namespace Student_Record.TeachersModule
{
    public partial class ReportCard : Form
    {
        private string? faculty_id, faculty_name;
        int pageSize = 10; // Number of records per page
        int currentPage = 1, studentCount = 0; // Current page number

        public ReportCard(string? id, string? name)
        {
            InitializeComponent();
            faculty_id = id;
            faculty_name = name;

            no_data_pb.Visible = false;
            loadingLbl.Text = "loading data...";
        }

        // Method to handle loading data for the next page
        async void LoadNextPage()
        {
            no_data_panel.Visible = true;
            no_data_pb.Visible = false;
            loadingLbl.Text = "loading data...";

            currentPage++; // Increment the current page number
            await getStudent(currentPage, pageSize); // Load data for the next page
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
                await getStudent(currentPage, pageSize); // Load data for the previous page
                UpdatePageNumberLabel();
                UpdatePaginationButtons();
            }
        }

        // Method to initialize or reload data for the first page
        public async Task LoadFirstPage()
        {
            currentPage = 1; // Reset the current page number to the first page
            await getStudent(currentPage, pageSize); // Load data for the first page
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
                    .GetSnapshotAsync();

                studentCount = studentQSnap.Documents.Count;
            }

            return studentCount;
        }

        private async Task getStudent(int pageNumber, int pageSize)
        {
            student_dtg.DataSource = null;
            student_dtg.Rows.Clear();

            try
            {
                var db = FirestoreHelper.database;

                if (db != null)
                {
                    CollectionReference colRef = db.Collection("students");

                    // Calculate the offset based on the page number and page size
                    int offset = (pageNumber - 1) * pageSize;

                    Query q = colRef
                        .WhereEqualTo("faculty_id", faculty_id)
                        .OrderBy("addedOn")
                        .Offset(offset)
                        .Limit(pageSize);

                    QuerySnapshot qSnap = await q.GetSnapshotAsync();

                    if (qSnap.Count > 0)
                    {
                        no_data_panel.Visible = false;
                        student_dtg.Visible = true;

                        // Add columns to the DataGridView if they are not already added
                        if (student_dtg.Columns.Count == 0)
                        {
                            student_dtg.Columns.Add("id", "ID");
                            student_dtg.Columns.Add("name", "Name");
                            student_dtg.Columns.Add("grade_level", "Grade Level");
                            student_dtg.Columns.Add("section", "Section");
                            student_dtg.Columns.Add("gender", "Gender");
                            student_dtg.Columns.Add("action", "Action");
                        }

                        foreach (DocumentSnapshot docSnap in qSnap.Documents)
                        {
                            Students student = docSnap.ConvertTo<Students>();

                            // Capitalize the first letter of last_name
                            string capitalizedLastName = char.ToUpper(student.last_name[0]) + student.last_name.Substring(1);
                            // Capitalize the first letter of last_name
                            string capitalizedFirstName = char.ToUpper(student.first_name[0]) + student.first_name.Substring(1);

                            string fullname = capitalizedLastName + ", " + capitalizedFirstName + " " + student.middle_name.Substring(0, 1).ToUpper() + ".";


                            if (student.hasGrade == true)
                            {
                                student_dtg.Rows.Insert(
                                    0,
                                    student.id,
                                    fullname,
                                    student.grade_level,
                                    student.section,
                                    student.gender,
                                    Properties.Resources.features_alt
                                );
                            }
                            else
                            {
                                student_dtg.Rows.Insert(
                                    0,
                                    student.id,
                                    fullname,
                                    student.grade_level,
                                    student.section,
                                    student.gender,
                                    Properties.Resources.delete_document
                                );
                            }

                            student_dtg.CellFormatting += (sender, e) =>
                            {
                                if (e.ColumnIndex == 5 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                                {
                                    DataGridViewCell cell = student_dtg.Rows[e.RowIndex].Cells[e.ColumnIndex];

                                    cell.ToolTipText = "Generate Card";
                                }
                            };

                            // Add the CellMouseEnter event to change the cursor to a hand cursor
                            student_dtg.CellMouseEnter += (sender, e) =>
                            {
                                if (e.ColumnIndex == 5 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                                {
                                    student_dtg.Cursor = Cursors.Hand;
                                }
                            };

                            // Add the CellMouseLeave event to revert the cursor to the default cursor
                            student_dtg.CellMouseLeave += (sender, e) =>
                            {
                                student_dtg.Cursor = Cursors.Default;
                            };
                        }

                        no_data_panel.Visible = false;
                        student_dtg.Visible = true;
                    }
                    else
                    {
                        no_data_panel.Visible = true;
                        loadingLbl.Text = "No data found!";
                        no_data_pb.Visible = true;
                        student_dtg.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void student_dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Perform the "Edit" action
                DataGridViewRow selectedRow = student_dtg.Rows[e.RowIndex];
                string? id = selectedRow.Cells["id"].Value.ToString();
                string? selectedGrade = selectedRow.Cells["grade_level"].Value.ToString();
                string? studentName = selectedRow.Cells["name"].Value.ToString();

                if (student_dtg.Columns[e.ColumnIndex].Name == "action")
                {
                    generateRCardToExcel(id, selectedGrade, studentName);
                }
            }
        }

        private void search_tb_OnValueChanged(object sender, EventArgs e)
        {
            string searchText = search_tb.Text.ToLower();

            foreach (DataGridViewRow row in student_dtg.Rows)
            {
                // If the row contains the search text, make it visible; otherwise, hide it
                row.Visible = row.Cells.Cast<DataGridViewCell>()
                                       .Any(cell => cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText));
            }
        }

        private async void ReportCard_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadFirstPage();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            string searchText = search_tb.Text.ToLower();

            foreach (DataGridViewRow row in student_dtg.Rows)
            {
                // If the row contains the search text, make it visible; otherwise, hide it
                row.Visible = row.Cells.Cast<DataGridViewCell>()
                                       .Any(cell => cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText));
            }
        }

        private async void generateRCardToExcel(string student_id, string selectedGrade, string student_name)
        {
            string resourceName = "sf9_temp.xlsx";
            string resourceName2 = "sf9_temp_g12.xlsx";
            string relativeFilePath = Path.Combine("ExcelTemplate", resourceName);
            string relativeFilePath2 = Path.Combine("ExcelTemplate", resourceName2);


            string assemblyPath = Assembly.GetExecutingAssembly().Location;
            string projectDirectory = Path.GetDirectoryName(assemblyPath);
            string filePath = Path.Combine(projectDirectory, relativeFilePath);
            string filePath2 = Path.Combine(projectDirectory, relativeFilePath2);

            // Specify the path to save the generated Excel file
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Save Generated Excel File",
                Filter = "Excel Files|*.xlsx;*.xls",
                FileName = student_name + "_SF9.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string saveFilePath = saveFileDialog.FileName;

                if (selectedGrade.Equals("11"))
                {
                    using (var package = new ExcelPackage(new FileInfo(filePath)))
                    {
                        // Get the worksheet in your Excel template (by name or index)
                        var worksheet = package.Workbook.Worksheets[0]; // Adjust the index or name as needed

                        int nameRow = 8; // Start at row 15 in Excel (B15)
                                         // Assuming you have student names in a DataGridView

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

                                    foreach (DocumentSnapshot gradeDoc in gradeSnap.Documents)
                                    {
                                        if (gradeDoc.Exists)
                                        {
                                            // Access and use data from the "grade" document
                                            // Example:
                                            Students grade = gradeDoc.ConvertTo<Students>();

                                            if (grade.sem.Equals("1"))
                                            {
                                                switch (grade.subject)
                                                {
                                                    case "Oral Communication":
                                                        worksheet.Cells[nameRow + 10, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 10, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino":
                                                        worksheet.Cells[nameRow + 11, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 11, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "21st Century Literature from the Philippines and the World":
                                                        worksheet.Cells[nameRow + 12, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 12, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "General Mathematics":
                                                        worksheet.Cells[nameRow + 13, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 13, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Introduction to the Philosophy of the Human Person/Pambungad sa Pilosopiya ng Tao":
                                                        worksheet.Cells[nameRow + 14, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 14, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Physical Education and Health":
                                                        worksheet.Cells[nameRow + 15, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 15, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Electrical Installation & Maintenance NCII":
                                                        worksheet.Cells[nameRow + 17, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 17, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    default:
                                                        // Handle other cases if needed
                                                        break;
                                                }
                                            }
                                            else if (grade.sem.Equals("2"))
                                            {
                                                switch (grade.subject)
                                                {
                                                    //second sem subjects
                                                    case "Reading and Writing":
                                                        worksheet.Cells[nameRow + 24, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 24, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Pagbasa at Pagsusuri ng Ibat ibang teksto tungo sa pananaliksik":
                                                        worksheet.Cells[nameRow + 25, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 25, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Understanding Culture, Society and Politics":
                                                        worksheet.Cells[nameRow + 26, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 26, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Statistics and Probability":
                                                        worksheet.Cells[nameRow + 27, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 27, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Physical Education and Health":
                                                        worksheet.Cells[nameRow + 28, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 28, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Practical Research 1":
                                                        worksheet.Cells[nameRow + 30, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 30, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Electrical Installation & Maintenance NCII":
                                                        worksheet.Cells[nameRow + 32, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 32, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    default:
                                                        // Handle other cases if needed
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

                                    //1st row
                                    worksheet.Cells[nameRow, 2].Value = capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ". " + students.suffix; // Assuming the student name should be in column B8
                                    worksheet.Cells[nameRow, 5].Value = students.gender; //E8
                                                                                         //2nd row
                                    worksheet.Cells[nameRow + 1, 2].Value = students.grade_level + "-" + students.section; //B9
                                    worksheet.Cells[nameRow + 1, 5].Value = age; //E9
                                                                                 //3rd row
                                    DateTime addedOnDate = students.addedOn;
                                    DateTime dateNow = DateTime.UtcNow;

                                    // Get the year from the DateTime object
                                    int year = addedOnDate.Year, yearNow = dateNow.Year;
                                    worksheet.Cells[nameRow + 2, 5].Value = year; //E10
                                                                                  //4th row
                                    worksheet.Cells[nameRow + 3, 2].Value = students.strand; //B11
                                    worksheet.Cells[nameRow + 3, 4].Value = students.lrn_number; //D11
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
                else if (selectedGrade.Equals("12"))
                {
                    using (var package = new ExcelPackage(new FileInfo(filePath2)))
                    {
                        // Get the worksheet in your Excel template (by name or index)
                        var worksheet = package.Workbook.Worksheets[0]; // Adjust the index or name as needed

                        int nameRow = 8; // Start at row 15 in Excel (B15)
                                         // Assuming you have student names in a DataGridView

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

                                    foreach (DocumentSnapshot gradeDoc in gradeSnap.Documents)
                                    {
                                        if (gradeDoc.Exists)
                                        {
                                            // Access and use data from the "grade" document
                                            // Example:
                                            Students grade = gradeDoc.ConvertTo<Students>();

                                            if (grade.sem.Equals("1"))
                                            {
                                                switch (grade.subject)
                                                {
                                                    case "Personal Development/Pansariling Kaunlaran":
                                                        worksheet.Cells[nameRow + 10, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 10, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Earth and Life Science":
                                                        worksheet.Cells[nameRow + 11, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 11, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Media and Information Literacy":
                                                        worksheet.Cells[nameRow + 12, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 12, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Physical Education and Health":
                                                        worksheet.Cells[nameRow + 13, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 13, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "English for Academic and Professional Purposes":
                                                        worksheet.Cells[nameRow + 14, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 14, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Practical Research 2":
                                                        worksheet.Cells[nameRow + 15, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 15, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Animal Production NCII":
                                                        worksheet.Cells[nameRow + 17, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 17, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Food Fish Processing NCII":
                                                        worksheet.Cells[nameRow + 18, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 18, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Illustration NCII":
                                                        worksheet.Cells[nameRow + 19, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 19, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Computer Systems Servicing NCII":
                                                        worksheet.Cells[nameRow + 20, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 20, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Agricultural Crops Production NC II":
                                                        worksheet.Cells[nameRow + 21, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 21, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Tailoring NCII":
                                                        worksheet.Cells[nameRow + 22, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 22, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Electrical Installation & Maintenance NCII":
                                                        worksheet.Cells[nameRow + 23, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 23, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    default:
                                                        // Handle other cases if needed
                                                        break;
                                                }
                                            }
                                            else if (grade.sem.Equals("2"))
                                            {
                                                switch (grade.subject)
                                                {
                                                    case "Contemporary Philippine Arts from the Regions":
                                                        worksheet.Cells[nameRow + 30, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 30, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Physical Science":
                                                        worksheet.Cells[nameRow + 31, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 31, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Physical Education and Health":
                                                        worksheet.Cells[nameRow + 32, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 32, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Filipino sa Piling Larang":
                                                        worksheet.Cells[nameRow + 33, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 33, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Empowerment Technologies":
                                                        worksheet.Cells[nameRow + 34, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 34, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Inquiries, Investigations and Immersion":
                                                        worksheet.Cells[nameRow + 35, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 35, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Entrepreneurship":
                                                        worksheet.Cells[nameRow + 37, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 37, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    case "Work Immersion":
                                                        worksheet.Cells[nameRow + 39, 3].Value = grade.mid_term_grade; //C18
                                                        worksheet.Cells[nameRow + 39, 4].Value = grade.final_term_grade; //C18
                                                        break;
                                                    default:
                                                        // Handle other cases if needed
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

                                    //1st row
                                    worksheet.Cells[nameRow, 2].Value = capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ". " + students.suffix; // Assuming the student name should be in column B8
                                    worksheet.Cells[nameRow, 5].Value = students.gender; //E8
                                                                                         //2nd row
                                    worksheet.Cells[nameRow + 1, 2].Value = students.grade_level + "-" + students.section; //B9
                                    worksheet.Cells[nameRow + 1, 5].Value = age; //E9
                                                                                 //3rd row
                                    DateTime addedOnDate = students.addedOn;
                                    DateTime dateNow = DateTime.UtcNow;

                                    // Get the year from the DateTime object
                                    int year = addedOnDate.Year, yearNow = dateNow.Year;
                                    worksheet.Cells[nameRow + 2, 5].Value = year; //E10
                                                                                  //4th row
                                    worksheet.Cells[nameRow + 3, 2].Value = students.strand; //B11
                                    worksheet.Cells[nameRow + 3, 4].Value = students.lrn_number; //D11
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

        private void next_btn_Click(object sender, EventArgs e)
        {
            LoadNextPage();
        }

        private void previous_btn_Click(object sender, EventArgs e)
        {
            LoadPreviousPage();
        }
    }
}
