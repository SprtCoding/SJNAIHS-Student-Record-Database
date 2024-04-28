namespace Student_Record.AdminModule
{
    partial class StudentProfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentProfiles));
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
            dtg_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            student_dtg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            lrn = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            grade_level = new DataGridViewTextBoxColumn();
            section = new DataGridViewTextBoxColumn();
            action = new DataGridViewImageColumn();
            details = new DataGridViewImageColumn();
            f_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            filter_gb = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            filter_type_cbx = new ComboBox();
            panel2 = new Panel();
            filter_value_cbx = new ComboBox();
            m_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            gender_tPanel.SuspendLayout();
            female_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            male_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)student_dtg).BeginInit();
            filter_gb.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(11, 8);
            label2.Name = "label2";
            label2.Size = new Size(290, 56);
            label2.TabIndex = 7;
            label2.Text = "Student Profiles";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gender_tPanel
            // 
            gender_tPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gender_tPanel.ColumnCount = 2;
            gender_tPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            gender_tPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            gender_tPanel.Controls.Add(female_panel, 1, 0);
            gender_tPanel.Controls.Add(male_panel, 0, 0);
            gender_tPanel.Location = new Point(11, 78);
            gender_tPanel.Name = "gender_tPanel";
            gender_tPanel.Padding = new Padding(6, 5, 6, 5);
            gender_tPanel.RowCount = 1;
            gender_tPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            gender_tPanel.Size = new Size(1104, 312);
            gender_tPanel.TabIndex = 8;
            // 
            // female_panel
            // 
            female_panel.BackColor = Color.FromArgb(229, 71, 161);
            female_panel.Controls.Add(female_count);
            female_panel.Controls.Add(label3);
            female_panel.Controls.Add(pictureBox2);
            female_panel.Cursor = Cursors.Hand;
            female_panel.Dock = DockStyle.Fill;
            female_panel.Location = new Point(562, 15);
            female_panel.Margin = new Padding(10);
            female_panel.Name = "female_panel";
            female_panel.Padding = new Padding(6, 5, 6, 5);
            female_panel.Size = new Size(526, 282);
            female_panel.TabIndex = 1;
            female_panel.Click += female_panel_Click;
            // 
            // female_count
            // 
            female_count.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            female_count.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            female_count.ForeColor = Color.WhiteSmoke;
            female_count.Location = new Point(23, 100);
            female_count.Name = "female_count";
            female_count.Size = new Size(479, 165);
            female_count.TabIndex = 10;
            female_count.Text = "0";
            female_count.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(23, 25);
            label3.Name = "label3";
            label3.Size = new Size(149, 56);
            label3.TabIndex = 9;
            label3.Text = "FEMALE";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(426, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 75);
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
            male_panel.Location = new Point(16, 15);
            male_panel.Margin = new Padding(10);
            male_panel.Name = "male_panel";
            male_panel.Padding = new Padding(6, 5, 6, 5);
            male_panel.Size = new Size(526, 282);
            male_panel.TabIndex = 0;
            male_panel.Click += male_panel_Click;
            // 
            // male_count
            // 
            male_count.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            male_count.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            male_count.ForeColor = Color.WhiteSmoke;
            male_count.Location = new Point(23, 100);
            male_count.Name = "male_count";
            male_count.Size = new Size(477, 165);
            male_count.TabIndex = 9;
            male_count.Text = "0";
            male_count.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(113, 56);
            label1.TabIndex = 8;
            label1.Text = "MALE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(426, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dtg_rad
            // 
            dtg_rad.ElipseRadius = 5;
            dtg_rad.TargetControl = student_dtg;
            // 
            // student_dtg
            // 
            student_dtg.AllowUserToAddRows = false;
            student_dtg.AllowUserToDeleteRows = false;
            student_dtg.AllowUserToResizeColumns = false;
            student_dtg.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle1.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(43, 47, 84);
            student_dtg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            student_dtg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            student_dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            student_dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            student_dtg.BackgroundColor = Color.WhiteSmoke;
            student_dtg.BorderStyle = BorderStyle.None;
            student_dtg.CellBorderStyle = DataGridViewCellBorderStyle.None;
            student_dtg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle2.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Padding = new Padding(15);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            student_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            student_dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            student_dtg.Columns.AddRange(new DataGridViewColumn[] { id, name, lrn, gender, grade_level, section, action, details });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle3.Padding = new Padding(15);
            dataGridViewCellStyle3.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            student_dtg.DefaultCellStyle = dataGridViewCellStyle3;
            student_dtg.DoubleBuffered = true;
            student_dtg.EnableHeadersVisualStyles = false;
            student_dtg.GridColor = Color.FromArgb(60, 64, 98);
            student_dtg.HeaderBgColor = Color.FromArgb(43, 47, 84);
            student_dtg.HeaderForeColor = Color.WhiteSmoke;
            student_dtg.Location = new Point(27, 518);
            student_dtg.Name = "student_dtg";
            student_dtg.ReadOnly = true;
            student_dtg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            student_dtg.RowHeadersVisible = false;
            student_dtg.RowHeadersWidth = 62;
            student_dtg.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            student_dtg.RowTemplate.Height = 33;
            student_dtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            student_dtg.ShowCellErrors = false;
            student_dtg.ShowEditingIcon = false;
            student_dtg.ShowRowErrors = false;
            student_dtg.Size = new Size(1073, 550);
            student_dtg.TabIndex = 9;
            student_dtg.CellContentClick += student_dtg_CellContentClick;
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
            // lrn
            // 
            lrn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            lrn.HeaderText = "LRN NUMBER";
            lrn.MinimumWidth = 8;
            lrn.Name = "lrn";
            lrn.ReadOnly = true;
            lrn.Width = 197;
            // 
            // gender
            // 
            gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gender.HeaderText = "GENDER";
            gender.MinimumWidth = 8;
            gender.Name = "gender";
            gender.ReadOnly = true;
            gender.Width = 153;
            // 
            // grade_level
            // 
            grade_level.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grade_level.HeaderText = "GRADE LEVEL";
            grade_level.MinimumWidth = 8;
            grade_level.Name = "grade_level";
            grade_level.ReadOnly = true;
            grade_level.Width = 200;
            // 
            // section
            // 
            section.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            section.HeaderText = "SECTION";
            section.MinimumWidth = 8;
            section.Name = "section";
            section.ReadOnly = true;
            section.Width = 161;
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
            // details
            // 
            details.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            details.HeaderText = "DETAILS";
            details.MinimumWidth = 8;
            details.Name = "details";
            details.ReadOnly = true;
            details.Width = 124;
            // 
            // f_rad
            // 
            f_rad.ElipseRadius = 5;
            f_rad.TargetControl = female_panel;
            // 
            // filter_gb
            // 
            filter_gb.Controls.Add(tableLayoutPanel1);
            filter_gb.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            filter_gb.Location = new Point(27, 412);
            filter_gb.Name = "filter_gb";
            filter_gb.Size = new Size(546, 92);
            filter_gb.TabIndex = 10;
            filter_gb.TabStop = false;
            filter_gb.Text = "Filter by";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(540, 59);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(filter_type_cbx);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 53);
            panel1.TabIndex = 0;
            // 
            // filter_type_cbx
            // 
            filter_type_cbx.Dock = DockStyle.Fill;
            filter_type_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            filter_type_cbx.FlatStyle = FlatStyle.Flat;
            filter_type_cbx.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            filter_type_cbx.FormattingEnabled = true;
            filter_type_cbx.ItemHeight = 32;
            filter_type_cbx.Items.AddRange(new object[] { "Any", "Section", "Grade Level" });
            filter_type_cbx.Location = new Point(0, 0);
            filter_type_cbx.Margin = new Padding(6, 5, 6, 5);
            filter_type_cbx.Name = "filter_type_cbx";
            filter_type_cbx.Size = new Size(194, 40);
            filter_type_cbx.TabIndex = 0;
            filter_type_cbx.SelectedIndexChanged += filter_type_cbx_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(filter_value_cbx);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(203, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 53);
            panel2.TabIndex = 1;
            // 
            // filter_value_cbx
            // 
            filter_value_cbx.Dock = DockStyle.Fill;
            filter_value_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            filter_value_cbx.Enabled = false;
            filter_value_cbx.FlatStyle = FlatStyle.Flat;
            filter_value_cbx.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            filter_value_cbx.FormattingEnabled = true;
            filter_value_cbx.ItemHeight = 32;
            filter_value_cbx.Location = new Point(0, 0);
            filter_value_cbx.Margin = new Padding(6, 5, 6, 5);
            filter_value_cbx.Name = "filter_value_cbx";
            filter_value_cbx.Size = new Size(334, 40);
            filter_value_cbx.TabIndex = 1;
            filter_value_cbx.SelectedIndexChanged += filter_value_cbx_SelectedIndexChanged;
            // 
            // m_rad
            // 
            m_rad.ElipseRadius = 5;
            m_rad.TargetControl = male_panel;
            // 
            // StudentProfiles
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1129, 1102);
            Controls.Add(filter_gb);
            Controls.Add(student_dtg);
            Controls.Add(gender_tPanel);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentProfiles";
            Text = "StudentProfiles";
            gender_tPanel.ResumeLayout(false);
            female_panel.ResumeLayout(false);
            female_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            male_panel.ResumeLayout(false);
            male_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)student_dtg).EndInit();
            filter_gb.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TableLayoutPanel gender_tPanel;
        private Panel female_panel;
        private Panel male_panel;
        private Bunifu.Framework.UI.BunifuElipse dtg_rad;
        private Bunifu.Framework.UI.BunifuElipse f_rad;
        private PictureBox pictureBox1;
        private Label female_count;
        private Label label3;
        private PictureBox pictureBox2;
        private Label male_count;
        private Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid student_dtg;
        private GroupBox filter_gb;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private ComboBox filter_type_cbx;
        private Panel panel2;
        private ComboBox filter_value_cbx;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn lrn;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn grade_level;
        private DataGridViewTextBoxColumn section;
        private DataGridViewImageColumn action;
        private DataGridViewImageColumn details;
        private Bunifu.Framework.UI.BunifuElipse m_rad;
    }
}