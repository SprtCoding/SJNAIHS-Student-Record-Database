namespace Student_Record.AdminModule
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label2 = new Label();
            gender_tPanel = new TableLayoutPanel();
            female_panel = new Panel();
            female_count = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            male_panel = new Panel();
            male_count = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            grade_panel = new Panel();
            sf9_lbl = new Label();
            label4 = new Label();
            report_card_panel = new Panel();
            sf10_lbl = new Label();
            label6 = new Label();
            dtg_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(components);
            label12 = new Label();
            report_dtg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(components);
            loadingPanel = new Panel();
            loadingTxt = new Label();
            next_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            previous_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            data_count_lbl = new Label();
            gender_tPanel.SuspendLayout();
            female_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            male_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            grade_panel.SuspendLayout();
            report_card_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)report_dtg).BeginInit();
            loadingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(11, 8);
            label2.Name = "label2";
            label2.Size = new Size(155, 56);
            label2.TabIndex = 7;
            label2.Text = "Reports";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gender_tPanel
            // 
            gender_tPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gender_tPanel.ColumnCount = 2;
            gender_tPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            gender_tPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            gender_tPanel.Controls.Add(female_panel, 1, 0);
            gender_tPanel.Location = new Point(0, 0);
            gender_tPanel.Name = "gender_tPanel";
            gender_tPanel.Padding = new Padding(5);
            gender_tPanel.RowCount = 1;
            gender_tPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            gender_tPanel.Size = new Size(200, 100);
            gender_tPanel.TabIndex = 0;
            // 
            // female_panel
            // 
            female_panel.BackColor = Color.FromArgb(229, 71, 161);
            female_panel.Controls.Add(female_count);
            female_panel.Controls.Add(label3);
            female_panel.Controls.Add(pictureBox2);
            female_panel.Cursor = Cursors.Hand;
            female_panel.Dock = DockStyle.Fill;
            female_panel.Location = new Point(110, 15);
            female_panel.Margin = new Padding(10);
            female_panel.Name = "female_panel";
            female_panel.Padding = new Padding(5);
            female_panel.Size = new Size(75, 70);
            female_panel.TabIndex = 1;
            // 
            // female_count
            // 
            female_count.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            female_count.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            female_count.ForeColor = Color.WhiteSmoke;
            female_count.Location = new Point(28, 105);
            female_count.Name = "female_count";
            female_count.Size = new Size(431, 56);
            female_count.TabIndex = 10;
            female_count.Text = "0";
            female_count.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(28, 30);
            label3.Name = "label3";
            label3.Size = new Size(146, 45);
            label3.TabIndex = 9;
            label3.Text = "FEMALE";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(240, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // male_panel
            // 
            male_panel.BackColor = Color.FromArgb(2, 158, 246);
            male_panel.Controls.Add(male_count);
            male_panel.Controls.Add(label1);
            male_panel.Controls.Add(pictureBox1);
            male_panel.Cursor = Cursors.Hand;
            male_panel.Dock = DockStyle.Fill;
            male_panel.Location = new Point(15, 15);
            male_panel.Margin = new Padding(10);
            male_panel.Name = "male_panel";
            male_panel.Padding = new Padding(5);
            male_panel.Size = new Size(75, 213);
            male_panel.TabIndex = 0;
            // 
            // male_count
            // 
            male_count.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            male_count.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            male_count.ForeColor = Color.WhiteSmoke;
            male_count.Location = new Point(28, 10);
            male_count.Name = "male_count";
            male_count.Size = new Size(431, 199);
            male_count.TabIndex = 9;
            male_count.Text = "0";
            male_count.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(28, 30);
            label1.Name = "label1";
            label1.Size = new Size(111, 45);
            label1.TabIndex = 8;
            label1.Text = "MALE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(240, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(grade_panel, 0, 0);
            tableLayoutPanel1.Controls.Add(report_card_panel, 1, 0);
            tableLayoutPanel1.Location = new Point(11, 67);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(6, 5, 6, 5);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1101, 357);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // grade_panel
            // 
            grade_panel.BackColor = Color.FromArgb(43, 47, 84);
            grade_panel.Controls.Add(sf9_lbl);
            grade_panel.Controls.Add(label4);
            grade_panel.Dock = DockStyle.Fill;
            grade_panel.Location = new Point(16, 15);
            grade_panel.Margin = new Padding(10);
            grade_panel.Name = "grade_panel";
            grade_panel.Size = new Size(524, 327);
            grade_panel.TabIndex = 0;
            // 
            // sf9_lbl
            // 
            sf9_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            sf9_lbl.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            sf9_lbl.ForeColor = Color.WhiteSmoke;
            sf9_lbl.Location = new Point(17, 117);
            sf9_lbl.Name = "sf9_lbl";
            sf9_lbl.Size = new Size(484, 95);
            sf9_lbl.TabIndex = 10;
            sf9_lbl.Text = "0";
            sf9_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(17, 17);
            label4.Name = "label4";
            label4.Size = new Size(81, 56);
            label4.TabIndex = 9;
            label4.Text = "SF9";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // report_card_panel
            // 
            report_card_panel.BackColor = Color.FromArgb(129, 142, 254);
            report_card_panel.Controls.Add(sf10_lbl);
            report_card_panel.Controls.Add(label6);
            report_card_panel.Dock = DockStyle.Fill;
            report_card_panel.Location = new Point(560, 15);
            report_card_panel.Margin = new Padding(10);
            report_card_panel.Name = "report_card_panel";
            report_card_panel.Size = new Size(525, 327);
            report_card_panel.TabIndex = 2;
            // 
            // sf10_lbl
            // 
            sf10_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            sf10_lbl.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            sf10_lbl.ForeColor = Color.WhiteSmoke;
            sf10_lbl.Location = new Point(17, 117);
            sf10_lbl.Name = "sf10_lbl";
            sf10_lbl.Size = new Size(484, 95);
            sf10_lbl.TabIndex = 12;
            sf10_lbl.Text = "0";
            sf10_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(17, 17);
            label6.Name = "label6";
            label6.Size = new Size(96, 56);
            label6.TabIndex = 11;
            label6.Text = "SF10";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtg_rad
            // 
            dtg_rad.ElipseRadius = 5;
            dtg_rad.TargetControl = grade_panel;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 5;
            bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            bunifuElipse2.ElipseRadius = 5;
            bunifuElipse2.TargetControl = report_card_panel;
            // 
            // bunifuElipse3
            // 
            bunifuElipse3.ElipseRadius = 5;
            bunifuElipse3.TargetControl = this;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Poppins", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(27, 443);
            label12.Name = "label12";
            label12.Size = new Size(217, 42);
            label12.TabIndex = 9;
            label12.Text = "Faculties Report";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // report_dtg
            // 
            report_dtg.AllowUserToAddRows = false;
            report_dtg.AllowUserToDeleteRows = false;
            report_dtg.AllowUserToResizeColumns = false;
            report_dtg.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle1.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(43, 47, 84);
            report_dtg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            report_dtg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            report_dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            report_dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            report_dtg.BackgroundColor = Color.WhiteSmoke;
            report_dtg.BorderStyle = BorderStyle.None;
            report_dtg.CellBorderStyle = DataGridViewCellBorderStyle.None;
            report_dtg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle2.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Padding = new Padding(15);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            report_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            report_dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle3.Padding = new Padding(15);
            dataGridViewCellStyle3.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            report_dtg.DefaultCellStyle = dataGridViewCellStyle3;
            report_dtg.DoubleBuffered = true;
            report_dtg.EnableHeadersVisualStyles = false;
            report_dtg.GridColor = Color.FromArgb(60, 64, 98);
            report_dtg.HeaderBgColor = Color.FromArgb(43, 47, 84);
            report_dtg.HeaderForeColor = Color.WhiteSmoke;
            report_dtg.Location = new Point(28, 488);
            report_dtg.Name = "report_dtg";
            report_dtg.ReadOnly = true;
            report_dtg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            report_dtg.RowHeadersVisible = false;
            report_dtg.RowHeadersWidth = 62;
            report_dtg.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            report_dtg.RowTemplate.Height = 33;
            report_dtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            report_dtg.ShowCellErrors = false;
            report_dtg.ShowEditingIcon = false;
            report_dtg.ShowRowErrors = false;
            report_dtg.Size = new Size(1069, 182);
            report_dtg.TabIndex = 10;
            report_dtg.CellContentClick += report_dtg_CellContentClick;
            // 
            // bunifuElipse4
            // 
            bunifuElipse4.ElipseRadius = 5;
            bunifuElipse4.TargetControl = report_dtg;
            // 
            // loadingPanel
            // 
            loadingPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loadingPanel.Controls.Add(loadingTxt);
            loadingPanel.Location = new Point(27, 488);
            loadingPanel.Name = "loadingPanel";
            loadingPanel.Size = new Size(1069, 182);
            loadingPanel.TabIndex = 11;
            // 
            // loadingTxt
            // 
            loadingTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            loadingTxt.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            loadingTxt.ForeColor = Color.FromArgb(43, 47, 84);
            loadingTxt.Location = new Point(181, 71);
            loadingTxt.Name = "loadingTxt";
            loadingTxt.Size = new Size(708, 38);
            loadingTxt.TabIndex = 0;
            loadingTxt.Text = "loading data...";
            loadingTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // next_btn
            // 
            next_btn.Active = false;
            next_btn.Activecolor = Color.FromArgb(60, 64, 98);
            next_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            next_btn.BackColor = Color.FromArgb(43, 47, 84);
            next_btn.BackgroundImageLayout = ImageLayout.Stretch;
            next_btn.BorderRadius = 5;
            next_btn.ButtonText = "Next";
            next_btn.DisabledColor = Color.Gray;
            next_btn.Iconcolor = Color.Transparent;
            next_btn.Iconimage = null;
            next_btn.Iconimage_right = null;
            next_btn.Iconimage_right_Selected = null;
            next_btn.Iconimage_Selected = null;
            next_btn.IconMarginLeft = 0;
            next_btn.IconMarginRight = 0;
            next_btn.IconRightVisible = true;
            next_btn.IconRightZoom = 35D;
            next_btn.IconVisible = true;
            next_btn.IconZoom = 35D;
            next_btn.IsTab = false;
            next_btn.Location = new Point(863, 688);
            next_btn.Margin = new Padding(6, 7, 6, 7);
            next_btn.Name = "next_btn";
            next_btn.Normalcolor = Color.FromArgb(43, 47, 84);
            next_btn.OnHovercolor = Color.FromArgb(86, 94, 169);
            next_btn.OnHoverTextColor = Color.WhiteSmoke;
            next_btn.Padding = new Padding(11, 8, 11, 8);
            next_btn.RightToLeft = RightToLeft.No;
            next_btn.selected = false;
            next_btn.Size = new Size(234, 58);
            next_btn.TabIndex = 56;
            next_btn.Text = "Next";
            next_btn.TextAlign = ContentAlignment.MiddleCenter;
            next_btn.Textcolor = Color.White;
            next_btn.TextFont = new Font("Poppins Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            next_btn.Click += next_btn_Click;
            // 
            // previous_btn
            // 
            previous_btn.Active = false;
            previous_btn.Activecolor = Color.FromArgb(60, 64, 98);
            previous_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            previous_btn.BackColor = Color.FromArgb(43, 47, 84);
            previous_btn.BackgroundImageLayout = ImageLayout.Stretch;
            previous_btn.BorderRadius = 5;
            previous_btn.ButtonText = "Previous";
            previous_btn.DisabledColor = Color.Gray;
            previous_btn.Iconcolor = Color.Transparent;
            previous_btn.Iconimage = null;
            previous_btn.Iconimage_right = null;
            previous_btn.Iconimage_right_Selected = null;
            previous_btn.Iconimage_Selected = null;
            previous_btn.IconMarginLeft = 0;
            previous_btn.IconMarginRight = 0;
            previous_btn.IconRightVisible = true;
            previous_btn.IconRightZoom = 40D;
            previous_btn.IconVisible = false;
            previous_btn.IconZoom = 40D;
            previous_btn.IsTab = false;
            previous_btn.Location = new Point(601, 688);
            previous_btn.Margin = new Padding(6, 7, 6, 7);
            previous_btn.Name = "previous_btn";
            previous_btn.Normalcolor = Color.FromArgb(43, 47, 84);
            previous_btn.OnHovercolor = Color.FromArgb(86, 94, 169);
            previous_btn.OnHoverTextColor = Color.WhiteSmoke;
            previous_btn.Padding = new Padding(11, 8, 11, 8);
            previous_btn.RightToLeft = RightToLeft.No;
            previous_btn.selected = false;
            previous_btn.Size = new Size(234, 58);
            previous_btn.TabIndex = 55;
            previous_btn.Text = "Previous";
            previous_btn.TextAlign = ContentAlignment.MiddleCenter;
            previous_btn.Textcolor = Color.White;
            previous_btn.TextFont = new Font("Poppins Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            previous_btn.Click += previous_btn_Click_1;
            // 
            // data_count_lbl
            // 
            data_count_lbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            data_count_lbl.AutoSize = true;
            data_count_lbl.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            data_count_lbl.ForeColor = Color.FromArgb(43, 47, 84);
            data_count_lbl.Location = new Point(27, 705);
            data_count_lbl.Name = "data_count_lbl";
            data_count_lbl.Size = new Size(28, 36);
            data_count_lbl.TabIndex = 57;
            data_count_lbl.Text = "0";
            data_count_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1129, 768);
            Controls.Add(data_count_lbl);
            Controls.Add(next_btn);
            Controls.Add(previous_btn);
            Controls.Add(loadingPanel);
            Controls.Add(label12);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(report_dtg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reports";
            Text = "Reports";
            Load += Reports_Load;
            gender_tPanel.ResumeLayout(false);
            female_panel.ResumeLayout(false);
            female_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            male_panel.ResumeLayout(false);
            male_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            grade_panel.ResumeLayout(false);
            grade_panel.PerformLayout();
            report_card_panel.ResumeLayout(false);
            report_card_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)report_dtg).EndInit();
            loadingPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TableLayoutPanel gender_tPanel;
        private Panel female_panel;
        private Label female_count;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel male_panel;
        private Label male_count;
        private Label label1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel report_card_panel;
        private Panel grade_panel;
        private Bunifu.Framework.UI.BunifuElipse dtg_rad;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Label label6;
        private Label label4;
        private Label sf9_lbl;
        private Label sf10_lbl;
        private Label label12;
        private Bunifu.Framework.UI.BunifuCustomDataGrid report_dtg;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Panel loadingPanel;
        private Label loadingTxt;
        private Bunifu.Framework.UI.BunifuFlatButton next_btn;
        private Bunifu.Framework.UI.BunifuFlatButton previous_btn;
        private Label data_count_lbl;
    }
}