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
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using DataTable = System.Data.DataTable;
using Task = System.Threading.Tasks.Task;

namespace Student_Record.AdminModule
{
    public partial class Reports : Form
    {
        int sf9Count = 0, sf10Count = 0;
        int pageSize = 6; // Number of records per page
        int currentPage = 1, reportCount = 0; // Current page number

        public Reports()
        {
            InitializeComponent();

            loadingTxt.Text = "loading reports...";
        }

        // Method to handle loading data for the next page
        async void LoadNextPage()
        {
            loadingPanel.Visible = true;
            loadingTxt.Text = "loading reports...";

            currentPage++; // Increment the current page number
            await getReports(currentPage, pageSize); // Load data for the next page
            UpdatePageNumberLabel();
            UpdatePaginationButtons();
        }

        // Method to handle loading data for the previous page
        async void LoadPreviousPage()
        {
            loadingPanel.Visible = true;
            loadingTxt.Text = "loading reports...";

            if (currentPage > 1)
            {
                currentPage--; // Decrement the current page number
                await getReports(currentPage, pageSize); // Load data for the previous page
                UpdatePageNumberLabel();
                UpdatePaginationButtons();
            }
        }

        // Method to initialize or reload data for the first page
        async Task LoadFirstPage()
        {
            currentPage = 1; // Reset the current page number to the first page
            await getReports(currentPage, pageSize); // Load data for the first page
            UpdatePageNumberLabel();
            UpdatePaginationButtons();
        }

        // Method to update the pagination buttons (previous and next)
        async void UpdatePaginationButtons()
        {
            // Hide previous button if it's the first page
            previous_btn.Visible = currentPage > 1;

            int totalReports = await getReportsCount();

            // Disable next button if there are no more pages
            next_btn.Enabled = (currentPage * pageSize) < totalReports;
        }

        // Method to update the page number label
        async void UpdatePageNumberLabel()
        {
            int totalReports = await getReportsCount();
            data_count_lbl.Text = "Page " + currentPage + ", Total Reports: " + totalReports; // Assuming pageNumberLabel is the label displaying the page number
        }

        private async Task<int> getReportsCount()
        {
            var db = FirestoreHelper.database;

            if (db != null)
            {
                CollectionReference studentColRef = db.Collection("Reports");

                QuerySnapshot studentQSnap = await studentColRef.GetSnapshotAsync();

                reportCount = studentQSnap.Count;
            }

            return reportCount;
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
                            //Word.Application wordApp = new Word.Application();
                            //wordApp.Visible = true;
                            //wordApp.WindowState = Word.WdWindowState.wdWindowStateNormal;
                            //
                            //wordApp.Documents.Open(saveFilePath);
                            Process.Start(new ProcessStartInfo
                            {
                                FileName = saveFilePath,
                                UseShellExecute = true
                            });
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
                        else if (fileExtension.Equals(".xlsx", StringComparison.OrdinalIgnoreCase) || fileExtension.Equals(".xls", StringComparison.OrdinalIgnoreCase))
                        {
                            // Open the file directly in Excel
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

        private async Task getReports(int pageNumber, int pageSize)
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

                    // Create a new DataTable with only the desired columns
                    DataTable filteredTable = new DataTable();
                    filteredTable.Columns.Add("ID");
                    filteredTable.Columns.Add("Faculty ID");
                    filteredTable.Columns.Add("Faculty");
                    filteredTable.Columns.Add("Report");
                    filteredTable.Columns.Add("Document");
                    filteredTable.Columns.Add("Status");
                    filteredTable.Columns.Add("Submitted On");
                    filteredTable.Columns.Add("Download", typeof(Image));
                    filteredTable.Columns.Add("Action", typeof(Image));
                    filteredTable.Columns.Add("FileUrl");

                    bool isDataFound = false;
                    // Calculate the offset based on the page number and page size
                    int offset = (pageNumber - 1) * pageSize;

                    Query q = collectionRef
                        .OrderBy("submitted_at")  // Assuming you want to order by id
                        .Offset(offset)
                        .Limit(pageSize);

                    // Fetch the documents
                    QuerySnapshot snapshot = await q.GetSnapshotAsync();

                    if (snapshot != null)
                    {
                        foreach (DocumentSnapshot docSnap in snapshot.Documents)
                        {
                            if (docSnap.Exists)
                            {
                                ReportsModel report = docSnap.ConvertTo<ReportsModel>();

                                filteredTable.Rows.InsertAt(filteredTable.NewRow(), 0); // Insert new row at index 0

                                filteredTable.Rows[0].SetField("ID", report.report_id);
                                filteredTable.Rows[0].SetField("Faculty ID", report.faculty_id);
                                filteredTable.Rows[0].SetField("Faculty", report.faculty_name);
                                filteredTable.Rows[0].SetField("Report", report.report_type);
                                filteredTable.Rows[0].SetField("Document", report.docs_name);
                                filteredTable.Rows[0].SetField("Status", report.status);
                                filteredTable.Rows[0].SetField("Submitted On", report.submitted_at.ToString("MMMM dd, yyyy hh:mm tt"));
                                filteredTable.Rows[0].SetField("Download", Properties.Resources.download_file_blck);
                                filteredTable.Rows[0].SetField("Action", Properties.Resources.trash);
                                filteredTable.Rows[0].SetField("FileUrl", report.docs_url);

                                /*report_dtg.Rows.Insert(
                                        0,
                                        report.report_id,
                                        report.faculty_name,
                                        report.report_type,
                                        report.status,
                                        Properties.Resources.trash
                                    );*/

                                isDataFound = true;
                            }
                            else
                            {
                                isDataFound = false;
                            }
                        }
                    }
                    else
                    {
                        isDataFound = false;
                    }

                    if (!isDataFound)
                    {
                        report_dtg.Visible = false;
                        loadingPanel.Visible = true;
                        loadingTxt.Text = "No Reports found!";
                    }
                    else
                    {
                        loadingPanel.Visible = false;
                        report_dtg.Visible = true;
                    }

                    report_dtg.DataSource = filteredTable;

                    // Set the column headers
                    report_dtg.Columns[0].HeaderText = "ID";
                    report_dtg.Columns[1].HeaderText = "Faculty ID";
                    report_dtg.Columns[2].HeaderText = "Faculty";
                    report_dtg.Columns[3].HeaderText = "Report";
                    report_dtg.Columns[4].HeaderText = "Document";
                    report_dtg.Columns[5].HeaderText = "Status";
                    report_dtg.Columns[6].HeaderText = "Submitted On";
                    report_dtg.Columns[7].HeaderText = "Download";
                    report_dtg.Columns[8].HeaderText = "Action";
                    report_dtg.Columns[9].HeaderText = "FileUrl";

                    // Set the column widths
                    report_dtg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    report_dtg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    report_dtg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    report_dtg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    report_dtg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    report_dtg.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    report_dtg.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    report_dtg.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    report_dtg.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    report_dtg.Columns[0].Visible = false;
                    report_dtg.Columns[1].Visible = false;
                    report_dtg.Columns[9].Visible = false;

                    // Set the padding and size of the icon
                    report_dtg.Columns[7].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); // Adjust the padding values to resize the icon
                    report_dtg.Columns[7].DefaultCellStyle.NullValue = null; // Remove the default null value display for the image column
                    report_dtg.Columns[7].Width = 30; // Adjust the width of the icon column

                    report_dtg.Columns[8].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); // Adjust the padding values to resize the icon
                    report_dtg.Columns[8].DefaultCellStyle.NullValue = null; // Remove the default null value display for the image column
                    report_dtg.Columns[8].Width = 30; // Adjust the width of the icon column

                    // Add the CellFormatting event to set the tooltip for the Warning column
                    report_dtg.CellFormatting += (sender, e) =>
                    {
                        if (e.ColumnIndex == 7 && e.RowIndex >= 0 && e.RowIndex < report_dtg.Rows.Count)
                        {
                            DataGridViewCell cell = report_dtg.Rows[e.RowIndex].Cells[e.ColumnIndex];
                            cell.ToolTipText = "Download Report Document?";
                        }
                        else if (e.ColumnIndex == 8 && e.RowIndex >= 0 && e.RowIndex < report_dtg.Rows.Count)
                        {
                            DataGridViewCell cell = report_dtg.Rows[e.RowIndex].Cells[e.ColumnIndex];
                            cell.ToolTipText = "Delete Report?";
                        }
                    };
                    // Add the CellMouseEnter event to change the cursor to a hand cursor
                    report_dtg.CellMouseEnter += (sender, e) =>
                    {
                        if (e.ColumnIndex == 7 && e.RowIndex >= 0 && e.RowIndex < report_dtg.Rows.Count)
                        {
                            report_dtg.Cursor = Cursors.Hand;
                        }
                        else if (e.ColumnIndex == 8 && e.RowIndex >= 0 && e.RowIndex < report_dtg.Rows.Count)
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
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<int> getSF9Count()
        {
            try
            {
                var db = FirestoreHelper.database;
                if (db != null)
                {
                    // Reference to your Firestore collection
                    CollectionReference collectionRef = db.Collection("Reports");

                    // Create a query to filter documents with "sms_type" equal to "emergency"
                    Query query = collectionRef.WhereEqualTo("report_type", "SF9");

                    QuerySnapshot qSnap = await query.GetSnapshotAsync();

                    sf9Count = qSnap.Documents.Count;
                }
                return sf9Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private async Task<int> getSF10Count()
        {
            try
            {
                var db = FirestoreHelper.database;
                if (db != null)
                {
                    // Reference to your Firestore collection
                    CollectionReference collectionRef = db.Collection("Reports");

                    // Create a query to filter documents with "sms_type" equal to "emergency"
                    Query query = collectionRef.WhereEqualTo("report_type", "SF10");

                    QuerySnapshot qSnap = await query.GetSnapshotAsync();

                    sf10Count = qSnap.Documents.Count;
                }
                return sf10Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
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
                string id = selectedRow.Cells["ID"].Value.ToString();
                string fileUrl = selectedRow.Cells["FileUrl"].Value.ToString();
                string fileName = selectedRow.Cells["Document"].Value.ToString();

                if (report_dtg.Columns[e.ColumnIndex].Name == "Action")
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
                else if (report_dtg.Columns[e.ColumnIndex].Name == "Download")
                {
                    using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                    {
                        frm_wait.ShowDialog(this);
                    }
                    downloadFileUrl(fileUrl, fileName);
                }
            }
        }

        private async void deleteReport(string? id)
        {
            var db = FirestoreHelper.database;
            if (db != null)
            {
                CollectionReference usersRef = db.Collection("Reports");
                await usersRef.Document(id).DeleteAsync();

                MessageBox.Show("Report Deleted.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadFirstPage();
            }
        }

        private async void Reports_Load(object sender, EventArgs e)
        {
            int sf9_Count = await getSF9Count();
            int sf10_Count = await getSF10Count();

            sf9_lbl.Text = sf9_Count.ToString();
            sf10_lbl.Text = sf10_Count.ToString();

            await LoadFirstPage();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            LoadNextPage();
        }

        private void previous_btn_Click_1(object sender, EventArgs e)
        {
            LoadPreviousPage();
        }

        private void loadingPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
