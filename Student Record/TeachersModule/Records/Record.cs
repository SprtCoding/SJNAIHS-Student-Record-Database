using Google.Cloud.Firestore;
using Microsoft.Office.Interop.Word;
using Student_Record.Firebase;
using Student_Record.Firebase.Model;
using Student_Record.Loaders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;

namespace Student_Record.TeachersModule.Records
{
    public partial class Record : Form
    {
        string? id, faculty_id;
        bool hasData = false;
        private ContextMenuStrip? contextMenuStrip;
        private string? documentContent;
        List<(string filePath, string fileName, string fileURL)> data = new List<(string filePath, string fileName, string fileURL)>();

        public Record(string? id, string? faculty_id)
        {
            InitializeComponent();
            this.id = id;
            this.faculty_id = faculty_id;
            PopulateFlowLayoutPanel();
            getStudentInfo(id);
        }

        public static Image Base64StringIntoImage(string imageStr)
        {
            byte[] img = Convert.FromBase64String(imageStr);
            using (MemoryStream ms = new MemoryStream(img))
            {
                return Image.FromStream(ms);
            }
        }

        private async void getStudentInfo(string? id)
        {
            var db = FirestoreHelper.database;
            if (db != null)
            {
                DocumentReference collection = db.Collection("students").Document(id);

                DocumentSnapshot docSnap = await collection.GetSnapshotAsync();

                if (docSnap.Exists)
                {
                    Students student = docSnap.ConvertTo<Students>();
                    if(student.lrn_number != null && student.section != null && student.gender != null && student.dob != null && student.address != null
                        && student.last_school_attended != null && student.contact_number != null && student.major != null && student.father_name != null && student.father_contact != null 
                        && student.mother_name != null && student.mother_contact != null && student.guardian_name != null && student.guardian_contact != null && student.ImageStr != null)
                    {
                        string _lrn = student.lrn_number;
                        string _section = student.section;
                        string _gender = student.gender;
                        string _dob = student.dob;
                        string _address = student.address;
                        string _last_attended = student.last_school_attended;
                        string _contact_number = student.contact_number;
                        string _major = student.major;
                        string _father = student.father_name;
                        string _father_contact = student.father_contact;
                        string _mother = student.mother_name;
                        string _mother_contact = student.mother_contact;
                        string _guardian = student.guardian_name;
                        string _guardian_contact = student.guardian_contact;
                        string _imageStr = student.ImageStr;

                        lrn_lbl.Text = _lrn;
                        section_lbl.Text = _section;
                        gender_lbl.Text = _gender;
                        dob_lbl.Text = _dob;
                        address_lbl.Text = _address;
                        last_attended_lbl.Text = _last_attended;
                        c_no_lbl.Text = _contact_number;
                        major_lbl.Text = _major;
                        father_lbl.Text = _father;
                        f_c_no_lbl.Text = _father_contact;
                        mother_lbl.Text = _mother;
                        m_c_no_lbl.Text = _mother_contact;
                        guardian_lbl.Text = _guardian;
                        g_c_no_lbl.Text = _guardian_contact;
                        student_pic.Image = Base64StringIntoImage(_imageStr);
                    }
                }
            }
        }

        public async Task<List<(string name, string url, string id, string path)>> GetDataFromFirestore(string id)
        {
            List<(string name, string url, string id, string path)> data = new List<(string name, string url, string id, string path)>();
            var db = FirestoreHelper.database;
            if (db != null)
            {
                DocumentReference collection = db.Collection("students").Document(id);

                DocumentSnapshot docSnap = await collection.GetSnapshotAsync();

                if (docSnap.Exists)
                {
                    Students student = docSnap.ConvertTo<Students>();

                    if (student.last_name != null && student.first_name != null && student.middle_name != null)
                    {
                        // Capitalize the first letter of last_name
                        string capitalizedLastName = char.ToUpper(student.last_name[0]) + student.last_name.Substring(1);
                        // Capitalize the first letter of last_name
                        string capitalizedFirstName = char.ToUpper(student.first_name[0]) + student.first_name.Substring(1);

                        string fullname = capitalizedFirstName + " " + student.middle_name.Substring(0, 1).ToUpper() + ". " + capitalizedLastName;

                        student_name_lbl.Text = fullname;
                    }

                    CollectionReference otherDocs = collection.Collection("other_docs");

                    QuerySnapshot snapshot = await otherDocs.GetSnapshotAsync();

                    foreach (DocumentSnapshot document in snapshot.Documents)
                    {
                        if (document.Exists)
                        {
                            // Assuming 'name' is a field in your Firestore documents
                            string _name = document.GetValue<string>("docs_name");
                            string _url = document.GetValue<string>("docs_url");
                            string _path = document.GetValue<string>("docs_path");
                            string _docs_id = document.GetValue<string>("docs_id");
                            data.Add((_name, _url, _docs_id, _path));

                            hasData = true;
                        }
                        else
                        {
                            hasData = false;
                        }
                    }

                    if (snapshot.Count >= 4)
                    {
                        new_docs_panel.Visible = false;
                    }
                    else
                    {
                        new_docs_panel.Visible = true;
                        add_docs_title.Text = "Add more Docs";
                    }
                }

                if (!hasData)
                {
                    // Create a label for each data item
                    Label label = new Label();
                    label.Text = "     No Docs found!";
                    // Set AutoSize property to true
                    label.AutoSize = true;
                    // Set font and font size
                    label.Font = new System.Drawing.Font("Poppins", 10, FontStyle.Regular);
                    label.TextAlign = ContentAlignment.MiddleLeft;
                    label.ImageAlign = ContentAlignment.MiddleLeft;
                    label.Image = Properties.Resources.square_small;

                    // Add the label to the FlowLayoutPanel
                    list_panel.Controls.Add(label);

                    new_docs_panel.Visible = true;
                    add_docs_title.Text = "Add Docs";
                }
            }
            return data;
        }

        private async void PopulateFlowLayoutPanel()
        {
            // Clear existing controls from FlowLayoutPanel
            list_panel.Controls.Clear();

            if (id != null)
            {
                List<(string, string, string, string)> firestoreData = await GetDataFromFirestore(id);

                foreach ((string name, string url, string docs_id, string path) in firestoreData)
                {
                    // Create a label for each data item
                    Label label = new Label();
                    label.Text = "     " + name;
                    // Set AutoSize property to true
                    label.AutoSize = true;
                    // Set font and font size
                    label.Font = new System.Drawing.Font("Poppins", 10, FontStyle.Regular);
                    label.TextAlign = ContentAlignment.MiddleLeft;
                    label.ImageAlign = ContentAlignment.MiddleLeft;
                    label.Image = Properties.Resources.checkbox;

                    // Create a new tooltip instance
                    ToolTip tooltip = new ToolTip();
                    tooltip.IsBalloon = true;
                    // Set the tooltip text
                    tooltip.SetToolTip(label, "Right click to enter menu!");

                    // Set the cursor to hand
                    label.Cursor = Cursors.Hand;

                    CreateContextMenu(url, name, docs_id, path);

                    // Attach context menu strip to the label
                    label.ContextMenuStrip = contextMenuStrip;

                    // Handle the Click event of the label
                    //label.Click += (sender, e) =>
                    //{
                    //    using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                    //    {
                    //        frm_wait.ShowDialog(this);
                    //    }
                    //    downloadFileUrl(url, name);
                    //};

                    // Add the label to the FlowLayoutPanel
                    list_panel.Controls.Add(label);
                }
            }
        }

        // Function to print the document
        private void PrintDocument(string documentContent)
        {
            // Create an instance of PrintDocument
            PrintDocument printDocument = new PrintDocument();

            // Set PrintPage event handler
            printDocument.PrintPage += (sender, e) =>
            {
                // Print the document content
                if(e.Graphics != null)
                {
                    e.Graphics.DrawString(documentContent, new System.Drawing.Font("Arial", 12), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top);
                }
            };

            // Show print dialog and print the document if user confirms
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void CreateContextMenu(string url, string name, string docs_id, string path)
        {
            // Create a new context menu strip
            contextMenuStrip = new ContextMenuStrip();

            // Create menu items
            ToolStripMenuItem menuItemOpen = new ToolStripMenuItem("Open", null, MenuItemOpen_Click);
            ToolStripMenuItem menuItemDownload = new ToolStripMenuItem("Download", null, MenuItemDownload_Click);
            ToolStripMenuItem menuItemDelete = new ToolStripMenuItem("Delete", null, MenuItemDelete_Click);

            // Set tags for menu items
            menuItemDownload.Tag = new Tuple<string, string>(url, name);
            menuItemOpen.Tag = new Tuple<string, string>(url, name);
            menuItemDelete.Tag = new Tuple<string, string>(name, docs_id);

            // Set icons for menu items
            menuItemDownload.Image = Properties.Resources.download_file_blck; // Change 'DownloadIcon' to your icon resource
            menuItemOpen.Image = Properties.Resources.folder_open; // Add this line
            menuItemDelete.Image = Properties.Resources.trash; // Change 'DeleteIcon' to your icon resource

            // Add menu items to the context menu strip
            contextMenuStrip.Items.Add(menuItemOpen);
            contextMenuStrip.Items.Add(menuItemDownload);
            contextMenuStrip.Items.Add(menuItemDelete);
        }

        private void MenuItemDownload_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            Tuple<string, string> tag = (Tuple<string, string>)menuItem.Tag;
            string url = tag.Item1;
            string labelText = tag.Item2;
            downloadFileUrl(url, labelText);
        }

        // Update MenuItemPrint_Click method to call PrintDocument
        private void MenuItemOpen_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            Tuple<string, string> tag = (Tuple<string, string>)menuItem.Tag;
            string url = tag.Item1;
            string name = tag.Item2;

            // Assuming you have a method to retrieve document content based on the URL
            OpenFile(url, name);

            // Print the document
            //PrintDocument(documentContent);
        }

        private async void MenuItemDelete_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            Tuple<string, string> tag = (Tuple<string, string>)menuItem.Tag;
            string labelText = tag.Item1;
            string docs_id = tag.Item2;
            DialogResult result = MessageBox.Show("Are you sure you want to delete " + labelText + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                {
                    frm_wait.ShowDialog(this);
                }
                // Implement delete logic based on the label text
                var db = FirestoreHelper.database;
                if (db != null)
                {
                    DocumentReference docRef = db.Collection("students").Document(id);

                    DocumentSnapshot docSnap = await docRef.GetSnapshotAsync();

                    if (docSnap.Exists)
                    {
                        CollectionReference otherDocs = docRef.Collection("other_docs");
                        await otherDocs.Document(docs_id).DeleteAsync();
                        MessageBox.Show(labelText + " Deleted successfully.", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PopulateFlowLayoutPanel();
                    }
                }
            }
        }

        private void OpenFile(string url, string fileName)
        {
            // Convert Base64 string back to bytes
            byte[] fileBytes = Convert.FromBase64String(url);
            if (fileBytes != null)
            {
                try
                {
                    // Get path to Downloads folder
                    string downloadsFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";

                    // Combine Downloads folder path with file name to get the complete save path
                    string saveFilePath = Path.Combine(downloadsFolder, fileName);

                    // Save file bytes to local file
                    File.WriteAllBytes(saveFilePath, fileBytes);

                    try
                    {
                        // Determine the file extension
                        string fileExtension = Path.GetExtension(saveFilePath);
                        // Open the file using the associated application
                        if (fileExtension.Equals(".docx", StringComparison.OrdinalIgnoreCase))
                        {
                            // Create a new Word application
                            Word.Application wordApp = new Word.Application();
                            wordApp.Visible = true;
                            wordApp.WindowState = Word.WdWindowState.wdWindowStateNormal;

                            wordApp.Documents.Open(saveFilePath);
                        }
                        else if (fileExtension.Equals(".pdf", StringComparison.OrdinalIgnoreCase))
                        {
                            // Use the default application associated with PDF files to open it
                            Process.Start(new ProcessStartInfo
                            {
                                FileName = saveFilePath,
                                UseShellExecute = true
                            });
                        }
                        else
                        {
                            // For other file types, show an error message
                            MessageBox.Show("Unsupported file type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error opening file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file locally: " + ex.Message);
                }
            }
        }

        private void downloadFileUrl(string fileUrl, string fileName)
        {
            // Convert Base64 string back to bytes
            byte[] fileBytes = Convert.FromBase64String(fileUrl);
            if (fileBytes != null)
            {
                try
                {
                    // Get path to Downloads folder
                    string downloadsFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";

                    // Combine Downloads folder path with file name to get the complete save path
                    string saveFilePath = Path.Combine(downloadsFolder, fileName);

                    // Save file bytes to local file
                    File.WriteAllBytes(saveFilePath, fileBytes);
                    MessageBox.Show($"File '{fileName}' saved to '{saveFilePath}' successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file locally: " + ex.Message);
                }
            }
        }

        private async void openFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Documents|*.docx;*.pdf|Images|*.png;*.jpg;*.jpeg|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(filePath);

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
                status_cb.Checked = true;
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

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
            }
        }

        private async void save_btn_Click(object sender, EventArgs e)
        {
            using (FRM_Wait frm_wait = new FRM_Wait(Wait))
            {
                frm_wait.ShowDialog(this);
            }
            if (data != null)
            {
                if (data.Count != 0)
                {
                    var db = FirestoreHelper.database;
                    if (db != null)
                    {
                        try
                        {
                            DocumentReference collectionRef = db.Collection("students").Document(id);

                            CollectionReference other_docs_ref = collectionRef.Collection("other_docs");

                            foreach (var item in data)
                            {
                                Guid uid = Guid.NewGuid();
                                string new_uid = uid.ToString();

                                Dictionary<string, object> docs_data = new Dictionary<string, object>()
                                {
                                    { "docs_name", item.fileName },
                                    { "docs_path", item.filePath },
                                    { "docs_url", item.fileURL },
                                    { "docs_id", new_uid }
                                };

                                await other_docs_ref.Document(new_uid).SetAsync(docs_data);
                            }
                            MessageBox.Show("Other document/s uploaded successfully.");
                            uploaded_panel.Controls.Clear();
                            otherDocsFileName.Text = "";
                            status_cb.Checked = false;
                            PopulateFlowLayoutPanel();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error uploading files to Firestore: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No docs found");
                }
            }
        }
    }
}
