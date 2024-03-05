using Student_Record.DataSets.StudentGradeDataSetTableAdapters;
using Student_Record.DataSets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Record.DataSets.StudentDataSetTableAdapters;
using Student_Record.Firebase;
using Google.Cloud.Firestore;
using Student_Record.Firebase.Model;
using Bunifu.Framework.UI;
using Student_Record.TeachersModule.ReportSubmit;
using Student_Record.TeachersModule.GradingSheetPrint;

namespace Student_Record.TeachersModule
{
    public partial class StudentGradingSummary : Form
    {
        string? faculty_id, faculty_name;
        private BunifuFlatButton? currentBtn;
        private Color activeColor = Color.FromArgb(129, 142, 254);
        private Color originalColor = Color.FromArgb(43, 47, 84);

        public StudentGradingSummary(string? id, string? name)
        {
            InitializeComponent();
            this.faculty_id = id;
            this.faculty_name = name;
            loadData("Mid Term");
            activeButton(mid_grade_filter);
            IsButtonActive(mid_grade_filter);
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

        public async void loadData(String term)
        {
            grading_summary_dtg.DataSource = null;
            grading_summary_dtg.Rows.Clear();

            try
            {
                var db = FirestoreHelper.database;
                if (db != null)
                {
                    CollectionReference colRef = db.Collection("students");

                    Query q = colRef.WhereEqualTo("faculty_id", faculty_id);

                    QuerySnapshot qSnap = await q.GetSnapshotAsync();

                    bool isDataFound = false;

                    foreach (DocumentSnapshot snapshot in qSnap.Documents)
                    {
                        if (snapshot.Exists)
                        {
                            Students students = snapshot.ConvertTo<Students>();

                            // Capitalize the first letter of last_name
                            string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                            // Capitalize the first letter of last_name
                            string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);

                            // Access the "grade" subcollection for the current student
                            CollectionReference gradeRef = snapshot.Reference.Collection("Grades");

                            QuerySnapshot gradeSnap = await gradeRef.GetSnapshotAsync();

                            double oralComGrade = 0, komunikasyonGrade = 0, centuryGrade = 0, mathGrade = 0,
                                philosophyGrade = 0, peGrade = 0, tveGrade = 0, grades = 0;

                            foreach (DocumentSnapshot gradeDoc in gradeSnap.Documents)
                            {
                                if (gradeDoc.Exists)
                                {
                                    // Access and use data from the "grade" document
                                    // Example:
                                    Students grade = gradeDoc.ConvertTo<Students>();

                                    if (term.Equals("Mid Term"))
                                    {
                                        grades = (double)grade.mid_term_grade;
                                    }
                                    else if (term.Equals("Final Term"))
                                    {
                                        grades = (double)grade.final_term_grade;
                                    }

                                    // Accumulate grades for each subject
                                    switch (grade.subject)
                                    {
                                        case "Oral Communication":
                                            oralComGrade += grades;
                                            break;
                                        case "Komunikasyon at Pananaliksik":
                                            komunikasyonGrade += grades;
                                            break;
                                        case "21st Century Literature":
                                            centuryGrade += grades;
                                            break;
                                        case "General Mathematics":
                                            mathGrade += grades;
                                            break;
                                        case "Introduction to the Philosophy":
                                            philosophyGrade += grades;
                                            break;
                                        case "Physical Education & Health":
                                            peGrade += grades;
                                            break;
                                        case "TVE":
                                            tveGrade += grades;
                                            break;
                                            // Add more cases for other subjects if needed
                                    }
                                    isDataFound = true;
                                }
                                else
                                {
                                    isDataFound = false;
                                    // Handle the case where there is no data in the "grade" subcollection
                                }
                            }

                            double finalGrade = oralComGrade + komunikasyonGrade + centuryGrade
                                + mathGrade + philosophyGrade + peGrade + tveGrade;

                            double average = Math.Round(finalGrade / 7, 2);

                            grading_summary_dtg.Rows.Insert(
                                0,
                                students.id,
                                capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".",
                                oralComGrade,
                                komunikasyonGrade,
                                centuryGrade,
                                mathGrade,
                                philosophyGrade,
                                peGrade,
                                tveGrade,
                                average
                            );
                        }
                    }

                    if (!isDataFound)
                    {
                        no_data_panel.Visible = true;
                        grading_summary_dtg.Visible = false;
                    }
                    else
                    {
                        no_data_panel.Visible = false;
                        grading_summary_dtg.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mid_grade_filter_Click(object sender, EventArgs e)
        {
            loadData(mid_grade_filter.Text);
            activeButton(mid_grade_filter);
            IsButtonActive(mid_grade_filter);
        }

        private void final_term_grade_filter_Click(object sender, EventArgs e)
        {
            loadData(final_term_grade_filter.Text);
            activeButton(final_term_grade_filter);
            IsButtonActive(final_term_grade_filter);
        }

        private void submit_report_btn_Click(object sender, EventArgs e)
        {
            SelectReportOption report = new SelectReportOption(faculty_id, faculty_name);
            report.ShowDialog();
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            string filter = GetActiveButtonText();
            if (faculty_id != null)
            {
                SummaryPrintPreview printPrev = new SummaryPrintPreview(faculty_id, filter);
                printPrev.ShowDialog();
            }
        }
    }
}
