using Google.Cloud.Firestore;
using Student_Record.Firebase.Model;
using Student_Record.Firebase;
using Student_Record.SMTP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Record.Loaders;

namespace Student_Record.TeachersModule.ReportSubmit
{
    public partial class SelectReportOption : Form
    {
        string? faculty_id, faculty_name;
        private Guid uid = Guid.NewGuid();

        public SelectReportOption(string? faculty_id, string? faculty_name)
        {
            InitializeComponent();
            this.faculty_id = faculty_id;
            this.faculty_name = faculty_name;
        }

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
            }
        }

        private async void submitReport()
        {
            string report_id = uid.ToString();
            string report_type = report_type_cbx.Text;
            string status = status_cbx.Text;

            try
            {
                var db = FirestoreHelper.database;

                if (db != null)
                {
                    CollectionReference colRef = db.Collection("Reports");

                    Query q = colRef.WhereEqualTo("faculty_id", faculty_id);

                    QuerySnapshot qSnap = await q.GetSnapshotAsync();

                    if (qSnap.Count > 0)
                    {
                        foreach (DocumentSnapshot documentSnapshot in qSnap.Documents)
                        {
                            // Get the reference to the document
                            DocumentReference docRef = documentSnapshot.Reference;

                            // Create a dictionary with the data to update
                            Dictionary<string, object> updates = new Dictionary<string, object>()
                                {
                                    {"report_type", report_type },
                                    {"status", status }
                                };

                            // Update the document
                            await docRef.UpdateAsync(updates);

                            sendEmail(faculty_name, "Honors Report", "Done");
                        }
                    }
                    else
                    {
                        Dictionary<string, object> reportData = new Dictionary<string, object>()
                            {
                                {"report_id", report_id },
                                {"faculty_id", faculty_id },
                                {"faculty_name", faculty_name },
                                {"report_type", report_type },
                                {"status", status }
                            };

                        await colRef.Document(report_id).CreateAsync(reportData);
                        sendEmail(faculty_name, report_type, status);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void sendEmail(string? faculty_name, string report_type, string status)
        {
            var db = FirestoreHelper.database;

            if (db != null)
            {
                CollectionReference colRef = db.Collection("users");

                Query q = colRef.WhereEqualTo("account_type", "admin");

                QuerySnapshot qSnap = await q.GetSnapshotAsync();

                if (qSnap.Count > 0)
                {
                    foreach (DocumentSnapshot docSnap in qSnap.Documents)
                    {
                        Users user = docSnap.ConvertTo<Users>();

                        if (user != null)
                        {
                            string admin_email = user.email;
                            if (admin_email != null)
                            {
                                try
                                {
                                    EmailSender.SendEmail(admin_email, "Report Submitted", "Hi, " + faculty_name + " is submitted a report.\nWith status of " + status + "\nReport type of " + report_type + "\n\nThank you!");
                                    MessageBox.Show("Report submitted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    report_type_cbx.SelectedIndex = 0;
                                    status_cbx.SelectedIndex = 0;
                                    Hide();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            using (FRM_Wait frm_wait = new FRM_Wait(Wait))
            {
                frm_wait.ShowDialog(this);
            }
            submitReport();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            report_type_cbx.SelectedIndex = 0;
            status_cbx.SelectedIndex = 0;
            Hide();
        }
    }
}
