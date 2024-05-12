using Google.Cloud.Firestore;
using Student_Record.Firebase;
using Student_Record.Firebase.Model;
using Student_Record.Loaders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using System.Xml.Linq;
using Bunifu.Framework.UI;
using Microsoft.Office.Interop.Word;
using Task = System.Threading.Tasks.Task;
using System.Diagnostics;

namespace Student_Record.TeachersModule.GradingSheetNew
{
    public partial class AddNewGrade : Form
    {
        string? faculty_id, student_id;
        private Guid uid = Guid.NewGuid();
        private BunifuCustomDataGrid? myDTG;
        private BunifuFlatButton next, prev;
        private Label data_count;
        private Panel? no_data_panel;
        private List<string> studentList = new List<string>();

        int pageSize = 6; // Number of records per page
        int currentPage = 1, studentCount = 0; // Current page number

        // Assuming you have a class-level variable to store the list of products
        //private List<string> productList = new List<string>();

        public AddNewGrade(string faculty_id, BunifuCustomDataGrid dtg, Panel no_data_panel)
        {
            InitializeComponent();
            this.faculty_id = faculty_id;
            this.myDTG = dtg;
        }

        #region get Student Pagination without filter

        /*// Method to handle loading data for the next page
        async void LoadNextPage()
        {
            currentPage++; // Increment the current page number
            await getStudents(currentPage, pageSize); // Load data for the next page
            UpdatePageNumberLabel();
            UpdatePaginationButtons();
        }

        // Method to handle loading data for the previous page
        async void LoadPreviousPage()
        {
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
            prev.Visible = currentPage > 1;

            int totalCount = await getStudentsCount();

            // Disable next button if there are no more pages
            next.Enabled = (currentPage * pageSize) < totalCount;
        }

        // Method to update the page number label
        async void UpdatePageNumberLabel()
        {
            int totalCount = await getStudentsCount();
            data_count.Text = "Page " + currentPage + ", Total Students: " + totalCount; // Assuming pageNumberLabel is the label displaying the page number
        }

        private async Task<int> getStudentsCount()
        {
            var db = FirestoreHelper.database;

            if (db != null)
            {
                CollectionReference studentColRef = db.Collection("students");

                QuerySnapshot studentQSnap = await studentColRef
                    .WhereEqualTo("faculty_id", this.faculty_id)
                    .GetSnapshotAsync();

                foreach (DocumentSnapshot snapshot in studentQSnap.Documents)
                {
                    if (snapshot.Exists)
                    {
                        // Access the "grade" subcollection for the current student
                        Query gradeRef = snapshot.Reference.Collection("Grades").OrderByDescending("gradeAddedOn");

                        QuerySnapshot gradeSnap = await gradeRef.GetSnapshotAsync();

                        if (gradeSnap != null)
                        {
                            studentCount = gradeSnap.Documents.Count;
                        }
                        else
                        {
                            studentCount = 0;
                        }
                    }
                }
            }

            return studentCount;
        }*/

        private async Task getStudents()
        {
            myDTG.DataSource = null;
            myDTG.Rows.Clear();

            var db = FirestoreHelper.database;
            if (db != null)
            {
                CollectionReference studentRef = db.Collection("students");

                // Calculate the offset based on the page number and page size
                //int offset = (pageNumber - 1) * pageSize;

                Query q = studentRef
                    .WhereEqualTo("faculty_id", faculty_id)
                    .OrderByDescending("addedOn");

                QuerySnapshot snap = await q.GetSnapshotAsync();

                bool isDataFound = false;

                foreach (DocumentSnapshot snapshot in snap.Documents)
                {
                    if (snapshot.Exists)
                    {
                        Students students = snapshot.ConvertTo<Students>();

                        // Access the "grade" subcollection for the current student
                        Query gradeRef = snapshot.Reference.Collection("Grades").OrderByDescending("gradeAddedOn");

                        QuerySnapshot gradeSnap = await gradeRef.GetSnapshotAsync();

                        // Capitalize the first letter of last_name
                        string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                        // Capitalize the first letter of last_name
                        string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);

                        // Add columns to the DataGridView if they are not already added
                        if (myDTG.Columns.Count == 0)
                        {
                            myDTG.Columns.Add("id", "ID");
                            myDTG.Columns.Add("name", "NAME");
                            myDTG.Columns.Add("subject", "SUBJECT");
                            myDTG.Columns.Add("sem", "SEMESTER");
                            myDTG.Columns.Add("mid_term", "MID TERM");
                            myDTG.Columns.Add("final_term", "FINAL TERM");
                            myDTG.Columns.Add("final_grade", "FINAL GRADE");
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
                                myDTG.Rows.Add(
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
            }
        }

        #endregion

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
            }
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

        private void AddNewGrade_Load(object sender, EventArgs e)
        {
            //student_cbx.Items.Clear();
            getStudentName();
            setAutoCompleteTB(student_cbx);
        }

        private async void getStudentName()
        {
            // Clear the existing items in the ComboBox
            student_cbx.Items.Clear();

            try
            {
                var db = FirestoreHelper.database;
                if (db != null)
                {
                    CollectionReference colRef = db.Collection("students");

                    Query q = colRef.WhereEqualTo("faculty_id", faculty_id);

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
                            // Concatenate the student's name
                            string studentName = capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ". " + students.suffix;

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

        private void save_btn_Click(object sender, EventArgs e)
        {
            string name = student_cbx.Text;
            string term = term_cbx.SelectedItem.ToString();
            string subject = subject_cbx.SelectedItem.ToString();
            string grade = grade_tb.Text;
            string sem = sem_cbx.SelectedItem.ToString();
            string major = majorSubject_cbx.Text;

            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please choose a student!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (String.IsNullOrEmpty(sem))
            {
                MessageBox.Show("Please choose sem!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (String.IsNullOrEmpty(term))
            {
                MessageBox.Show("Please choose term!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (String.IsNullOrEmpty(subject))
            {
                MessageBox.Show("Please choose subject!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (String.IsNullOrEmpty(grade))
            {
                MessageBox.Show("Please add grade!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grade_tb.Focus();
                return;
            }
            else
            {
                using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                {
                    frm_wait.ShowDialog(this);
                }
                if (myDTG != null)
                {
                    myDTG.DataSource = null;
                    myDTG.Rows.Clear();
                }
                if (subject.Equals("TVE"))
                {
                    setGrade(student_id, term, major, grade, sem);
                }
                else
                {
                    setGrade(student_id, term, subject, grade, sem);
                }
            }
        }

        private async void setGrade(string? student_id, string term, string subject, string grade, string sem)
        {
            try
            {
                string grade_id = uid.ToString();
                var db = FirestoreHelper.database;

                if (db != null)
                {
                    DocumentReference docRef = db.Collection("students").Document(student_id);
                    if (docRef != null)
                    {
                        CollectionReference gradeColRef = docRef.Collection("Grades");

                        Query q = gradeColRef.WhereEqualTo("subject", subject).WhereEqualTo("sem", sem);

                        QuerySnapshot qSnap = await q.GetSnapshotAsync();

                        if (qSnap.Count > 0)
                        {
                            // The document already exists, update the existing grade
                            var existingGradeDoc = qSnap.Documents[0];
                            double mid_term_grade = existingGradeDoc.ContainsField("mid_term_grade") ?
                                                Convert.ToDouble(existingGradeDoc.GetValue<double>("mid_term_grade")) : 0;

                            double final_term_grade = existingGradeDoc.ContainsField("final_term_grade") ?
                                                Convert.ToDouble(existingGradeDoc.GetValue<double>("final_term_grade")) : 0;

                            if (term.Equals("Mid Term"))
                            {
                                mid_term_grade = double.Parse(grade);
                            }
                            else if (term.Equals("Final Term"))
                            {
                                final_term_grade = double.Parse(grade);
                            }

                            double final_grade = mid_term_grade + final_term_grade;
                            double total_grade = final_grade / 2;

                            Dictionary<string, object> updateData = new Dictionary<string, object>()
                            {
                                {"term", term },
                                {"mid_term_grade", mid_term_grade },
                                {"final_term_grade", final_term_grade },
                                {"final_grade", total_grade },
                                {"gradeUpdatedOn", DateTime.UtcNow }
                            };

                            await existingGradeDoc.Reference.UpdateAsync(updateData);

                            MessageBox.Show("Grade updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await getStudents();
                            clearFields();
                            Hide();
                        }
                        else
                        {
                            // The document doesn't exist, create a new grade
                            Dictionary<string, object> updateData = new Dictionary<string, object>()
                            {
                                {"hasGrade", true }
                            };

                            await docRef.UpdateAsync(updateData);

                            double mid_term_grade = 0, final_term_grade = 0;

                            if (term.Equals("Mid Term"))
                            {
                                mid_term_grade = double.Parse(grade);
                            }
                            else if (term.Equals("Final Term"))
                            {
                                final_term_grade = double.Parse(grade);
                            }

                            double final_grade = mid_term_grade + final_term_grade;
                            double total_grade = final_grade / 1;

                            Dictionary<string, object> gradeData = new Dictionary<string, object>()
                            {
                                {"grade_id", grade_id },
                                {"subject", subject },
                                {"sem", sem },
                                {"term", term },
                                {"mid_term_grade", mid_term_grade },
                                {"final_term_grade", final_term_grade },
                                {"final_grade", total_grade },
                                {"gradeAddedOn", DateTime.UtcNow }
                            };

                            await gradeColRef.Document(grade_id).CreateAsync(gradeData);
                            MessageBox.Show("Grade added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await getStudents();
                            clearFields();
                            Hide();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void clearFields()
        {
            student_cbx.SelectedIndex = 0;
            term_cbx.SelectedIndex = 0;
            subject_cbx.SelectedIndex = 0;
            grade_tb.Text = "";
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void gradeLevelLbl_OnValueChanged(object sender, EventArgs e)
        {
            sem_cbx.SelectedIndex = 0;
        }

        private void student_cbx_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Retrieve the selected student's ID and display it in a message box
            int selectedIndex = student_cbx.SelectedIndex;

            var db = FirestoreHelper.database;
            if (db != null)
            {
                CollectionReference colRef = db.Collection("students");

                // Retrieve the corresponding student document using the Document method
                var selectedStudentDoc = colRef
                    .WhereEqualTo("faculty_id", faculty_id)
                    .GetSnapshotAsync()
                    .Result
                    .Documents[selectedIndex];

                if (selectedStudentDoc.Exists)
                {
                    Students selectedStudent = selectedStudentDoc.ConvertTo<Students>();
                    student_id = selectedStudent.id;
                    gradeLevelLbl.Text = "Grade " + selectedStudent.grade_level;
                }
            }
        }

        private async void student_cbx_Validated(object sender, EventArgs e)
        {
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

                DocumentSnapshot selectedStudentDoc = querySnapshot.Documents.FirstOrDefault();

                if (String.IsNullOrEmpty(gradeLevelLbl.Text))
                {
                    if (selectedStudentDoc != null && selectedStudentDoc.Exists)
                    {
                        Students selectedStudent = selectedStudentDoc.ConvertTo<Students>();
                        student_id = selectedStudent.id;
                        gradeLevelLbl.Text = "Grade " + selectedStudent.grade_level;
                    }
                    else
                    {
                        MessageBox.Show("Selected student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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

        private void sem_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            subject_cbx.Items.Clear();

            string grade_level = gradeLevelLbl.Text;
            string selectedSem = sem_cbx.SelectedItem.ToString();

            // Populate ComboBoxSection based on the selected grade
            if (grade_level == "Grade 11" && selectedSem.Equals("1"))
            {
                subject_cbx.Items.AddRange(GradingSheet.g11_1st_subject.Skip(1).ToArray());
                subject_cbx.SelectedIndex = 0;
            }
            else if (grade_level == "Grade 11" && selectedSem.Equals("2"))
            {
                subject_cbx.Items.AddRange(GradingSheet.g11_2nd_subject.Skip(1).ToArray());
                subject_cbx.SelectedIndex = 0;
            }
            else if (grade_level == "Grade 12" && selectedSem.Equals("1"))
            {
                subject_cbx.Items.AddRange(GradingSheet.g12_1st_subject.Skip(1).ToArray());
                subject_cbx.SelectedIndex = 0;
            }
            else if (grade_level == "Grade 12" && selectedSem.Equals("2"))
            {
                subject_cbx.Items.AddRange(GradingSheet.g12_2nd_subject.Skip(1).ToArray());
                subject_cbx.SelectedIndex = 0;
            }
        }

        private void subject_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSubject = subject_cbx.SelectedItem.ToString();
            string grade_level = gradeLevelLbl.Text;
            string selectedSem = sem_cbx.SelectedItem.ToString();

            if (selectedSubject.Equals("TVE"))
            {
                if (grade_level == "Grade 11" && selectedSem.Equals("1"))
                {
                    majorSubject_cbx.Items.AddRange(GradingSheet.g11_tve_subject.Skip(1).ToArray());
                    majorSubject_cbx.SelectedIndex = 0;
                }
                else if (grade_level == "Grade 11" && selectedSem.Equals("2"))
                {
                    majorSubject_cbx.Items.AddRange(GradingSheet.g11_tve2_subject.Skip(1).ToArray());
                    majorSubject_cbx.SelectedIndex = 0;
                }
                else if (grade_level == "Grade 12" && selectedSem.Equals("1"))
                {
                    majorSubject_cbx.Items.AddRange(GradingSheet.g12_tve_subject.Skip(1).ToArray());
                    majorSubject_cbx.SelectedIndex = 0;
                }
                else if (grade_level == "Grade 12" && selectedSem.Equals("2"))
                {
                    majorSubject_cbx.Items.AddRange(GradingSheet.g12_tve2_subject.Skip(1).ToArray());
                    majorSubject_cbx.SelectedIndex = 0;
                }
            }
            else
            {
                majorSubject_cbx.Items.Clear();
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
