using Google.Cloud.Firestore;
using Microsoft.Office.Interop.Word;
using Student_Record.AdminModule.Student;
using Student_Record.Firebase;
using Student_Record.Firebase.Model;
using Student_Record.Loaders;
using Student_Record.TeachersModule.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Student_Record.AdminModule
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            getStudentGradeCount();
            getReports();
        }

        private async void getReports()
        {
            report_dtg.DataSource = null;
            report_dtg.Rows.Clear();

            try
            {
                var db = FirestoreHelper.database;
                if (db != null)
                {
                    // Reference to your Firestore collection
                    CollectionReference collectionRef = db.Collection("Reports");

                    // Fetch the documents
                    QuerySnapshot snapshot = await collectionRef.GetSnapshotAsync();

                    foreach (DocumentSnapshot docSnap in snapshot.Documents)
                    {
                        ReportsModel report = docSnap.ConvertTo<ReportsModel>();

                        report_dtg.Rows.Insert(
                                0,
                                report.report_id,
                                report.faculty_name,
                                report.report_type,
                                report.status,
                                Properties.Resources.trash
                            );

                        // Add the CellFormatting event to set the tooltip for the Warning column
                        report_dtg.CellFormatting += (sender, e) =>
                        {
                            if (e.ColumnIndex == 4 && e.RowIndex >= 0 && e.RowIndex < report_dtg.Rows.Count)
                            {
                                DataGridViewCell cell = report_dtg.Rows[e.RowIndex].Cells[e.ColumnIndex];
                                cell.ToolTipText = "Delete Report?";
                            }
                        };
                        // Add the CellMouseEnter event to change the cursor to a hand cursor
                        report_dtg.CellMouseEnter += (sender, e) =>
                        {
                            if (e.ColumnIndex == 4 && e.RowIndex >= 0 && e.RowIndex < report_dtg.Rows.Count)
                            {
                                report_dtg.Cursor = Cursors.Hand;
                            }
                        };

                        // Add the CellMouseLeave event to revert the cursor to the default cursor
                        report_dtg.CellMouseLeave += (sender, e) =>
                        {
                            report_dtg.Cursor = Cursors.Default;
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void getStudentGradeCount()
        {
            try
            {
                var db = FirestoreHelper.database;
                if (db != null)
                {
                    // Reference to your Firestore collection
                    CollectionReference collectionRef = db.Collection("students");

                    // Create a query to filter documents with "sms_type" equal to "emergency"
                    Query query = collectionRef.WhereEqualTo("hasGrade", true);

                    // Fetch the documents
                    QuerySnapshot snapshot = await query.GetSnapshotAsync();

                    int facultyCount = snapshot.Documents.Count;
                    grade_lbl.Text = facultyCount.ToString() + " has Grade.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
            }
        }

        private void report_dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Perform the "Edit" action
                DataGridViewRow selectedRow = report_dtg.Rows[e.RowIndex];
                string id = selectedRow.Cells["id"].Value.ToString();
                if (report_dtg.Columns[e.ColumnIndex].Name == "action")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this report?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                        {
                            frm_wait.ShowDialog(this);
                        }
                        deleteReport(id);
                    }
                }
            }
        }

        private async void deleteReport(string? id)
        {
            var db = FirestoreHelper.database;
            if(db != null)
            {
                CollectionReference usersRef = db.Collection("Reports");
                await usersRef.Document(id).DeleteAsync();

                MessageBox.Show("Report Deleted.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getReports();
            }
        }
    }
}
