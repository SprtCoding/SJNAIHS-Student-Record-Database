namespace Student_Record.TeachersModule
{
    partial class StudentGradingSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentGradingSummary));
            label2 = new Label();
            grading_summary_dtg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            mid_grade_filter = new Bunifu.Framework.UI.BunifuFlatButton();
            final_term_grade_filter = new Bunifu.Framework.UI.BunifuFlatButton();
            no_data_panel = new Panel();
            loadingLbl = new Label();
            no_data_pb = new PictureBox();
            sem_cbx = new ComboBox();
            label5 = new Label();
            submitReportBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            printGradeBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            toolTip1 = new ToolTip(components);
            grade_level_cbx = new ComboBox();
            label1 = new Label();
            section_cbx = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)grading_summary_dtg).BeginInit();
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
            label2.Size = new Size(301, 30);
            label2.TabIndex = 9;
            label2.Text = "Student Grading Summary";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grading_summary_dtg
            // 
            grading_summary_dtg.AllowUserToAddRows = false;
            grading_summary_dtg.AllowUserToDeleteRows = false;
            grading_summary_dtg.AllowUserToResizeColumns = false;
            grading_summary_dtg.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle1.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(43, 47, 84);
            grading_summary_dtg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grading_summary_dtg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grading_summary_dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grading_summary_dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grading_summary_dtg.BackgroundColor = SystemColors.Control;
            grading_summary_dtg.BorderStyle = BorderStyle.None;
            grading_summary_dtg.CellBorderStyle = DataGridViewCellBorderStyle.None;
            grading_summary_dtg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle2.Font = new Font("Poppins Medium", 6F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grading_summary_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grading_summary_dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Poppins", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle3.Padding = new Padding(15);
            dataGridViewCellStyle3.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            grading_summary_dtg.DefaultCellStyle = dataGridViewCellStyle3;
            grading_summary_dtg.DoubleBuffered = true;
            grading_summary_dtg.EnableHeadersVisualStyles = false;
            grading_summary_dtg.GridColor = Color.FromArgb(60, 64, 98);
            grading_summary_dtg.HeaderBgColor = Color.FromArgb(43, 47, 84);
            grading_summary_dtg.HeaderForeColor = Color.WhiteSmoke;
            grading_summary_dtg.Location = new Point(8, 157);
            grading_summary_dtg.Margin = new Padding(2, 2, 2, 2);
            grading_summary_dtg.Name = "grading_summary_dtg";
            grading_summary_dtg.ReadOnly = true;
            grading_summary_dtg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grading_summary_dtg.RowHeadersVisible = false;
            grading_summary_dtg.RowHeadersWidth = 62;
            grading_summary_dtg.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            grading_summary_dtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grading_summary_dtg.ShowCellErrors = false;
            grading_summary_dtg.ShowEditingIcon = false;
            grading_summary_dtg.ShowRowErrors = false;
            grading_summary_dtg.Size = new Size(773, 293);
            grading_summary_dtg.TabIndex = 11;
            // 
            // mid_grade_filter
            // 
            mid_grade_filter.Active = false;
            mid_grade_filter.Activecolor = Color.FromArgb(60, 64, 98);
            mid_grade_filter.BackColor = Color.FromArgb(43, 47, 84);
            mid_grade_filter.BackgroundImageLayout = ImageLayout.Stretch;
            mid_grade_filter.BorderRadius = 5;
            mid_grade_filter.ButtonText = "Mid Term";
            mid_grade_filter.DisabledColor = Color.Gray;
            mid_grade_filter.Iconcolor = Color.Transparent;
            mid_grade_filter.Iconimage = null;
            mid_grade_filter.Iconimage_right = null;
            mid_grade_filter.Iconimage_right_Selected = null;
            mid_grade_filter.Iconimage_Selected = null;
            mid_grade_filter.IconMarginLeft = 0;
            mid_grade_filter.IconMarginRight = 0;
            mid_grade_filter.IconRightVisible = true;
            mid_grade_filter.IconRightZoom = 40D;
            mid_grade_filter.IconVisible = false;
            mid_grade_filter.IconZoom = 40D;
            mid_grade_filter.IsTab = false;
            mid_grade_filter.Location = new Point(8, 111);
            mid_grade_filter.Margin = new Padding(4, 4, 4, 4);
            mid_grade_filter.Name = "mid_grade_filter";
            mid_grade_filter.Normalcolor = Color.FromArgb(43, 47, 84);
            mid_grade_filter.OnHovercolor = Color.FromArgb(60, 64, 98);
            mid_grade_filter.OnHoverTextColor = Color.White;
            mid_grade_filter.Padding = new Padding(8, 5, 8, 5);
            mid_grade_filter.RightToLeft = RightToLeft.No;
            mid_grade_filter.selected = false;
            mid_grade_filter.Size = new Size(156, 32);
            mid_grade_filter.TabIndex = 19;
            mid_grade_filter.Text = "Mid Term";
            mid_grade_filter.TextAlign = ContentAlignment.MiddleCenter;
            mid_grade_filter.Textcolor = Color.White;
            mid_grade_filter.TextFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mid_grade_filter.Click += mid_grade_filter_Click;
            // 
            // final_term_grade_filter
            // 
            final_term_grade_filter.Active = false;
            final_term_grade_filter.Activecolor = Color.FromArgb(60, 64, 98);
            final_term_grade_filter.BackColor = Color.FromArgb(43, 47, 84);
            final_term_grade_filter.BackgroundImageLayout = ImageLayout.Stretch;
            final_term_grade_filter.BorderRadius = 5;
            final_term_grade_filter.ButtonText = "Final Term";
            final_term_grade_filter.DisabledColor = Color.Gray;
            final_term_grade_filter.Iconcolor = Color.Transparent;
            final_term_grade_filter.Iconimage = null;
            final_term_grade_filter.Iconimage_right = null;
            final_term_grade_filter.Iconimage_right_Selected = null;
            final_term_grade_filter.Iconimage_Selected = null;
            final_term_grade_filter.IconMarginLeft = 0;
            final_term_grade_filter.IconMarginRight = 0;
            final_term_grade_filter.IconRightVisible = true;
            final_term_grade_filter.IconRightZoom = 40D;
            final_term_grade_filter.IconVisible = false;
            final_term_grade_filter.IconZoom = 40D;
            final_term_grade_filter.IsTab = false;
            final_term_grade_filter.Location = new Point(197, 111);
            final_term_grade_filter.Margin = new Padding(4, 4, 4, 4);
            final_term_grade_filter.Name = "final_term_grade_filter";
            final_term_grade_filter.Normalcolor = Color.FromArgb(43, 47, 84);
            final_term_grade_filter.OnHovercolor = Color.FromArgb(60, 64, 98);
            final_term_grade_filter.OnHoverTextColor = Color.White;
            final_term_grade_filter.Padding = new Padding(8, 5, 8, 5);
            final_term_grade_filter.RightToLeft = RightToLeft.No;
            final_term_grade_filter.selected = false;
            final_term_grade_filter.Size = new Size(156, 32);
            final_term_grade_filter.TabIndex = 20;
            final_term_grade_filter.Text = "Final Term";
            final_term_grade_filter.TextAlign = ContentAlignment.MiddleCenter;
            final_term_grade_filter.Textcolor = Color.White;
            final_term_grade_filter.TextFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            final_term_grade_filter.Click += final_term_grade_filter_Click;
            // 
            // no_data_panel
            // 
            no_data_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            no_data_panel.Controls.Add(loadingLbl);
            no_data_panel.Controls.Add(no_data_pb);
            no_data_panel.Location = new Point(8, 157);
            no_data_panel.Margin = new Padding(2, 2, 2, 2);
            no_data_panel.Name = "no_data_panel";
            no_data_panel.Size = new Size(773, 293);
            no_data_panel.TabIndex = 25;
            // 
            // loadingLbl
            // 
            loadingLbl.Anchor = AnchorStyles.None;
            loadingLbl.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            loadingLbl.ForeColor = Color.FromArgb(60, 64, 98);
            loadingLbl.Location = new Point(99, 190);
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
            no_data_pb.Location = new Point(233, 67);
            no_data_pb.Margin = new Padding(2, 2, 2, 2);
            no_data_pb.Name = "no_data_pb";
            no_data_pb.Size = new Size(304, 131);
            no_data_pb.SizeMode = PictureBoxSizeMode.Zoom;
            no_data_pb.TabIndex = 0;
            no_data_pb.TabStop = false;
            no_data_pb.Visible = false;
            // 
            // sem_cbx
            // 
            sem_cbx.BackColor = Color.FromArgb(43, 47, 84);
            sem_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            sem_cbx.FlatStyle = FlatStyle.Flat;
            sem_cbx.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sem_cbx.ForeColor = Color.WhiteSmoke;
            sem_cbx.FormattingEnabled = true;
            sem_cbx.Items.AddRange(new object[] { "1", "2" });
            sem_cbx.Location = new Point(197, 70);
            sem_cbx.Margin = new Padding(2, 2, 2, 2);
            sem_cbx.Name = "sem_cbx";
            sem_cbx.Size = new Size(176, 36);
            sem_cbx.TabIndex = 35;
            sem_cbx.SelectedIndexChanged += sem_cbx_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Poppins SemiBold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(43, 47, 84);
            label5.Location = new Point(197, 47);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 34;
            label5.Text = "Semester";
            label5.TextAlign = ContentAlignment.MiddleCenter;
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
            submitReportBtn.Location = new Point(701, 10);
            submitReportBtn.Margin = new Padding(4, 4, 4, 4);
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
            submitReportBtn.TabIndex = 45;
            submitReportBtn.TextAlign = ContentAlignment.MiddleRight;
            submitReportBtn.Textcolor = Color.White;
            submitReportBtn.TextFont = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            submitReportBtn.Click += submitReportBtn_Click;
            submitReportBtn.MouseEnter += submitReportBtn_MouseEnter_1;
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
            printGradeBtn.Location = new Point(745, 10);
            printGradeBtn.Margin = new Padding(4, 4, 4, 4);
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
            printGradeBtn.TabIndex = 44;
            printGradeBtn.TextAlign = ContentAlignment.MiddleRight;
            printGradeBtn.Textcolor = Color.White;
            printGradeBtn.TextFont = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            printGradeBtn.Click += printGradeBtn_Click;
            printGradeBtn.MouseEnter += printGradeBtn_MouseEnter;
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            // 
            // grade_level_cbx
            // 
            grade_level_cbx.BackColor = Color.FromArgb(43, 47, 84);
            grade_level_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            grade_level_cbx.FlatStyle = FlatStyle.Flat;
            grade_level_cbx.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grade_level_cbx.ForeColor = Color.WhiteSmoke;
            grade_level_cbx.FormattingEnabled = true;
            grade_level_cbx.Items.AddRange(new object[] { "11", "12" });
            grade_level_cbx.Location = new Point(8, 70);
            grade_level_cbx.Margin = new Padding(2, 2, 2, 2);
            grade_level_cbx.Name = "grade_level_cbx";
            grade_level_cbx.Size = new Size(176, 36);
            grade_level_cbx.TabIndex = 47;
            grade_level_cbx.SelectedIndexChanged += grade_level_cbx_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Poppins SemiBold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(43, 47, 84);
            label1.Location = new Point(8, 47);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 46;
            label1.Text = "Grade Level";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // section_cbx
            // 
            section_cbx.BackColor = Color.FromArgb(43, 47, 84);
            section_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            section_cbx.FlatStyle = FlatStyle.Flat;
            section_cbx.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            section_cbx.ForeColor = Color.WhiteSmoke;
            section_cbx.FormattingEnabled = true;
            section_cbx.Location = new Point(392, 70);
            section_cbx.Margin = new Padding(2, 2, 2, 2);
            section_cbx.Name = "section_cbx";
            section_cbx.Size = new Size(176, 36);
            section_cbx.TabIndex = 49;
            section_cbx.SelectedIndexChanged += section_cbx_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Poppins SemiBold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(43, 47, 84);
            label3.Location = new Point(392, 47);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 48;
            label3.Text = "Section";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StudentGradingSummary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 461);
            Controls.Add(section_cbx);
            Controls.Add(label3);
            Controls.Add(grade_level_cbx);
            Controls.Add(label1);
            Controls.Add(submitReportBtn);
            Controls.Add(printGradeBtn);
            Controls.Add(sem_cbx);
            Controls.Add(label5);
            Controls.Add(no_data_panel);
            Controls.Add(final_term_grade_filter);
            Controls.Add(mid_grade_filter);
            Controls.Add(grading_summary_dtg);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentGradingSummary";
            Text = "StudentGradingSummary";
            Load += StudentGradingSummary_Load;
            ((System.ComponentModel.ISupportInitialize)grading_summary_dtg).EndInit();
            no_data_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)no_data_pb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grading_summary_dtg;
        private Bunifu.Framework.UI.BunifuFlatButton mid_grade_filter;
        private Bunifu.Framework.UI.BunifuFlatButton final_term_grade_filter;
        private Panel no_data_panel;
        private Label loadingLbl;
        private PictureBox no_data_pb;
        private ComboBox sem_cbx;
        private Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton submitReportBtn;
        private Bunifu.Framework.UI.BunifuFlatButton printGradeBtn;
        private ToolTip toolTip1;
        private ComboBox grade_level_cbx;
        private Label label1;
        private ComboBox section_cbx;
        private Label label3;
    }
}