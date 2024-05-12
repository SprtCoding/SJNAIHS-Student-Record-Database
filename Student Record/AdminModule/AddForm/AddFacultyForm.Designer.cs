namespace Student_Record.AdminModule.AddForm
{
    partial class AddFacultyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFacultyForm));
            title_lbl = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            fullname_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            fullname_lbl = new Label();
            panel3 = new Panel();
            position_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label3 = new Label();
            panel5 = new Panel();
            email_address_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label5 = new Label();
            panel2 = new Panel();
            gen_code_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            login_code_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label1 = new Label();
            save_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            rad = new Bunifu.Framework.UI.BunifuElipse(components);
            close_btn = new PictureBox();
            pictureBox1 = new PictureBox();
            new_code_panel = new Panel();
            new_code_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            new_code_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)close_btn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            new_code_panel.SuspendLayout();
            SuspendLayout();
            // 
            // title_lbl
            // 
            title_lbl.AutoSize = true;
            title_lbl.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            title_lbl.ForeColor = SystemColors.ControlText;
            title_lbl.Location = new Point(20, 32);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(355, 38);
            title_lbl.TabIndex = 7;
            title_lbl.Text = "Add New Faculty Profile";
            title_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel5, 1, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Location = new Point(20, 333);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Size = new Size(809, 248);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(fullname_tb);
            panel1.Controls.Add(fullname_lbl);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 117);
            panel1.TabIndex = 0;
            // 
            // fullname_tb
            // 
            fullname_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            fullname_tb.AutoCompleteMode = AutoCompleteMode.None;
            fullname_tb.AutoCompleteSource = AutoCompleteSource.None;
            fullname_tb.characterCasing = CharacterCasing.Normal;
            fullname_tb.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            fullname_tb.ForeColor = Color.FromArgb(64, 64, 64);
            fullname_tb.HintForeColor = Color.Empty;
            fullname_tb.HintText = "";
            fullname_tb.isPassword = false;
            fullname_tb.LineFocusedColor = Color.FromArgb(43, 47, 84);
            fullname_tb.LineIdleColor = Color.FromArgb(60, 64, 98);
            fullname_tb.LineMouseHoverColor = Color.FromArgb(43, 47, 84);
            fullname_tb.LineThickness = 2;
            fullname_tb.Location = new Point(19, 47);
            fullname_tb.Margin = new Padding(6, 5, 6, 5);
            fullname_tb.MaxLength = 32767;
            fullname_tb.Name = "fullname_tb";
            fullname_tb.Size = new Size(358, 55);
            fullname_tb.TabIndex = 15;
            fullname_tb.TextAlign = HorizontalAlignment.Left;
            // 
            // fullname_lbl
            // 
            fullname_lbl.AutoSize = true;
            fullname_lbl.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            fullname_lbl.ForeColor = SystemColors.ControlText;
            fullname_lbl.Location = new Point(19, 18);
            fullname_lbl.Name = "fullname_lbl";
            fullname_lbl.Size = new Size(108, 23);
            fullname_lbl.TabIndex = 14;
            fullname_lbl.Text = "Full Name";
            fullname_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(position_tb);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(407, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(399, 117);
            panel3.TabIndex = 2;
            // 
            // position_tb
            // 
            position_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            position_tb.AutoCompleteMode = AutoCompleteMode.None;
            position_tb.AutoCompleteSource = AutoCompleteSource.None;
            position_tb.characterCasing = CharacterCasing.Normal;
            position_tb.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            position_tb.ForeColor = Color.FromArgb(64, 64, 64);
            position_tb.HintForeColor = Color.Empty;
            position_tb.HintText = "";
            position_tb.isPassword = false;
            position_tb.LineFocusedColor = Color.FromArgb(43, 47, 84);
            position_tb.LineIdleColor = Color.FromArgb(60, 64, 98);
            position_tb.LineMouseHoverColor = Color.FromArgb(43, 47, 84);
            position_tb.LineThickness = 2;
            position_tb.Location = new Point(19, 47);
            position_tb.Margin = new Padding(6, 5, 6, 5);
            position_tb.MaxLength = 32767;
            position_tb.Name = "position_tb";
            position_tb.Size = new Size(359, 55);
            position_tb.TabIndex = 15;
            position_tb.TextAlign = HorizontalAlignment.Left;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(19, 18);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 14;
            label3.Text = "Position";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(email_address_tb);
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(407, 126);
            panel5.Name = "panel5";
            panel5.Size = new Size(399, 119);
            panel5.TabIndex = 4;
            // 
            // email_address_tb
            // 
            email_address_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            email_address_tb.AutoCompleteMode = AutoCompleteMode.None;
            email_address_tb.AutoCompleteSource = AutoCompleteSource.None;
            email_address_tb.characterCasing = CharacterCasing.Normal;
            email_address_tb.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            email_address_tb.ForeColor = Color.FromArgb(64, 64, 64);
            email_address_tb.HintForeColor = Color.Empty;
            email_address_tb.HintText = "";
            email_address_tb.isPassword = false;
            email_address_tb.LineFocusedColor = Color.FromArgb(43, 47, 84);
            email_address_tb.LineIdleColor = Color.FromArgb(60, 64, 98);
            email_address_tb.LineMouseHoverColor = Color.FromArgb(43, 47, 84);
            email_address_tb.LineThickness = 2;
            email_address_tb.Location = new Point(19, 47);
            email_address_tb.Margin = new Padding(6, 5, 6, 5);
            email_address_tb.MaxLength = 32767;
            email_address_tb.Name = "email_address_tb";
            email_address_tb.Size = new Size(359, 55);
            email_address_tb.TabIndex = 15;
            email_address_tb.TextAlign = HorizontalAlignment.Left;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(19, 18);
            label5.Name = "label5";
            label5.Size = new Size(146, 23);
            label5.TabIndex = 14;
            label5.Text = "Email Address";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(gen_code_btn);
            panel2.Controls.Add(login_code_tb);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(398, 119);
            panel2.TabIndex = 1;
            // 
            // gen_code_btn
            // 
            gen_code_btn.Active = false;
            gen_code_btn.Activecolor = Color.FromArgb(60, 64, 98);
            gen_code_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gen_code_btn.BackColor = Color.FromArgb(43, 47, 84);
            gen_code_btn.BackgroundImageLayout = ImageLayout.Stretch;
            gen_code_btn.BorderRadius = 5;
            gen_code_btn.ButtonText = "Generate";
            gen_code_btn.DisabledColor = Color.Gray;
            gen_code_btn.Iconcolor = Color.Transparent;
            gen_code_btn.Iconimage = null;
            gen_code_btn.Iconimage_right = null;
            gen_code_btn.Iconimage_right_Selected = null;
            gen_code_btn.Iconimage_Selected = null;
            gen_code_btn.IconMarginLeft = 0;
            gen_code_btn.IconMarginRight = 0;
            gen_code_btn.IconRightVisible = true;
            gen_code_btn.IconRightZoom = 40D;
            gen_code_btn.IconVisible = false;
            gen_code_btn.IconZoom = 40D;
            gen_code_btn.IsTab = false;
            gen_code_btn.Location = new Point(243, 47);
            gen_code_btn.Margin = new Padding(6, 7, 6, 7);
            gen_code_btn.Name = "gen_code_btn";
            gen_code_btn.Normalcolor = Color.FromArgb(43, 47, 84);
            gen_code_btn.OnHovercolor = Color.FromArgb(60, 64, 98);
            gen_code_btn.OnHoverTextColor = Color.White;
            gen_code_btn.Padding = new Padding(10, 10, 10, 10);
            gen_code_btn.RightToLeft = RightToLeft.No;
            gen_code_btn.selected = false;
            gen_code_btn.Size = new Size(134, 43);
            gen_code_btn.TabIndex = 16;
            gen_code_btn.Text = "Generate";
            gen_code_btn.TextAlign = ContentAlignment.MiddleCenter;
            gen_code_btn.Textcolor = Color.White;
            gen_code_btn.TextFont = new Font("Century Gothic", 7F, FontStyle.Regular, GraphicsUnit.Point);
            gen_code_btn.Click += gen_code_btn_Click;
            // 
            // login_code_tb
            // 
            login_code_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            login_code_tb.AutoCompleteMode = AutoCompleteMode.None;
            login_code_tb.AutoCompleteSource = AutoCompleteSource.None;
            login_code_tb.characterCasing = CharacterCasing.Normal;
            login_code_tb.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            login_code_tb.ForeColor = Color.FromArgb(64, 64, 64);
            login_code_tb.HintForeColor = Color.Empty;
            login_code_tb.HintText = "";
            login_code_tb.isPassword = false;
            login_code_tb.LineFocusedColor = Color.FromArgb(43, 47, 84);
            login_code_tb.LineIdleColor = Color.FromArgb(60, 64, 98);
            login_code_tb.LineMouseHoverColor = Color.FromArgb(43, 47, 84);
            login_code_tb.LineThickness = 2;
            login_code_tb.Location = new Point(19, 47);
            login_code_tb.Margin = new Padding(6, 5, 6, 5);
            login_code_tb.MaxLength = 32767;
            login_code_tb.Name = "login_code_tb";
            login_code_tb.Size = new Size(358, 55);
            login_code_tb.TabIndex = 15;
            login_code_tb.TextAlign = HorizontalAlignment.Left;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(19, 18);
            label1.Name = "label1";
            label1.Size = new Size(123, 23);
            label1.TabIndex = 14;
            label1.Text = "Login Code";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // save_btn
            // 
            save_btn.Active = false;
            save_btn.Activecolor = Color.FromArgb(60, 64, 98);
            save_btn.BackColor = Color.FromArgb(43, 47, 84);
            save_btn.BackgroundImageLayout = ImageLayout.Stretch;
            save_btn.BorderRadius = 5;
            save_btn.ButtonText = "Save";
            save_btn.DisabledColor = Color.Gray;
            save_btn.Iconcolor = Color.Transparent;
            save_btn.Iconimage = null;
            save_btn.Iconimage_right = null;
            save_btn.Iconimage_right_Selected = null;
            save_btn.Iconimage_Selected = null;
            save_btn.IconMarginLeft = 0;
            save_btn.IconMarginRight = 0;
            save_btn.IconRightVisible = true;
            save_btn.IconRightZoom = 40D;
            save_btn.IconVisible = false;
            save_btn.IconZoom = 40D;
            save_btn.IsTab = false;
            save_btn.Location = new Point(571, 603);
            save_btn.Margin = new Padding(6, 7, 6, 7);
            save_btn.Name = "save_btn";
            save_btn.Normalcolor = Color.FromArgb(43, 47, 84);
            save_btn.OnHovercolor = Color.FromArgb(60, 64, 98);
            save_btn.OnHoverTextColor = Color.White;
            save_btn.Padding = new Padding(10, 10, 10, 10);
            save_btn.RightToLeft = RightToLeft.No;
            save_btn.selected = false;
            save_btn.Size = new Size(230, 63);
            save_btn.TabIndex = 12;
            save_btn.Text = "Save";
            save_btn.TextAlign = ContentAlignment.MiddleCenter;
            save_btn.Textcolor = Color.White;
            save_btn.TextFont = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            save_btn.Click += save_btn_Click;
            // 
            // rad
            // 
            rad.ElipseRadius = 10;
            rad.TargetControl = this;
            // 
            // close_btn
            // 
            close_btn.Cursor = Cursors.Hand;
            close_btn.Image = Properties.Resources.cross;
            close_btn.Location = new Point(806, 12);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(26, 25);
            close_btn.SizeMode = PictureBoxSizeMode.Zoom;
            close_btn.TabIndex = 13;
            close_btn.TabStop = false;
            close_btn.Click += close_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(300, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // new_code_panel
            // 
            new_code_panel.Controls.Add(new_code_btn);
            new_code_panel.Controls.Add(new_code_tb);
            new_code_panel.Controls.Add(label2);
            new_code_panel.Location = new Point(23, 585);
            new_code_panel.Name = "new_code_panel";
            new_code_panel.Size = new Size(399, 118);
            new_code_panel.TabIndex = 15;
            new_code_panel.Visible = false;
            // 
            // new_code_btn
            // 
            new_code_btn.Active = false;
            new_code_btn.Activecolor = Color.FromArgb(60, 64, 98);
            new_code_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            new_code_btn.BackColor = Color.FromArgb(43, 47, 84);
            new_code_btn.BackgroundImageLayout = ImageLayout.Stretch;
            new_code_btn.BorderRadius = 5;
            new_code_btn.ButtonText = "Generate";
            new_code_btn.DisabledColor = Color.Gray;
            new_code_btn.Iconcolor = Color.Transparent;
            new_code_btn.Iconimage = null;
            new_code_btn.Iconimage_right = null;
            new_code_btn.Iconimage_right_Selected = null;
            new_code_btn.Iconimage_Selected = null;
            new_code_btn.IconMarginLeft = 0;
            new_code_btn.IconMarginRight = 0;
            new_code_btn.IconRightVisible = true;
            new_code_btn.IconRightZoom = 40D;
            new_code_btn.IconVisible = false;
            new_code_btn.IconZoom = 40D;
            new_code_btn.IsTab = false;
            new_code_btn.Location = new Point(244, 57);
            new_code_btn.Margin = new Padding(6, 7, 6, 7);
            new_code_btn.Name = "new_code_btn";
            new_code_btn.Normalcolor = Color.FromArgb(43, 47, 84);
            new_code_btn.OnHovercolor = Color.FromArgb(60, 64, 98);
            new_code_btn.OnHoverTextColor = Color.White;
            new_code_btn.Padding = new Padding(10, 10, 10, 10);
            new_code_btn.RightToLeft = RightToLeft.No;
            new_code_btn.selected = false;
            new_code_btn.Size = new Size(134, 43);
            new_code_btn.TabIndex = 16;
            new_code_btn.Text = "Generate";
            new_code_btn.TextAlign = ContentAlignment.MiddleCenter;
            new_code_btn.Textcolor = Color.White;
            new_code_btn.TextFont = new Font("Century Gothic", 7F, FontStyle.Regular, GraphicsUnit.Point);
            new_code_btn.Click += new_code_btn_Click;
            // 
            // new_code_tb
            // 
            new_code_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            new_code_tb.AutoCompleteMode = AutoCompleteMode.None;
            new_code_tb.AutoCompleteSource = AutoCompleteSource.None;
            new_code_tb.characterCasing = CharacterCasing.Normal;
            new_code_tb.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            new_code_tb.ForeColor = Color.FromArgb(64, 64, 64);
            new_code_tb.HintForeColor = Color.Empty;
            new_code_tb.HintText = "";
            new_code_tb.isPassword = false;
            new_code_tb.LineFocusedColor = Color.FromArgb(43, 47, 84);
            new_code_tb.LineIdleColor = Color.FromArgb(60, 64, 98);
            new_code_tb.LineMouseHoverColor = Color.FromArgb(43, 47, 84);
            new_code_tb.LineThickness = 2;
            new_code_tb.Location = new Point(19, 57);
            new_code_tb.Margin = new Padding(6, 5, 6, 5);
            new_code_tb.MaxLength = 32767;
            new_code_tb.Name = "new_code_tb";
            new_code_tb.Size = new Size(359, 55);
            new_code_tb.TabIndex = 15;
            new_code_tb.TextAlign = HorizontalAlignment.Left;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(19, 18);
            label2.Name = "label2";
            label2.Size = new Size(173, 23);
            label2.TabIndex = 14;
            label2.Text = "New Login Code";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddFacultyForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 723);
            Controls.Add(new_code_panel);
            Controls.Add(pictureBox1);
            Controls.Add(close_btn);
            Controls.Add(save_btn);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(title_lbl);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddFacultyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Faculty";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)close_btn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            new_code_panel.ResumeLayout(false);
            new_code_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title_lbl;
        private TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton save_btn;
        private Panel panel1;
        private Label fullname_lbl;
        private Panel panel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email_address_tb;
        private Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fullname_tb;
        private Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox login_code_tb;
        private Label label1;
        private Panel panel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox position_tb;
        private Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton gen_code_btn;
        private Bunifu.Framework.UI.BunifuElipse rad;
        private PictureBox close_btn;
        private PictureBox pictureBox1;
        private Panel new_code_panel;
        private Bunifu.Framework.UI.BunifuFlatButton new_code_btn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox new_code_tb;
        private Label label2;
    }
}