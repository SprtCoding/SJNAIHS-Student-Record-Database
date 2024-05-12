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
            label3 = new Label();
            pictureBox2 = new PictureBox();
            female_count = new Label();
            male_panel = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            male_count = new Label();
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
            filter_type_cbx = new ComboBox();
            filter_value_cbx = new ComboBox();
            m_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            loadingPanel = new Panel();
            loadingTxt = new Label();
            label4 = new Label();
            panel1 = new Panel();
            search_tb = new TextBox();
            pictureBox3 = new PictureBox();
            next_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            previous_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            data_count_lbl = new Label();
            gender_tPanel.SuspendLayout();
            female_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            male_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)student_dtg).BeginInit();
            loadingPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(8, 5);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(201, 39);
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
            gender_tPanel.Location = new Point(9, 47);
            gender_tPanel.Margin = new Padding(2, 2, 2, 2);
            gender_tPanel.Name = "gender_tPanel";
            gender_tPanel.Padding = new Padding(4, 3, 4, 3);
            gender_tPanel.RowCount = 1;
            gender_tPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            gender_tPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 181F));
            gender_tPanel.Size = new Size(770, 187);
            gender_tPanel.TabIndex = 8;
            // 
            // female_panel
            // 
            female_panel.BackColor = Color.FromArgb(229, 71, 161);
            female_panel.Controls.Add(label3);
            female_panel.Controls.Add(pictureBox2);
            female_panel.Controls.Add(female_count);
            female_panel.Cursor = Cursors.Hand;
            female_panel.Dock = DockStyle.Fill;
            female_panel.Location = new Point(392, 9);
            female_panel.Margin = new Padding(7, 6, 7, 6);
            female_panel.Name = "female_panel";
            female_panel.Padding = new Padding(4, 3, 4, 3);
            female_panel.Size = new Size(367, 169);
            female_panel.TabIndex = 1;
            female_panel.Click += female_panel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(16, 15);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 39);
            label3.TabIndex = 9;
            label3.Text = "FEMALE";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(307, 15);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // female_count
            // 
            female_count.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            female_count.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            female_count.ForeColor = Color.WhiteSmoke;
            female_count.Location = new Point(16, 60);
            female_count.Margin = new Padding(2, 0, 2, 0);
            female_count.Name = "female_count";
            female_count.Size = new Size(335, 99);
            female_count.TabIndex = 10;
            female_count.Text = "0";
            female_count.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // male_panel
            // 
            male_panel.BackColor = Color.FromArgb(2, 158, 246);
            male_panel.Controls.Add(label1);
            male_panel.Controls.Add(pictureBox1);
            male_panel.Controls.Add(male_count);
            male_panel.Cursor = Cursors.Hand;
            male_panel.Dock = DockStyle.Fill;
            male_panel.Location = new Point(11, 9);
            male_panel.Margin = new Padding(7, 6, 7, 6);
            male_panel.Name = "male_panel";
            male_panel.Padding = new Padding(4, 3, 4, 3);
            male_panel.Size = new Size(367, 169);
            male_panel.TabIndex = 0;
            male_panel.Click += male_panel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(16, 15);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 39);
            label1.TabIndex = 8;
            label1.Text = "MALE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(307, 15);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // male_count
            // 
            male_count.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            male_count.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            male_count.ForeColor = Color.WhiteSmoke;
            male_count.Location = new Point(16, 60);
            male_count.Margin = new Padding(2, 0, 2, 0);
            male_count.Name = "male_count";
            male_count.Size = new Size(334, 99);
            male_count.TabIndex = 9;
            male_count.Text = "0";
            male_count.TextAlign = ContentAlignment.MiddleLeft;
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
            student_dtg.Location = new Point(20, 314);
            student_dtg.Margin = new Padding(2, 2, 2, 2);
            student_dtg.Name = "student_dtg";
            student_dtg.ReadOnly = true;
            student_dtg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            student_dtg.RowHeadersVisible = false;
            student_dtg.RowHeadersWidth = 62;
            student_dtg.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            student_dtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            student_dtg.ShowCellErrors = false;
            student_dtg.ShowEditingIcon = false;
            student_dtg.ShowRowErrors = false;
            student_dtg.Size = new Size(748, 97);
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
            name.HeaderText = "Name";
            name.MinimumWidth = 8;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // lrn
            // 
            lrn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lrn.HeaderText = "Lrn Number";
            lrn.MinimumWidth = 8;
            lrn.Name = "lrn";
            lrn.ReadOnly = true;
            // 
            // gender
            // 
            gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gender.HeaderText = "Gender";
            gender.MinimumWidth = 8;
            gender.Name = "gender";
            gender.ReadOnly = true;
            // 
            // grade_level
            // 
            grade_level.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grade_level.HeaderText = "Grade Level";
            grade_level.MinimumWidth = 8;
            grade_level.Name = "grade_level";
            grade_level.ReadOnly = true;
            // 
            // section
            // 
            section.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            section.HeaderText = "Section";
            section.MinimumWidth = 8;
            section.Name = "section";
            section.ReadOnly = true;
            // 
            // action
            // 
            action.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            action.HeaderText = "Action";
            action.MinimumWidth = 8;
            action.Name = "action";
            action.ReadOnly = true;
            action.Width = 88;
            // 
            // details
            // 
            details.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            details.HeaderText = "Details";
            details.MinimumWidth = 8;
            details.Name = "details";
            details.ReadOnly = true;
            details.Width = 91;
            // 
            // f_rad
            // 
            f_rad.ElipseRadius = 5;
            f_rad.TargetControl = female_panel;
            // 
            // filter_type_cbx
            // 
            filter_type_cbx.BackColor = Color.FromArgb(33, 56, 77);
            filter_type_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            filter_type_cbx.FlatStyle = FlatStyle.Flat;
            filter_type_cbx.Font = new Font("Poppins Light", 10F, FontStyle.Italic, GraphicsUnit.Point);
            filter_type_cbx.ForeColor = Color.WhiteSmoke;
            filter_type_cbx.FormattingEnabled = true;
            filter_type_cbx.ItemHeight = 23;
            filter_type_cbx.Items.AddRange(new object[] { "Any", "Section", "Grade Level" });
            filter_type_cbx.Location = new Point(19, 273);
            filter_type_cbx.Margin = new Padding(4, 3, 4, 3);
            filter_type_cbx.Name = "filter_type_cbx";
            filter_type_cbx.Size = new Size(144, 31);
            filter_type_cbx.TabIndex = 0;
            filter_type_cbx.SelectedIndexChanged += filter_type_cbx_SelectedIndexChanged;
            // 
            // filter_value_cbx
            // 
            filter_value_cbx.BackColor = Color.FromArgb(33, 56, 77);
            filter_value_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            filter_value_cbx.Enabled = false;
            filter_value_cbx.FlatStyle = FlatStyle.Flat;
            filter_value_cbx.Font = new Font("Poppins Light", 10F, FontStyle.Italic, GraphicsUnit.Point);
            filter_value_cbx.ForeColor = Color.WhiteSmoke;
            filter_value_cbx.FormattingEnabled = true;
            filter_value_cbx.ItemHeight = 23;
            filter_value_cbx.Location = new Point(178, 273);
            filter_value_cbx.Margin = new Padding(4, 3, 4, 3);
            filter_value_cbx.Name = "filter_value_cbx";
            filter_value_cbx.Size = new Size(235, 31);
            filter_value_cbx.TabIndex = 1;
            filter_value_cbx.SelectedIndexChanged += filter_value_cbx_SelectedIndexChanged;
            // 
            // m_rad
            // 
            m_rad.ElipseRadius = 5;
            m_rad.TargetControl = male_panel;
            // 
            // loadingPanel
            // 
            loadingPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loadingPanel.Controls.Add(loadingTxt);
            loadingPanel.Location = new Point(19, 314);
            loadingPanel.Margin = new Padding(2, 2, 2, 2);
            loadingPanel.Name = "loadingPanel";
            loadingPanel.Size = new Size(749, 97);
            loadingPanel.TabIndex = 13;
            // 
            // loadingTxt
            // 
            loadingTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            loadingTxt.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            loadingTxt.ForeColor = Color.FromArgb(43, 47, 84);
            loadingTxt.Location = new Point(27, 36);
            loadingTxt.Margin = new Padding(2, 0, 2, 0);
            loadingTxt.Name = "loadingTxt";
            loadingTxt.Size = new Size(696, 23);
            loadingTxt.TabIndex = 0;
            loadingTxt.Text = "loading data...";
            loadingTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(19, 248);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 14;
            label4.Text = "Filter By";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(search_tb);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(452, 264);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 40);
            panel1.TabIndex = 29;
            // 
            // search_tb
            // 
            search_tb.BackColor = SystemColors.Control;
            search_tb.BorderStyle = BorderStyle.None;
            search_tb.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            search_tb.Location = new Point(36, 11);
            search_tb.Margin = new Padding(2, 2, 2, 2);
            search_tb.Name = "search_tb";
            search_tb.PlaceholderText = "Search...";
            search_tb.Size = new Size(268, 18);
            search_tb.TabIndex = 29;
            search_tb.TextChanged += search_tb_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 13);
            pictureBox3.Margin = new Padding(2, 2, 2, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(17, 14);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // next_btn
            // 
            next_btn.Active = false;
            next_btn.Activecolor = Color.FromArgb(60, 64, 98);
            next_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            next_btn.BackColor = Color.FromArgb(33, 56, 77);
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
            next_btn.Location = new Point(604, 417);
            next_btn.Margin = new Padding(4, 4, 4, 4);
            next_btn.Name = "next_btn";
            next_btn.Normalcolor = Color.FromArgb(33, 56, 77);
            next_btn.OnHovercolor = Color.FromArgb(86, 94, 169);
            next_btn.OnHoverTextColor = Color.WhiteSmoke;
            next_btn.Padding = new Padding(8, 5, 8, 5);
            next_btn.RightToLeft = RightToLeft.No;
            next_btn.selected = false;
            next_btn.Size = new Size(164, 35);
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
            previous_btn.BackColor = Color.FromArgb(33, 56, 77);
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
            previous_btn.Location = new Point(417, 417);
            previous_btn.Margin = new Padding(4, 4, 4, 4);
            previous_btn.Name = "previous_btn";
            previous_btn.Normalcolor = Color.FromArgb(33, 56, 77);
            previous_btn.OnHovercolor = Color.FromArgb(86, 94, 169);
            previous_btn.OnHoverTextColor = Color.WhiteSmoke;
            previous_btn.Padding = new Padding(8, 5, 8, 5);
            previous_btn.RightToLeft = RightToLeft.No;
            previous_btn.selected = false;
            previous_btn.Size = new Size(164, 35);
            previous_btn.TabIndex = 55;
            previous_btn.Text = "Previous";
            previous_btn.TextAlign = ContentAlignment.MiddleCenter;
            previous_btn.Textcolor = Color.White;
            previous_btn.TextFont = new Font("Poppins Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            previous_btn.Click += previous_btn_Click;
            // 
            // data_count_lbl
            // 
            data_count_lbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            data_count_lbl.AutoSize = true;
            data_count_lbl.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            data_count_lbl.ForeColor = Color.FromArgb(33, 56, 77);
            data_count_lbl.Location = new Point(20, 427);
            data_count_lbl.Margin = new Padding(2, 0, 2, 0);
            data_count_lbl.Name = "data_count_lbl";
            data_count_lbl.Size = new Size(21, 25);
            data_count_lbl.TabIndex = 57;
            data_count_lbl.Text = "0";
            data_count_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StudentProfiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(790, 461);
            Controls.Add(data_count_lbl);
            Controls.Add(next_btn);
            Controls.Add(panel1);
            Controls.Add(previous_btn);
            Controls.Add(label4);
            Controls.Add(filter_value_cbx);
            Controls.Add(filter_type_cbx);
            Controls.Add(loadingPanel);
            Controls.Add(student_dtg);
            Controls.Add(gender_tPanel);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "StudentProfiles";
            Text = "StudentProfiles";
            Load += StudentProfiles_Load;
            gender_tPanel.ResumeLayout(false);
            female_panel.ResumeLayout(false);
            female_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            male_panel.ResumeLayout(false);
            male_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)student_dtg).EndInit();
            loadingPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private ComboBox filter_type_cbx;
        private ComboBox filter_value_cbx;
        private Bunifu.Framework.UI.BunifuElipse m_rad;
        private Panel loadingPanel;
        private Label loadingTxt;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn lrn;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn grade_level;
        private DataGridViewTextBoxColumn section;
        private DataGridViewImageColumn action;
        private DataGridViewImageColumn details;
        private Label label4;
        private Panel panel1;
        private TextBox search_tb;
        private PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuFlatButton next_btn;
        private Bunifu.Framework.UI.BunifuFlatButton previous_btn;
        private Label data_count_lbl;
    }
}