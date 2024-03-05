using Bunifu.Framework.UI;
using Student_Record.Auth;
using Student_Record.Internet;
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
using System.Xml.Linq;

namespace Student_Record.AdminModule
{
    public partial class AdminDashboard : Form
    {
        private BunifuFlatButton? currentBtn;
        private Form? activeForm = null;
        private Color activeColor = Color.FromArgb(43, 47, 84);
        private Color originalColor = Color.FromArgb(129, 142, 254);

        private string? userID, fullname, email;

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
            }
        }

        public AdminDashboard(string id, string name, string email)
        {
            InitializeComponent();

            this.userID = id;
            this.fullname = name;
            this.email = email;

            // Example usage in your form's method
            if (!InternetConnectionChecker.IsInternetAvailable())
            {
                MessageBox.Show("No internet connection!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            main_panel.Controls.Add(childForm);
            main_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void activeButton(BunifuFlatButton btn)
        {
            if (currentBtn != null)
            {
                currentBtn.Normalcolor = originalColor;
            }
            currentBtn = btn;

            currentBtn.Normalcolor = activeColor;
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            openChildForm(new HomeDashboard());
            activeButton(home_btn);
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new HomeDashboard());
            activeButton(home_btn);
        }

        private void faculty_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new FacultyProfiles());
            activeButton(faculty_btn);
        }

        private void student_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new StudentProfiles());
            activeButton(student_btn);
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Logout?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                {
                    frm_wait.ShowDialog(this);
                }
                LoginForm login = new LoginForm();
                login.Show();
                Hide();
            }
        }

        private void report_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new Reports());
            activeButton(report_btn);
        }
    }
}
