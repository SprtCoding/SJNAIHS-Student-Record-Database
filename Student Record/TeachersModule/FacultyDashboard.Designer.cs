namespace Student_Record.TeachersModule
{
    partial class FacultyDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacultyDashboard));
            nav_panel = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            menu_panel = new TableLayoutPanel();
            student_record_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            grading_summary_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            grading_sheet_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            student_profile_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            home_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            logout_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            card_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            profile_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            main_panel = new Panel();
            nav_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menu_panel.SuspendLayout();
            SuspendLayout();
            // 
            // nav_panel
            // 
            nav_panel.BackColor = Color.FromArgb(129, 142, 254);
            nav_panel.Controls.Add(pictureBox1);
            nav_panel.Controls.Add(label2);
            nav_panel.Controls.Add(menu_panel);
            nav_panel.Dock = DockStyle.Left;
            nav_panel.Location = new Point(0, 0);
            nav_panel.Name = "nav_panel";
            nav_panel.Size = new Size(346, 1022);
            nav_panel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sjnaihs_logo;
            pictureBox1.Location = new Point(87, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Poppins Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(36, 274);
            label2.Name = "label2";
            label2.Size = new Size(274, 77);
            label2.TabIndex = 7;
            label2.Text = "SJNAIHS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menu_panel
            // 
            menu_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menu_panel.ColumnCount = 1;
            menu_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            menu_panel.Controls.Add(student_record_btn, 0, 5);
            menu_panel.Controls.Add(grading_summary_btn, 0, 3);
            menu_panel.Controls.Add(grading_sheet_btn, 0, 2);
            menu_panel.Controls.Add(student_profile_btn, 0, 1);
            menu_panel.Controls.Add(home_btn, 0, 0);
            menu_panel.Controls.Add(logout_btn, 0, 10);
            menu_panel.Controls.Add(card_btn, 0, 4);
            menu_panel.Controls.Add(profile_btn, 0, 6);
            menu_panel.Location = new Point(3, 354);
            menu_panel.Name = "menu_panel";
            menu_panel.RowCount = 11;
            menu_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            menu_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            menu_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            menu_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            menu_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            menu_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            menu_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            menu_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            menu_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            menu_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            menu_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            menu_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            menu_panel.Size = new Size(340, 664);
            menu_panel.TabIndex = 5;
            // 
            // student_record_btn
            // 
            student_record_btn.Active = false;
            student_record_btn.Activecolor = Color.FromArgb(43, 47, 84);
            student_record_btn.BackColor = Color.FromArgb(129, 142, 254);
            student_record_btn.BackgroundImageLayout = ImageLayout.Stretch;
            student_record_btn.BorderRadius = 5;
            student_record_btn.ButtonText = "  STUDENT RECORD";
            student_record_btn.DisabledColor = Color.Gray;
            student_record_btn.Dock = DockStyle.Fill;
            student_record_btn.Iconcolor = Color.Transparent;
            student_record_btn.Iconimage = (Image)resources.GetObject("student_record_btn.Iconimage");
            student_record_btn.Iconimage_right = null;
            student_record_btn.Iconimage_right_Selected = null;
            student_record_btn.Iconimage_Selected = null;
            student_record_btn.IconMarginLeft = 0;
            student_record_btn.IconMarginRight = 0;
            student_record_btn.IconRightVisible = true;
            student_record_btn.IconRightZoom = 0D;
            student_record_btn.IconVisible = true;
            student_record_btn.IconZoom = 25D;
            student_record_btn.IsTab = false;
            student_record_btn.Location = new Point(6, 422);
            student_record_btn.Margin = new Padding(6, 7, 6, 7);
            student_record_btn.Name = "student_record_btn";
            student_record_btn.Normalcolor = Color.FromArgb(129, 142, 254);
            student_record_btn.OnHovercolor = Color.FromArgb(43, 47, 84);
            student_record_btn.OnHoverTextColor = Color.White;
            student_record_btn.selected = false;
            student_record_btn.Size = new Size(328, 69);
            student_record_btn.TabIndex = 16;
            student_record_btn.Text = "  STUDENT RECORD";
            student_record_btn.TextAlign = ContentAlignment.MiddleLeft;
            student_record_btn.Textcolor = Color.White;
            student_record_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            student_record_btn.Click += student_record_btn_Click;
            // 
            // grading_summary_btn
            // 
            grading_summary_btn.Active = false;
            grading_summary_btn.Activecolor = Color.FromArgb(43, 47, 84);
            grading_summary_btn.BackColor = Color.FromArgb(129, 142, 254);
            grading_summary_btn.BackgroundImageLayout = ImageLayout.Stretch;
            grading_summary_btn.BorderRadius = 5;
            grading_summary_btn.ButtonText = "  GRADING SUMMARY";
            grading_summary_btn.DisabledColor = Color.Gray;
            grading_summary_btn.Dock = DockStyle.Fill;
            grading_summary_btn.Iconcolor = Color.Transparent;
            grading_summary_btn.Iconimage = (Image)resources.GetObject("grading_summary_btn.Iconimage");
            grading_summary_btn.Iconimage_right = null;
            grading_summary_btn.Iconimage_right_Selected = null;
            grading_summary_btn.Iconimage_Selected = null;
            grading_summary_btn.IconMarginLeft = 0;
            grading_summary_btn.IconMarginRight = 0;
            grading_summary_btn.IconRightVisible = true;
            grading_summary_btn.IconRightZoom = 0D;
            grading_summary_btn.IconVisible = true;
            grading_summary_btn.IconZoom = 25D;
            grading_summary_btn.IsTab = false;
            grading_summary_btn.Location = new Point(6, 256);
            grading_summary_btn.Margin = new Padding(6, 7, 6, 7);
            grading_summary_btn.Name = "grading_summary_btn";
            grading_summary_btn.Normalcolor = Color.FromArgb(129, 142, 254);
            grading_summary_btn.OnHovercolor = Color.FromArgb(43, 47, 84);
            grading_summary_btn.OnHoverTextColor = Color.White;
            grading_summary_btn.selected = false;
            grading_summary_btn.Size = new Size(328, 69);
            grading_summary_btn.TabIndex = 15;
            grading_summary_btn.Text = "  GRADING SUMMARY";
            grading_summary_btn.TextAlign = ContentAlignment.MiddleLeft;
            grading_summary_btn.Textcolor = Color.White;
            grading_summary_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grading_summary_btn.Click += grading_summary_btn_Click;
            // 
            // grading_sheet_btn
            // 
            grading_sheet_btn.Active = false;
            grading_sheet_btn.Activecolor = Color.FromArgb(43, 47, 84);
            grading_sheet_btn.BackColor = Color.FromArgb(129, 142, 254);
            grading_sheet_btn.BackgroundImageLayout = ImageLayout.Stretch;
            grading_sheet_btn.BorderRadius = 5;
            grading_sheet_btn.ButtonText = "  CONSOLIDATION OF GRADES";
            grading_sheet_btn.DisabledColor = Color.Gray;
            grading_sheet_btn.Dock = DockStyle.Fill;
            grading_sheet_btn.Iconcolor = Color.Transparent;
            grading_sheet_btn.Iconimage = (Image)resources.GetObject("grading_sheet_btn.Iconimage");
            grading_sheet_btn.Iconimage_right = null;
            grading_sheet_btn.Iconimage_right_Selected = null;
            grading_sheet_btn.Iconimage_Selected = null;
            grading_sheet_btn.IconMarginLeft = 0;
            grading_sheet_btn.IconMarginRight = 0;
            grading_sheet_btn.IconRightVisible = true;
            grading_sheet_btn.IconRightZoom = 0D;
            grading_sheet_btn.IconVisible = true;
            grading_sheet_btn.IconZoom = 25D;
            grading_sheet_btn.IsTab = false;
            grading_sheet_btn.Location = new Point(6, 173);
            grading_sheet_btn.Margin = new Padding(6, 7, 6, 7);
            grading_sheet_btn.Name = "grading_sheet_btn";
            grading_sheet_btn.Normalcolor = Color.FromArgb(129, 142, 254);
            grading_sheet_btn.OnHovercolor = Color.FromArgb(43, 47, 84);
            grading_sheet_btn.OnHoverTextColor = Color.White;
            grading_sheet_btn.selected = false;
            grading_sheet_btn.Size = new Size(328, 69);
            grading_sheet_btn.TabIndex = 15;
            grading_sheet_btn.Text = "  CONSOLIDATION OF GRADES";
            grading_sheet_btn.TextAlign = ContentAlignment.MiddleLeft;
            grading_sheet_btn.Textcolor = Color.White;
            grading_sheet_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grading_sheet_btn.Click += grading_sheet_btn_Click;
            // 
            // student_profile_btn
            // 
            student_profile_btn.Active = false;
            student_profile_btn.Activecolor = Color.FromArgb(43, 47, 84);
            student_profile_btn.BackColor = Color.FromArgb(129, 142, 254);
            student_profile_btn.BackgroundImageLayout = ImageLayout.Stretch;
            student_profile_btn.BorderRadius = 5;
            student_profile_btn.ButtonText = "  STUDENT PROFILE";
            student_profile_btn.DisabledColor = Color.Gray;
            student_profile_btn.Dock = DockStyle.Fill;
            student_profile_btn.Iconcolor = Color.Transparent;
            student_profile_btn.Iconimage = (Image)resources.GetObject("student_profile_btn.Iconimage");
            student_profile_btn.Iconimage_right = null;
            student_profile_btn.Iconimage_right_Selected = null;
            student_profile_btn.Iconimage_Selected = null;
            student_profile_btn.IconMarginLeft = 0;
            student_profile_btn.IconMarginRight = 0;
            student_profile_btn.IconRightVisible = true;
            student_profile_btn.IconRightZoom = 0D;
            student_profile_btn.IconVisible = true;
            student_profile_btn.IconZoom = 25D;
            student_profile_btn.IsTab = false;
            student_profile_btn.Location = new Point(6, 90);
            student_profile_btn.Margin = new Padding(6, 7, 6, 7);
            student_profile_btn.Name = "student_profile_btn";
            student_profile_btn.Normalcolor = Color.FromArgb(129, 142, 254);
            student_profile_btn.OnHovercolor = Color.FromArgb(43, 47, 84);
            student_profile_btn.OnHoverTextColor = Color.White;
            student_profile_btn.selected = false;
            student_profile_btn.Size = new Size(328, 69);
            student_profile_btn.TabIndex = 15;
            student_profile_btn.Text = "  STUDENT PROFILE";
            student_profile_btn.TextAlign = ContentAlignment.MiddleLeft;
            student_profile_btn.Textcolor = Color.White;
            student_profile_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            student_profile_btn.Click += student_profile_btn_Click;
            // 
            // home_btn
            // 
            home_btn.Active = false;
            home_btn.Activecolor = Color.FromArgb(43, 47, 84);
            home_btn.BackColor = Color.FromArgb(129, 142, 254);
            home_btn.BackgroundImageLayout = ImageLayout.Stretch;
            home_btn.BorderRadius = 5;
            home_btn.ButtonText = "  HOME";
            home_btn.DisabledColor = Color.Gray;
            home_btn.Dock = DockStyle.Fill;
            home_btn.Iconcolor = Color.Transparent;
            home_btn.Iconimage = (Image)resources.GetObject("home_btn.Iconimage");
            home_btn.Iconimage_right = null;
            home_btn.Iconimage_right_Selected = null;
            home_btn.Iconimage_Selected = null;
            home_btn.IconMarginLeft = 0;
            home_btn.IconMarginRight = 0;
            home_btn.IconRightVisible = true;
            home_btn.IconRightZoom = 0D;
            home_btn.IconVisible = true;
            home_btn.IconZoom = 25D;
            home_btn.IsTab = false;
            home_btn.Location = new Point(6, 7);
            home_btn.Margin = new Padding(6, 7, 6, 7);
            home_btn.Name = "home_btn";
            home_btn.Normalcolor = Color.FromArgb(129, 142, 254);
            home_btn.OnHovercolor = Color.FromArgb(43, 47, 84);
            home_btn.OnHoverTextColor = Color.White;
            home_btn.selected = false;
            home_btn.Size = new Size(328, 69);
            home_btn.TabIndex = 15;
            home_btn.Text = "  HOME";
            home_btn.TextAlign = ContentAlignment.MiddleLeft;
            home_btn.Textcolor = Color.White;
            home_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            home_btn.Click += home_btn_Click;
            // 
            // logout_btn
            // 
            logout_btn.Active = false;
            logout_btn.Activecolor = Color.FromArgb(43, 47, 84);
            logout_btn.BackColor = Color.FromArgb(129, 142, 254);
            logout_btn.BackgroundImageLayout = ImageLayout.Stretch;
            logout_btn.BorderRadius = 5;
            logout_btn.ButtonText = "  LOGOUT";
            logout_btn.DisabledColor = Color.Gray;
            logout_btn.Dock = DockStyle.Fill;
            logout_btn.Iconcolor = Color.Transparent;
            logout_btn.Iconimage = (Image)resources.GetObject("logout_btn.Iconimage");
            logout_btn.Iconimage_right = null;
            logout_btn.Iconimage_right_Selected = null;
            logout_btn.Iconimage_Selected = null;
            logout_btn.IconMarginLeft = 0;
            logout_btn.IconMarginRight = 0;
            logout_btn.IconRightVisible = true;
            logout_btn.IconRightZoom = 0D;
            logout_btn.IconVisible = true;
            logout_btn.IconZoom = 25D;
            logout_btn.IsTab = false;
            logout_btn.Location = new Point(6, 588);
            logout_btn.Margin = new Padding(6, 7, 6, 7);
            logout_btn.Name = "logout_btn";
            logout_btn.Normalcolor = Color.FromArgb(129, 142, 254);
            logout_btn.OnHovercolor = Color.FromArgb(43, 47, 84);
            logout_btn.OnHoverTextColor = Color.White;
            logout_btn.selected = false;
            logout_btn.Size = new Size(328, 69);
            logout_btn.TabIndex = 12;
            logout_btn.Text = "  LOGOUT";
            logout_btn.TextAlign = ContentAlignment.MiddleLeft;
            logout_btn.Textcolor = Color.White;
            logout_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            logout_btn.Click += logout_btn_Click;
            // 
            // card_btn
            // 
            card_btn.Active = false;
            card_btn.Activecolor = Color.FromArgb(43, 47, 84);
            card_btn.BackColor = Color.FromArgb(129, 142, 254);
            card_btn.BackgroundImageLayout = ImageLayout.Stretch;
            card_btn.BorderRadius = 5;
            card_btn.ButtonText = "  REPORT CARDS";
            card_btn.DisabledColor = Color.Gray;
            card_btn.Dock = DockStyle.Fill;
            card_btn.Iconcolor = Color.Transparent;
            card_btn.Iconimage = (Image)resources.GetObject("card_btn.Iconimage");
            card_btn.Iconimage_right = null;
            card_btn.Iconimage_right_Selected = null;
            card_btn.Iconimage_Selected = null;
            card_btn.IconMarginLeft = 0;
            card_btn.IconMarginRight = 0;
            card_btn.IconRightVisible = true;
            card_btn.IconRightZoom = 0D;
            card_btn.IconVisible = true;
            card_btn.IconZoom = 25D;
            card_btn.IsTab = false;
            card_btn.Location = new Point(6, 339);
            card_btn.Margin = new Padding(6, 7, 6, 7);
            card_btn.Name = "card_btn";
            card_btn.Normalcolor = Color.FromArgb(129, 142, 254);
            card_btn.OnHovercolor = Color.FromArgb(43, 47, 84);
            card_btn.OnHoverTextColor = Color.White;
            card_btn.selected = false;
            card_btn.Size = new Size(328, 69);
            card_btn.TabIndex = 15;
            card_btn.Text = "  REPORT CARDS";
            card_btn.TextAlign = ContentAlignment.MiddleLeft;
            card_btn.Textcolor = Color.White;
            card_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            card_btn.Click += card_btn_Click;
            // 
            // profile_btn
            // 
            profile_btn.Active = false;
            profile_btn.Activecolor = Color.FromArgb(43, 47, 84);
            profile_btn.BackColor = Color.FromArgb(129, 142, 254);
            profile_btn.BackgroundImageLayout = ImageLayout.Stretch;
            profile_btn.BorderRadius = 5;
            profile_btn.ButtonText = "  PROFILE";
            profile_btn.DisabledColor = Color.Gray;
            profile_btn.Dock = DockStyle.Fill;
            profile_btn.Iconcolor = Color.Transparent;
            profile_btn.Iconimage = (Image)resources.GetObject("profile_btn.Iconimage");
            profile_btn.Iconimage_right = null;
            profile_btn.Iconimage_right_Selected = null;
            profile_btn.Iconimage_Selected = null;
            profile_btn.IconMarginLeft = 0;
            profile_btn.IconMarginRight = 0;
            profile_btn.IconRightVisible = true;
            profile_btn.IconRightZoom = 0D;
            profile_btn.IconVisible = true;
            profile_btn.IconZoom = 25D;
            profile_btn.IsTab = false;
            profile_btn.Location = new Point(6, 505);
            profile_btn.Margin = new Padding(6, 7, 6, 7);
            profile_btn.Name = "profile_btn";
            profile_btn.Normalcolor = Color.FromArgb(129, 142, 254);
            profile_btn.OnHovercolor = Color.FromArgb(43, 47, 84);
            profile_btn.OnHoverTextColor = Color.White;
            profile_btn.selected = false;
            profile_btn.Size = new Size(328, 69);
            profile_btn.TabIndex = 15;
            profile_btn.Text = "  PROFILE";
            profile_btn.TextAlign = ContentAlignment.MiddleLeft;
            profile_btn.Textcolor = Color.White;
            profile_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            profile_btn.Click += profile_btn_Click;
            // 
            // main_panel
            // 
            main_panel.Dock = DockStyle.Fill;
            main_panel.Location = new Point(346, 0);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1128, 1022);
            main_panel.TabIndex = 2;
            // 
            // FacultyDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1474, 1022);
            Controls.Add(main_panel);
            Controls.Add(nav_panel);
            MinimumSize = new Size(1488, 768);
            Name = "FacultyDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FacultyDashboard";
            WindowState = FormWindowState.Maximized;
            FormClosed += FacultyDashboard_FormClosed;
            Load += FacultyDashboard_Load;
            nav_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menu_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel nav_panel;
        private TableLayoutPanel menu_panel;
        private Label home_text;
        private Panel main_panel;
        private PictureBox pictureBox1;
        private Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton logout_btn;
        private Bunifu.Framework.UI.BunifuFlatButton home_btn;
        private Bunifu.Framework.UI.BunifuFlatButton grading_sheet_btn;
        private Bunifu.Framework.UI.BunifuFlatButton student_profile_btn;
        private Bunifu.Framework.UI.BunifuFlatButton profile_btn;
        private Bunifu.Framework.UI.BunifuFlatButton card_btn;
        private Bunifu.Framework.UI.BunifuFlatButton grading_summary_btn;
        private Bunifu.Framework.UI.BunifuFlatButton student_record_btn;
    }
}