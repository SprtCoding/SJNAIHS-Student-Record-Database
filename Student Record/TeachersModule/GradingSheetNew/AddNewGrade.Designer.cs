namespace Student_Record.TeachersModule.GradingSheetNew
{
    partial class AddNewGrade
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
            dtg_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            close_btn = new Label();
            fullname_lbl = new Label();
            student_cbx = new ComboBox();
            term_cbx = new ComboBox();
            label1 = new Label();
            subject_cbx = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            grade_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label4 = new Label();
            save_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            SuspendLayout();
            // 
            // dtg_rad
            // 
            dtg_rad.ElipseRadius = 20;
            dtg_rad.TargetControl = this;
            // 
            // close_btn
            // 
            close_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close_btn.AutoSize = true;
            close_btn.Cursor = Cursors.Hand;
            close_btn.Font = new Font("Poppins Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            close_btn.ForeColor = Color.WhiteSmoke;
            close_btn.Location = new Point(556, 5);
            close_btn.Margin = new Padding(2, 0, 2, 0);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(25, 34);
            close_btn.TabIndex = 21;
            close_btn.Text = "x";
            close_btn.TextAlign = ContentAlignment.MiddleLeft;
            close_btn.Click += close_btn_Click;
            // 
            // fullname_lbl
            // 
            fullname_lbl.AutoSize = true;
            fullname_lbl.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            fullname_lbl.ForeColor = Color.WhiteSmoke;
            fullname_lbl.Location = new Point(31, 89);
            fullname_lbl.Margin = new Padding(2, 0, 2, 0);
            fullname_lbl.Name = "fullname_lbl";
            fullname_lbl.Size = new Size(124, 25);
            fullname_lbl.TabIndex = 22;
            fullname_lbl.Text = "Choose Student";
            fullname_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // student_cbx
            // 
            student_cbx.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            student_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            student_cbx.FlatStyle = FlatStyle.Flat;
            student_cbx.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            student_cbx.FormattingEnabled = true;
            student_cbx.Items.AddRange(new object[] { "11", "12" });
            student_cbx.Location = new Point(33, 119);
            student_cbx.Margin = new Padding(2, 2, 2, 2);
            student_cbx.Name = "student_cbx";
            student_cbx.Size = new Size(525, 36);
            student_cbx.TabIndex = 23;
            student_cbx.SelectedIndexChanged += student_cbx_SelectedIndexChanged;
            // 
            // term_cbx
            // 
            term_cbx.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            term_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            term_cbx.FlatStyle = FlatStyle.Flat;
            term_cbx.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            term_cbx.FormattingEnabled = true;
            term_cbx.Items.AddRange(new object[] { "Mid Term", "Final Term" });
            term_cbx.Location = new Point(31, 194);
            term_cbx.Margin = new Padding(2, 2, 2, 2);
            term_cbx.Name = "term_cbx";
            term_cbx.Size = new Size(525, 36);
            term_cbx.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(31, 164);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 24;
            label1.Text = "Term";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // subject_cbx
            // 
            subject_cbx.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            subject_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            subject_cbx.FlatStyle = FlatStyle.Flat;
            subject_cbx.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            subject_cbx.FormattingEnabled = true;
            subject_cbx.Items.AddRange(new object[] { "Oral Communication", "Komunikasyon at Pananaliksik", "21st Century Literature", "General Mathematics", "Introduction to the Philosophy", "Physical Education & Health", "TVE" });
            subject_cbx.Location = new Point(31, 264);
            subject_cbx.Margin = new Padding(2, 2, 2, 2);
            subject_cbx.Name = "subject_cbx";
            subject_cbx.Size = new Size(525, 36);
            subject_cbx.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(31, 237);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 26;
            label2.Text = "Subject";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(33, 315);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 28;
            label3.Text = "Grade";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grade_tb
            // 
            grade_tb.AutoCompleteMode = AutoCompleteMode.None;
            grade_tb.AutoCompleteSource = AutoCompleteSource.None;
            grade_tb.characterCasing = CharacterCasing.Normal;
            grade_tb.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            grade_tb.ForeColor = Color.WhiteSmoke;
            grade_tb.HintForeColor = Color.WhiteSmoke;
            grade_tb.HintText = "";
            grade_tb.isPassword = false;
            grade_tb.LineFocusedColor = Color.Gainsboro;
            grade_tb.LineIdleColor = Color.WhiteSmoke;
            grade_tb.LineMouseHoverColor = Color.Gainsboro;
            grade_tb.LineThickness = 1;
            grade_tb.Location = new Point(31, 334);
            grade_tb.Margin = new Padding(4, 5, 4, 5);
            grade_tb.MaxLength = 32767;
            grade_tb.Name = "grade_tb";
            grade_tb.Size = new Size(378, 33);
            grade_tb.TabIndex = 29;
            grade_tb.TextAlign = HorizontalAlignment.Left;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Medium", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(33, 20);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(146, 39);
            label4.TabIndex = 30;
            label4.Text = "Add Grade";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // save_btn
            // 
            save_btn.Active = false;
            save_btn.Activecolor = Color.FromArgb(60, 64, 98);
            save_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            save_btn.BackColor = Color.FromArgb(42, 89, 53);
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
            save_btn.Location = new Point(434, 334);
            save_btn.Margin = new Padding(4, 4, 4, 4);
            save_btn.Name = "save_btn";
            save_btn.Normalcolor = Color.FromArgb(42, 89, 53);
            save_btn.OnHovercolor = Color.FromArgb(106, 168, 79);
            save_btn.OnHoverTextColor = Color.FromArgb(43, 47, 84);
            save_btn.Padding = new Padding(8, 5, 8, 5);
            save_btn.RightToLeft = RightToLeft.No;
            save_btn.selected = false;
            save_btn.Size = new Size(122, 33);
            save_btn.TabIndex = 31;
            save_btn.Text = "Save";
            save_btn.TextAlign = ContentAlignment.MiddleCenter;
            save_btn.Textcolor = Color.White;
            save_btn.TextFont = new Font("Poppins Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            save_btn.Click += save_btn_Click;
            // 
            // AddNewGrade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 47, 84);
            ClientSize = new Size(590, 429);
            Controls.Add(save_btn);
            Controls.Add(label4);
            Controls.Add(grade_tb);
            Controls.Add(label3);
            Controls.Add(subject_cbx);
            Controls.Add(label2);
            Controls.Add(term_cbx);
            Controls.Add(label1);
            Controls.Add(student_cbx);
            Controls.Add(fullname_lbl);
            Controls.Add(close_btn);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "AddNewGrade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewGrade";
            Load += AddNewGrade_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse dtg_rad;
        private Label close_btn;
        private Label fullname_lbl;
        private Label label3;
        private ComboBox subject_cbx;
        private Label label2;
        private ComboBox term_cbx;
        private Label label1;
        private ComboBox student_cbx;
        private Bunifu.Framework.UI.BunifuMaterialTextbox grade_tb;
        private Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton save_btn;
    }
}