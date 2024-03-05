namespace Student_Record.AdminModule.Student
{
    partial class Details
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details));
            dtg_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            student_name_lbl = new Label();
            img = new PictureBox();
            grade_dtg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            id = new DataGridViewTextBoxColumn();
            subject = new DataGridViewTextBoxColumn();
            mid_grade = new DataGridViewTextBoxColumn();
            final_grade = new DataGridViewTextBoxColumn();
            average = new DataGridViewTextBoxColumn();
            section_lbl = new Label();
            no_data_panel = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            close_btn = new Label();
            rebon_img = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            general_average_lbl = new Label();
            label3 = new Label();
            final_term_average_lbl = new Label();
            label7 = new Label();
            mid_term_average_lbl = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grade_dtg).BeginInit();
            no_data_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rebon_img).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtg_rad
            // 
            dtg_rad.ElipseRadius = 20;
            dtg_rad.TargetControl = this;
            // 
            // student_name_lbl
            // 
            student_name_lbl.Anchor = AnchorStyles.None;
            student_name_lbl.Font = new Font("Poppins Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            student_name_lbl.ForeColor = Color.WhiteSmoke;
            student_name_lbl.Location = new Point(13, 256);
            student_name_lbl.Name = "student_name_lbl";
            student_name_lbl.Size = new Size(819, 38);
            student_name_lbl.TabIndex = 15;
            student_name_lbl.Text = "Student Name";
            student_name_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // img
            // 
            img.Image = Properties.Resources.user_male;
            img.Location = new Point(300, 61);
            img.Name = "img";
            img.Size = new Size(243, 192);
            img.SizeMode = PictureBoxSizeMode.Zoom;
            img.TabIndex = 16;
            img.TabStop = false;
            // 
            // grade_dtg
            // 
            grade_dtg.AllowUserToAddRows = false;
            grade_dtg.AllowUserToDeleteRows = false;
            grade_dtg.AllowUserToResizeColumns = false;
            grade_dtg.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            grade_dtg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grade_dtg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grade_dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grade_dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grade_dtg.BackgroundColor = Color.FromArgb(43, 47, 84);
            grade_dtg.BorderStyle = BorderStyle.None;
            grade_dtg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Padding = new Padding(15);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grade_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grade_dtg.ColumnHeadersHeight = 65;
            grade_dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grade_dtg.Columns.AddRange(new DataGridViewColumn[] { id, subject, mid_grade, final_grade, average });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Padding = new Padding(15);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle3.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            grade_dtg.DefaultCellStyle = dataGridViewCellStyle3;
            grade_dtg.DoubleBuffered = true;
            grade_dtg.EnableHeadersVisualStyles = false;
            grade_dtg.GridColor = Color.WhiteSmoke;
            grade_dtg.HeaderBgColor = Color.FromArgb(43, 47, 84);
            grade_dtg.HeaderForeColor = Color.WhiteSmoke;
            grade_dtg.Location = new Point(12, 403);
            grade_dtg.Name = "grade_dtg";
            grade_dtg.ReadOnly = true;
            grade_dtg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(129, 142, 254);
            dataGridViewCellStyle4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Padding = new Padding(15);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            grade_dtg.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            grade_dtg.RowHeadersVisible = false;
            grade_dtg.RowHeadersWidth = 62;
            grade_dtg.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            grade_dtg.RowTemplate.Height = 33;
            grade_dtg.SelectionMode = DataGridViewSelectionMode.CellSelect;
            grade_dtg.ShowCellErrors = false;
            grade_dtg.ShowEditingIcon = false;
            grade_dtg.ShowRowErrors = false;
            grade_dtg.Size = new Size(818, 533);
            grade_dtg.TabIndex = 17;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // subject
            // 
            subject.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subject.HeaderText = "SUBJECT";
            subject.MinimumWidth = 8;
            subject.Name = "subject";
            subject.ReadOnly = true;
            // 
            // mid_grade
            // 
            mid_grade.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            mid_grade.HeaderText = "MID GRADE";
            mid_grade.MinimumWidth = 8;
            mid_grade.Name = "mid_grade";
            mid_grade.ReadOnly = true;
            mid_grade.Width = 173;
            // 
            // final_grade
            // 
            final_grade.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            final_grade.HeaderText = "FINAL GRADE";
            final_grade.MinimumWidth = 8;
            final_grade.Name = "final_grade";
            final_grade.ReadOnly = true;
            final_grade.Width = 187;
            // 
            // average
            // 
            average.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            average.HeaderText = "AVERAGE";
            average.MinimumWidth = 8;
            average.Name = "average";
            average.ReadOnly = true;
            average.Width = 155;
            // 
            // section_lbl
            // 
            section_lbl.Anchor = AnchorStyles.None;
            section_lbl.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            section_lbl.ForeColor = Color.WhiteSmoke;
            section_lbl.Location = new Point(13, 306);
            section_lbl.Name = "section_lbl";
            section_lbl.Size = new Size(819, 38);
            section_lbl.TabIndex = 18;
            section_lbl.Text = "Student Name";
            section_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // no_data_panel
            // 
            no_data_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            no_data_panel.Controls.Add(label1);
            no_data_panel.Controls.Add(pictureBox1);
            no_data_panel.Location = new Point(2, 403);
            no_data_panel.Name = "no_data_panel";
            no_data_panel.Size = new Size(840, 616);
            no_data_panel.TabIndex = 19;
            no_data_panel.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(11, 334);
            label1.Name = "label1";
            label1.Size = new Size(819, 38);
            label1.TabIndex = 19;
            label1.Text = "No grade for this student";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(203, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(435, 218);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // close_btn
            // 
            close_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close_btn.AutoSize = true;
            close_btn.Cursor = Cursors.Hand;
            close_btn.Font = new Font("Poppins Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            close_btn.ForeColor = Color.WhiteSmoke;
            close_btn.Location = new Point(794, 12);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(37, 50);
            close_btn.TabIndex = 20;
            close_btn.Text = "x";
            close_btn.TextAlign = ContentAlignment.MiddleLeft;
            close_btn.Click += close_btn_Click;
            // 
            // rebon_img
            // 
            rebon_img.Image = Properties.Resources.medal_1;
            rebon_img.Location = new Point(521, 193);
            rebon_img.Name = "rebon_img";
            rebon_img.Size = new Size(60, 60);
            rebon_img.SizeMode = PictureBoxSizeMode.Zoom;
            rebon_img.TabIndex = 21;
            rebon_img.TabStop = false;
            rebon_img.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(general_average_lbl);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(final_term_average_lbl);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(mid_term_average_lbl);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(13, 942);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(817, 66);
            flowLayoutPanel1.TabIndex = 22;
            // 
            // general_average_lbl
            // 
            general_average_lbl.AutoSize = true;
            general_average_lbl.Font = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            general_average_lbl.ForeColor = Color.WhiteSmoke;
            general_average_lbl.Location = new Point(786, 0);
            general_average_lbl.Name = "general_average_lbl";
            general_average_lbl.Size = new Size(28, 36);
            general_average_lbl.TabIndex = 0;
            general_average_lbl.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(602, 0);
            label3.Name = "label3";
            label3.Size = new Size(178, 31);
            label3.TabIndex = 1;
            label3.Text = "GENERAL AVERAGE:";
            // 
            // final_term_average_lbl
            // 
            final_term_average_lbl.AutoSize = true;
            final_term_average_lbl.Font = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            final_term_average_lbl.ForeColor = Color.WhiteSmoke;
            final_term_average_lbl.Location = new Point(568, 0);
            final_term_average_lbl.Name = "final_term_average_lbl";
            final_term_average_lbl.Size = new Size(28, 36);
            final_term_average_lbl.TabIndex = 2;
            final_term_average_lbl.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(363, 0);
            label7.Name = "label7";
            label7.Size = new Size(199, 31);
            label7.TabIndex = 5;
            label7.Text = "FINAL TERM AVERAGE:";
            // 
            // mid_term_average_lbl
            // 
            mid_term_average_lbl.AutoSize = true;
            mid_term_average_lbl.Font = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            mid_term_average_lbl.ForeColor = Color.WhiteSmoke;
            mid_term_average_lbl.Location = new Point(329, 0);
            mid_term_average_lbl.Name = "mid_term_average_lbl";
            mid_term_average_lbl.Size = new Size(28, 36);
            mid_term_average_lbl.TabIndex = 4;
            mid_term_average_lbl.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(137, 0);
            label5.Name = "label5";
            label5.Size = new Size(186, 31);
            label5.TabIndex = 3;
            label5.Text = "MID TERM AVERAGE:";
            // 
            // Details
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 47, 84);
            ClientSize = new Size(843, 1020);
            Controls.Add(no_data_panel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(rebon_img);
            Controls.Add(close_btn);
            Controls.Add(section_lbl);
            Controls.Add(grade_dtg);
            Controls.Add(img);
            Controls.Add(student_name_lbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Details";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Details";
            ((System.ComponentModel.ISupportInitialize)img).EndInit();
            ((System.ComponentModel.ISupportInitialize)grade_dtg).EndInit();
            no_data_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rebon_img).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse dtg_rad;
        private Label student_name_lbl;
        private PictureBox img;
        private Label section_lbl;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grade_dtg;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn mid_grade;
        private DataGridViewTextBoxColumn final_grade;
        private DataGridViewTextBoxColumn average;
        private Panel no_data_panel;
        private PictureBox pictureBox1;
        private Label general_average_lbl;
        private Label close_btn;
        private Label label1;
        private PictureBox rebon_img;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private Label final_term_average_lbl;
        private Label label7;
        private Label mid_term_average_lbl;
        private Label label5;
    }
}