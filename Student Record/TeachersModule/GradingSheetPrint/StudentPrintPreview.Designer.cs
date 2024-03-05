namespace Student_Record.TeachersModule.GradingSheetPrint
{
    partial class StudentPrintPreview
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentPrintPreview));
            printBtn = new PictureBox();
            print_panel = new Panel();
            student_dtg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            id = new DataGridViewTextBoxColumn();
            no = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            lrn = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            dob = new DataGridViewTextBoxColumn();
            father = new DataGridViewTextBoxColumn();
            mother = new DataGridViewTextBoxColumn();
            guardian = new DataGridViewTextBoxColumn();
            last_school = new DataGridViewTextBoxColumn();
            major = new DataGridViewTextBoxColumn();
            contact = new DataGridViewTextBoxColumn();
            title_lbl = new Label();
            label6 = new Label();
            section_lbl = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            section_cbx = new ComboBox();
            grade_lvl_cbx = new ComboBox();
            label5 = new Label();
            print_tp = new ToolTip(components);
            download_btn = new Label();
            ((System.ComponentModel.ISupportInitialize)printBtn).BeginInit();
            print_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)student_dtg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // printBtn
            // 
            printBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            printBtn.Image = Properties.Resources.print_icon;
            printBtn.Location = new Point(888, 7);
            printBtn.Margin = new Padding(2, 2, 2, 2);
            printBtn.Name = "printBtn";
            printBtn.Size = new Size(18, 15);
            printBtn.SizeMode = PictureBoxSizeMode.Zoom;
            printBtn.TabIndex = 5;
            printBtn.TabStop = false;
            printBtn.Click += printBtn_Click;
            // 
            // print_panel
            // 
            print_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            print_panel.BackColor = Color.White;
            print_panel.Controls.Add(student_dtg);
            print_panel.Controls.Add(title_lbl);
            print_panel.Controls.Add(label6);
            print_panel.Controls.Add(section_lbl);
            print_panel.Controls.Add(label3);
            print_panel.Controls.Add(label2);
            print_panel.Controls.Add(label1);
            print_panel.Controls.Add(pictureBox1);
            print_panel.Location = new Point(8, 41);
            print_panel.Margin = new Padding(2, 2, 2, 2);
            print_panel.MaximumSize = new Size(897, 0);
            print_panel.MinimumSize = new Size(897, 581);
            print_panel.Name = "print_panel";
            print_panel.Size = new Size(897, 702);
            print_panel.TabIndex = 4;
            // 
            // student_dtg
            // 
            student_dtg.AllowUserToAddRows = false;
            student_dtg.AllowUserToDeleteRows = false;
            student_dtg.AllowUserToResizeColumns = false;
            student_dtg.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            student_dtg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            student_dtg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            student_dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            student_dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            student_dtg.BackgroundColor = Color.White;
            student_dtg.BorderStyle = BorderStyle.None;
            student_dtg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Poppins Medium", 6F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            student_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            student_dtg.ColumnHeadersHeight = 54;
            student_dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            student_dtg.Columns.AddRange(new DataGridViewColumn[] { id, no, name, lrn, address, dob, father, mother, guardian, last_school, major, contact });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Poppins", 5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle3.Padding = new Padding(7);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            student_dtg.DefaultCellStyle = dataGridViewCellStyle3;
            student_dtg.DoubleBuffered = true;
            student_dtg.EnableHeadersVisualStyles = false;
            student_dtg.GridColor = Color.FromArgb(43, 47, 84);
            student_dtg.HeaderBgColor = Color.White;
            student_dtg.HeaderForeColor = Color.FromArgb(43, 47, 84);
            student_dtg.Location = new Point(12, 209);
            student_dtg.Margin = new Padding(2, 2, 2, 2);
            student_dtg.Name = "student_dtg";
            student_dtg.ReadOnly = true;
            student_dtg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            student_dtg.RowHeadersVisible = false;
            student_dtg.RowHeadersWidth = 62;
            student_dtg.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            student_dtg.RowTemplate.Height = 33;
            student_dtg.SelectionMode = DataGridViewSelectionMode.CellSelect;
            student_dtg.ShowCellErrors = false;
            student_dtg.ShowEditingIcon = false;
            student_dtg.ShowRowErrors = false;
            student_dtg.Size = new Size(874, 481);
            student_dtg.TabIndex = 11;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // no
            // 
            no.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            no.HeaderText = "NO";
            no.MinimumWidth = 8;
            no.Name = "no";
            no.ReadOnly = true;
            no.Width = 55;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "NAME OF STUDENTS";
            name.MinimumWidth = 8;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // lrn
            // 
            lrn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lrn.HeaderText = "LRN";
            lrn.MinimumWidth = 8;
            lrn.Name = "lrn";
            lrn.ReadOnly = true;
            // 
            // address
            // 
            address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            address.HeaderText = "ADDRESS";
            address.MinimumWidth = 8;
            address.Name = "address";
            address.ReadOnly = true;
            // 
            // dob
            // 
            dob.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dob.HeaderText = "DATE OF BIRTH";
            dob.MinimumWidth = 8;
            dob.Name = "dob";
            dob.ReadOnly = true;
            // 
            // father
            // 
            father.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            father.HeaderText = "FATHER";
            father.MinimumWidth = 8;
            father.Name = "father";
            father.ReadOnly = true;
            // 
            // mother
            // 
            mother.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mother.HeaderText = "MOTHER";
            mother.MinimumWidth = 8;
            mother.Name = "mother";
            mother.ReadOnly = true;
            // 
            // guardian
            // 
            guardian.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            guardian.HeaderText = "GUARDIAN";
            guardian.MinimumWidth = 8;
            guardian.Name = "guardian";
            guardian.ReadOnly = true;
            // 
            // last_school
            // 
            last_school.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            last_school.HeaderText = "LAST SCHOOL ATTENDED";
            last_school.MinimumWidth = 8;
            last_school.Name = "last_school";
            last_school.ReadOnly = true;
            // 
            // major
            // 
            major.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            major.HeaderText = "MAJOR";
            major.MinimumWidth = 8;
            major.Name = "major";
            major.ReadOnly = true;
            // 
            // contact
            // 
            contact.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            contact.HeaderText = "CONTACT NO.";
            contact.MinimumWidth = 8;
            contact.Name = "contact";
            contact.ReadOnly = true;
            // 
            // title_lbl
            // 
            title_lbl.Anchor = AnchorStyles.Top;
            title_lbl.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            title_lbl.Location = new Point(314, 181);
            title_lbl.Margin = new Padding(2, 0, 2, 0);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(270, 17);
            title_lbl.TabIndex = 9;
            title_lbl.Text = "STUDENT'S PROFILE";
            title_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(314, 158);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(270, 17);
            label6.TabIndex = 8;
            label6.Text = "S.Y. 2022-2023";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // section_lbl
            // 
            section_lbl.Anchor = AnchorStyles.Top;
            section_lbl.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            section_lbl.Location = new Point(314, 140);
            section_lbl.Margin = new Padding(2, 0, 2, 0);
            section_lbl.Name = "section_lbl";
            section_lbl.Size = new Size(270, 17);
            section_lbl.TabIndex = 7;
            section_lbl.Text = "SECTION NAME";
            section_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(345, 117);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(221, 14);
            label3.TabIndex = 5;
            label3.Text = "Schools Division of Occidental Mindoro";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Old English Text MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(384, 104);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 16);
            label2.TabIndex = 4;
            label2.Text = "Department of Education";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Old English Text MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(378, 91);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 16);
            label1.TabIndex = 3;
            label1.Text = "Republic of the Philippines";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.depEd_logo;
            pictureBox1.Location = new Point(403, 7);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(125, 5);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(85, 14);
            label4.TabIndex = 6;
            label4.Text = "Select Section:";
            // 
            // section_cbx
            // 
            section_cbx.Enabled = false;
            section_cbx.FormattingEnabled = true;
            section_cbx.Location = new Point(125, 18);
            section_cbx.Margin = new Padding(2, 2, 2, 2);
            section_cbx.Name = "section_cbx";
            section_cbx.Size = new Size(255, 23);
            section_cbx.TabIndex = 7;
            section_cbx.SelectedIndexChanged += section_cbx_SelectedIndexChanged;
            // 
            // grade_lvl_cbx
            // 
            grade_lvl_cbx.FormattingEnabled = true;
            grade_lvl_cbx.Items.AddRange(new object[] { "11", "12" });
            grade_lvl_cbx.Location = new Point(8, 18);
            grade_lvl_cbx.Margin = new Padding(2, 2, 2, 2);
            grade_lvl_cbx.Name = "grade_lvl_cbx";
            grade_lvl_cbx.Size = new Size(109, 23);
            grade_lvl_cbx.TabIndex = 9;
            grade_lvl_cbx.SelectedIndexChanged += grade_lvl_cbx_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(8, 5);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 14);
            label5.TabIndex = 8;
            label5.Text = "Select Grade:";
            // 
            // download_btn
            // 
            download_btn.AutoSize = true;
            download_btn.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point);
            download_btn.Image = (Image)resources.GetObject("download_btn.Image");
            download_btn.ImageAlign = ContentAlignment.MiddleLeft;
            download_btn.Location = new Point(788, 8);
            download_btn.Margin = new Padding(2, 0, 2, 0);
            download_btn.Name = "download_btn";
            download_btn.Size = new Size(87, 17);
            download_btn.TabIndex = 20;
            download_btn.Text = "      Download";
            download_btn.Click += download_btn_Click;
            // 
            // StudentPrintPreview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 751);
            Controls.Add(download_btn);
            Controls.Add(grade_lvl_cbx);
            Controls.Add(label5);
            Controls.Add(section_cbx);
            Controls.Add(label4);
            Controls.Add(printBtn);
            Controls.Add(print_panel);
            Margin = new Padding(2, 2, 2, 2);
            MinimumSize = new Size(934, 790);
            Name = "StudentPrintPreview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentPrintPreview";
            ((System.ComponentModel.ISupportInitialize)printBtn).EndInit();
            print_panel.ResumeLayout(false);
            print_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)student_dtg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox printBtn;
        private Panel print_panel;
        private Bunifu.Framework.UI.BunifuCustomDataGrid student_dtg;
        private Label title_lbl;
        private Label label6;
        private Label section_lbl;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn no;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn lrn;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn dob;
        private DataGridViewTextBoxColumn father;
        private DataGridViewTextBoxColumn mother;
        private DataGridViewTextBoxColumn guardian;
        private DataGridViewTextBoxColumn last_school;
        private DataGridViewTextBoxColumn major;
        private DataGridViewTextBoxColumn contact;
        private Label label4;
        private ComboBox section_cbx;
        private ComboBox grade_lvl_cbx;
        private Label label5;
        private ToolTip print_tp;
        private Label download_btn;
    }
}