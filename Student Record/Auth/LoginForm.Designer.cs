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
            login_code_tb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)close_btn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // radious
            // 
            radious.ElipseRadius = 25;
            radious.TargetControl = this;
            // 
            // close_btn
            // 
            close_btn.Cursor = Cursors.Hand;
            close_btn.Image = Properties.Resources.cross;
            close_btn.Location = new Point(761, 11);
            close_btn.Margin = new Padding(2, 2, 2, 2);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(18, 15);
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
            label1.Location = new Point(94, 50);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(603, 95);
            label1.TabIndex = 1;
            label1.Text = "DEVELOPMENT OF STUDENT RECORD DATABASE MANAGEMENT SYSTEM OF SENIOR HIGH SCHOOL IN SAN JOSE NATIONAL AND INDUSTRIAL HIGH SCHOOL";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(295, 367);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(200, 21);
            label2.TabIndex = 3;
            label2.Text = "Login to your Dashboard";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // login_btn
            // 
            login_btn.Active = false;
            login_btn.Activecolor = Color.FromArgb(46, 139, 87);
            login_btn.Anchor = AnchorStyles.Bottom;
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
            login_btn.Location = new Point(286, 486);
            login_btn.Margin = new Padding(4, 4, 4, 4);
            login_btn.Name = "login_btn";
            login_btn.Normalcolor = Color.FromArgb(129, 142, 254);
            login_btn.OnHovercolor = Color.FromArgb(171, 179, 254);
            login_btn.OnHoverTextColor = Color.White;
            login_btn.selected = false;
            login_btn.Size = new Size(218, 39);
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
            pictureBox1.Location = new Point(278, 159);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // login_code_tb
            // 
            login_code_tb.Anchor = AnchorStyles.Bottom;
            login_code_tb.BackgroundImageLayout = ImageLayout.None;
            login_code_tb.BorderColorFocused = Color.FromArgb(129, 142, 254);
            login_code_tb.BorderColorIdle = Color.FromArgb(64, 64, 64);
            login_code_tb.BorderColorMouseHover = Color.FromArgb(129, 142, 254);
            login_code_tb.BorderThickness = 1;
            login_code_tb.characterCasing = CharacterCasing.Normal;
            login_code_tb.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            login_code_tb.ForeColor = Color.FromArgb(64, 64, 64);
            login_code_tb.isPassword = false;
            login_code_tb.Location = new Point(104, 397);
            login_code_tb.Margin = new Padding(4);
            login_code_tb.MaxLength = 32767;
            login_code_tb.Name = "login_code_tb";
            login_code_tb.Size = new Size(582, 44);
            login_code_tb.TabIndex = 8;
            login_code_tb.Text = "Enter Login Code";
            login_code_tb.TextAlign = HorizontalAlignment.Center;
            login_code_tb.KeyDown += login_code_tb_KeyDown;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 581);
            Controls.Add(login_code_tb);
            Controls.Add(login_btn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(close_btn);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)close_btn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}