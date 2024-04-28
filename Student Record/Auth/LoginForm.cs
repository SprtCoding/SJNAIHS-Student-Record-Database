using Google.Cloud.Firestore;
using Student_Record.AdminModule;
using Student_Record.DataSets;
using Student_Record.DataSets.UserDataSetTableAdapters;
using Student_Record.Firebase;
using Student_Record.Firebase.Model;
using Student_Record.Internet;
using Student_Record.Loaders;
using Student_Record.TeachersModule;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Student_Record.Auth
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            // Example usage in your form's method
            if (!InternetConnectionChecker.IsInternetAvailable())
            {
                MessageBox.Show("No internet connection!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            string loginCode = login_code_tb.Text;

            if (String.IsNullOrEmpty(loginCode) || loginCode.Equals("Enter Login Code") || loginCode.Equals(""))
            {
                MessageBox.Show("Please enter your login code.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                login_code_tb.Focus();
                return;
            }
            else
            {
                using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                {
                    frm_wait.ShowDialog(this);
                }

                signIn(loginCode);
            }
        }

        private void signIn(string loginCode)
        {
            try
            {
                var db = FirestoreHelper.database;
                if (db != null)
                {
                    DocumentReference userDocRef = db.Collection("users").Document(loginCode);
                    Users data = userDocRef.GetSnapshotAsync().Result.ConvertTo<Users>();

                    if (data != null)
                    {
                        if (loginCode == data.login_code)
                        {
                            string? account_type = data.account_type;
                            string? name = data.name;
                            string? email = data.email;

                            if (account_type != null && name != null && email != null)
                            {
                                if (account_type.Equals("admin"))
                                {
                                    AdminDashboard adminDashboard = new AdminDashboard(
                                    data.login_code,
                                    name,
                                    email
                                    );
                                    adminDashboard.Show();
                                    Hide();
                                }
                                else
                                {
                                    FacultyDashboard facultyDashboard = new FacultyDashboard(
                                    data.login_code,
                                    name,
                                    email
                                    );
                                    facultyDashboard.Show();
                                    Hide();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username and password.", "Auth Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No account found.", "Auth Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("null.", "DB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Console.WriteLine(ex.Message);
                login_code_tb.Focus();
                return;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            login_code_tb.Focus();
        }

        private void login_code_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string loginCode = login_code_tb.Text;

                if (String.IsNullOrEmpty(loginCode) || loginCode.Equals("Enter Login Code") || loginCode.Equals(""))
                {
                    MessageBox.Show("Please enter your login code.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    login_code_tb.Focus();
                    return;
                }
                else
                {
                    using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                    {
                        frm_wait.ShowDialog(this);
                    }
                    signIn(loginCode);
                }
            }
        }
    }
}
