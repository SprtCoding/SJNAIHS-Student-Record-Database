namespace Student_Record.AdminModule
{
    partial class Profiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profiles));
            label2 = new Label();
            name_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label1 = new Label();
            email_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            position_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            loginCodeTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            loginCodePanel = new Panel();
            seePassBtn = new PictureBox();
            viewCodeBtn = new Label();
            updateBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            right_panel = new Panel();
            left_panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            loginCodePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)seePassBtn).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            right_panel.SuspendLayout();
            left_panel.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(8, 5);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 30);
            label2.TabIndex = 9;
            label2.Text = "Profile";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // name_tb
            // 
            name_tb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name_tb.AutoCompleteMode = AutoCompleteMode.None;
            name_tb.AutoCompleteSource = AutoCompleteSource.None;
            name_tb.characterCasing = CharacterCasing.Normal;
            name_tb.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            name_tb.ForeColor = Color.FromArgb(64, 64, 64);
            name_tb.HintForeColor = Color.Empty;
            name_tb.HintText = "Name";
            name_tb.isPassword = false;
            name_tb.LineFocusedColor = Color.FromArgb(43, 47, 84);
            name_tb.LineIdleColor = Color.FromArgb(60, 64, 98);
            name_tb.LineMouseHoverColor = Color.FromArgb(43, 47, 84);
            name_tb.LineThickness = 2;
            name_tb.Location = new Point(13, 59);
            name_tb.Margin = new Padding(4, 3, 4, 3);
            name_tb.MaxLength = 32767;
            name_tb.Name = "name_tb";
            name_tb.Size = new Size(351, 30);
            name_tb.TabIndex = 17;
            name_tb.TextAlign = HorizontalAlignment.Left;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(15, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(228, 25);
            label1.TabIndex = 18;
            label1.Text = "Update your profile information";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // email_tb
            // 
            email_tb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            email_tb.AutoCompleteMode = AutoCompleteMode.None;
            email_tb.AutoCompleteSource = AutoCompleteSource.None;
            email_tb.characterCasing = CharacterCasing.Normal;
            email_tb.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            email_tb.ForeColor = Color.FromArgb(64, 64, 64);
            email_tb.HintForeColor = Color.Empty;
            email_tb.HintText = "Email";
            email_tb.isPassword = false;
            email_tb.LineFocusedColor = Color.FromArgb(43, 47, 84);
            email_tb.LineIdleColor = Color.FromArgb(60, 64, 98);
            email_tb.LineMouseHoverColor = Color.FromArgb(43, 47, 84);
            email_tb.LineThickness = 2;
            email_tb.Location = new Point(13, 116);
            email_tb.Margin = new Padding(4, 3, 4, 3);
            email_tb.MaxLength = 32767;
            email_tb.Name = "email_tb";
            email_tb.Size = new Size(351, 30);
            email_tb.TabIndex = 19;
            email_tb.TextAlign = HorizontalAlignment.Left;
            // 
            // position_tb
            // 
            position_tb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            position_tb.AutoCompleteMode = AutoCompleteMode.None;
            position_tb.AutoCompleteSource = AutoCompleteSource.None;
            position_tb.characterCasing = CharacterCasing.Normal;
            position_tb.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            position_tb.ForeColor = Color.FromArgb(64, 64, 64);
            position_tb.HintForeColor = Color.Empty;
            position_tb.HintText = "Position";
            position_tb.isPassword = false;
            position_tb.LineFocusedColor = Color.FromArgb(43, 47, 84);
            position_tb.LineIdleColor = Color.FromArgb(60, 64, 98);
            position_tb.LineMouseHoverColor = Color.FromArgb(43, 47, 84);
            position_tb.LineThickness = 2;
            position_tb.Location = new Point(13, 174);
            position_tb.Margin = new Padding(4, 3, 4, 3);
            position_tb.MaxLength = 32767;
            position_tb.Name = "position_tb";
            position_tb.Size = new Size(351, 30);
            position_tb.TabIndex = 20;
            position_tb.TextAlign = HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.sjnaihs_logo;
            pictureBox1.Location = new Point(50, 312);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Left;
            pictureBox2.Image = Properties.Resources.depEd_logo;
            pictureBox2.Location = new Point(18, 69);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(316, 224);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(18, 11);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 23;
            label3.Text = "Your Login Code";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginCodeTb
            // 
            loginCodeTb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            loginCodeTb.AutoCompleteMode = AutoCompleteMode.None;
            loginCodeTb.AutoCompleteSource = AutoCompleteSource.None;
            loginCodeTb.characterCasing = CharacterCasing.Normal;
            loginCodeTb.Enabled = false;
            loginCodeTb.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            loginCodeTb.ForeColor = Color.FromArgb(64, 64, 64);
            loginCodeTb.HintForeColor = Color.Empty;
            loginCodeTb.HintText = "";
            loginCodeTb.isPassword = true;
            loginCodeTb.LineFocusedColor = Color.FromArgb(43, 47, 84);
            loginCodeTb.LineIdleColor = Color.FromArgb(60, 64, 98);
            loginCodeTb.LineMouseHoverColor = Color.FromArgb(43, 47, 84);
            loginCodeTb.LineThickness = 2;
            loginCodeTb.Location = new Point(18, 49);
            loginCodeTb.Margin = new Padding(4, 3, 4, 3);
            loginCodeTb.MaxLength = 32767;
            loginCodeTb.Name = "loginCodeTb";
            loginCodeTb.Size = new Size(315, 30);
            loginCodeTb.TabIndex = 24;
            loginCodeTb.TextAlign = HorizontalAlignment.Left;
            // 
            // loginCodePanel
            // 
            loginCodePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginCodePanel.Controls.Add(seePassBtn);
            loginCodePanel.Controls.Add(label3);
            loginCodePanel.Controls.Add(loginCodeTb);
            loginCodePanel.Location = new Point(13, 274);
            loginCodePanel.Margin = new Padding(2);
            loginCodePanel.Name = "loginCodePanel";
            loginCodePanel.Size = new Size(351, 90);
            loginCodePanel.TabIndex = 25;
            loginCodePanel.Visible = false;
            // 
            // seePassBtn
            // 
            seePassBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            seePassBtn.Image = Properties.Resources.eye;
            seePassBtn.Location = new Point(319, 58);
            seePassBtn.Margin = new Padding(2);
            seePassBtn.Name = "seePassBtn";
            seePassBtn.Size = new Size(14, 12);
            seePassBtn.SizeMode = PictureBoxSizeMode.Zoom;
            seePassBtn.TabIndex = 25;
            seePassBtn.TabStop = false;
            seePassBtn.Click += seePassBtn_Click;
            // 
            // viewCodeBtn
            // 
            viewCodeBtn.AutoSize = true;
            viewCodeBtn.Font = new Font("Poppins Medium", 8F, FontStyle.Regular, GraphicsUnit.Point);
            viewCodeBtn.ForeColor = SystemColors.ControlText;
            viewCodeBtn.Image = (Image)resources.GetObject("viewCodeBtn.Image");
            viewCodeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            viewCodeBtn.Location = new Point(15, 218);
            viewCodeBtn.Margin = new Padding(2, 0, 2, 0);
            viewCodeBtn.Name = "viewCodeBtn";
            viewCodeBtn.Size = new Size(119, 19);
            viewCodeBtn.TabIndex = 26;
            viewCodeBtn.Text = "      View Login Code";
            viewCodeBtn.TextAlign = ContentAlignment.MiddleCenter;
            viewCodeBtn.Click += viewCodeBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Active = false;
            updateBtn.Activecolor = Color.FromArgb(60, 64, 98);
            updateBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            updateBtn.BackColor = Color.FromArgb(43, 47, 84);
            updateBtn.BackgroundImageLayout = ImageLayout.Stretch;
            updateBtn.BorderRadius = 5;
            updateBtn.ButtonText = "Update";
            updateBtn.DisabledColor = Color.Gray;
            updateBtn.Iconcolor = Color.Transparent;
            updateBtn.Iconimage = null;
            updateBtn.Iconimage_right = null;
            updateBtn.Iconimage_right_Selected = null;
            updateBtn.Iconimage_Selected = null;
            updateBtn.IconMarginLeft = 0;
            updateBtn.IconMarginRight = 0;
            updateBtn.IconRightVisible = true;
            updateBtn.IconRightZoom = 40D;
            updateBtn.IconVisible = false;
            updateBtn.IconZoom = 40D;
            updateBtn.IsTab = false;
            updateBtn.Location = new Point(252, 218);
            updateBtn.Margin = new Padding(4);
            updateBtn.Name = "updateBtn";
            updateBtn.Normalcolor = Color.FromArgb(43, 47, 84);
            updateBtn.OnHovercolor = Color.FromArgb(60, 64, 98);
            updateBtn.OnHoverTextColor = Color.White;
            updateBtn.Padding = new Padding(8, 5, 8, 5);
            updateBtn.RightToLeft = RightToLeft.No;
            updateBtn.selected = false;
            updateBtn.Size = new Size(113, 28);
            updateBtn.TabIndex = 27;
            updateBtn.Text = "Update";
            updateBtn.TextAlign = ContentAlignment.MiddleCenter;
            updateBtn.Textcolor = Color.White;
            updateBtn.TextFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            updateBtn.Click += updateBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(right_panel, 1, 0);
            tableLayoutPanel1.Controls.Add(left_panel, 0, 0);
            tableLayoutPanel1.Location = new Point(13, 38);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(765, 611);
            tableLayoutPanel1.TabIndex = 28;
            // 
            // right_panel
            // 
            right_panel.Controls.Add(pictureBox2);
            right_panel.Controls.Add(pictureBox1);
            right_panel.Dock = DockStyle.Fill;
            right_panel.Location = new Point(385, 3);
            right_panel.Name = "right_panel";
            right_panel.Size = new Size(377, 605);
            right_panel.TabIndex = 1;
            // 
            // left_panel
            // 
            left_panel.Controls.Add(label1);
            left_panel.Controls.Add(updateBtn);
            left_panel.Controls.Add(name_tb);
            left_panel.Controls.Add(viewCodeBtn);
            left_panel.Controls.Add(email_tb);
            left_panel.Controls.Add(loginCodePanel);
            left_panel.Controls.Add(position_tb);
            left_panel.Dock = DockStyle.Fill;
            left_panel.Location = new Point(3, 3);
            left_panel.Name = "left_panel";
            left_panel.Size = new Size(376, 605);
            left_panel.TabIndex = 0;
            // 
            // Profiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 661);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Profiles";
            Text = "Profiles";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            loginCodePanel.ResumeLayout(false);
            loginCodePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)seePassBtn).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            right_panel.ResumeLayout(false);
            left_panel.ResumeLayout(false);
            left_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox name_tb;
        private Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email_tb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox position_tb;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox loginCodeTb;
        private Panel loginCodePanel;
        private Label viewCodeBtn;
        private Bunifu.Framework.UI.BunifuFlatButton updateBtn;
        private PictureBox seePassBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel right_panel;
        private Panel left_panel;
    }
}