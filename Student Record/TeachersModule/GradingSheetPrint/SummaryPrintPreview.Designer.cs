namespace Student_Record.TeachersModule.GradingSheetPrint
{
    partial class SummaryPrintPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryPrintPreview));
            printBtn = new PictureBox();
            print_panel = new Panel();
            grading_summary_dtg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            id = new DataGridViewTextBoxColumn();
            no = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            oral_com = new DataGridViewTextBoxColumn();
            komunikasyon = new DataGridViewTextBoxColumn();
            century = new DataGridViewTextBoxColumn();
            math = new DataGridViewTextBoxColumn();
            philosophy = new DataGridViewTextBoxColumn();
            p_e = new DataGridViewTextBoxColumn();
            tve = new DataGridViewTextBoxColumn();
            average = new DataGridViewTextBoxColumn();
            remarks = new DataGridViewTextBoxColumn();
            section_lbl = new Label();
            label6 = new Label();
            term_lbl = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            print_tp = new ToolTip(components);
            grade_lvl_cbx = new ComboBox();
            label7 = new Label();
            section_cbx = new ComboBox();
            label8 = new Label();
            download_btn = new Label();
            ((System.ComponentModel.ISupportInitialize)printBtn).BeginInit();
            print_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grading_summary_dtg).BeginInit();
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
            printBtn.TabIndex = 3;
            printBtn.TabStop = false;
            printBtn.Click += printBtn_Click;
            // 
            // print_panel
            // 
            print_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            print_panel.BackColor = Color.White;
            print_panel.Controls.Add(grading_summary_dtg);
            print_panel.Controls.Add(section_lbl);
            print_panel.Controls.Add(label6);
            print_panel.Controls.Add(term_lbl);
            print_panel.Controls.Add(label4);
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
            print_panel.TabIndex = 2;
            // 
            // grading_summary_dtg
            // 
            grading_summary_dtg.AllowUserToAddRows = false;
            grading_summary_dtg.AllowUserToDeleteRows = false;
            grading_summary_dtg.AllowUserToResizeColumns = false;
            grading_summary_dtg.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(43, 47, 84);
            grading_summary_dtg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grading_summary_dtg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grading_summary_dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grading_summary_dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grading_summary_dtg.BackgroundColor = Color.White;
            grading_summary_dtg.BorderStyle = BorderStyle.None;
            grading_summary_dtg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Poppins Medium", 6F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle2.Padding = new Padding(7);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grading_summary_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grading_summary_dtg.ColumnHeadersHeight = 60;
            grading_summary_dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grading_summary_dtg.Columns.AddRange(new DataGridViewColumn[] { id, no, name, oral_com, komunikasyon, century, math, philosophy, p_e, tve, average, remarks });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Poppins", 5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle3.Padding = new Padding(7);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            grading_summary_dtg.DefaultCellStyle = dataGridViewCellStyle3;
            grading_summary_dtg.DoubleBuffered = true;
            grading_summary_dtg.EnableHeadersVisualStyles = false;
            grading_summary_dtg.GridColor = Color.FromArgb(43, 47, 84);
            grading_summary_dtg.HeaderBgColor = Color.White;
            grading_summary_dtg.HeaderForeColor = Color.FromArgb(43, 47, 84);
            grading_summary_dtg.Location = new Point(12, 218);
            grading_summary_dtg.Margin = new Padding(2, 2, 2, 2);
            grading_summary_dtg.Name = "grading_summary_dtg";
            grading_summary_dtg.ReadOnly = true;
            grading_summary_dtg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grading_summary_dtg.RowHeadersVisible = false;
            grading_summary_dtg.RowHeadersWidth = 62;
            grading_summary_dtg.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            grading_summary_dtg.RowTemplate.Height = 33;
            grading_summary_dtg.SelectionMode = DataGridViewSelectionMode.CellSelect;
            grading_summary_dtg.ShowCellErrors = false;
            grading_summary_dtg.ShowEditingIcon = false;
            grading_summary_dtg.ShowRowErrors = false;
            grading_summary_dtg.Size = new Size(874, 472);
            grading_summary_dtg.TabIndex = 11;
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
            no.HeaderText = "No";
            no.MinimumWidth = 8;
            no.Name = "no";
            no.ReadOnly = true;
            no.Width = 58;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Name of Students";
            name.MinimumWidth = 8;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // oral_com
            // 
            oral_com.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            oral_com.HeaderText = "Oral Communication";
            oral_com.MinimumWidth = 8;
            oral_com.Name = "oral_com";
            oral_com.ReadOnly = true;
            // 
            // komunikasyon
            // 
            komunikasyon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            komunikasyon.HeaderText = "Komunikasyon at Pananaliksik";
            komunikasyon.MinimumWidth = 8;
            komunikasyon.Name = "komunikasyon";
            komunikasyon.ReadOnly = true;
            // 
            // century
            // 
            century.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            century.HeaderText = "21st Century Literature";
            century.MinimumWidth = 8;
            century.Name = "century";
            century.ReadOnly = true;
            // 
            // math
            // 
            math.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            math.HeaderText = "General Mathematics";
            math.MinimumWidth = 8;
            math.Name = "math";
            math.ReadOnly = true;
            // 
            // philosophy
            // 
            philosophy.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            philosophy.HeaderText = "Introduction to the Philosophy";
            philosophy.MinimumWidth = 8;
            philosophy.Name = "philosophy";
            philosophy.ReadOnly = true;
            // 
            // p_e
            // 
            p_e.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            p_e.HeaderText = "Physical Education & Health";
            p_e.MinimumWidth = 8;
            p_e.Name = "p_e";
            p_e.ReadOnly = true;
            // 
            // tve
            // 
            tve.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tve.HeaderText = "TVE";
            tve.MinimumWidth = 8;
            tve.Name = "tve";
            tve.ReadOnly = true;
            // 
            // average
            // 
            average.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            average.HeaderText = "Average";
            average.MinimumWidth = 8;
            average.Name = "average";
            average.ReadOnly = true;
            // 
            // remarks
            // 
            remarks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            remarks.HeaderText = "Remarks";
            remarks.MinimumWidth = 8;
            remarks.Name = "remarks";
            remarks.ReadOnly = true;
            // 
            // section_lbl
            // 
            section_lbl.Anchor = AnchorStyles.Top;
            section_lbl.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            section_lbl.Location = new Point(314, 193);
            section_lbl.Margin = new Padding(2, 0, 2, 0);
            section_lbl.Name = "section_lbl";
            section_lbl.Size = new Size(270, 17);
            section_lbl.TabIndex = 9;
            section_lbl.Text = "SECTION NAME";
            section_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(314, 170);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(270, 17);
            label6.TabIndex = 8;
            label6.Text = "S.Y. 2022-2023";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // term_lbl
            // 
            term_lbl.Anchor = AnchorStyles.Top;
            term_lbl.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            term_lbl.Location = new Point(314, 152);
            term_lbl.Margin = new Padding(2, 0, 2, 0);
            term_lbl.Name = "term_lbl";
            term_lbl.Size = new Size(270, 17);
            term_lbl.TabIndex = 7;
            term_lbl.Text = "FIRST SEMESTER - FINAL TERM";
            term_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(382, 136);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(128, 19);
            label4.TabIndex = 6;
            label4.Text = "SUMMARY SHEET";
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
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // grade_lvl_cbx
            // 
            grade_lvl_cbx.FormattingEnabled = true;
            grade_lvl_cbx.Items.AddRange(new object[] { "11", "12" });
            grade_lvl_cbx.Location = new Point(8, 18);
            grade_lvl_cbx.Margin = new Padding(2, 2, 2, 2);
            grade_lvl_cbx.Name = "grade_lvl_cbx";
            grade_lvl_cbx.Size = new Size(109, 23);
            grade_lvl_cbx.TabIndex = 17;
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
            label7.TabIndex = 16;
            label7.Text = "Select Grade:";
            // 
            // section_cbx
            // 
            section_cbx.Enabled = false;
            section_cbx.FormattingEnabled = true;
            section_cbx.Location = new Point(125, 18);
            section_cbx.Margin = new Padding(2, 2, 2, 2);
            section_cbx.Name = "section_cbx";
            section_cbx.Size = new Size(255, 23);
            section_cbx.TabIndex = 15;
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
            label8.TabIndex = 14;
            label8.Text = "Select Section:";
            // 
            // download_btn
            // 
            download_btn.AutoSize = true;
            download_btn.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point);
            download_btn.Image = (Image)resources.GetObject("download_btn.Image");
            download_btn.ImageAlign = ContentAlignment.MiddleLeft;
            download_btn.Location = new Point(786, 8);
            download_btn.Margin = new Padding(2, 0, 2, 0);
            download_btn.Name = "download_btn";
            download_btn.Size = new Size(87, 17);
            download_btn.TabIndex = 18;
            download_btn.Text = "      Download";
            download_btn.Click += download_btn_Click;
            // 
            // SummaryPrintPreview
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
            Margin = new Padding(2, 2, 2, 2);
            MinimumSize = new Size(934, 790);
            Name = "SummaryPrintPreview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SummaryPrintPreview";
            ((System.ComponentModel.ISupportInitialize)printBtn).EndInit();
            print_panel.ResumeLayout(false);
            print_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grading_summary_dtg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox printBtn;
        private Panel print_panel;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grading_summary_dtg;
        private Label section_lbl;
        private Label label6;
        private Label term_lbl;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn no;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn oral_com;
        private DataGridViewTextBoxColumn komunikasyon;
        private DataGridViewTextBoxColumn century;
        private DataGridViewTextBoxColumn math;
        private DataGridViewTextBoxColumn philosophy;
        private DataGridViewTextBoxColumn p_e;
        private DataGridViewTextBoxColumn tve;
        private DataGridViewTextBoxColumn average;
        private DataGridViewTextBoxColumn remarks;
        private ToolTip print_tp;
        private ComboBox grade_lvl_cbx;
        private Label label7;
        private ComboBox section_cbx;
        private Label label8;
        private Label download_btn;
    }
}