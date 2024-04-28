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
            grade_lbl = new Label();
            label4 = new Label();
            report_card_panel = new Panel();
            label10 = new Label();
            label6 = new Label();
            dtg_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(components);
            label12 = new Label();
            report_dtg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            report_type = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            action = new DataGridViewImageColumn();
            bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(components);
            gender_tPanel.SuspendLayout();
            female_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            male_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            grade_panel.SuspendLayout();
            report_card_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)report_dtg).BeginInit();
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
            tableLayoutPanel1.Size = new Size(1104, 408);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // grade_panel
            // 
            grade_panel.BackColor = Color.FromArgb(43, 47, 84);
            grade_panel.Controls.Add(grade_lbl);
            grade_panel.Controls.Add(label4);
            grade_panel.Dock = DockStyle.Fill;
            grade_panel.Location = new Point(16, 15);
            grade_panel.Margin = new Padding(10, 10, 10, 10);
            grade_panel.Name = "grade_panel";
            grade_panel.Size = new Size(526, 378);
            grade_panel.TabIndex = 0;
            // 
            // grade_lbl
            // 
            grade_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grade_lbl.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            grade_lbl.ForeColor = Color.WhiteSmoke;
            grade_lbl.Location = new Point(20, 82);
            grade_lbl.Name = "grade_lbl";
            grade_lbl.Size = new Size(484, 277);
            grade_lbl.TabIndex = 10;
            grade_lbl.Text = "0";
            grade_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(17, 17);
            label4.Name = "label4";
            label4.Size = new Size(136, 56);
            label4.TabIndex = 9;
            label4.Text = "GRADE";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // report_card_panel
            // 
            report_card_panel.BackColor = Color.FromArgb(129, 142, 254);
            report_card_panel.Controls.Add(label10);
            report_card_panel.Controls.Add(label6);
            report_card_panel.Dock = DockStyle.Fill;
            report_card_panel.Location = new Point(562, 15);
            report_card_panel.Margin = new Padding(10, 10, 10, 10);
            report_card_panel.Name = "report_card_panel";
            report_card_panel.Size = new Size(526, 378);
            report_card_panel.TabIndex = 2;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label10.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(20, 82);
            label10.Name = "label10";
            label10.Size = new Size(484, 277);
            label10.TabIndex = 12;
            label10.Text = "0";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(17, 17);
            label6.Name = "label6";
            label6.Size = new Size(249, 56);
            label6.TabIndex = 11;
            label6.Text = "REPORT CARD";
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
            label12.Location = new Point(27, 497);
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
            report_dtg.Columns.AddRange(new DataGridViewColumn[] { id, name, report_type, status, action });
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
            report_dtg.Location = new Point(27, 547);
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
            report_dtg.Size = new Size(1074, 532);
            report_dtg.TabIndex = 10;
            report_dtg.CellContentClick += report_dtg_CellContentClick;
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
            name.HeaderText = "FACULTY";
            name.MinimumWidth = 8;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // report_type
            // 
            report_type.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            report_type.HeaderText = "REPORT TYPE";
            report_type.MinimumWidth = 8;
            report_type.Name = "report_type";
            report_type.ReadOnly = true;
            report_type.Width = 201;
            // 
            // status
            // 
            status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            status.HeaderText = "STATUS";
            status.MinimumWidth = 8;
            status.Name = "status";
            status.ReadOnly = true;
            status.Width = 151;
            // 
            // action
            // 
            action.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            action.HeaderText = "ACTION";
            action.MinimumWidth = 30;
            action.Name = "action";
            action.ReadOnly = true;
            action.Width = 123;
            // 
            // bunifuElipse4
            // 
            bunifuElipse4.ElipseRadius = 5;
            bunifuElipse4.TargetControl = report_dtg;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1129, 1102);
            Controls.Add(report_dtg);
            Controls.Add(label12);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reports";
            Text = "Reports";
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
        private Label grade_lbl;
        private Label label10;
        private Label label12;
        private Bunifu.Framework.UI.BunifuCustomDataGrid report_dtg;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn report_type;
        private DataGridViewTextBoxColumn status;
        private DataGridViewImageColumn action;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
    }
}