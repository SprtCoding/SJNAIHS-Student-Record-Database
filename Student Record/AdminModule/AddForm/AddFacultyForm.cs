using Bunifu.Framework.UI;
using Google.Cloud.Firestore;
using Student_Record.DataSets;
using Student_Record.DataSets.UserDataSetTableAdapters;
using Student_Record.Firebase;
using Student_Record.Firebase.Model;
using Student_Record.Loaders;
using Student_Record.SMTP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Record.AdminModule.AddForm
{
    public partial class AddFacultyForm : Form
    {
        private BunifuCustomDataGrid? myDTG;
        private Random random = new Random();
        private string? status, id;
        private bool isupdate;

        public AddFacultyForm(BunifuCustomDataGrid dtg, string status, string id)
        {
            InitializeComponent();
            myDTG = dtg;
            this.status = status;
            this.id = id;

            if (!status.Equals("") && !id.Equals(""))
            {
                isupdate = true;
                title_lbl.Text = "Update Faculty Profile";
                gen_code_btn.Text = "Change";
                login_code_tb.Enabled = false;
                getUserData(id);
            }
        }

        private void getUserData(string id)
        {
            var db = FirestoreHelper.database;
            if (db != null)
            {
                DocumentReference userCol = db.Collection("users").Document(id);
                Users data = userCol.GetSnapshotAsync().Result.ConvertTo<Users>();
                if (data != null)
                {
                    fullname_tb.Text = data.name;
                    login_code_tb.Text = data.login_code;
                    position_tb.Text = data.position;
                    email_address_tb.Text = data.email;
                }
            }
        }

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            string name = fullname_tb.Text;
            string loginCode = login_code_tb.Text;
            string email = email_address_tb.Text;
            string position = position_tb.Text;

            if (isupdate)
            {
                string new_code = new_code_tb.Text;

                bool isVisible = new_code_panel.Visible;

                if (isVisible)
                {
                    if (String.IsNullOrEmpty(new_code))
                    {
                        MessageBox.Show("Please generate new login code!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new_code_tb.Focus();
                        return;
                    }
                    else if (String.IsNullOrEmpty(name))
                    {
                        MessageBox.Show("Full Name is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fullname_tb.Focus();
                        return;
                    }
                    else if (String.IsNullOrEmpty(email))
                    {
                        MessageBox.Show("Email is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        email_address_tb.Focus();
                        return;
                    }
                    else if (String.IsNullOrEmpty(position))
                    {
                        MessageBox.Show("Position is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        position_tb.Focus();
                        return;
                    }
                    else
                    {
                        using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                        {
                            frm_wait.ShowDialog(this);
                        }
                        updateFacultyWithNewCode(name, loginCode, email, position, "faculty", new_code);
                    }
                }
                else
                {
                    using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                    {
                        frm_wait.ShowDialog(this);
                    }
                    updateFaculty(name, loginCode, email, position);
                }
            }
            else
            {
                if (String.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Full Name is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fullname_tb.Focus();
                    return;
                }
                else if (String.IsNullOrEmpty(loginCode))
                {
                    MessageBox.Show("Login Code is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    login_code_tb.Focus();
                    return;
                }
                else if (String.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Email is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    email_address_tb.Focus();
                    return;
                }
                else if (String.IsNullOrEmpty(position))
                {
                    MessageBox.Show("Position is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    position_tb.Focus();
                    return;
                }
                else
                {
                    using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                    {
                        frm_wait.ShowDialog(this);
                    }
                    setFaculty(name, loginCode, email, position, "faculty");
                }
            }
        }

        private async void updateFaculty(string name, string loginCode, string email, string position)
        {
            var db = FirestoreHelper.database;
            if (db != null)
            {
                // Get the current date and time in UTC format
                DateTime currentDateTime = DateTime.UtcNow;

                CollectionReference userColRef = db.Collection("users");
                Dictionary<string, object> userData = new Dictionary<string, object>()
                    {
                        {"name", name },
                        {"email", email },
                        {"position", position },
                        {"updatedOn", currentDateTime }
                    };

                var info = await userColRef.Document(loginCode).UpdateAsync(userData);

                try
                {
                    EmailSender.SendEmail(email, "Account Update", "Hi, " + name + ".\nYour is being updated by admin.");
                    MessageBox.Show(name + " updated successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (myDTG != null)
                    {
                        myDTG.DataSource = null;
                        myDTG.Rows.Clear();
                    }
                    loadData();
                    clear();
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void updateFacultyWithNewCode(string name, string old_code, string email, string position, string account_type, string new_code)
        {
            var db = FirestoreHelper.database;
            if (db != null)
            {
                DocumentReference userDoc = db.Collection("users").Document(old_code);
                await userDoc.DeleteAsync();
                createNewFaculty(new_code, name, email, position, account_type);
            }
        }

        private async void createNewFaculty(string new_code, string name, string email, string position, string account_type)
        {
            var db = FirestoreHelper.database;
            if (db != null)
            {
                // Get the current date and time in UTC format
                DateTime currentDateTime = DateTime.UtcNow;

                CollectionReference userColRef = db.Collection("users");
                Dictionary<string, object> userData = new Dictionary<string, object>()
                    {
                        {"id", new_code },
                        {"name", name },
                        {"email", email },
                        {"login_code", new_code },
                        {"position", position },
                        {"account_type", account_type },
                        {"createdOn", currentDateTime }
                    };

                var info = await userColRef.Document(new_code).CreateAsync(userData);

                try
                {
                    EmailSender.SendEmail(email, "Faculty Login Code Updated", "Hi, " + name + ".\nYour New Login Code is " + new_code);
                    MessageBox.Show(name + " updated successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (myDTG != null)
                    {
                        myDTG.DataSource = null;
                        myDTG.Rows.Clear();
                    }
                    loadData();
                    clear();
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void setFaculty(string name, string loginCode, string email, string position, string accountType)
        {
            try
            {
                var db = FirestoreHelper.database;

                if (db != null)
                {
                    // Get the current date and time in UTC format
                    DateTime currentDateTime = DateTime.UtcNow;

                    CollectionReference userColRef = db.Collection("users");
                    Dictionary<string, object> userData = new Dictionary<string, object>()
                    {
                        {"id", loginCode },
                        {"name", name },
                        {"email", email },
                        {"login_code", loginCode },
                        {"position", position },
                        {"account_type", accountType },
                        {"createdOn", currentDateTime }
                    };

                    var info = await userColRef.Document(loginCode).CreateAsync(userData);

                    try
                    {
                        EmailSender.SendEmail(email, "Faculty Login Code", "Hi, " + name + ".\nYour Login Code is " + loginCode);
                        MessageBox.Show(name + " saved successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (myDTG != null)
                        {
                            myDTG.DataSource = null;
                            myDTG.Rows.Clear();
                        }
                        loadData();
                        clear();
                        Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public async void loadData()
        {
            myDTG.DataSource = null;
            try
            {
                var db = FirestoreHelper.database;
                if (db != null)
                {
                    Query userQuery = db.Collection("users").WhereEqualTo("account_type", "faculty").OrderByDescending("createdOn");
                    QuerySnapshot snap = await userQuery.GetSnapshotAsync();

                    bool isDataFound = false;

                    // Add columns to the DataGridView if they are not already added
                    if (myDTG.Columns.Count == 0)
                    {
                        myDTG.Columns.Add("id", "ID");
                        myDTG.Columns.Add("name", "Name");
                        myDTG.Columns.Add("email", "Email");
                        myDTG.Columns.Add("position", "Position");
                        myDTG.Columns.Add("edit", "Edit");
                        myDTG.Columns.Add("delete", "Delete");
                    }

                    foreach (DocumentSnapshot snapshot in snap.Documents)
                    {
                        if (snapshot.Exists)
                        {
                            Users users = snapshot.ConvertTo<Users>(); // Make sure "Users" class is defined correctly

                            myDTG.Rows.Add(
                                users.id,
                                users.name,
                                users.email,
                                users.position,
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

                    myDTG.CellFormatting += (sender, e) =>
                    {
                        if (e.ColumnIndex == 4 && e.RowIndex >= 0 && e.RowIndex < myDTG.Rows.Count)
                        {
                            DataGridViewCell cell = myDTG.Rows[e.RowIndex].Cells[e.ColumnIndex];
                            cell.ToolTipText = "Edit";
                        }
                        else if (e.ColumnIndex == 5 && e.RowIndex >= 0 && e.RowIndex < myDTG.Rows.Count)
                        {
                            DataGridViewCell cell = myDTG.Rows[e.RowIndex].Cells[e.ColumnIndex];
                            cell.ToolTipText = "Delete " + myDTG.Rows[e.RowIndex].Cells["name"].Value.ToString() + "?";
                        }
                    };

                    // Add the CellMouseEnter event to change the cursor to a hand cursor
                    myDTG.CellMouseEnter += (sender, e) =>
                    {
                        if (e.ColumnIndex == 4 && e.RowIndex >= 0 && e.RowIndex < myDTG.Rows.Count)
                        {
                            myDTG.Cursor = Cursors.Hand;
                        }
                        else if (e.ColumnIndex == 5 && e.RowIndex >= 0 && e.RowIndex < myDTG.Rows.Count)
                        {
                            myDTG.Cursor = Cursors.Hand;
                        }
                    };

                    // Add the CellMouseLeave event to revert the cursor to the default cursor
                    myDTG.CellMouseLeave += (sender, e) =>
                    {
                        myDTG.Cursor = Cursors.Default;
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void clear()
        {
            fullname_tb.Text = "";
            login_code_tb.Text = "";
            email_address_tb.Text = "";
            position_tb.Text = "";
        }

        private string GenerateRandomString(int length)
        {
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] result = new char[length];

            // Add 'faculty-'
            int startIndex = 0;
            string prefix = "faculty-";
            for (int i = 0; i < prefix.Length; i++)
            {
                result[startIndex++] = prefix[i];
            }

            // Add random numbers
            for (int i = startIndex; i < length; i++)
            {
                result[i] = characters[random.Next(characters.Length)];
            }

            return new string(result);
        }

        private void gen_code_btn_Click(object sender, EventArgs e)
        {
            if (isupdate)
            {
                new_code_panel.Visible = true;
            }
            else
            {
                int length = 15;
                string randomString = GenerateRandomString(length);
                login_code_tb.Text = randomString;
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void new_code_btn_Click(object sender, EventArgs e)
        {
            int length = 15;
            string randomString = GenerateRandomString(length);
            new_code_tb.Text = randomString;
        }
    }
}
