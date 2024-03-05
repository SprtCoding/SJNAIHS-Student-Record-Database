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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentGradingSummary));
            label2 = new Label();
            grading_summary_dtg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            subject1 = new DataGridViewTextBoxColumn();
            subject2 = new DataGridViewTextBoxColumn();
            subject3 = new DataGridViewTextBoxColumn();
            subject4 = new DataGridViewTextBoxColumn();
            subject5 = new DataGridViewTextBoxColumn();
            subject6 = new DataGridViewTextBoxColumn();
            subject7 = new DataGridViewTextBoxColumn();
            average = new DataGridViewTextBoxColumn();
            mid_grade_filter = new Bunifu.Framework.UI.BunifuFlatButton();
            final_term_grade_filter = new Bunifu.Framework.UI.BunifuFlatButton();
            no_data_panel = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            submit_report_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            print_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)grading_summary_dtg).BeginInit();
            no_data_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            grading_summary_dtg.Columns.AddRange(new DataGridViewColumn[] { id, name, subject1, subject2, subject3, subject4, subject5, subject6, subject7, average });
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
            grading_summary_dtg.Location = new Point(8, 80);
            grading_summary_dtg.Margin = new Padding(2);
            grading_summary_dtg.Name = "grading_summary_dtg";
            grading_summary_dtg.ReadOnly = true;
            grading_summary_dtg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grading_summary_dtg.RowHeadersVisible = false;
            grading_summary_dtg.RowHeadersWidth = 62;
            grading_summary_dtg.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            grading_summary_dtg.RowTemplate.Height = 33;
            grading_summary_dtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grading_summary_dtg.ShowCellErrors = false;
            grading_summary_dtg.ShowEditingIcon = false;
            grading_summary_dtg.ShowRowErrors = false;
            grading_summary_dtg.Size = new Size(773, 573);
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
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "NAME";
            name.MinimumWidth = 8;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // subject1
            // 
            subject1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subject1.HeaderText = "ORAL COMMUNICATION";
            subject1.MinimumWidth = 8;
            subject1.Name = "subject1";
            subject1.ReadOnly = true;
            // 
            // subject2
            // 
            subject2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subject2.HeaderText = "KOMUNIKASYON AT PANANALIKSIK";
            subject2.MinimumWidth = 8;
            subject2.Name = "subject2";
            subject2.ReadOnly = true;
            // 
            // subject3
            // 
            subject3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subject3.HeaderText = "21ST CENTURY LITERATURE";
            subject3.MinimumWidth = 8;
            subject3.Name = "subject3";
            subject3.ReadOnly = true;
            // 
            // subject4
            // 
            subject4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subject4.HeaderText = "GENERAL MATHEMATICS";
            subject4.MinimumWidth = 8;
            subject4.Name = "subject4";
            subject4.ReadOnly = true;
            // 
            // subject5
            // 
            subject5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subject5.HeaderText = "INTRO TO PHILOSOPHY";
            subject5.MinimumWidth = 8;
            subject5.Name = "subject5";
            subject5.ReadOnly = true;
            // 
            // subject6
            // 
            subject6.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            subject6.HeaderText = "PE & HEALTH";
            subject6.MinimumWidth = 8;
            subject6.Name = "subject6";
            subject6.ReadOnly = true;
            subject6.Width = 94;
            // 
            // subject7
            // 
            subject7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subject7.HeaderText = "TVE";
            subject7.MinimumWidth = 8;
            subject7.Name = "subject7";
            subject7.ReadOnly = true;
            // 
            // average
            // 
            average.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            average.HeaderText = "AVERAGE";
            average.MinimumWidth = 8;
            average.Name = "average";
            average.ReadOnly = true;
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
            mid_grade_filter.Location = new Point(10, 43);
            mid_grade_filter.Margin = new Padding(4);
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
            final_term_grade_filter.Location = new Point(175, 43);
            final_term_grade_filter.Margin = new Padding(4);
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
            no_data_panel.Controls.Add(label1);
            no_data_panel.Controls.Add(pictureBox1);
            no_data_panel.Location = new Point(8, 80);
            no_data_panel.Margin = new Padding(2);
            no_data_panel.Name = "no_data_panel";
            no_data_panel.Size = new Size(774, 570);
            no_data_panel.TabIndex = 25;
            no_data_panel.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(60, 64, 98);
            label1.Location = new Point(100, 329);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(573, 23);
            label1.TabIndex = 19;
            label1.Text = "No data found!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(234, 206);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // submit_report_btn
            // 
            submit_report_btn.Active = false;
            submit_report_btn.Activecolor = Color.FromArgb(43, 47, 84);
            submit_report_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            submit_report_btn.BackColor = Color.FromArgb(43, 47, 84);
            submit_report_btn.BackgroundImageLayout = ImageLayout.Stretch;
            submit_report_btn.BorderRadius = 5;
            submit_report_btn.ButtonText = "  Submit Report";
            submit_report_btn.DisabledColor = Color.Gray;
            submit_report_btn.Iconcolor = Color.Transparent;
            submit_report_btn.Iconimage = Properties.Resources.send_message;
            submit_report_btn.Iconimage_right = null;
            submit_report_btn.Iconimage_right_Selected = null;
            submit_report_btn.Iconimage_Selected = null;
            submit_report_btn.IconMarginLeft = 0;
            submit_report_btn.IconMarginRight = 0;
            submit_report_btn.IconRightVisible = true;
            submit_report_btn.IconRightZoom = 0D;
            submit_report_btn.IconVisible = true;
            submit_report_btn.IconZoom = 25D;
            submit_report_btn.IsTab = false;
            submit_report_btn.Location = new Point(522, 43);
            submit_report_btn.Margin = new Padding(4);
            submit_report_btn.Name = "submit_report_btn";
            submit_report_btn.Normalcolor = Color.FromArgb(43, 47, 84);
            submit_report_btn.OnHovercolor = Color.FromArgb(60, 64, 98);
            submit_report_btn.OnHoverTextColor = Color.White;
            submit_report_btn.selected = false;
            submit_report_btn.Size = new Size(129, 32);
            submit_report_btn.TabIndex = 29;
            submit_report_btn.Text = "  Submit Report";
            submit_report_btn.TextAlign = ContentAlignment.MiddleLeft;
            submit_report_btn.Textcolor = Color.White;
            submit_report_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            submit_report_btn.Click += submit_report_btn_Click;
            // 
            // print_btn
            // 
            print_btn.Active = false;
            print_btn.Activecolor = Color.FromArgb(60, 64, 98);
            print_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            print_btn.BackColor = Color.FromArgb(43, 47, 84);
            print_btn.BackgroundImageLayout = ImageLayout.Stretch;
            print_btn.BorderRadius = 5;
            print_btn.ButtonText = "Print";
            print_btn.DisabledColor = Color.Gray;
            print_btn.Iconcolor = Color.Transparent;
            print_btn.Iconimage = null;
            print_btn.Iconimage_right = null;
            print_btn.Iconimage_right_Selected = null;
            print_btn.Iconimage_Selected = null;
            print_btn.IconMarginLeft = 0;
            print_btn.IconMarginRight = 0;
            print_btn.IconRightVisible = true;
            print_btn.IconRightZoom = 40D;
            print_btn.IconVisible = false;
            print_btn.IconZoom = 40D;
            print_btn.IsTab = false;
            print_btn.Location = new Point(659, 43);
            print_btn.Margin = new Padding(4);
            print_btn.Name = "print_btn";
            print_btn.Normalcolor = Color.FromArgb(43, 47, 84);
            print_btn.OnHovercolor = Color.FromArgb(60, 64, 98);
            print_btn.OnHoverTextColor = Color.White;
            print_btn.Padding = new Padding(8, 5, 8, 5);
            print_btn.RightToLeft = RightToLeft.No;
            print_btn.selected = false;
            print_btn.Size = new Size(122, 32);
            print_btn.TabIndex = 30;
            print_btn.Text = "Print";
            print_btn.TextAlign = ContentAlignment.MiddleCenter;
            print_btn.Textcolor = Color.White;
            print_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            print_btn.Click += print_btn_Click;
            // 
            // StudentGradingSummary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 661);
            Controls.Add(print_btn);
            Controls.Add(submit_report_btn);
            Controls.Add(no_data_panel);
            Controls.Add(final_term_grade_filter);
            Controls.Add(mid_grade_filter);
            Controls.Add(grading_summary_dtg);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentGradingSummary";
            Text = "StudentGradingSummary";
            ((System.ComponentModel.ISupportInitialize)grading_summary_dtg).EndInit();
            no_data_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grading_summary_dtg;
        private Bunifu.Framework.UI.BunifuFlatButton mid_grade_filter;
        private Bunifu.Framework.UI.BunifuFlatButton final_term_grade_filter;
        private Panel no_data_panel;
        private Label label1;
        private PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton submit_report_btn;
        private Bunifu.Framework.UI.BunifuFlatButton print_btn;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn subject1;
        private DataGridViewTextBoxColumn subject2;
        private DataGridViewTextBoxColumn subject3;
        private DataGridViewTextBoxColumn subject4;
        private DataGridViewTextBoxColumn subject5;
        private DataGridViewTextBoxColumn subject6;
        private DataGridViewTextBoxColumn subject7;
        private DataGridViewTextBoxColumn average;
    }
}