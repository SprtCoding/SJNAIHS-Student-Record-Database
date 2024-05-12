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
            section_lbl = new Label();
            label6 = new Label();
            term_lbl = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            print_tp = new ToolTip(components);
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
            printBtn.Location = new Point(1269, 12);
            printBtn.Name = "printBtn";
            printBtn.Size = new Size(26, 25);
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
            print_panel.Location = new Point(11, 68);
            print_panel.MaximumSize = new Size(1281, 0);
            print_panel.MinimumSize = new Size(1281, 968);
            print_panel.Name = "print_panel";
            print_panel.Size = new Size(1281, 968);
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
            grading_summary_dtg.Location = new Point(17, 363);
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
            grading_summary_dtg.Size = new Size(1249, 585);
            grading_summary_dtg.TabIndex = 11;
            // 
            // section_lbl
            // 
            section_lbl.Anchor = AnchorStyles.Top;
            section_lbl.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            section_lbl.Location = new Point(449, 322);
            section_lbl.Name = "section_lbl";
            section_lbl.Size = new Size(386, 28);
            section_lbl.TabIndex = 9;
            section_lbl.Text = "SECTION NAME";
            section_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(449, 283);
            label6.Name = "label6";
            label6.Size = new Size(386, 28);
            label6.TabIndex = 8;
            label6.Text = "S.Y. 2022-2023";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // term_lbl
            // 
            term_lbl.Anchor = AnchorStyles.Top;
            term_lbl.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            term_lbl.Location = new Point(449, 253);
            term_lbl.Name = "term_lbl";
            term_lbl.Size = new Size(386, 28);
            term_lbl.TabIndex = 7;
            term_lbl.Text = "FIRST SEMESTER - FINAL TERM";
            term_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(546, 227);
            label4.Name = "label4";
            label4.Size = new Size(190, 29);
            label4.TabIndex = 6;
            label4.Text = "SUMMARY SHEET";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(493, 188);
            label3.Name = "label3";
            label3.Size = new Size(296, 22);
            label3.TabIndex = 5;
            label3.Text = "Schools Division of Occidental Mindoro";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Old English Text MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(549, 167);
            label2.Name = "label2";
            label2.Size = new Size(185, 22);
            label2.TabIndex = 4;
            label2.Text = "Department of Education";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Old English Text MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(540, 143);
            label1.Name = "label1";
            label1.Size = new Size(203, 22);
            label1.TabIndex = 3;
            label1.Text = "Republic of the Philippines";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.depEd_logo;
            pictureBox1.Location = new Point(576, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // download_btn
            // 
            download_btn.AutoSize = true;
            download_btn.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point);
            download_btn.Image = (Image)resources.GetObject("download_btn.Image");
            download_btn.ImageAlign = ContentAlignment.MiddleLeft;
            download_btn.Location = new Point(1123, 13);
            download_btn.Name = "download_btn";
            download_btn.Size = new Size(127, 24);
            download_btn.TabIndex = 18;
            download_btn.Text = "      Download";
            download_btn.Click += download_btn_Click;
            // 
            // SummaryPrintPreview
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 1050);
            Controls.Add(download_btn);
            Controls.Add(printBtn);
            Controls.Add(print_panel);
            MinimumSize = new Size(1325, 1078);
            Name = "SummaryPrintPreview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SummaryPrintPreview";
            Load += SummaryPrintPreview_Load;
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
        private ToolTip print_tp;
        private Label download_btn;
    }
}