using Google.Cloud.Firestore;
using Microsoft.Office.Interop.Word;
using Student_Record.AdminModule.AddForm;
using Student_Record.AdminModule.Student;
using Student_Record.DataSets;
using Student_Record.DataSets.UserDataSetTableAdapters;
using Student_Record.Firebase;
using Student_Record.Firebase.Model;
using Student_Record.Internet;
using Student_Record.Loaders;
using Student_Record.SMTP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;
using Task = System.Threading.Tasks.Task;

namespace Student_Record.AdminModule
{
    public partial class FacultyProfiles : Form
    {
        int pageSize = 6; // Number of records per page
        int currentPage = 1, facultyCount = 0; // Current page number

        public FacultyProfiles()
        {
            InitializeComponent();
            loadingTxt.Text = "loading faculty...";
        }

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
            }
        }

        private async void FacultyProfiles_Load(object sender, EventArgs e)
        {
            search_tb.Focus();
            try
            {
                await LoadFirstPage();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Method to handle loading data for the next page
        async void LoadNextPage()
        {
            loadingPanel.Visible = true;
            loadingTxt.Text = "loading reports...";

            currentPage++; // Increment the current page number
            await getFaculty(currentPage, pageSize); // Load data for the next page
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
                await getFaculty(currentPage, pageSize); // Load data for the previous page
                UpdatePageNumberLabel();
                UpdatePaginationButtons();
            }
        }

        // Method to initialize or reload data for the first page
        async Task LoadFirstPage()
        {
            currentPage = 1; // Reset the current page number to the first page
            await getFaculty(currentPage, pageSize); // Load data for the first page
            UpdatePageNumberLabel();
            UpdatePaginationButtons();
        }

        // Method to update the pagination buttons (previous and next)
        async void UpdatePaginationButtons()
        {
            // Hide previous button if it's the first page
            previous_btn.Visible = currentPage > 1;

            int totalFaculty = await getFacultyCount();

            // Disable next button if there are no more pages
            next_btn.Enabled = (currentPage * pageSize) < totalFaculty;
        }

        // Method to update the page number label
        async void UpdatePageNumberLabel()
        {
            int totalFaculty = await getFacultyCount();
            data_count_lbl.Text = "Page " + currentPage + ", Total Faculty: " + totalFaculty; // Assuming pageNumberLabel is the label displaying the page number
        }

        private async Task<int> getFacultyCount()
        {
            var db = FirestoreHelper.database;

            if (db != null)
            {
                CollectionReference ffacultyColRef = db.Collection("users");

                QuerySnapshot facultyQSnap = await ffacultyColRef
                    .WhereEqualTo("account_type", "faculty")
                    .GetSnapshotAsync();

                facultyCount = facultyQSnap.Count;
            }

            return facultyCount;
        }

        private void add_new_btn_Click(object sender, EventArgs e)
        {
            AddFacultyForm facultyForm = new AddFacultyForm(faculty_profile_dtg, "", "");
            facultyForm.ShowDialog();
        }

        public async Task getFaculty(int pageNumber, int pageSize)
        {
            faculty_profile_dtg.DataSource = null;
            faculty_profile_dtg.Rows.Clear();

            try
            {
                var db = FirestoreHelper.database;
                if (db != null)
                {
                    CollectionReference colRef = db.Collection("users");

                    // Calculate the offset based on the page number and page size
                    int offset = (pageNumber - 1) * pageSize;

                    Query userQuery = colRef
                        .WhereEqualTo("account_type", "faculty")
                        .OrderByDescending("createdOn")
                        .Offset(offset)
                        .Limit(pageSize);

                    QuerySnapshot snap = await userQuery.GetSnapshotAsync();

                    bool isDataFound = false;

                    // Add columns to the DataGridView if they are not already added
                    if (faculty_profile_dtg.Columns.Count == 0)
                    {
                        faculty_profile_dtg.Columns.Add("id", "ID");
                        faculty_profile_dtg.Columns.Add("name", "Name");
                        faculty_profile_dtg.Columns.Add("email", "Email");
                        faculty_profile_dtg.Columns.Add("position", "Position");
                        faculty_profile_dtg.Columns.Add("students", "Students");
                        faculty_profile_dtg.Columns.Add("edit", "Edit");
                        faculty_profile_dtg.Columns.Add("delete", "Delete");
                    }

                    foreach (DocumentSnapshot snapshot in snap.Documents)
                    {
                        if (snapshot.Exists)
                        {
                            Users users = snapshot.ConvertTo<Users>(); // Make sure "Users" class is defined correctly

                            /*filteredTable.Rows.InsertAt(filteredTable.NewRow(), 0); // Insert new row at index 0

                            filteredTable.Rows[0].SetField("ID", users.id);
                            filteredTable.Rows[0].SetField("Name", users.name);
                            filteredTable.Rows[0].SetField("Email", users.email);
                            filteredTable.Rows[0].SetField("Position", users.position);
                            filteredTable.Rows[0].SetField("Edit", Properties.Resources.edit);
                            filteredTable.Rows[0].SetField("Delete", Properties.Resources.trash);*/

                            faculty_profile_dtg.Rows.Add(
                                users.id,
                                users.name,
                                users.email,
                                users.position,
                                Properties.Resources.student,
                                Properties.Resources.edit,
                                Properties.Resources.trash);

                            // Add the CellFormatting event to set the tooltip for the Warning column
                            isDataFound = true;

                        }
                        else
                        {
                            isDataFound = false;
                        }
                    }

                    faculty_profile_dtg.CellFormatting += (sender, e) =>
                    {
                        if (e.ColumnIndex == 4 && e.RowIndex >= 0 && e.RowIndex < faculty_profile_dtg.Rows.Count)
                        {
                            DataGridViewCell cell = faculty_profile_dtg.Rows[e.RowIndex].Cells[e.ColumnIndex];
                            cell.ToolTipText = "View Students of " + faculty_profile_dtg.Rows[e.RowIndex].Cells["name"].Value.ToString();
                        }
                        else if (e.ColumnIndex == 5 && e.RowIndex >= 0 && e.RowIndex < faculty_profile_dtg.Rows.Count)
                        {
                            DataGridViewCell cell = faculty_profile_dtg.Rows[e.RowIndex].Cells[e.ColumnIndex];
                            cell.ToolTipText = "Edit " + faculty_profile_dtg.Rows[e.RowIndex].Cells["name"].Value.ToString() + "?";
                        }
                        else if (e.ColumnIndex == 6 && e.RowIndex >= 0 && e.RowIndex < faculty_profile_dtg.Rows.Count)
                        {
                            DataGridViewCell cell = faculty_profile_dtg.Rows[e.RowIndex].Cells[e.ColumnIndex];
                            cell.ToolTipText = "Delete " + faculty_profile_dtg.Rows[e.RowIndex].Cells["name"].Value.ToString() + "?";
                        }
                    };

                    // Add the CellMouseEnter event to change the cursor to a hand cursor
                    faculty_profile_dtg.CellMouseEnter += (sender, e) =>
                    {
                        if (e.ColumnIndex == 4 && e.RowIndex >= 0 && e.RowIndex < faculty_profile_dtg.Rows.Count)
                        {
                            faculty_profile_dtg.Cursor = Cursors.Hand;
                        }
                        else if (e.ColumnIndex == 5 && e.RowIndex >= 0 && e.RowIndex < faculty_profile_dtg.Rows.Count)
                        {
                            faculty_profile_dtg.Cursor = Cursors.Hand;
                        }
                    };

                    // Add the CellMouseLeave event to revert the cursor to the default cursor
                    faculty_profile_dtg.CellMouseLeave += (sender, e) =>
                    {
                        faculty_profile_dtg.Cursor = Cursors.Default;
                    };

                    if (!isDataFound)
                    {
                        loadingPanel.Visible = true;
                        loadingTxt.Text = "No Faculty found!";
                    }
                    else
                    {
                        loadingPanel.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void faculty_profile_dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Perform the "Edit" action
                DataGridViewRow selectedRow = faculty_profile_dtg.Rows[e.RowIndex];
                string id = selectedRow.Cells["id"].Value?.ToString();
                string name = selectedRow.Cells["name"].Value?.ToString();
                string email = selectedRow.Cells["email"].Value?.ToString();
                if (faculty_profile_dtg.Columns[e.ColumnIndex].Name == "delete")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete " + name + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                        {
                            frm_wait.ShowDialog(this);
                        }
                        if (id != null && email != null && name != null)
                        {
                            deleteUser(id, email, name);
                        }
                    }
                }

                if (faculty_profile_dtg.Columns[e.ColumnIndex].Name == "edit")
                {
                    if (id != null)
                    {
                        AddFacultyForm faculty = new AddFacultyForm(faculty_profile_dtg, "Edit", id);
                        faculty.ShowDialog(this);
                    }
                }

                if (faculty_profile_dtg.Columns[e.ColumnIndex].Name == "students")
                {
                    if (id != null)
                    {
                        StudentListFrm faculty = new StudentListFrm(id, name);
                        faculty.ShowDialog(this);
                    }
                }
            }
        }

        private async void deleteUser(string id, string email, string name)
        {
            var db = FirestoreHelper.database;
            if (db != null)
            {
                CollectionReference usersRef = db.Collection("users");
                await usersRef.Document(id).DeleteAsync();

                try
                {
                    EmailSender.SendEmail(email, "Account Removed", "Hi, " + name + ".\nYour account is removed. Please contact admin to confirm why.\nThank you.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Deleted Successfully!");
                faculty_profile_dtg.DataSource = null;
                faculty_profile_dtg.Rows.Clear();
                await LoadFirstPage();
            }
        }

        private void search_tb_Enter(object sender, EventArgs e)
        {
            search_tb.Text = "";
        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            string searchText = search_tb.Text.ToLower();

            foreach (DataGridViewRow row in faculty_profile_dtg.Rows)
            {
                // If the row contains the search text, make it visible; otherwise, hide it
                row.Visible = row.Cells.Cast<DataGridViewCell>()
                                       .Any(cell => cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText));
            }
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            LoadNextPage();
        }

        private void previous_btn_Click(object sender, EventArgs e)
        {
            LoadPreviousPage();
        }
    }
}
