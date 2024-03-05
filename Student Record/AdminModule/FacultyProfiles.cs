using Google.Cloud.Firestore;
using Microsoft.Office.Interop.Word;
using Student_Record.AdminModule.AddForm;
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
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Record.AdminModule
{
    public partial class FacultyProfiles : Form
    {
        public FacultyProfiles()
        {
            InitializeComponent();
            // Example usage in your form's method
            if (!InternetConnectionChecker.IsInternetAvailable())
            {
                MessageBox.Show("No internet connection!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
            }
        }

        private void FacultyProfiles_Load(object sender, EventArgs e)
        {
            search_tb.Focus();
            loadData();
        }

        private void add_new_btn_Click(object sender, EventArgs e)
        {
            AddFacultyForm facultyForm = new AddFacultyForm(faculty_profile_dtg, "", "");
            facultyForm.ShowDialog();
        }

        public async void loadData()
        {
            try
            {
                var db = FirestoreHelper.database;
                if (db != null)
                {
                    Query userQuery = db.Collection("users").WhereEqualTo("account_type", "faculty");
                    QuerySnapshot snap = await userQuery.GetSnapshotAsync();

                    foreach (DocumentSnapshot snapshot in snap.Documents)
                    {
                        if (snapshot.Exists)
                        {
                            Users users = snapshot.ConvertTo<Users>(); // Make sure "Users" class is defined correctly
                            faculty_profile_dtg.Rows.Insert(0,
                                users.id,
                                users.name,
                                users.email,
                                users.position,
                                Properties.Resources.edit,
                                Properties.Resources.trash);

                            // Add the CellFormatting event to set the tooltip for the Warning column
                            faculty_profile_dtg.CellFormatting += (sender, e) =>
                            {
                                if (e.ColumnIndex == 4 && e.RowIndex >= 0 && e.RowIndex < faculty_profile_dtg.Rows.Count)
                                {
                                    DataGridViewCell cell = faculty_profile_dtg.Rows[e.RowIndex].Cells[e.ColumnIndex];
                                    cell.ToolTipText = "Edit";
                                }
                                else if (e.ColumnIndex == 5 && e.RowIndex >= 0 && e.RowIndex < faculty_profile_dtg.Rows.Count)
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
                        }
                        else
                        {
                            MessageBox.Show("No data found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void search_tb_OnValueChanged(object sender, EventArgs e)
        {
            string searchText = search_tb.Text.ToLower();

            foreach (DataGridViewRow row in faculty_profile_dtg.Rows)
            {
                // If the row contains the search text, make it visible; otherwise, hide it
                row.Visible = row.Cells.Cast<DataGridViewCell>()
                                       .Any(cell => cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText));
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
                loadData();
            }
        }
    }
}
