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
        List<(string filePath, string fileName, string fileURL)> data = new List<(string filePath, string fileName, string fileURL)>();

        public SelectReportOption(string? faculty_id, string? faculty_name)
        {
            InitializeComponent();
            this.faculty_id = faculty_id;
            this.faculty_name = faculty_name;
        }

        private async void submitReport()
        {
            lbl.Visible = true;
            loadingProgress.Visible = true;
            loadingProgress.Value = 25;

            string report_id = uid.ToString();
            string report_type = report_cbx.SelectedItem.ToString();
            string status = status_cbx.SelectedItem.ToString();

            try
            {
                var db = FirestoreHelper.database;

                if (db != null)
                {
                    CollectionReference colRef = db.Collection("Reports");

                    loadingProgress.Value = 50;

                    DateTime now = DateTime.UtcNow;

                    foreach (var item in data)
                    {
                        Dictionary<string, object> reportData = new Dictionary<string, object>()
                            {
                                {"report_id", report_id },
                                {"faculty_id", this.faculty_id },
                                {"faculty_name", faculty_name },
                                {"report_type", report_type },
                                {"docs_name", item.fileName },
                                {"docs_path", item.filePath },
                                {"docs_url", item.fileURL },
                                {"status", status },
                                {"submitted_at", now }
                            };

                        await colRef.Document(report_id).CreateAsync(reportData);
                        sendEmail(faculty_name, report_type, status);
                        loadingProgress.Value = 75;
                    }

                    /*Query q = colRef.WhereEqualTo("faculty_id", faculty_id);

                    QuerySnapshot qSnap = await q.GetSnapshotAsync();*/

                    /*if (qSnap.Count > 0)
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

                            sendEmail(faculty_name, report_type, status);
                        }
                    }*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl.Visible = false;
                loadingProgress.Visible = false;
                loadingProgress.Value = 0;
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

                loadingProgress.Value = 100;

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
                                    List<string> attachments = new List<string>();

                                    foreach (var fileData in data)
                                    {
                                        attachments.Add(fileData.filePath);
                                    }

                                    EmailSenderWithAttachment.SendEmail(admin_email, "Report Submitted", "Hi, " + faculty_name + " has submitted a report.\nWith status of " + status + "\nReport type of " + report_type + "\n\nThank you!", attachments);
                                    MessageBox.Show("Report submitted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            submitReport();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private async void SelectReportOption_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(await getFacultyEmail());
        }

        private async void open_file_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Documents|*.docx;*.pdf;*.xlsx;*.xls|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(filePath);

                // Check file size
                long fileSize = new FileInfo(filePath).Length; // Size in bytes
                long maxSize = 5 * 1024 * 1024; // 5MB in bytes
                if (fileSize > maxSize)
                {
                    MessageBox.Show("File size exceeds 5MB limit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string collectionName = "uploads";

                // Upload file to Firestore
                var result = await UploadFileToFirestore(filePath, fileName, collectionName);

                if (result.url != null && result.fileName != null)
                {
                    data.Add((result.path, result.fileName, result.url));

                    // Create a label for the uploaded file
                    Label label = new Label();
                    label.Text = "     " + result.fileName;
                    // Set AutoSize property to true
                    label.AutoSize = true;
                    // Set font and font size
                    label.Font = new System.Drawing.Font("Poppins", 10, FontStyle.Regular);
                    label.TextAlign = ContentAlignment.MiddleLeft;
                    label.ImageAlign = ContentAlignment.MiddleLeft;
                    label.Image = Properties.Resources.checkbox;

                    // Add the label to the FlowLayoutPanel
                    //uploaded_panel.Controls.Add(label);
                }
                else
                {
                    MessageBox.Show("Error uploading file to Firestore.");
                }

                //string collectionName = "uploads";
                //
                //// Upload file to Firestore
                //await UploadFileToFirestore(filePath, fileName, collectionName);

                file_name_tb.Text = fileName;
            }
        }

        private async Task<(string url, string fileName, string path)> UploadFileToFirestore(string filePath, string fileName, string collectionName)
        {
            var db = FirestoreHelper.database;
            if (db != null)
            {
                try
                {
                    CollectionReference collectionRef = db.Collection(collectionName);

                    // Read the file as bytes
                    byte[] fileBytes = File.ReadAllBytes(filePath);

                    // Convert bytes to Base64 string
                    string fileBase64 = Convert.ToBase64String(fileBytes);

                    Dictionary<string, object> data = new Dictionary<string, object>()
                    {
                        { "File", fileBase64 },
                        { "FileName", fileName },
                        { "FilePath", filePath }
                    };

                    // Upload file Base64 string to Firestore
                    await collectionRef.Document(fileName).SetAsync(data);

                    // Get download URL of the uploaded file
                    var snapshot = await db.Collection(collectionName).Document(fileName).GetSnapshotAsync();
                    var fileUrl = snapshot.Exists ? snapshot.GetValue<string>("File") : null;
                    var fileNames = snapshot.Exists ? snapshot.GetValue<string>("FileName") : null;
                    var Path = snapshot.Exists ? snapshot.GetValue<string>("FilePath") : null;

                    return (fileUrl, fileNames, Path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error uploading file to Firestore: " + ex.Message);
                    return (null, null, null);
                }
            }
            else
            {
                throw new Exception("Firestore database is not initialized.");
            }
        }
    }
}
