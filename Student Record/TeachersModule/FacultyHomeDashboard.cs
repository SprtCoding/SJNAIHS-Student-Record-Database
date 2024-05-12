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
        int totalStudent = 0, totalG11Student = 0, totalG12Student = 0;
        public FacultyHomeDashboard(string? id)
        {
            InitializeComponent();
            this.faculty_id = id;
        }

        private async Task<int> getTotalStudent()
        {
            try
            {
                var db = FirestoreHelper.database;

                if (db != null)
                {
                    CollectionReference colRef = db.Collection("students");

                    Query q = colRef.WhereEqualTo("faculty_id", faculty_id);

                    QuerySnapshot snap = await q.GetSnapshotAsync();

                    totalStudent = snap.Documents.Count();

                    /*QuerySnapshot qSnap = await q.GetSnapshotAsync();

                    if(qSnap != null)
                    {
                        totalStudent = qSnap.Documents.Count();
                        //enrolled_total_lbl.Text = studentCount.ToString();
                    }*/
                }
                return totalStudent;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private async Task<int> getTotalStudentGrade11()
        {
            try
            {
                var db = FirestoreHelper.database;

                if (db != null)
                {
                    CollectionReference colRef = db.Collection("students");

                    Query q = colRef.WhereEqualTo("faculty_id", faculty_id).WhereEqualTo("grade_level", 11);

                    QuerySnapshot qSnap = await q.GetSnapshotAsync();

                    if(qSnap != null)
                    {
                        totalG11Student = qSnap.Documents.Count();
                        //grade11_total_lbl.Text = student11Count.ToString();
                    }
                }
                return totalG11Student;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private async Task<int> getTotalStudentGrade12()
        {
            try
            {
                var db = FirestoreHelper.database;

                if (db != null)
                {
                    CollectionReference colRef = db.Collection("students");

                    Query q = colRef.WhereEqualTo("faculty_id", faculty_id).WhereEqualTo("grade_level", 12);

                    QuerySnapshot qSnap = await q.GetSnapshotAsync();

                    if(qSnap != null)
                    {
                        totalG12Student = qSnap.Documents.Count();
                        //grade12_total_lbl.Text = student11Count.ToString();
                    }
                }
                return totalG12Student;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private async Task getStudentSection()
        {
            try
            {
                var db = FirestoreHelper.database;

                if (db != null)
                {
                    CollectionReference colRef = db.Collection("students");

                    Query q = colRef.WhereEqualTo("faculty_id", faculty_id)
                                    .OrderBy("section");

                    QuerySnapshot snap = await q.GetSnapshotAsync();

                    if (snap != null)
                    {
                        // Set the font for the axis titles, axis labels, and legend only once
                        grade_chart.ChartAreas[0].AxisX.TitleFont = new Font("Poppins", 10, FontStyle.Italic);
                        grade_chart.ChartAreas[0].AxisY.TitleFont = new Font("Poppins", 10, FontStyle.Italic);
                        grade_chart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Poppins", 8, FontStyle.Italic);
                        grade_chart.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Poppins", 8, FontStyle.Italic);
                        grade_chart.Legends[0].Font = new Font("Poppins", 6, FontStyle.Bold);
                        grade_chart.ChartAreas[0].IsSameFontSizeForAllAxes = true;

                        // Clear existing series from the chart
                        grade_chart.Series.Clear();

                        // Create a dictionary to hold the section name and its count
                        Dictionary<string, int> sectionCounts = new Dictionary<string, int>();

                        // Populate the dictionary with section names and their counts
                        foreach (DocumentSnapshot docSnap in snap.Documents)
                        {
                            if (docSnap.Exists)
                            {
                                Students student = docSnap.ConvertTo<Students>();
                                string section = student.section;

                                if (sectionCounts.ContainsKey(section))
                                    sectionCounts[section]++;
                                else
                                    sectionCounts[section] = 1;
                            }
                        }

                        // Add each section as a series to the column chart
                        foreach (var kvp in sectionCounts)
                        {
                            Series series = new Series(kvp.Key);
                            series.ChartType = SeriesChartType.Column;
                            grade_chart.Series.Add(series);

                            series.LegendText = kvp.Key;
                            series.BorderWidth = 2;
                            series.Points.AddXY(kvp.Key, kvp.Value);
                            series["PointWidth"] = "1";
                            series["PixelPointWidth"] = "250";
                            series.Points[0].ToolTip = $"{kvp.Key}: {kvp.Value}";

                            // Add animation to the series
                            await AnimateColumn(series.Points[0], kvp.Value, 1000);
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

        private async Task AnimateColumn(DataPoint point, double finalValue, int duration)
        {
            double initialValue = point.YValues[0];
            double increment = (finalValue - initialValue) / (duration / 20.0); // Adjust the interval (20 ms in this example)

            while (point.YValues[0] < finalValue)
            {
                point.YValues[0] += increment;
                grade_chart.Invalidate(); // Refresh the chart to display changes
                await Task.Delay(20); // Adjust the interval (20 ms in this example)
            }

            // Ensure final value is set exactly
            point.YValues[0] = finalValue;
            grade_chart.Invalidate(); // Refresh the chart to display changes
        }

        private async void FacultyHomeDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                int totalStudentCount = await getTotalStudent();
                int totalStudentG11Count = await getTotalStudentGrade11();
                int totalStudentG12Count = await getTotalStudentGrade12();

                enrolled_total_lbl.Text = totalStudentCount.ToString();
                grade11_total_lbl.Text = totalStudentG11Count.ToString();
                grade12_total_lbl.Text = totalStudentG12Count.ToString();
                await getStudentSection();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
