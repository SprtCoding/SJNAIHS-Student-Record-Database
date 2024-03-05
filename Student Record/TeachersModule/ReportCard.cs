using Google.Cloud.Firestore;
using Student_Record.AdminModule.Student;
using Student_Record.Firebase;
using Student_Record.Firebase.Model;
using Student_Record.TeachersModule.GeneratedCard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Record.TeachersModule
{
    public partial class ReportCard : Form
    {
        private string? faculty_id, faculty_name;
        public ReportCard(string? id, string? name)
        {
            InitializeComponent();
            faculty_id = id;
            faculty_name = name;

            getStudent();
        }

        private async void getStudent()
        {
            student_dtg.DataSource = null;
            student_dtg.Rows.Clear();

            try
            {
                var db = FirestoreHelper.database;

                if (db != null)
                {
                    CollectionReference colRef = db.Collection("students");

                    Query q = colRef.WhereEqualTo("faculty_id", faculty_id);

                    QuerySnapshot qSnap = await q.GetSnapshotAsync();

                    if (qSnap.Count > 0)
                    {
                        no_data_panel.Visible = false;
                        student_dtg.Visible = true;

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
                    }
                    else
                    {
                        no_data_panel.Visible = true;
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
                if (student_dtg.Columns[e.ColumnIndex].Name == "action")
                {
                    GenReportCard reportCard = new GenReportCard(id);
                    reportCard.ShowDialog();
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
    }
}
