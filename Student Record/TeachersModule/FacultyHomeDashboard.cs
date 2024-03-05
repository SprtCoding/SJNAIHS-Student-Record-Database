using Google.Cloud.Firestore;
using Student_Record.DataSets.StudentDataSetTableAdapters;
using Student_Record.Firebase;
using Student_Record.Firebase.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Student_Record.TeachersModule
{
    public partial class FacultyHomeDashboard : Form
    {
        string? faculty_id;
        public FacultyHomeDashboard(string? id)
        {
            InitializeComponent();
            this.faculty_id = id;
        }

        private async void getTotalStudent()
        {
            try
            {
                var db = FirestoreHelper.database;

                if (db != null)
                {
                    CollectionReference colRef = db.Collection("students");

                    Query q = colRef.WhereEqualTo("faculty_id", faculty_id);

                    QuerySnapshot qSnap = await q.GetSnapshotAsync();

                    int studentCount = qSnap.Documents.Count();
                    enrolled_total_lbl.Text = studentCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private async void getTotalStudentGrade11()
        {
            try
            {
                var db = FirestoreHelper.database;

                if (db != null)
                {
                    CollectionReference colRef = db.Collection("students");

                    Query q = colRef.WhereEqualTo("faculty_id", faculty_id).WhereEqualTo("grade_level", 11);

                    QuerySnapshot qSnap = await q.GetSnapshotAsync();

                    int student11Count = qSnap.Documents.Count();
                    grade11_total_lbl.Text = student11Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private async void getTotalStudentGrade12()
        {
            try
            {
                var db = FirestoreHelper.database;

                if (db != null)
                {
                    CollectionReference colRef = db.Collection("students");

                    Query q = colRef.WhereEqualTo("faculty_id", faculty_id).WhereEqualTo("grade_level", 12);

                    QuerySnapshot qSnap = await q.GetSnapshotAsync();

                    int student11Count = qSnap.Documents.Count();
                    grade12_total_lbl.Text = student11Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private async void getStudentGrade()
        {
            try
            {
                var db = FirestoreHelper.database;

                if (db != null)
                {
                    CollectionReference colRef = db.Collection("students");

                    Query q = colRef.WhereEqualTo("faculty_id", faculty_id);

                    QuerySnapshot qSnap = await q.GetSnapshotAsync();

                    // Clear existing series from the chart
                    grade_chart.Series.Clear();

                    // Set the font for the axis titles, axis labels, and legend only once
                    grade_chart.ChartAreas[0].AxisX.TitleFont = new Font("Poppins", 10, FontStyle.Italic);
                    grade_chart.ChartAreas[0].AxisY.TitleFont = new Font("Poppins", 10, FontStyle.Italic);
                    grade_chart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Poppins", 8, FontStyle.Italic);
                    grade_chart.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Poppins", 8, FontStyle.Italic);
                    grade_chart.Legends[0].Font = new Font("Poppins", 6, FontStyle.Bold);
                    grade_chart.ChartAreas[0].IsSameFontSizeForAllAxes = true;

                    foreach (DocumentSnapshot snapshot in qSnap.Documents)
                    {
                        Students student = snapshot.ConvertTo<Students>();

                        // Capitalize the first letter of last_name
                        string capitalizedLastName = char.ToUpper(student.last_name[0]) + student.last_name.Substring(1);
                        // Capitalize the first letter of last_name
                        string capitalizedFirstName = char.ToUpper(student.first_name[0]) + student.first_name.Substring(1);

                        string fullname = capitalizedFirstName + " " + student.middle_name.Substring(0, 1).ToUpper() + ". " + capitalizedLastName;

                        double totalGrade = 0, finalAverage = 0;

                        CollectionReference gradeColRef = snapshot.Reference.Collection("Grades");

                        QuerySnapshot gradeSnap = await gradeColRef.GetSnapshotAsync();

                        foreach (DocumentSnapshot gradeSnapShoot in gradeSnap.Documents)
                        {
                            Students grade = gradeSnapShoot.ConvertTo<Students>();

                            totalGrade += (double)grade.final_grade;


                        }

                        finalAverage = totalGrade / gradeSnap.Documents.Count();

                        // Create a series for the chart
                        Series series = new Series(fullname);
                        series.ChartType = SeriesChartType.RangeColumn; // Use a column chart
                        grade_chart.Series.Add(series);

                        series.Points.AddXY("Final Average", finalAverage);
                        series["PointWidth"] = ".8";
                        series.Points[0].ToolTip = $"{fullname}: {Math.Round(finalAverage, 2)}";
                    }

                    // Add data points to the series (student names and their final averages)

                    // Set the Legend property of the chart to display the fullname
                    //series.LegendText = fullname;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void FacultyHomeDashboard_Load(object sender, EventArgs e)
        {
            getTotalStudent();
            getTotalStudentGrade11();
            getTotalStudentGrade12();
            getStudentGrade();
        }
    }
}
