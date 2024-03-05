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

namespace Student_Record.TeachersModule
{
    public partial class GradingSheet : Form
    {
        private string? faculty_id, faculty_name;
        private BunifuFlatButton? currentBtn;
        private Color activeColor = Color.FromArgb(129, 142, 254);
        private Color originalColor = Color.FromArgb(43, 47, 84);

        public GradingSheet(string? id, string? name)
        {
            InitializeComponent();

            faculty_id = id;
            faculty_name = name;

            getStudentsFilter("Oral Communication");
            activeButton(oral_btn);
            IsButtonActive(oral_btn);
        }

        private void activeButton(BunifuFlatButton btn)
        {
            if (currentBtn != null)
            {
                currentBtn.Normalcolor = originalColor;
            }
            currentBtn = btn;

            currentBtn.Normalcolor = activeColor;
        }

        // Method to check if a button is active
        private bool IsButtonActive(BunifuFlatButton btn)
        {
            return currentBtn == btn;
        }

        // Method to get the text of the active button
        public string GetActiveButtonText()
        {
            if (currentBtn != null)
            {
                return currentBtn.Text;
            }
            else
            {
                // Return null or throw an exception based on your requirement
                throw new InvalidOperationException("No button is currently active.");
            }
        }

        private async void getStudents()
        {
            var db = FirestoreHelper.database;
            if (db != null)
            {
                CollectionReference studentRef = db.Collection("students");

                Query q = studentRef.WhereEqualTo("faculty_id", faculty_id);

                QuerySnapshot snap = await q.GetSnapshotAsync();

                bool isDataFound = false;

                foreach (DocumentSnapshot snapshot in snap.Documents)
                {
                    if (snapshot.Exists)
                    {
                        Students students = snapshot.ConvertTo<Students>();

                        // Access the "grade" subcollection for the current student
                        CollectionReference gradeRef = snapshot.Reference.Collection("Grades");

                        QuerySnapshot gradeSnap = await gradeRef.GetSnapshotAsync();

                        // Capitalize the first letter of last_name
                        string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                        // Capitalize the first letter of last_name
                        string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);

                        foreach (DocumentSnapshot gradeDoc in gradeSnap.Documents)
                        {
                            if (gradeDoc.Exists)
                            {
                                Students grade = gradeDoc.ConvertTo<Students>();
                                // Access and use data from the "grade" document
                                // Example:
                                // string gradeValue = gradeDoc.GetValue<string>("grade_field");
                                // worksheet.Cells[currentExcelRow, 13].Value = gradeValue; // Assuming the column for grades is 13
                                grading_sheet_dtg.Rows.Insert(
                                    0,
                                    students.id,
                                    capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".",
                                    grade.subject,
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
                    grading_sheet_dtg.Visible = false;
                }
                else
                {
                    no_data_panel.Visible = false;
                    grading_sheet_dtg.Visible = true;
                }
            }
        }

        private async void getStudentsFilter(string subject)
        {
            var db = FirestoreHelper.database;
            if (db != null)
            {
                CollectionReference studentRef = db.Collection("students");

                Query q = studentRef.WhereEqualTo("faculty_id", faculty_id);

                QuerySnapshot snap = await q.GetSnapshotAsync();

                bool isDataFound = false;

                foreach (DocumentSnapshot snapshot in snap.Documents)
                {
                    if (snapshot.Exists)
                    {
                        Students students = snapshot.ConvertTo<Students>();

                        // Access the "grade" subcollection for the current student
                        CollectionReference gradeRef = snapshot.Reference.Collection("Grades");

                        Query grade_q = gradeRef.WhereEqualTo("subject", subject);

                        QuerySnapshot gradeSnap = await grade_q.GetSnapshotAsync();

                        // Capitalize the first letter of last_name
                        string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                        // Capitalize the first letter of last_name
                        string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);

                        foreach (DocumentSnapshot gradeDoc in gradeSnap.Documents)
                        {
                            if (gradeDoc.Exists)
                            {
                                Students grade = gradeDoc.ConvertTo<Students>();
                                // Access and use data from the "grade" document
                                // Example:
                                // string gradeValue = gradeDoc.GetValue<string>("grade_field");
                                // worksheet.Cells[currentExcelRow, 13].Value = gradeValue; // Assuming the column for grades is 13
                                grading_sheet_dtg.Rows.Insert(
                                    0,
                                    students.id,
                                    capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".",
                                    grade.subject,
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
                    grading_sheet_dtg.Visible = false;
                }
                else
                {
                    no_data_panel.Visible = false;
                    grading_sheet_dtg.Visible = true;
                }
            }
        }

        private void student_dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Perform the "Edit" action
                DataGridViewRow selectedRow = grading_sheet_dtg.Rows[e.RowIndex];
                string id = selectedRow.Cells["id"].Value.ToString();
                if (grading_sheet_dtg.Columns[e.ColumnIndex].Name == "grades")
                {
                    Details details = new Details(id);
                    details.ShowDialog(this);
                }
                if (grading_sheet_dtg.Columns[e.ColumnIndex].Name == "add_btn")
                {
                    MessageBox.Show("Adds");
                }
            }
        }

        private async void generateExcel()
        {
            // Allow the user to choose the template file
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Excel Template",
                Filter = "Excel Files|*.xlsx;*.xls",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string templateFilePath = openFileDialog.FileName;

                // Specify the path to save the generated Excel file
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Title = "Save Generated Excel File",
                    Filter = "Excel Files|*.xlsx;*.xls",
                    FileName = "Generated_Grading_Sheet_Summary.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string saveFilePath = saveFileDialog.FileName;

                    using (var package = new ExcelPackage(new FileInfo(templateFilePath)))
                    {
                        // Get the worksheet in your Excel template (by name or index)
                        var worksheet = package.Workbook.Worksheets[0]; // Adjust the index or name as needed

                        int excelRowMale = 15, excelRowFemale = 64; // Start at row 15 in Excel (B15)
                                                                    // Assuming you have student names in a DataGridView

                        var db = FirestoreHelper.database;

                        if (db != null)
                        {
                            CollectionReference colRef = db.Collection("students");

                            Query q = colRef.WhereEqualTo("faculty_id", faculty_id);

                            QuerySnapshot snap = await q.GetSnapshotAsync();

                            foreach (DocumentSnapshot snapshot in snap.Documents)
                            {
                                if (snapshot.Exists)
                                {
                                    Students students = snapshot.ConvertTo<Students>();

                                    // Access the "grade" subcollection for the current student
                                    CollectionReference gradeRef = snapshot.Reference.Collection("Grades");

                                    QuerySnapshot gradeSnap = await gradeRef.GetSnapshotAsync();

                                    int currentExcelRow;

                                    if (students.gender.ToLower() == "male")
                                    {
                                        currentExcelRow = excelRowMale;
                                    }
                                    else if (students.gender.ToLower() == "female")
                                    {
                                        currentExcelRow = excelRowFemale;
                                    }
                                    else
                                    {
                                        // Handle other genders or unknown cases
                                        continue; // Skip to the next iteration
                                    }

                                    foreach (DocumentSnapshot gradeDoc in gradeSnap.Documents)
                                    {
                                        if (gradeDoc.Exists)
                                        {
                                            // Access and use data from the "grade" document
                                            // Example:
                                            Students grade = gradeDoc.ConvertTo<Students>();

                                            worksheet.Cells[currentExcelRow, 3].Value = grade.mid_term_grade;
                                            worksheet.Cells[currentExcelRow, 4].Value = grade.final_term_grade;
                                        }
                                        else
                                        {
                                            // Handle the case where there is no data in the "grade" subcollection
                                        }
                                    }

                                    // Capitalize the first letter of last_name
                                    string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                                    // Capitalize the first letter of last_name
                                    string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);

                                    worksheet.Cells[currentExcelRow, 2].Value = capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ". " + students.suffix; // Assuming the student name should be in column B

                                    // Increment the excelRow for the next student of the respective gender
                                    if (students.gender.ToLower() == "male")
                                    {
                                        excelRowMale++;
                                    }
                                    else if (students.gender.ToLower() == "female")
                                    {
                                        excelRowFemale++;
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
                            MessageBox.Show("Grading sheet generated and saved.");
                        }
                    }
                }
            }
        }

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
            }
        }

        private void generate_btn_Click(object sender, EventArgs e)
        {
            using (FRM_Wait frm_wait = new FRM_Wait(Wait))
            {
                frm_wait.ShowDialog(this);
            }
            generateExcel();
        }

        private void add_new_btn_Click(object sender, EventArgs e)
        {
            AddNewGrade addNew = new AddNewGrade(faculty_id, grading_sheet_dtg, no_data_panel);
            addNew.ShowDialog();
        }

        private void oral_btn_Click(object sender, EventArgs e)
        {
            string filter = oral_btn.Text;
            grading_sheet_dtg.DataSource = null;
            grading_sheet_dtg.Rows.Clear();
            getStudentsFilter(filter);
            activeButton(oral_btn);
            IsButtonActive(oral_btn);
        }

        private void century_btn_Click(object sender, EventArgs e)
        {
            string filter = century_btn.Text;
            grading_sheet_dtg.DataSource = null;
            grading_sheet_dtg.Rows.Clear();
            getStudentsFilter(filter);
            activeButton(century_btn);
            IsButtonActive(century_btn);
        }

        private void math_btn_Click(object sender, EventArgs e)
        {
            string filter = math_btn.Text;
            grading_sheet_dtg.DataSource = null;
            grading_sheet_dtg.Rows.Clear();
            getStudentsFilter(filter);
            activeButton(math_btn);
            IsButtonActive(math_btn);
        }

        private void komunikasyon_btn_Click(object sender, EventArgs e)
        {
            string filter = komunikasyon_btn.Text;
            grading_sheet_dtg.DataSource = null;
            grading_sheet_dtg.Rows.Clear();
            getStudentsFilter(filter);
            activeButton(komunikasyon_btn);
            IsButtonActive(komunikasyon_btn);
        }

        private void philosophy_btn_Click(object sender, EventArgs e)
        {
            string filter = philosophy_btn.Text;
            grading_sheet_dtg.DataSource = null;
            grading_sheet_dtg.Rows.Clear();
            getStudentsFilter(filter);
            activeButton(philosophy_btn);
            IsButtonActive(philosophy_btn);
        }

        private void p_e_btn_Click(object sender, EventArgs e)
        {
            string filter = p_e_btn.Text;
            grading_sheet_dtg.DataSource = null;
            grading_sheet_dtg.Rows.Clear();
            getStudentsFilter(filter);
            activeButton(p_e_btn);
            IsButtonActive(p_e_btn);
        }

        private void tve_btn_Click(object sender, EventArgs e)
        {
            string filter = tve_btn.Text;
            grading_sheet_dtg.DataSource = null;
            grading_sheet_dtg.Rows.Clear();
            getStudentsFilter(filter);
            activeButton(tve_btn);
            IsButtonActive(tve_btn);
        }

        private void submit_report_btn_Click(object sender, EventArgs e)
        {
            SelectReportOption report = new SelectReportOption(faculty_id, faculty_name);
            report.ShowDialog();
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            string activeButtonText = GetActiveButtonText();
            if (faculty_id != null)
            {
                PrintPreview printPrev = new PrintPreview(faculty_id, activeButtonText);
                printPrev.ShowDialog();
            }
        }
    }
}
