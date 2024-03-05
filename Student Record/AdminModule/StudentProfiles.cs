using Google.Cloud.Firestore;
using Student_Record.AdminModule.AddForm;
using Student_Record.AdminModule.Student;
using Student_Record.Firebase;
using Student_Record.Firebase.Model;
using Student_Record.Loaders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Record.AdminModule
{
    public partial class StudentProfiles : Form
    {
        public StudentProfiles()
        {
            InitializeComponent();
            filter_type_cbx.SelectedIndex = 0;
            //getStudents();
            getMaleCount();
            getFemaleCount();
        }

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
            }
        }

        private async void getFemaleCount()
        {
            try
            {
                var db = FirestoreHelper.database;
                if (db != null)
                {
                    // Reference to your Firestore collection
                    CollectionReference collectionRef = db.Collection("students");

                    // Create a query to filter documents with "sms_type" equal to "emergency"
                    Query query = collectionRef.WhereEqualTo("gender", "Female");

                    // Fetch the documents
                    QuerySnapshot snapshot = await query.GetSnapshotAsync();

                    int femaleCount = snapshot.Documents.Count;
                    female_count.Text = femaleCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void getMaleCount()
        {
            try
            {
                var db = FirestoreHelper.database;
                if (db != null)
                {
                    // Reference to your Firestore collection
                    CollectionReference collectionRef = db.Collection("students");

                    // Create a query to filter documents with "sms_type" equal to "emergency"
                    Query query = collectionRef.WhereEqualTo("gender", "Male");

                    // Fetch the documents
                    QuerySnapshot snapshot = await query.GetSnapshotAsync();

                    int maleCount = snapshot.Documents.Count;
                    male_count.Text = maleCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void getStudents()
        {
            student_dtg.DataSource = null;
            student_dtg.Rows.Clear();

            var db = FirestoreHelper.database;
            if (db != null)
            {
                CollectionReference studentRef = db.Collection("students");
                QuerySnapshot snap = await studentRef.GetSnapshotAsync();

                foreach (DocumentSnapshot snapshot in snap.Documents)
                {
                    if (snapshot.Exists)
                    {
                        Students students = snapshot.ConvertTo<Students>();

                        // Capitalize the first letter of last_name
                        string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                        // Capitalize the first letter of last_name
                        string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);

                        student_dtg.Rows.Insert(
                                0,
                                students.id,
                                capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".",
                                students.lrn_number,
                                students.gender,
                                students.grade_level,
                                students.section,
                                Properties.Resources.test,
                                Properties.Resources.eye
                            );

                        // Add the CellFormatting event to set the tooltip for the Warning column
                        student_dtg.CellFormatting += (sender, e) =>
                        {
                            if (e.ColumnIndex == 6 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                            {
                                DataGridViewCell cell = student_dtg.Rows[e.RowIndex].Cells[e.ColumnIndex];
                                cell.ToolTipText = "View Grades";
                            }
                            if (e.ColumnIndex == 7 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                            {
                                DataGridViewCell cell = student_dtg.Rows[e.RowIndex].Cells[e.ColumnIndex];
                                cell.ToolTipText = "View Details";
                            }
                        };
                        // Add the CellMouseEnter event to change the cursor to a hand cursor
                        student_dtg.CellMouseEnter += (sender, e) =>
                        {
                            if (e.ColumnIndex == 6 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                            {
                                student_dtg.Cursor = Cursors.Hand;
                            }
                            if (e.ColumnIndex == 7 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
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
                    else
                    {
                        MessageBox.Show("No data found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void filter_type_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(filter_type_cbx.Text))
            {
                filter_value_cbx.Enabled = false;
            }
            else
            {
                filter_value_cbx.Enabled = true;
                string filter = filter_type_cbx.Text;
                if (filter.Equals("Grade Level"))
                {
                    filter_value_cbx.Items.Clear();
                    filter_value_cbx.Items.AddRange(new string[] { "Any", "11", "12" });
                    filter_value_cbx.SelectedIndex = 0;
                }
                else if (filter.Equals("Section"))
                {
                    filter_value_cbx.Items.Clear();
                    filter_value_cbx.Items.AddRange(new string[] { "Any", "Canary", "Flamingo", "Falcon", "Skylark", "Pelican", "Apollo", "Artemis", "Athena", "Kairos", "Sol Invictus" });
                    filter_value_cbx.SelectedIndex = 0;
                }
                else if (filter.Equals("Any"))
                {
                    filter_value_cbx.Enabled = false;
                    getStudents();
                }
            }
        }

        private void student_dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Perform the "Edit" action
                DataGridViewRow selectedRow = student_dtg.Rows[e.RowIndex];
                string id = selectedRow.Cells["id"].Value.ToString();
                if (student_dtg.Columns[e.ColumnIndex].Name == "action")
                {
                    Details details = new Details(id);
                    details.ShowDialog(this);
                }
            }
        }

        private void male_panel_Click(object sender, EventArgs e)
        {
            using (FRM_Wait frm_wait = new FRM_Wait(Wait))
            {
                frm_wait.ShowDialog(this);
            }
            getStudent("Male");
        }

        private async void getStudentFilter(string filter)
        {
            student_dtg.DataSource = null;
            student_dtg.Rows.Clear();

            var db = FirestoreHelper.database;
            if (db != null)
            {
                CollectionReference studentRef = db.Collection("students");

                if (filter.Equals("Any"))
                {
                    getStudents();
                }
                else if (filter.Equals("11") || filter.Equals("12"))
                {
                    int filterInt = int.Parse(filter);

                    Query q = studentRef.WhereEqualTo("grade_level", filterInt);

                    QuerySnapshot snap = await q.GetSnapshotAsync();

                    foreach (DocumentSnapshot snapshot in snap.Documents)
                    {
                        if (snapshot.Exists)
                        {
                            Students students = snapshot.ConvertTo<Students>();

                            // Capitalize the first letter of last_name
                            string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                            // Capitalize the first letter of last_name
                            string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);

                            student_dtg.DataSource = null;
                            student_dtg.Rows.Clear();

                            student_dtg.Rows.Insert(
                                    0,
                                    students.id,
                                    capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".",
                                    students.lrn_number,
                                    students.gender,
                                    students.grade_level,
                                    students.section,
                                    Properties.Resources.test_white,
                                    Properties.Resources.eye
                                );

                            // Add the CellFormatting event to set the tooltip for the Warning column
                            student_dtg.CellFormatting += (sender, e) =>
                            {
                                if (e.ColumnIndex == 6 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                                {
                                    DataGridViewCell cell = student_dtg.Rows[e.RowIndex].Cells[e.ColumnIndex];
                                    cell.ToolTipText = "View Grades";
                                }
                            };
                            // Add the CellMouseEnter event to change the cursor to a hand cursor
                            student_dtg.CellMouseEnter += (sender, e) =>
                            {
                                if (e.ColumnIndex == 6 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
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
                        else
                        {
                            MessageBox.Show("No data found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    Query q = studentRef.WhereEqualTo("section", filter);

                    QuerySnapshot snap = await q.GetSnapshotAsync();

                    foreach (DocumentSnapshot snapshot in snap.Documents)
                    {
                        if (snapshot.Exists)
                        {
                            Students students = snapshot.ConvertTo<Students>();

                            // Capitalize the first letter of last_name
                            string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                            // Capitalize the first letter of last_name
                            string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);

                            student_dtg.DataSource = null;
                            student_dtg.Rows.Clear();

                            student_dtg.Rows.Insert(
                                    0,
                                    students.id,
                                    capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".",
                                    students.lrn_number,
                                    students.gender,
                                    students.grade_level,
                                    students.section,
                                    Properties.Resources.test_white,
                                    Properties.Resources.eye
                                );

                            // Add the CellFormatting event to set the tooltip for the Warning column
                            student_dtg.CellFormatting += (sender, e) =>
                            {
                                if (e.ColumnIndex == 6 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                                {
                                    DataGridViewCell cell = student_dtg.Rows[e.RowIndex].Cells[e.ColumnIndex];
                                    cell.ToolTipText = "View Grades";
                                }
                            };
                            // Add the CellMouseEnter event to change the cursor to a hand cursor
                            student_dtg.CellMouseEnter += (sender, e) =>
                            {
                                if (e.ColumnIndex == 6 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
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
                        else
                        {
                            MessageBox.Show("No data found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private async void getStudent(string gender)
        {
            student_dtg.DataSource = null;
            student_dtg.Rows.Clear();

            var db = FirestoreHelper.database;
            if (db != null)
            {
                CollectionReference studentRef = db.Collection("students");

                Query q = studentRef.WhereEqualTo("gender", gender);

                QuerySnapshot snap = await q.GetSnapshotAsync();

                foreach (DocumentSnapshot snapshot in snap.Documents)
                {
                    if (snapshot.Exists)
                    {
                        Students students = snapshot.ConvertTo<Students>();

                        // Capitalize the first letter of last_name
                        string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                        // Capitalize the first letter of last_name
                        string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);

                        student_dtg.DataSource = null;
                        student_dtg.Rows.Clear();

                        student_dtg.Rows.Insert(
                                0,
                                students.id,
                                capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".",
                                students.lrn_number,
                                students.gender,
                                students.grade_level,
                                students.section,
                                Properties.Resources.test_white,
                                Properties.Resources.eye
                            );

                        // Add the CellFormatting event to set the tooltip for the Warning column
                        student_dtg.CellFormatting += (sender, e) =>
                        {
                            if (e.ColumnIndex == 6 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                            {
                                DataGridViewCell cell = student_dtg.Rows[e.RowIndex].Cells[e.ColumnIndex];
                                cell.ToolTipText = "View Grades";
                            }
                        };
                        // Add the CellMouseEnter event to change the cursor to a hand cursor
                        student_dtg.CellMouseEnter += (sender, e) =>
                        {
                            if (e.ColumnIndex == 6 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
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
                    else
                    {
                        MessageBox.Show("No data found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void female_panel_Click(object sender, EventArgs e)
        {
            using (FRM_Wait frm_wait = new FRM_Wait(Wait))
            {
                frm_wait.ShowDialog(this);
            }
            getStudent("Female");
        }

        private void filter_value_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = filter_value_cbx.SelectedItem.ToString();
            getStudentFilter(filter);
        }
    }
}
