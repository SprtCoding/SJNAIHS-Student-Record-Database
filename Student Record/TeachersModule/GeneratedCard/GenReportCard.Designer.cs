namespace Student_Record.TeachersModule.GeneratedCard
{
    partial class GenReportCard
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
            radious = new Bunifu.Framework.UI.BunifuElipse(components);
            card_panel = new Panel();
            grade_dtg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            subject = new DataGridViewTextBoxColumn();
            mid_term = new DataGridViewTextBoxColumn();
            final_term = new DataGridViewTextBoxColumn();
            average = new DataGridViewTextBoxColumn();
            section_tb = new Label();
            label8 = new Label();
            level_tb = new Label();
            label6 = new Label();
            name_tb = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            close_btn = new PictureBox();
            print_btn = new PictureBox();
            toolTip1 = new ToolTip(components);
            card_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grade_dtg).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)close_btn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)print_btn).BeginInit();
            SuspendLayout();
            // 
            // radious
            // 
            radious.ElipseRadius = 10;
            radious.TargetControl = this;
            // 
            // card_panel
            // 
            card_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            card_panel.BackColor = Color.White;
            card_panel.Controls.Add(grade_dtg);
            card_panel.Controls.Add(section_tb);
            card_panel.Controls.Add(label8);
            card_panel.Controls.Add(level_tb);
            card_panel.Controls.Add(label6);
            card_panel.Controls.Add(name_tb);
            card_panel.Controls.Add(label3);
            card_panel.Controls.Add(panel2);
            card_panel.Location = new Point(31, 58);
            card_panel.Name = "card_panel";
            card_panel.Size = new Size(849, 1023);
            card_panel.TabIndex = 0;
            // 
            // grade_dtg
            // 
            grade_dtg.AllowUserToAddRows = false;
            grade_dtg.AllowUserToDeleteRows = false;
            grade_dtg.AllowUserToResizeColumns = false;
            grade_dtg.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle1.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(43, 47, 84);
            grade_dtg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grade_dtg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grade_dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grade_dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grade_dtg.BackgroundColor = Color.White;
            grade_dtg.BorderStyle = BorderStyle.None;
            grade_dtg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(15);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grade_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grade_dtg.ColumnHeadersHeight = 65;
            grade_dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grade_dtg.Columns.AddRange(new DataGridViewColumn[] { subject, mid_term, final_term, average });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle3.Padding = new Padding(15);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            grade_dtg.DefaultCellStyle = dataGridViewCellStyle3;
            grade_dtg.DoubleBuffered = true;
            grade_dtg.EnableHeadersVisualStyles = false;
            grade_dtg.GridColor = Color.Black;
            grade_dtg.HeaderBgColor = Color.White;
            grade_dtg.HeaderForeColor = Color.Black;
            grade_dtg.Location = new Point(16, 392);
            grade_dtg.Name = "grade_dtg";
            grade_dtg.ReadOnly = true;
            grade_dtg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grade_dtg.RowHeadersVisible = false;
            grade_dtg.RowHeadersWidth = 62;
            grade_dtg.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            grade_dtg.RowTemplate.Height = 33;
            grade_dtg.SelectionMode = DataGridViewSelectionMode.CellSelect;
            grade_dtg.ShowCellErrors = false;
            grade_dtg.ShowEditingIcon = false;
            grade_dtg.ShowRowErrors = false;
            grade_dtg.Size = new Size(817, 607);
            grade_dtg.TabIndex = 21;
            // 
            // subject
            // 
            subject.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subject.HeaderText = "SUBJECT";
            subject.MinimumWidth = 8;
            subject.Name = "subject";
            subject.ReadOnly = true;
            // 
            // mid_term
            // 
            mid_term.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            mid_term.HeaderText = "MID TERM";
            mid_term.MinimumWidth = 8;
            mid_term.Name = "mid_term";
            mid_term.ReadOnly = true;
            mid_term.Width = 172;
            // 
            // final_term
            // 
            final_term.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            final_term.HeaderText = "FINAL TERM";
            final_term.MinimumWidth = 8;
            final_term.Name = "final_term";
            final_term.ReadOnly = true;
            final_term.Width = 188;
            // 
            // average
            // 
            average.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            average.HeaderText = "AVERAGE";
            average.MinimumWidth = 8;
            average.Name = "average";
            average.ReadOnly = true;
            average.Width = 167;
            // 
            // section_tb
            // 
            section_tb.AutoSize = true;
            section_tb.Font = new Font("Poppins Medium", 10F, FontStyle.Underline, GraphicsUnit.Point);
            section_tb.Location = new Point(246, 332);
            section_tb.Name = "section_tb";
            section_tb.Size = new Size(162, 36);
            section_tb.TabIndex = 20;
            section_tb.Text = "STUDENT NAME";
            section_tb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(57, 332);
            label8.Name = "label8";
            label8.Size = new Size(98, 36);
            label8.TabIndex = 19;
            label8.Text = "SECTION";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // level_tb
            // 
            level_tb.AutoSize = true;
            level_tb.Font = new Font("Poppins Medium", 10F, FontStyle.Underline, GraphicsUnit.Point);
            level_tb.Location = new Point(246, 277);
            level_tb.Name = "level_tb";
            level_tb.Size = new Size(162, 36);
            level_tb.TabIndex = 18;
            level_tb.Text = "STUDENT NAME";
            level_tb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(57, 277);
            label6.Name = "label6";
            label6.Size = new Size(138, 36);
            label6.TabIndex = 17;
            label6.Text = "GRADE LEVEL";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // name_tb
            // 
            name_tb.AutoSize = true;
            name_tb.Font = new Font("Poppins Medium", 10F, FontStyle.Underline, GraphicsUnit.Point);
            name_tb.Location = new Point(246, 222);
            name_tb.Name = "name_tb";
            name_tb.Size = new Size(162, 36);
            name_tb.TabIndex = 16;
            name_tb.Text = "STUDENT NAME";
            name_tb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(57, 222);
            label3.Name = "label3";
            label3.Size = new Size(162, 36);
            label3.TabIndex = 15;
            label3.Text = "STUDENT NAME";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(171, 179, 254);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(849, 205);
            panel2.TabIndex = 14;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(246, 80);
            label1.Name = "label1";
            label1.Size = new Size(546, 92);
            label1.TabIndex = 5;
            label1.Text = "SAN JOSE NATIONAL AGRICULTURAL AND INDUSTRIAL HIGH SCHOOL";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Poppins ExtraBold", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(236, 22);
            label2.Name = "label2";
            label2.Size = new Size(340, 78);
            label2.TabIndex = 4;
            label2.Text = "REPORT CARD";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.sjnaihs_logo;
            pictureBox1.Location = new Point(59, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // close_btn
            // 
            close_btn.Cursor = Cursors.Hand;
            close_btn.Image = Properties.Resources.cross;
            close_btn.Location = new Point(853, 27);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(26, 25);
            close_btn.SizeMode = PictureBoxSizeMode.Zoom;
            close_btn.TabIndex = 2;
            close_btn.TabStop = false;
            close_btn.Click += close_btn_Click;
            // 
            // print_btn
            // 
            print_btn.Cursor = Cursors.Hand;
            print_btn.Image = Properties.Resources.print_icon;
            print_btn.Location = new Point(812, 27);
            print_btn.Name = "print_btn";
            print_btn.Size = new Size(26, 25);
            print_btn.SizeMode = PictureBoxSizeMode.Zoom;
            print_btn.TabIndex = 3;
            print_btn.TabStop = false;
            print_btn.Click += print_btn_Click;
            // 
            // toolTip1
            // 
            toolTip1.BackColor = Color.FromArgb(43, 47, 84);
            toolTip1.ForeColor = Color.WhiteSmoke;
            toolTip1.IsBalloon = true;
            // 
            // GenReportCard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(910, 1106);
            Controls.Add(print_btn);
            Controls.Add(card_panel);
            Controls.Add(close_btn);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(910, 1078);
            Name = "GenReportCard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GenReportCard";
            card_panel.ResumeLayout(false);
            card_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grade_dtg).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)close_btn).EndInit();
            ((System.ComponentModel.ISupportInitialize)print_btn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse radious;
        private Panel card_panel;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grade_dtg;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn mid_term;
        private DataGridViewTextBoxColumn final_term;
        private DataGridViewTextBoxColumn average;
        private Label section_tb;
        private Label label8;
        private Label level_tb;
        private Label label6;
        private Label name_tb;
        private Label label3;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox close_btn;
        private PictureBox print_btn;
        private ToolTip toolTip1;
    }
}