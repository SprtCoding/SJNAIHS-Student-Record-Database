namespace Student_Record.AdminModule
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            nav_panel = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            menu_panel = new TableLayoutPanel();
            report_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            logout_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            home_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            faculty_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            student_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            main_panel = new Panel();
            connectionPanel = new Panel();
            connectionStatusLbl = new Label();
            nav_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menu_panel.SuspendLayout();
            main_panel.SuspendLayout();
            connectionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // nav_panel
            // 
            nav_panel.BackColor = Color.FromArgb(129, 142, 254);
            nav_panel.Controls.Add(label2);
            nav_panel.Controls.Add(pictureBox1);
            nav_panel.Controls.Add(menu_panel);
            nav_panel.Dock = DockStyle.Left;
            nav_panel.Location = new Point(0, 0);
            nav_panel.Name = "nav_panel";
            nav_panel.Size = new Size(346, 1022);
            nav_panel.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Poppins Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(36, 297);
            label2.Name = "label2";
            label2.Size = new Size(274, 77);
            label2.TabIndex = 8;
            label2.Text = "SJNAIHS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sjnaihs_logo;
            pictureBox1.Location = new Point(87, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // menu_panel
            // 
            menu_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menu_panel.ColumnCount = 1;
            menu_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            menu_panel.Controls.Add(report_btn, 0, 3);
            menu_panel.Controls.Add(logout_btn, 0, 6);
            menu_panel.Controls.Add(home_btn, 0, 0);
            menu_panel.Controls.Add(faculty_btn, 0, 1);
            menu_panel.Controls.Add(student_btn, 0, 2);
            menu_panel.Location = new Point(3, 435);
            menu_panel.Name = "menu_panel";
            menu_panel.RowCount = 7;
            menu_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            menu_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            menu_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            menu_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            menu_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            menu_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            menu_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            menu_panel.Size = new Size(340, 583);
            menu_panel.TabIndex = 5;
            // 
            // report_btn
            // 
            report_btn.Active = false;
            report_btn.Activecolor = Color.FromArgb(43, 47, 84);
            report_btn.BackColor = Color.FromArgb(129, 142, 254);
            report_btn.BackgroundImageLayout = ImageLayout.Stretch;
            report_btn.BorderRadius = 5;
            report_btn.ButtonText = "  FACULTIES REPORT";
            report_btn.DisabledColor = Color.Gray;
            report_btn.Dock = DockStyle.Fill;
            report_btn.Iconcolor = Color.Transparent;
            report_btn.Iconimage = (Image)resources.GetObject("report_btn.Iconimage");
            report_btn.Iconimage_right = null;
            report_btn.Iconimage_right_Selected = null;
            report_btn.Iconimage_Selected = null;
            report_btn.IconMarginLeft = 0;
            report_btn.IconMarginRight = 0;
            report_btn.IconRightVisible = true;
            report_btn.IconRightZoom = 0D;
            report_btn.IconVisible = true;
            report_btn.IconZoom = 25D;
            report_btn.IsTab = false;
            report_btn.Location = new Point(6, 256);
            report_btn.Margin = new Padding(6, 7, 6, 7);
            report_btn.Name = "report_btn";
            report_btn.Normalcolor = Color.FromArgb(129, 142, 254);
            report_btn.OnHovercolor = Color.FromArgb(43, 47, 84);
            report_btn.OnHoverTextColor = Color.White;
            report_btn.selected = false;
            report_btn.Size = new Size(328, 69);
            report_btn.TabIndex = 11;
            report_btn.Text = "  FACULTIES REPORT";
            report_btn.TextAlign = ContentAlignment.MiddleLeft;
            report_btn.Textcolor = Color.White;
            report_btn.TextFont = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            report_btn.Click += report_btn_Click;
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
            logout_btn.Location = new Point(6, 507);
            logout_btn.Margin = new Padding(6, 7, 6, 7);
            logout_btn.Name = "logout_btn";
            logout_btn.Normalcolor = Color.FromArgb(129, 142, 254);
            logout_btn.OnHovercolor = Color.FromArgb(43, 47, 84);
            logout_btn.OnHoverTextColor = Color.White;
            logout_btn.selected = false;
            logout_btn.Size = new Size(328, 69);
            logout_btn.TabIndex = 10;
            logout_btn.Text = "  LOGOUT";
            logout_btn.TextAlign = ContentAlignment.MiddleLeft;
            logout_btn.Textcolor = Color.White;
            logout_btn.TextFont = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            logout_btn.Click += logout_btn_Click;
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
            home_btn.TabIndex = 7;
            home_btn.Text = "  HOME";
            home_btn.TextAlign = ContentAlignment.MiddleLeft;
            home_btn.Textcolor = Color.White;
            home_btn.TextFont = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            home_btn.Click += home_btn_Click;
            // 
            // faculty_btn
            // 
            faculty_btn.Active = false;
            faculty_btn.Activecolor = Color.FromArgb(43, 47, 84);
            faculty_btn.BackColor = Color.FromArgb(129, 142, 254);
            faculty_btn.BackgroundImageLayout = ImageLayout.Stretch;
            faculty_btn.BorderRadius = 5;
            faculty_btn.ButtonText = "  FACULTIES";
            faculty_btn.DisabledColor = Color.Gray;
            faculty_btn.Dock = DockStyle.Fill;
            faculty_btn.Iconcolor = Color.Transparent;
            faculty_btn.Iconimage = (Image)resources.GetObject("faculty_btn.Iconimage");
            faculty_btn.Iconimage_right = null;
            faculty_btn.Iconimage_right_Selected = null;
            faculty_btn.Iconimage_Selected = null;
            faculty_btn.IconMarginLeft = 0;
            faculty_btn.IconMarginRight = 0;
            faculty_btn.IconRightVisible = true;
            faculty_btn.IconRightZoom = 0D;
            faculty_btn.IconVisible = true;
            faculty_btn.IconZoom = 25D;
            faculty_btn.IsTab = false;
            faculty_btn.Location = new Point(6, 90);
            faculty_btn.Margin = new Padding(6, 7, 6, 7);
            faculty_btn.Name = "faculty_btn";
            faculty_btn.Normalcolor = Color.FromArgb(129, 142, 254);
            faculty_btn.OnHovercolor = Color.FromArgb(43, 47, 84);
            faculty_btn.OnHoverTextColor = Color.White;
            faculty_btn.selected = false;
            faculty_btn.Size = new Size(328, 69);
            faculty_btn.TabIndex = 8;
            faculty_btn.Text = "  FACULTIES";
            faculty_btn.TextAlign = ContentAlignment.MiddleLeft;
            faculty_btn.Textcolor = Color.White;
            faculty_btn.TextFont = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            faculty_btn.Click += faculty_btn_Click;
            // 
            // student_btn
            // 
            student_btn.Active = false;
            student_btn.Activecolor = Color.FromArgb(43, 47, 84);
            student_btn.BackColor = Color.FromArgb(129, 142, 254);
            student_btn.BackgroundImageLayout = ImageLayout.Stretch;
            student_btn.BorderRadius = 5;
            student_btn.ButtonText = "  STUDENTS";
            student_btn.DisabledColor = Color.Gray;
            student_btn.Dock = DockStyle.Fill;
            student_btn.Iconcolor = Color.Transparent;
            student_btn.Iconimage = (Image)resources.GetObject("student_btn.Iconimage");
            student_btn.Iconimage_right = null;
            student_btn.Iconimage_right_Selected = null;
            student_btn.Iconimage_Selected = null;
            student_btn.IconMarginLeft = 0;
            student_btn.IconMarginRight = 0;
            student_btn.IconRightVisible = true;
            student_btn.IconRightZoom = 0D;
            student_btn.IconVisible = true;
            student_btn.IconZoom = 25D;
            student_btn.IsTab = false;
            student_btn.Location = new Point(6, 173);
            student_btn.Margin = new Padding(6, 7, 6, 7);
            student_btn.Name = "student_btn";
            student_btn.Normalcolor = Color.FromArgb(129, 142, 254);
            student_btn.OnHovercolor = Color.FromArgb(43, 47, 84);
            student_btn.OnHoverTextColor = Color.White;
            student_btn.selected = false;
            student_btn.Size = new Size(328, 69);
            student_btn.TabIndex = 9;
            student_btn.Text = "  STUDENTS";
            student_btn.TextAlign = ContentAlignment.MiddleLeft;
            student_btn.Textcolor = Color.White;
            student_btn.TextFont = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            student_btn.Click += student_btn_Click;
            // 
            // main_panel
            // 
            main_panel.Controls.Add(connectionPanel);
            main_panel.Dock = DockStyle.Fill;
            main_panel.Location = new Point(346, 0);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1550, 1022);
            main_panel.TabIndex = 1;
            // 
            // connectionPanel
            // 
            connectionPanel.BackColor = Color.IndianRed;
            connectionPanel.Controls.Add(connectionStatusLbl);
            connectionPanel.Dock = DockStyle.Top;
            connectionPanel.Location = new Point(0, 0);
            connectionPanel.Name = "connectionPanel";
            connectionPanel.Size = new Size(1550, 55);
            connectionPanel.TabIndex = 0;
            connectionPanel.Visible = false;
            // 
            // connectionStatusLbl
            // 
            connectionStatusLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            connectionStatusLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            connectionStatusLbl.ForeColor = Color.WhiteSmoke;
            connectionStatusLbl.Location = new Point(17, 9);
            connectionStatusLbl.Name = "connectionStatusLbl";
            connectionStatusLbl.Size = new Size(1517, 35);
            connectionStatusLbl.TabIndex = 0;
            connectionStatusLbl.Text = "label1";
            connectionStatusLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1896, 1022);
            Controls.Add(main_panel);
            Controls.Add(nav_panel);
            MinimumSize = new Size(1918, 1078);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            WindowState = FormWindowState.Maximized;
            FormClosed += AdminDashboard_FormClosed;
            Load += AdminDashboard_Load;
            nav_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menu_panel.ResumeLayout(false);
            main_panel.ResumeLayout(false);
            connectionPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel nav_panel;
        private TableLayoutPanel menu_panel;
        private Panel main_panel;
        private Bunifu.Framework.UI.BunifuFlatButton home_btn;
        private Bunifu.Framework.UI.BunifuFlatButton faculty_btn;
        private Bunifu.Framework.UI.BunifuFlatButton student_btn;
        private Bunifu.Framework.UI.BunifuFlatButton logout_btn;
        private Bunifu.Framework.UI.BunifuFlatButton report_btn;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel connectionPanel;
        private Label connectionStatusLbl;
    }
}