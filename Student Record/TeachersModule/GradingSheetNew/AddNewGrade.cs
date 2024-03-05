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

namespace Student_Record.TeachersModule.GradingSheetNew
{
    public partial class AddNewGrade : Form
    {
        string? faculty_id, student_id;
        private Guid uid = Guid.NewGuid();
        private BunifuCustomDataGrid? myDTG;
        private Panel? no_data_panel;

        public AddNewGrade(string faculty_id, BunifuCustomDataGrid dtg, Panel no_data_panel)
        {
            InitializeComponent();
            this.faculty_id = faculty_id;
            this.myDTG = dtg;
        }

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
            }
        }

        private async void getStudentsFilter(string subject)
        {
            if(myDTG != null) {
                myDTG.DataSource = null;
                myDTG.Rows.Clear();

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
                                    myDTG.Rows.Insert(
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
                        if(no_data_panel != null)
                        {
                            no_data_panel.Visible = true;
                        }
                        myDTG.Visible = false;
                    }
                    else
                    {
                        if (no_data_panel != null)
                        {
                            no_data_panel.Visible = false;
                        }
                        myDTG.Visible = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("no dtg");
            }
        }

        private async void getStudentName()
        {
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
                            student_cbx.Items.Add(capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ". " + students.suffix);
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

        private void AddNewGrade_Load(object sender, EventArgs e)
        {
            student_cbx.Items.Clear();
            getStudentName();
        }

        private void student_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Retrieve the selected student's ID and display it in a message box
            int selectedIndex = student_cbx.SelectedIndex;

            // Check if an item is selected
            if (selectedIndex >= 0)
            {
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
                    }
                }
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            string name = student_cbx.Text;
            string term = term_cbx.Text;
            string subject = subject_cbx.Text;
            string grade = grade_tb.Text;

            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please choose a student!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                setGrade(student_id, term, subject, grade);
            }
        }

        private async void setGrade(string? student_id, string term, string subject, string grade)
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

                        Query q = gradeColRef.WhereEqualTo("subject", subject);

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
                                {"final_grade", total_grade }
                            };

                            await existingGradeDoc.Reference.UpdateAsync(updateData);

                            MessageBox.Show("Grade updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            getStudentsFilter(subject);
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
                                {"term", term },
                                {"mid_term_grade", mid_term_grade },
                                {"final_term_grade", final_term_grade },
                                {"final_grade", total_grade }
                            };

                            await gradeColRef.Document(grade_id).CreateAsync(gradeData);
                            MessageBox.Show("Grade added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            getStudentsFilter(subject);
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
    }
}
