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
            term_cbx = new ComboBox();
            label1 = new Label();
            subject_cbx = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            grade_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label4 = new Label();
            save_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            sem_cbx = new ComboBox();
            label5 = new Label();
            gradeLevelLbl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label6 = new Label();
            student_cbx = new ComboBox();
            label7 = new Label();
            majorSubject_cbx = new ComboBox();
            label8 = new Label();
            cancel_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            SuspendLayout();
            // 
            // dtg_rad
            // 
            dtg_rad.ElipseRadius = 10;
            dtg_rad.TargetControl = this;
            // 
            // close_btn
            // 
            close_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close_btn.AutoSize = true;
            close_btn.Cursor = Cursors.Hand;
            close_btn.Font = new Font("Poppins Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            close_btn.ForeColor = Color.WhiteSmoke;
            close_btn.Location = new Point(1294, 8);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(37, 50);
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
            fullname_lbl.Location = new Point(49, 121);
            fullname_lbl.Name = "fullname_lbl";
            fullname_lbl.Size = new Size(174, 36);
            fullname_lbl.TabIndex = 22;
            fullname_lbl.Text = "Choose Student";
            fullname_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // term_cbx
            // 
            term_cbx.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            term_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            term_cbx.FlatStyle = FlatStyle.Flat;
            term_cbx.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            term_cbx.FormattingEnabled = true;
            term_cbx.Items.AddRange(new object[] { "Mid Term", "Final Term" });
            term_cbx.Location = new Point(46, 317);
            term_cbx.Name = "term_cbx";
            term_cbx.Size = new Size(605, 50);
            term_cbx.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(49, 271);
            label1.Name = "label1";
            label1.Size = new Size(66, 36);
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
            subject_cbx.Location = new Point(692, 314);
            subject_cbx.Name = "subject_cbx";
            subject_cbx.Size = new Size(605, 50);
            subject_cbx.TabIndex = 27;
            subject_cbx.SelectedIndexChanged += subject_cbx_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(692, 271);
            label2.Name = "label2";
            label2.Size = new Size(90, 36);
            label2.TabIndex = 26;
            label2.Text = "Subject";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(49, 523);
            label3.Name = "label3";
            label3.Size = new Size(78, 36);
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
            grade_tb.Location = new Point(46, 558);
            grade_tb.Margin = new Padding(6, 8, 6, 8);
            grade_tb.MaxLength = 32767;
            grade_tb.Name = "grade_tb";
            grade_tb.Size = new Size(605, 58);
            grade_tb.TabIndex = 29;
            grade_tb.TextAlign = HorizontalAlignment.Left;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Medium", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(47, 33);
            label4.Name = "label4";
            label4.Size = new Size(208, 56);
            label4.TabIndex = 30;
            label4.Text = "Add Grade";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // save_btn
            // 
            save_btn.Active = false;
            save_btn.Activecolor = Color.FromArgb(60, 64, 98);
            save_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            save_btn.BackColor = Color.FromArgb(129, 142, 254);
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
            save_btn.Location = new Point(692, 558);
            save_btn.Margin = new Padding(6, 7, 6, 7);
            save_btn.Name = "save_btn";
            save_btn.Normalcolor = Color.FromArgb(129, 142, 254);
            save_btn.OnHovercolor = Color.FromArgb(86, 94, 169);
            save_btn.OnHoverTextColor = Color.WhiteSmoke;
            save_btn.Padding = new Padding(11, 8, 11, 8);
            save_btn.RightToLeft = RightToLeft.No;
            save_btn.selected = false;
            save_btn.Size = new Size(290, 58);
            save_btn.TabIndex = 31;
            save_btn.Text = "Save";
            save_btn.TextAlign = ContentAlignment.MiddleCenter;
            save_btn.Textcolor = Color.White;
            save_btn.TextFont = new Font("Poppins Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            save_btn.Click += save_btn_Click;
            // 
            // sem_cbx
            // 
            sem_cbx.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sem_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            sem_cbx.FlatStyle = FlatStyle.Flat;
            sem_cbx.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sem_cbx.FormattingEnabled = true;
            sem_cbx.Items.AddRange(new object[] { "1", "2" });
            sem_cbx.Location = new Point(692, 164);
            sem_cbx.Name = "sem_cbx";
            sem_cbx.Size = new Size(605, 50);
            sem_cbx.TabIndex = 33;
            sem_cbx.SelectedIndexChanged += sem_cbx_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(692, 121);
            label5.Name = "label5";
            label5.Size = new Size(60, 36);
            label5.TabIndex = 32;
            label5.Text = "Sem";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gradeLevelLbl
            // 
            gradeLevelLbl.AutoCompleteMode = AutoCompleteMode.None;
            gradeLevelLbl.AutoCompleteSource = AutoCompleteSource.None;
            gradeLevelLbl.characterCasing = CharacterCasing.Normal;
            gradeLevelLbl.Enabled = false;
            gradeLevelLbl.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            gradeLevelLbl.ForeColor = Color.WhiteSmoke;
            gradeLevelLbl.HintForeColor = Color.WhiteSmoke;
            gradeLevelLbl.HintText = "";
            gradeLevelLbl.isPassword = false;
            gradeLevelLbl.LineFocusedColor = Color.Gainsboro;
            gradeLevelLbl.LineIdleColor = Color.WhiteSmoke;
            gradeLevelLbl.LineMouseHoverColor = Color.Gainsboro;
            gradeLevelLbl.LineThickness = 1;
            gradeLevelLbl.Location = new Point(46, 433);
            gradeLevelLbl.Margin = new Padding(6, 8, 6, 8);
            gradeLevelLbl.MaxLength = 32767;
            gradeLevelLbl.Name = "gradeLevelLbl";
            gradeLevelLbl.Size = new Size(605, 58);
            gradeLevelLbl.TabIndex = 35;
            gradeLevelLbl.TextAlign = HorizontalAlignment.Left;
            gradeLevelLbl.OnValueChanged += gradeLevelLbl_OnValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(49, 396);
            label6.Name = "label6";
            label6.Size = new Size(132, 36);
            label6.TabIndex = 34;
            label6.Text = "Grade Level";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // student_cbx
            // 
            student_cbx.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            student_cbx.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            student_cbx.FormattingEnabled = true;
            student_cbx.Items.AddRange(new object[] { "1", "2" });
            student_cbx.Location = new Point(46, 164);
            student_cbx.Name = "student_cbx";
            student_cbx.Size = new Size(605, 50);
            student_cbx.TabIndex = 36;
            student_cbx.SelectedIndexChanged += student_cbx_SelectedIndexChanged_1;
            student_cbx.Validated += student_cbx_Validated;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(49, 223);
            label7.Name = "label7";
            label7.Size = new Size(200, 28);
            label7.TabIndex = 37;
            label7.Text = "(ex: juan cruz dela cruz)";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // majorSubject_cbx
            // 
            majorSubject_cbx.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            majorSubject_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            majorSubject_cbx.FlatStyle = FlatStyle.Flat;
            majorSubject_cbx.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            majorSubject_cbx.FormattingEnabled = true;
            majorSubject_cbx.Location = new Point(692, 439);
            majorSubject_cbx.Name = "majorSubject_cbx";
            majorSubject_cbx.Size = new Size(605, 50);
            majorSubject_cbx.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(692, 396);
            label8.Name = "label8";
            label8.Size = new Size(151, 36);
            label8.TabIndex = 38;
            label8.Text = "Major Subject";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cancel_btn
            // 
            cancel_btn.Active = false;
            cancel_btn.Activecolor = Color.FromArgb(60, 64, 98);
            cancel_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cancel_btn.BackColor = Color.FromArgb(255, 67, 67);
            cancel_btn.BackgroundImageLayout = ImageLayout.Stretch;
            cancel_btn.BorderRadius = 5;
            cancel_btn.ButtonText = "Cancel";
            cancel_btn.DisabledColor = Color.Gray;
            cancel_btn.Iconcolor = Color.Transparent;
            cancel_btn.Iconimage = null;
            cancel_btn.Iconimage_right = null;
            cancel_btn.Iconimage_right_Selected = null;
            cancel_btn.Iconimage_Selected = null;
            cancel_btn.IconMarginLeft = 0;
            cancel_btn.IconMarginRight = 0;
            cancel_btn.IconRightVisible = true;
            cancel_btn.IconRightZoom = 40D;
            cancel_btn.IconVisible = false;
            cancel_btn.IconZoom = 40D;
            cancel_btn.IsTab = false;
            cancel_btn.Location = new Point(1007, 558);
            cancel_btn.Margin = new Padding(6, 7, 6, 7);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Normalcolor = Color.FromArgb(255, 67, 67);
            cancel_btn.OnHovercolor = Color.FromArgb(255, 129, 129);
            cancel_btn.OnHoverTextColor = Color.WhiteSmoke;
            cancel_btn.Padding = new Padding(11, 8, 11, 8);
            cancel_btn.RightToLeft = RightToLeft.No;
            cancel_btn.selected = false;
            cancel_btn.Size = new Size(290, 58);
            cancel_btn.TabIndex = 40;
            cancel_btn.Text = "Cancel";
            cancel_btn.TextAlign = ContentAlignment.MiddleCenter;
            cancel_btn.Textcolor = Color.White;
            cancel_btn.TextFont = new Font("Poppins Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cancel_btn.Click += cancel_btn_Click;
            // 
            // AddNewGrade
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 47, 84);
            ClientSize = new Size(1343, 700);
            Controls.Add(cancel_btn);
            Controls.Add(majorSubject_cbx);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(student_cbx);
            Controls.Add(gradeLevelLbl);
            Controls.Add(label6);
            Controls.Add(sem_cbx);
            Controls.Add(label5);
            Controls.Add(save_btn);
            Controls.Add(label4);
            Controls.Add(grade_tb);
            Controls.Add(label3);
            Controls.Add(subject_cbx);
            Controls.Add(label2);
            Controls.Add(term_cbx);
            Controls.Add(label1);
            Controls.Add(fullname_lbl);
            Controls.Add(close_btn);
            FormBorderStyle = FormBorderStyle.None;
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
        private Bunifu.Framework.UI.BunifuMaterialTextbox grade_tb;
        private Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton save_btn;
        private ComboBox sem_cbx;
        private Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox gradeLevelLbl;
        private Label label6;
        private ComboBox student_cbx;
        private Label label7;
        private ComboBox majorSubject_cbx;
        private Label label8;
        private Bunifu.Framework.UI.BunifuFlatButton cancel_btn;
    }
}