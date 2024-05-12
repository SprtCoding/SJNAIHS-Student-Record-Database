namespace Student_Record.TeachersModule
{
    partial class GradingSheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradingSheet));
            label2 = new Label();
            grading_sheet_dtg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            subject = new DataGridViewTextBoxColumn();
            sem = new DataGridViewTextBoxColumn();
            mid_term = new DataGridViewTextBoxColumn();
            final_term = new DataGridViewTextBoxColumn();
            final_grade = new DataGridViewTextBoxColumn();
            no_data_panel = new Panel();
            loadingLbl = new Label();
            no_data_pb = new PictureBox();
            add_new_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            grade_level_cbx = new ComboBox();
            label5 = new Label();
            subject_cbx = new ComboBox();
            label1 = new Label();
            printGradeBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            submitReportBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            toolTip1 = new ToolTip(components);
            sem_cbx = new ComboBox();
            label3 = new Label();
            majorSubTb = new ComboBox();
            majorSubLbl = new Label();
            genBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)grading_sheet_dtg).BeginInit();
            no_data_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)no_data_pb).BeginInit();
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
            label2.Size = new Size(166, 30);
            label2.TabIndex = 8;
            label2.Text = "Grading Sheet";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grading_sheet_dtg
            // 
            grading_sheet_dtg.AllowUserToAddRows = false;
            grading_sheet_dtg.AllowUserToDeleteRows = false;
            grading_sheet_dtg.AllowUserToResizeColumns = false;
            grading_sheet_dtg.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle1.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(43, 47, 84);
            grading_sheet_dtg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grading_sheet_dtg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grading_sheet_dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grading_sheet_dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grading_sheet_dtg.BackgroundColor = SystemColors.Control;
            grading_sheet_dtg.BorderStyle = BorderStyle.None;
            grading_sheet_dtg.CellBorderStyle = DataGridViewCellBorderStyle.None;
            grading_sheet_dtg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle2.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Padding = new Padding(15);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grading_sheet_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grading_sheet_dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grading_sheet_dtg.Columns.AddRange(new DataGridViewColumn[] { id, name, subject, sem, mid_term, final_term, final_grade });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle3.Padding = new Padding(15);
            dataGridViewCellStyle3.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            grading_sheet_dtg.DefaultCellStyle = dataGridViewCellStyle3;
            grading_sheet_dtg.DoubleBuffered = true;
            grading_sheet_dtg.EnableHeadersVisualStyles = false;
            grading_sheet_dtg.GridColor = Color.FromArgb(60, 64, 98);
            grading_sheet_dtg.HeaderBgColor = Color.FromArgb(43, 47, 84);
            grading_sheet_dtg.HeaderForeColor = Color.WhiteSmoke;
            grading_sheet_dtg.Location = new Point(8, 190);
            grading_sheet_dtg.Margin = new Padding(2);
            grading_sheet_dtg.Name = "grading_sheet_dtg";
            grading_sheet_dtg.ReadOnly = true;
            grading_sheet_dtg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grading_sheet_dtg.RowHeadersVisible = false;
            grading_sheet_dtg.RowHeadersWidth = 62;
            grading_sheet_dtg.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            grading_sheet_dtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grading_sheet_dtg.ShowCellErrors = false;
            grading_sheet_dtg.ShowEditingIcon = false;
            grading_sheet_dtg.ShowRowErrors = false;
            grading_sheet_dtg.Size = new Size(773, 260);
            grading_sheet_dtg.TabIndex = 10;
            grading_sheet_dtg.CellContentClick += student_dtg_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "NAME";
            name.MinimumWidth = 8;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // subject
            // 
            subject.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subject.HeaderText = "SUBJECT";
            subject.MinimumWidth = 8;
            subject.Name = "subject";
            subject.ReadOnly = true;
            // 
            // sem
            // 
            sem.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sem.HeaderText = "SEMESTER";
            sem.MinimumWidth = 8;
            sem.Name = "sem";
            sem.ReadOnly = true;
            // 
            // mid_term
            // 
            mid_term.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mid_term.HeaderText = "MID TERM";
            mid_term.MinimumWidth = 8;
            mid_term.Name = "mid_term";
            mid_term.ReadOnly = true;
            // 
            // final_term
            // 
            final_term.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            final_term.HeaderText = "FINAL TERM";
            final_term.MinimumWidth = 8;
            final_term.Name = "final_term";
            final_term.ReadOnly = true;
            // 
            // final_grade
            // 
            final_grade.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            final_grade.HeaderText = "FINAL GRADE";
            final_grade.MinimumWidth = 8;
            final_grade.Name = "final_grade";
            final_grade.ReadOnly = true;
            // 
            // no_data_panel
            // 
            no_data_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            no_data_panel.Controls.Add(loadingLbl);
            no_data_panel.Controls.Add(no_data_pb);
            no_data_panel.Location = new Point(8, 190);
            no_data_panel.Margin = new Padding(2);
            no_data_panel.Name = "no_data_panel";
            no_data_panel.Size = new Size(773, 260);
            no_data_panel.TabIndex = 24;
            // 
            // loadingLbl
            // 
            loadingLbl.Anchor = AnchorStyles.None;
            loadingLbl.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            loadingLbl.ForeColor = Color.FromArgb(60, 64, 98);
            loadingLbl.Location = new Point(100, 174);
            loadingLbl.Margin = new Padding(2, 0, 2, 0);
            loadingLbl.Name = "loadingLbl";
            loadingLbl.Size = new Size(573, 23);
            loadingLbl.TabIndex = 19;
            loadingLbl.Text = "No data found!";
            loadingLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // no_data_pb
            // 
            no_data_pb.Anchor = AnchorStyles.None;
            no_data_pb.Image = (Image)resources.GetObject("no_data_pb.Image");
            no_data_pb.Location = new Point(234, 51);
            no_data_pb.Margin = new Padding(2);
            no_data_pb.Name = "no_data_pb";
            no_data_pb.Size = new Size(304, 131);
            no_data_pb.SizeMode = PictureBoxSizeMode.Zoom;
            no_data_pb.TabIndex = 0;
            no_data_pb.TabStop = false;
            no_data_pb.Visible = false;
            // 
            // add_new_btn
            // 
            add_new_btn.Active = false;
            add_new_btn.Activecolor = Color.FromArgb(60, 64, 98);
            add_new_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            add_new_btn.BackColor = Color.FromArgb(43, 47, 84);
            add_new_btn.BackgroundImageLayout = ImageLayout.Stretch;
            add_new_btn.BorderRadius = 5;
            add_new_btn.ButtonText = "";
            add_new_btn.DisabledColor = Color.Gray;
            add_new_btn.Iconcolor = Color.Transparent;
            add_new_btn.Iconimage = Properties.Resources.add_white;
            add_new_btn.Iconimage_right = null;
            add_new_btn.Iconimage_right_Selected = null;
            add_new_btn.Iconimage_Selected = null;
            add_new_btn.IconMarginLeft = 0;
            add_new_btn.IconMarginRight = 0;
            add_new_btn.IconRightVisible = false;
            add_new_btn.IconRightZoom = 40D;
            add_new_btn.IconVisible = true;
            add_new_btn.IconZoom = 40D;
            add_new_btn.IsTab = false;
            add_new_btn.Location = new Point(746, 10);
            add_new_btn.Margin = new Padding(4);
            add_new_btn.MaximumSize = new Size(35, 30);
            add_new_btn.MinimumSize = new Size(35, 30);
            add_new_btn.Name = "add_new_btn";
            add_new_btn.Normalcolor = Color.FromArgb(43, 47, 84);
            add_new_btn.OnHovercolor = Color.FromArgb(60, 64, 98);
            add_new_btn.OnHoverTextColor = Color.White;
            add_new_btn.Padding = new Padding(7, 6, 7, 6);
            add_new_btn.RightToLeft = RightToLeft.No;
            add_new_btn.selected = false;
            add_new_btn.Size = new Size(35, 30);
            add_new_btn.TabIndex = 17;
            add_new_btn.TextAlign = ContentAlignment.MiddleRight;
            add_new_btn.Textcolor = Color.White;
            add_new_btn.TextFont = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            add_new_btn.Click += add_new_btn_Click;
            add_new_btn.MouseEnter += add_new_btn_MouseEnter;
            // 
            // grade_level_cbx
            // 
            grade_level_cbx.BackColor = Color.FromArgb(43, 47, 84);
            grade_level_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            grade_level_cbx.FlatStyle = FlatStyle.Flat;
            grade_level_cbx.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grade_level_cbx.ForeColor = Color.WhiteSmoke;
            grade_level_cbx.FormattingEnabled = true;
            grade_level_cbx.Items.AddRange(new object[] { "Any", "11", "12" });
            grade_level_cbx.Location = new Point(8, 80);
            grade_level_cbx.Margin = new Padding(2);
            grade_level_cbx.Name = "grade_level_cbx";
            grade_level_cbx.Size = new Size(171, 36);
            grade_level_cbx.TabIndex = 37;
            grade_level_cbx.SelectedIndexChanged += grade_level_cbx_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Poppins SemiBold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(43, 47, 84);
            label5.Location = new Point(8, 56);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(142, 25);
            label5.TabIndex = 36;
            label5.Text = "Select Grade Level";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // subject_cbx
            // 
            subject_cbx.BackColor = Color.FromArgb(43, 47, 84);
            subject_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            subject_cbx.FlatStyle = FlatStyle.Flat;
            subject_cbx.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            subject_cbx.ForeColor = Color.WhiteSmoke;
            subject_cbx.FormattingEnabled = true;
            subject_cbx.Location = new Point(8, 146);
            subject_cbx.Margin = new Padding(2);
            subject_cbx.Name = "subject_cbx";
            subject_cbx.Size = new Size(353, 36);
            subject_cbx.TabIndex = 39;
            subject_cbx.SelectedIndexChanged += subject_cbx_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Poppins SemiBold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(43, 47, 84);
            label1.Location = new Point(8, 122);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 38;
            label1.Text = "Select Subject";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // printGradeBtn
            // 
            printGradeBtn.Active = false;
            printGradeBtn.Activecolor = Color.FromArgb(60, 64, 98);
            printGradeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            printGradeBtn.BackColor = Color.FromArgb(43, 47, 84);
            printGradeBtn.BackgroundImageLayout = ImageLayout.Stretch;
            printGradeBtn.BorderRadius = 5;
            printGradeBtn.ButtonText = "";
            printGradeBtn.DisabledColor = Color.Gray;
            printGradeBtn.Iconcolor = Color.Transparent;
            printGradeBtn.Iconimage = (Image)resources.GetObject("printGradeBtn.Iconimage");
            printGradeBtn.Iconimage_right = null;
            printGradeBtn.Iconimage_right_Selected = null;
            printGradeBtn.Iconimage_Selected = null;
            printGradeBtn.IconMarginLeft = 0;
            printGradeBtn.IconMarginRight = 0;
            printGradeBtn.IconRightVisible = false;
            printGradeBtn.IconRightZoom = 40D;
            printGradeBtn.IconVisible = true;
            printGradeBtn.IconZoom = 30D;
            printGradeBtn.IsTab = false;
            printGradeBtn.Location = new Point(703, 10);
            printGradeBtn.Margin = new Padding(4);
            printGradeBtn.MaximumSize = new Size(35, 30);
            printGradeBtn.MinimumSize = new Size(35, 30);
            printGradeBtn.Name = "printGradeBtn";
            printGradeBtn.Normalcolor = Color.FromArgb(43, 47, 84);
            printGradeBtn.OnHovercolor = Color.FromArgb(60, 64, 98);
            printGradeBtn.OnHoverTextColor = Color.White;
            printGradeBtn.Padding = new Padding(7, 6, 7, 6);
            printGradeBtn.RightToLeft = RightToLeft.No;
            printGradeBtn.selected = false;
            printGradeBtn.Size = new Size(35, 30);
            printGradeBtn.TabIndex = 41;
            printGradeBtn.TextAlign = ContentAlignment.MiddleRight;
            printGradeBtn.Textcolor = Color.White;
            printGradeBtn.TextFont = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            printGradeBtn.Click += printGradeBtn_Click;
            printGradeBtn.MouseEnter += printGradeBtn_MouseEnter;
            // 
            // submitReportBtn
            // 
            submitReportBtn.Active = false;
            submitReportBtn.Activecolor = Color.FromArgb(60, 64, 98);
            submitReportBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            submitReportBtn.BackColor = Color.FromArgb(43, 47, 84);
            submitReportBtn.BackgroundImageLayout = ImageLayout.Stretch;
            submitReportBtn.BorderRadius = 5;
            submitReportBtn.ButtonText = "";
            submitReportBtn.DisabledColor = Color.Gray;
            submitReportBtn.Iconcolor = Color.Transparent;
            submitReportBtn.Iconimage = (Image)resources.GetObject("submitReportBtn.Iconimage");
            submitReportBtn.Iconimage_right = null;
            submitReportBtn.Iconimage_right_Selected = null;
            submitReportBtn.Iconimage_Selected = null;
            submitReportBtn.IconMarginLeft = 0;
            submitReportBtn.IconMarginRight = 0;
            submitReportBtn.IconRightVisible = false;
            submitReportBtn.IconRightZoom = 40D;
            submitReportBtn.IconVisible = true;
            submitReportBtn.IconZoom = 30D;
            submitReportBtn.IsTab = false;
            submitReportBtn.Location = new Point(659, 10);
            submitReportBtn.Margin = new Padding(4);
            submitReportBtn.MaximumSize = new Size(35, 30);
            submitReportBtn.MinimumSize = new Size(35, 30);
            submitReportBtn.Name = "submitReportBtn";
            submitReportBtn.Normalcolor = Color.FromArgb(43, 47, 84);
            submitReportBtn.OnHovercolor = Color.FromArgb(60, 64, 98);
            submitReportBtn.OnHoverTextColor = Color.White;
            submitReportBtn.Padding = new Padding(7, 6, 7, 6);
            submitReportBtn.RightToLeft = RightToLeft.No;
            submitReportBtn.selected = false;
            submitReportBtn.Size = new Size(35, 30);
            submitReportBtn.TabIndex = 43;
            submitReportBtn.TextAlign = ContentAlignment.MiddleRight;
            submitReportBtn.Textcolor = Color.White;
            submitReportBtn.TextFont = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            submitReportBtn.Click += submitReportBtn_Click;
            submitReportBtn.MouseEnter += submitReportBtn_MouseEnter;
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            // 
            // sem_cbx
            // 
            sem_cbx.BackColor = Color.FromArgb(43, 47, 84);
            sem_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            sem_cbx.FlatStyle = FlatStyle.Flat;
            sem_cbx.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sem_cbx.ForeColor = Color.WhiteSmoke;
            sem_cbx.FormattingEnabled = true;
            sem_cbx.Items.AddRange(new object[] { "1st", "2nd" });
            sem_cbx.Location = new Point(190, 80);
            sem_cbx.Margin = new Padding(2);
            sem_cbx.Name = "sem_cbx";
            sem_cbx.Size = new Size(171, 36);
            sem_cbx.TabIndex = 45;
            sem_cbx.SelectedIndexChanged += sem_cbx_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Poppins SemiBold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(43, 47, 84);
            label3.Location = new Point(190, 56);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 44;
            label3.Text = "Semester";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // majorSubTb
            // 
            majorSubTb.BackColor = Color.FromArgb(43, 47, 84);
            majorSubTb.DropDownStyle = ComboBoxStyle.DropDownList;
            majorSubTb.FlatStyle = FlatStyle.Flat;
            majorSubTb.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            majorSubTb.ForeColor = Color.WhiteSmoke;
            majorSubTb.FormattingEnabled = true;
            majorSubTb.Location = new Point(377, 146);
            majorSubTb.Margin = new Padding(2);
            majorSubTb.Name = "majorSubTb";
            majorSubTb.Size = new Size(353, 36);
            majorSubTb.TabIndex = 47;
            majorSubTb.Visible = false;
            majorSubTb.SelectedIndexChanged += majorSubTb_SelectedIndexChanged;
            // 
            // majorSubLbl
            // 
            majorSubLbl.AutoSize = true;
            majorSubLbl.BackColor = SystemColors.Control;
            majorSubLbl.Font = new Font("Poppins SemiBold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            majorSubLbl.ForeColor = Color.FromArgb(43, 47, 84);
            majorSubLbl.Location = new Point(377, 122);
            majorSubLbl.Margin = new Padding(2, 0, 2, 0);
            majorSubLbl.Name = "majorSubLbl";
            majorSubLbl.Size = new Size(109, 25);
            majorSubLbl.TabIndex = 46;
            majorSubLbl.Text = "Major Subject";
            majorSubLbl.TextAlign = ContentAlignment.MiddleCenter;
            majorSubLbl.Visible = false;
            // 
            // genBtn
            // 
            genBtn.Active = false;
            genBtn.Activecolor = Color.FromArgb(60, 64, 98);
            genBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            genBtn.BackColor = Color.FromArgb(43, 47, 84);
            genBtn.BackgroundImageLayout = ImageLayout.Stretch;
            genBtn.BorderRadius = 5;
            genBtn.ButtonText = "";
            genBtn.DisabledColor = Color.Gray;
            genBtn.Iconcolor = Color.Transparent;
            genBtn.Iconimage = (Image)resources.GetObject("genBtn.Iconimage");
            genBtn.Iconimage_right = null;
            genBtn.Iconimage_right_Selected = null;
            genBtn.Iconimage_Selected = null;
            genBtn.IconMarginLeft = 0;
            genBtn.IconMarginRight = 0;
            genBtn.IconRightVisible = false;
            genBtn.IconRightZoom = 40D;
            genBtn.IconVisible = true;
            genBtn.IconZoom = 30D;
            genBtn.IsTab = false;
            genBtn.Location = new Point(616, 10);
            genBtn.Margin = new Padding(4);
            genBtn.MaximumSize = new Size(35, 30);
            genBtn.MinimumSize = new Size(35, 30);
            genBtn.Name = "genBtn";
            genBtn.Normalcolor = Color.FromArgb(43, 47, 84);
            genBtn.OnHovercolor = Color.FromArgb(60, 64, 98);
            genBtn.OnHoverTextColor = Color.White;
            genBtn.Padding = new Padding(7, 6, 7, 6);
            genBtn.RightToLeft = RightToLeft.No;
            genBtn.selected = false;
            genBtn.Size = new Size(35, 30);
            genBtn.TabIndex = 52;
            genBtn.TextAlign = ContentAlignment.MiddleRight;
            genBtn.Textcolor = Color.White;
            genBtn.TextFont = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            genBtn.Click += genBtn_Click;
            genBtn.MouseEnter += genBtn_MouseEnter;
            // 
            // GradingSheet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 461);
            Controls.Add(genBtn);
            Controls.Add(majorSubTb);
            Controls.Add(majorSubLbl);
            Controls.Add(sem_cbx);
            Controls.Add(label3);
            Controls.Add(submitReportBtn);
            Controls.Add(printGradeBtn);
            Controls.Add(subject_cbx);
            Controls.Add(label1);
            Controls.Add(grade_level_cbx);
            Controls.Add(label5);
            Controls.Add(no_data_panel);
            Controls.Add(add_new_btn);
            Controls.Add(grading_sheet_dtg);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "GradingSheet";
            Text = "GradingSheet";
            ((System.ComponentModel.ISupportInitialize)grading_sheet_dtg).EndInit();
            no_data_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)no_data_pb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grading_sheet_dtg;
        private Panel no_data_panel;
        private Label loadingLbl;
        private PictureBox no_data_pb;
        private Bunifu.Framework.UI.BunifuFlatButton add_new_btn;
        private ComboBox grade_level_cbx;
        private Label label5;
        private ComboBox subject_cbx;
        private Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton printGradeBtn;
        private Bunifu.Framework.UI.BunifuFlatButton submitReportBtn;
        private ToolTip toolTip1;
        private ComboBox sem_cbx;
        private Label label3;
        private ComboBox majorSubTb;
        private Label majorSubLbl;
        private Bunifu.Framework.UI.BunifuFlatButton genBtn;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn sem;
        private DataGridViewTextBoxColumn mid_term;
        private DataGridViewTextBoxColumn final_term;
        private DataGridViewTextBoxColumn final_grade;
    }
}