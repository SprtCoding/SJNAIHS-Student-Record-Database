using Bunifu.Framework.UI;
using Student_Record.AdminModule;
using Student_Record.Auth;
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

namespace Student_Record.TeachersModule
{
    public partial class FacultyDashboard : Form
    {
        private Form? activeForm = null;

        private string? userID, fullname, email;
        private BunifuFlatButton? currentBtn;
        private Color activeColor = Color.FromArgb(43, 47, 84);
        private Color originalColor = Color.FromArgb(129, 142, 254);

        public FacultyDashboard(string id, string name, string UserEmail)
        {
            InitializeComponent();
            userID = id;
            fullname = name;
            email = UserEmail;
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

        private void FacultyDashboard_Load(object sender, EventArgs e)
        {
            Text = home_btn.Text;
            openChildForm(new FacultyHomeDashboard(userID));
            activeButton(home_btn);
        }

        private void FacultyDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            Text = home_btn.Text;
            openChildForm(new FacultyHomeDashboard(userID));
            activeButton(home_btn);
        }

        private void student_profile_btn_Click(object sender, EventArgs e)
        {
            Text = student_profile_btn.Text;
            openChildForm(new StudentProfile(userID, fullname));
            activeButton(student_profile_btn);
        }

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
            }
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

        private void grading_sheet_btn_Click(object sender, EventArgs e)
        {
            Text = grading_sheet_btn.Text;
            openChildForm(new GradingSheet(userID, fullname));
            activeButton(grading_sheet_btn);
        }

        private void grading_summary_btn_Click(object sender, EventArgs e)
        {
            Text = grading_summary_btn.Text;
            openChildForm(new StudentGradingSummary(userID, fullname));
            activeButton(grading_summary_btn);
        }

        private void card_btn_Click(object sender, EventArgs e)
        {
            Text = card_btn.Text;
            openChildForm(new ReportCard(userID, fullname));
            activeButton(card_btn);
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            Text = profile_btn.Text;
            if(userID != null && fullname != null)
            {
                openChildForm(new Profiles(userID, fullname));
                activeButton(profile_btn);
            }
            
        }

        private void student_record_btn_Click(object sender, EventArgs e)
        {
            Text = student_record_btn.Text;
            openChildForm(new StudentRecordPage(userID));
            activeButton(student_record_btn);
        }
    }
}
