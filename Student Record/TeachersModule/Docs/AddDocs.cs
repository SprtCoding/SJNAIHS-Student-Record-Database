using Google.Cloud.Firestore;
using Student_Record.Firebase;
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

namespace Student_Record.TeachersModule.Docs
{
    public partial class AddDocs : Form
    {
        public static List<(string filePath, string fileName, string fileURL)> data = new List<(string filePath, string fileName, string fileURL)>();
        public AddDocs()
        {
            InitializeComponent();
        }

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
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

        private void save_btn_Click(object sender, EventArgs e)
        {
            using (FRM_Wait frm_wait = new FRM_Wait(Wait))
            {
                frm_wait.ShowDialog(this);
            }
            if (data != null)
            {
                if (data.Count != 0)
                {
                    Hide();
                }
                else
                {
                    MessageBox.Show("No docs found");
                }
            }
        }

        private async void openFileBtn_Click(object sender, EventArgs e)
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
                    uploaded_panel.Controls.Add(label);
                }
                else
                {
                    MessageBox.Show("Error uploading file to Firestore.");
                }

                //string collectionName = "uploads";
                //
                //// Upload file to Firestore
                //await UploadFileToFirestore(filePath, fileName, collectionName);

                otherDocsFileName.Text = fileName;
            }
        }
    }
}
