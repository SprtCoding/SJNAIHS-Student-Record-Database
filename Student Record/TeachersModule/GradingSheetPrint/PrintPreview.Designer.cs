namespace Student_Record.TeachersModule.GradingSheetPrint
{
    partial class PrintPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintPreview));
            print_panel = new Panel();
            grading_sheet_dtg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            id = new DataGridViewTextBoxColumn();
            no = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            mid_term = new DataGridViewTextBoxColumn();
            final_term = new DataGridViewTextBoxColumn();
            final_grade = new DataGridViewTextBoxColumn();
            subject_lbl = new Label();
            label6 = new Label();
            section_lbl = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            printBtn = new PictureBox();
            print_tp = new ToolTip(components);
            grade_lvl_cbx = new ComboBox();
            label7 = new Label();
            section_cbx = new ComboBox();
            label8 = new Label();
            download_btn = new Label();
            print_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grading_sheet_dtg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)printBtn).BeginInit();
            SuspendLayout();
            // 
            // print_panel
            // 
            print_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            print_panel.AutoScroll = true;
            print_panel.BackColor = Color.White;
            print_panel.Controls.Add(grading_sheet_dtg);
            print_panel.Controls.Add(subject_lbl);
            print_panel.Controls.Add(label6);
            print_panel.Controls.Add(section_lbl);
            print_panel.Controls.Add(label4);
            print_panel.Controls.Add(label3);
            print_panel.Controls.Add(label2);
            print_panel.Controls.Add(label1);
            print_panel.Controls.Add(pictureBox1);
            print_panel.Location = new Point(8, 41);
            print_panel.Margin = new Padding(2);
            print_panel.MaximumSize = new Size(897, 0);
            print_panel.MinimumSize = new Size(897, 581);
            print_panel.Name = "print_panel";
            print_panel.Size = new Size(897, 702);
            print_panel.TabIndex = 0;
            // 
            // grading_sheet_dtg
            // 
            grading_sheet_dtg.AllowUserToAddRows = false;
            grading_sheet_dtg.AllowUserToDeleteRows = false;
            grading_sheet_dtg.AllowUserToResizeColumns = false;
            grading_sheet_dtg.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(43, 47, 84);
            grading_sheet_dtg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grading_sheet_dtg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grading_sheet_dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grading_sheet_dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grading_sheet_dtg.BackgroundColor = Color.White;
            grading_sheet_dtg.BorderStyle = BorderStyle.None;
            grading_sheet_dtg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Poppins Medium", 6F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle2.Padding = new Padding(15);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grading_sheet_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grading_sheet_dtg.ColumnHeadersHeight = 45;
            grading_sheet_dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grading_sheet_dtg.Columns.AddRange(new DataGridViewColumn[] { id, no, name, mid_term, final_term, final_grade });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Poppins", 6F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle3.Padding = new Padding(15);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            grading_sheet_dtg.DefaultCellStyle = dataGridViewCellStyle3;
            grading_sheet_dtg.DoubleBuffered = true;
            grading_sheet_dtg.EnableHeadersVisualStyles = false;
            grading_sheet_dtg.GridColor = Color.FromArgb(43, 47, 84);
            grading_sheet_dtg.HeaderBgColor = Color.White;
            grading_sheet_dtg.HeaderForeColor = Color.FromArgb(43, 47, 84);
            grading_sheet_dtg.Location = new Point(13, 218);
            grading_sheet_dtg.Margin = new Padding(2);
            grading_sheet_dtg.Name = "grading_sheet_dtg";
            grading_sheet_dtg.ReadOnly = true;
            grading_sheet_dtg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grading_sheet_dtg.RowHeadersVisible = false;
            grading_sheet_dtg.RowHeadersWidth = 62;
            grading_sheet_dtg.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            grading_sheet_dtg.RowTemplate.Height = 33;
            grading_sheet_dtg.ScrollBars = ScrollBars.None;
            grading_sheet_dtg.SelectionMode = DataGridViewSelectionMode.CellSelect;
            grading_sheet_dtg.ShowCellErrors = false;
            grading_sheet_dtg.ShowEditingIcon = false;
            grading_sheet_dtg.ShowRowErrors = false;
            grading_sheet_dtg.Size = new Size(872, 477);
            grading_sheet_dtg.TabIndex = 11;
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
            no.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            no.HeaderText = "NO";
            no.MinimumWidth = 8;
            no.Name = "no";
            no.ReadOnly = true;
            no.Width = 75;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "NAME";
            name.MinimumWidth = 8;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // mid_term
            // 
            mid_term.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            mid_term.HeaderText = "MID TERM";
            mid_term.MinimumWidth = 8;
            mid_term.Name = "mid_term";
            mid_term.ReadOnly = true;
            mid_term.Width = 107;
            // 
            // final_term
            // 
            final_term.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            final_term.HeaderText = "FINAL TERM";
            final_term.MinimumWidth = 8;
            final_term.Name = "final_term";
            final_term.ReadOnly = true;
            final_term.Width = 116;
            // 
            // final_grade
            // 
            final_grade.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            final_grade.HeaderText = "FINAL GRADE";
            final_grade.MinimumWidth = 8;
            final_grade.Name = "final_grade";
            final_grade.ReadOnly = true;
            final_grade.Width = 123;
            // 
            // subject_lbl
            // 
            subject_lbl.Anchor = AnchorStyles.Top;
            subject_lbl.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            subject_lbl.Location = new Point(314, 192);
            subject_lbl.Margin = new Padding(2, 0, 2, 0);
            subject_lbl.Name = "subject_lbl";
            subject_lbl.Size = new Size(270, 17);
            subject_lbl.TabIndex = 9;
            subject_lbl.Text = "SUBJECT";
            subject_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(314, 169);
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
            section_lbl.Location = new Point(314, 152);
            section_lbl.Margin = new Padding(2, 0, 2, 0);
            section_lbl.Name = "section_lbl";
            section_lbl.Size = new Size(270, 17);
            section_lbl.TabIndex = 7;
            section_lbl.Text = "SECTION NAME";
            section_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(382, 135);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(131, 19);
            label4.TabIndex = 6;
            label4.Text = "GRADING SYSTEM";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(345, 113);
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
            label2.Location = new Point(384, 100);
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
            label1.Location = new Point(378, 86);
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
            pictureBox1.Location = new Point(403, 3);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // printBtn
            // 
            printBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            printBtn.Image = Properties.Resources.print_icon;
            printBtn.Location = new Point(888, 7);
            printBtn.Margin = new Padding(2);
            printBtn.Name = "printBtn";
            printBtn.Size = new Size(18, 15);
            printBtn.SizeMode = PictureBoxSizeMode.Zoom;
            printBtn.TabIndex = 1;
            printBtn.TabStop = false;
            printBtn.Click += printBtn_Click;
            // 
            // grade_lvl_cbx
            // 
            grade_lvl_cbx.FormattingEnabled = true;
            grade_lvl_cbx.Items.AddRange(new object[] { "11", "12" });
            grade_lvl_cbx.Location = new Point(8, 18);
            grade_lvl_cbx.Margin = new Padding(2);
            grade_lvl_cbx.Name = "grade_lvl_cbx";
            grade_lvl_cbx.Size = new Size(109, 23);
            grade_lvl_cbx.TabIndex = 13;
            grade_lvl_cbx.SelectedIndexChanged += grade_lvl_cbx_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(8, 5);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(79, 14);
            label7.TabIndex = 12;
            label7.Text = "Select Grade:";
            // 
            // section_cbx
            // 
            section_cbx.Enabled = false;
            section_cbx.FormattingEnabled = true;
            section_cbx.Location = new Point(125, 18);
            section_cbx.Margin = new Padding(2);
            section_cbx.Name = "section_cbx";
            section_cbx.Size = new Size(255, 23);
            section_cbx.TabIndex = 11;
            section_cbx.SelectedIndexChanged += section_cbx_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(125, 5);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(85, 14);
            label8.TabIndex = 10;
            label8.Text = "Select Section:";
            // 
            // download_btn
            // 
            download_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            download_btn.AutoSize = true;
            download_btn.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point);
            download_btn.Image = (Image)resources.GetObject("download_btn.Image");
            download_btn.ImageAlign = ContentAlignment.MiddleLeft;
            download_btn.Location = new Point(786, 8);
            download_btn.Margin = new Padding(2, 0, 2, 0);
            download_btn.Name = "download_btn";
            download_btn.Size = new Size(87, 17);
            download_btn.TabIndex = 19;
            download_btn.Text = "      Download";
            download_btn.Click += download_btn_Click;
            // 
            // PrintPreview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 751);
            Controls.Add(download_btn);
            Controls.Add(grade_lvl_cbx);
            Controls.Add(label7);
            Controls.Add(section_cbx);
            Controls.Add(label8);
            Controls.Add(printBtn);
            Controls.Add(print_panel);
            Margin = new Padding(2);
            MinimumSize = new Size(934, 790);
            Name = "PrintPreview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Print Grading Sheet";
            print_panel.ResumeLayout(false);
            print_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grading_sheet_dtg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)printBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel print_panel;
        private PictureBox printBtn;
        private ToolTip print_tp;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label subject_lbl;
        private Label label6;
        private Label section_lbl;
        private Label label4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grading_sheet_dtg;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn no;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn mid_term;
        private DataGridViewTextBoxColumn final_term;
        private DataGridViewTextBoxColumn final_grade;
        private ComboBox grade_lvl_cbx;
        private Label label7;
        private ComboBox section_cbx;
        private Label label8;
        private Label download_btn;
    }
}