namespace Student_Record.Auth
{
    partial class LoginForm
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
            components = new System.ComponentModel.Container();
            radious = new Bunifu.Framework.UI.BunifuElipse(components);
            close_btn = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            login_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            btn_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            pictureBox1 = new PictureBox();
            authLabel = new Label();
            loadingProgress = new ProgressBar();
            panel1 = new Panel();
            loginCodeTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)close_btn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // radious
            // 
            radious.ElipseRadius = 5;
            radious.TargetControl = this;
            // 
            // close_btn
            // 
            close_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close_btn.Cursor = Cursors.Hand;
            close_btn.Image = Properties.Resources.cross;
            close_btn.Location = new Point(1087, 18);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(26, 25);
            close_btn.SizeMode = PictureBoxSizeMode.Zoom;
            close_btn.TabIndex = 0;
            close_btn.TabStop = false;
            close_btn.Click += close_btn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(134, 75);
            label1.Name = "label1";
            label1.Size = new Size(861, 158);
            label1.TabIndex = 1;
            label1.Text = "DEVELOPMENT OF STUDENT RECORD DATABASE MANAGEMENT SYSTEM OF SENIOR HIGH SCHOOL IN SAN JOSE NATIONAL AGRICULTURAL INDUSTRIAL HIGH SCHOOL";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(413, 604);
            label2.Name = "label2";
            label2.Size = new Size(303, 30);
            label2.TabIndex = 3;
            label2.Text = "Login to your Dashboard";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // login_btn
            // 
            login_btn.Active = false;
            login_btn.Activecolor = Color.FromArgb(46, 139, 87);
            login_btn.Anchor = AnchorStyles.None;
            login_btn.BackColor = Color.FromArgb(129, 142, 254);
            login_btn.BackgroundImageLayout = ImageLayout.Stretch;
            login_btn.BorderRadius = 5;
            login_btn.ButtonText = "Login";
            login_btn.DisabledColor = Color.Gray;
            login_btn.Iconcolor = Color.Transparent;
            login_btn.Iconimage = null;
            login_btn.Iconimage_right = null;
            login_btn.Iconimage_right_Selected = null;
            login_btn.Iconimage_Selected = null;
            login_btn.IconMarginLeft = 0;
            login_btn.IconMarginRight = 0;
            login_btn.IconRightVisible = true;
            login_btn.IconRightZoom = 0D;
            login_btn.IconVisible = true;
            login_btn.IconZoom = 90D;
            login_btn.IsTab = false;
            login_btn.Location = new Point(409, 828);
            login_btn.Margin = new Padding(6, 7, 6, 7);
            login_btn.Name = "login_btn";
            login_btn.Normalcolor = Color.FromArgb(129, 142, 254);
            login_btn.OnHovercolor = Color.FromArgb(171, 179, 254);
            login_btn.OnHoverTextColor = Color.White;
            login_btn.selected = false;
            login_btn.Size = new Size(311, 65);
            login_btn.TabIndex = 4;
            login_btn.Text = "Login";
            login_btn.TextAlign = ContentAlignment.MiddleCenter;
            login_btn.Textcolor = Color.White;
            login_btn.TextFont = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            login_btn.Click += login_btn_Click;
            // 
            // btn_rad
            // 
            btn_rad.ElipseRadius = 5;
            btn_rad.TargetControl = login_btn;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.sjnaihs_logo;
            pictureBox1.Location = new Point(397, 257);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 320);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // authLabel
            // 
            authLabel.Anchor = AnchorStyles.None;
            authLabel.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            authLabel.ForeColor = Color.LightCoral;
            authLabel.Location = new Point(149, 737);
            authLabel.Name = "authLabel";
            authLabel.Size = new Size(831, 40);
            authLabel.TabIndex = 9;
            authLabel.TextAlign = ContentAlignment.MiddleCenter;
            authLabel.Visible = false;
            // 
            // loadingProgress
            // 
            loadingProgress.Anchor = AnchorStyles.None;
            loadingProgress.Location = new Point(149, 780);
            loadingProgress.Name = "loadingProgress";
            loadingProgress.Size = new Size(831, 23);
            loadingProgress.TabIndex = 10;
            loadingProgress.Visible = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(loginCodeTB);
            panel1.Location = new Point(149, 649);
            panel1.Name = "panel1";
            panel1.Size = new Size(831, 65);
            panel1.TabIndex = 33;
            // 
            // loginCodeTB
            // 
            loginCodeTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginCodeTB.BackColor = SystemColors.Control;
            loginCodeTB.BorderStyle = BorderStyle.None;
            loginCodeTB.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            loginCodeTB.Location = new Point(16, 16);
            loginCodeTB.Name = "loginCodeTB";
            loginCodeTB.PlaceholderText = "Enter Login Code";
            loginCodeTB.Size = new Size(797, 27);
            loginCodeTB.TabIndex = 0;
            loginCodeTB.TextAlign = HorizontalAlignment.Center;
            loginCodeTB.KeyDown += loginCodeTB_KeyDown;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 968);
            Controls.Add(panel1);
            Controls.Add(loadingProgress);
            Controls.Add(authLabel);
            Controls.Add(login_btn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(close_btn);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            WindowState = FormWindowState.Maximized;
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)close_btn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse radious;
        private PictureBox close_btn;
        private Bunifu.Framework.UI.BunifuFlatButton login_btn;
        private Label label2;
        private Label label1;
        private Bunifu.Framework.UI.BunifuElipse btn_rad;
        private PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox login_code_tb;
        private Label authLabel;
        private ProgressBar loadingProgress;
        private Panel panel1;
        private PictureBox pictureBox2;
        private TextBox loginCodeTB;
    }
}