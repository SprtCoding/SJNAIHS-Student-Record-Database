using Google.Cloud.Firestore;
using Student_Record.Firebase;
using Student_Record.Firebase.Model;
using Student_Record.Loaders;
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

namespace Student_Record.AdminModule
{
    public partial class Profiles : Form
    {
        string? my_id, name;
        private bool isPasswordVisible = false;
        public Profiles(string id, string name)
        {
            InitializeComponent();
            this.my_id = id;
            this.name = name;

            loadUser();
        }

        private void viewCodeBtn_Click(object sender, EventArgs e)
        {
            string viewCodeText = viewCodeBtn.Text;
            if (!viewCodeText.Equals("       Hide Login Code"))
            {
                loginCodePanel.Visible = true;
                viewCodeBtn.Text = "       Hide Login Code";
                viewCodeBtn.Image = Properties.Resources.crossed_eye_small;
            }
            else
            {
                loginCodePanel.Visible = false;
                viewCodeBtn.Text = "       View Login Code";
                viewCodeBtn.Image = Properties.Resources.eye_small;
            }

        }

        private void seePassBtn_Click(object sender, EventArgs e)
        {
            // Toggle password visibility
            isPasswordVisible = !isPasswordVisible;
            loginCodeTb.isPassword = !isPasswordVisible;

            // Change picture box image accordingly
            seePassBtn.Image = isPasswordVisible ? Properties.Resources.eye_crossed : Properties.Resources.eye;
        }

        private void loadUser()
        {
            name_tb.Text = string.Empty;
            email_tb.Text = string.Empty;
            position_tb.Text = string.Empty;

            var db = FirestoreHelper.database;
            if (db != null)
            {
                DocumentReference userCol = db.Collection("users").Document(this.my_id);
                Users data = userCol.GetSnapshotAsync().Result.ConvertTo<Users>();

                if (data != null)
                {
                    string name = data.name;
                    string email = data.email;
                    string position = data.position;
                    string loginCode = data.login_code;

                    name_tb.Text = name;
                    email_tb.Text = email;
                    position_tb.Text = position;
                    loginCodeTb.Text = loginCode;
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string name = name_tb.Text;
            string email = email_tb.Text;
            string position = position_tb.Text;

            using (FRM_Wait frm_wait = new FRM_Wait(Wait))
            {
                frm_wait.ShowDialog(this);
            }
            updateProfile(name, email, position);
        }

        private async void updateProfile(string name, string email, string position)
        {
            try
            {
                var db = FirestoreHelper.database;
                if (db != null)
                {
                    CollectionReference userCol = db.Collection("users");

                    Dictionary<string, object> data = new Dictionary<string, object>()
                            {
                                {"name", name },
                                {"email", email },
                                {"position", position }
                            };

                    await userCol.Document(this.my_id).UpdateAsync(data);
                    MessageBox.Show("Updated successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadUser();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
