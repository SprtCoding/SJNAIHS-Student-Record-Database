namespace Student_Record.TeachersModule
{
    partial class ReportCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportCard));
            label2 = new Label();
            student_dtg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            grade_level = new DataGridViewTextBoxColumn();
            section = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            action = new DataGridViewImageColumn();
            no_data_panel = new Panel();
            loadingLbl = new Label();
            no_data_pb = new PictureBox();
            panel1 = new Panel();
            search_tb = new TextBox();
            pictureBox1 = new PictureBox();
            next_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            previous_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            data_count_lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)student_dtg).BeginInit();
            no_data_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)no_data_pb).BeginInit();
            panel1.SuspendLayout();
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
            label2.Size = new Size(143, 30);
            label2.TabIndex = 11;
            label2.Text = "Report Card";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            student_dtg.BackgroundColor = SystemColors.Control;
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
            student_dtg.Columns.AddRange(new DataGridViewColumn[] { id, name, grade_level, section, gender, action });
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
            student_dtg.Location = new Point(8, 93);
            student_dtg.Margin = new Padding(2);
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
            student_dtg.Size = new Size(768, 287);
            student_dtg.TabIndex = 12;
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
            name.FillWeight = 238.0166F;
            name.HeaderText = "NAME";
            name.MinimumWidth = 8;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // grade_level
            // 
            grade_level.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grade_level.FillWeight = 1.89533591F;
            grade_level.HeaderText = "GRADE LEVEL";
            grade_level.MinimumWidth = 8;
            grade_level.Name = "grade_level";
            grade_level.ReadOnly = true;
            grade_level.Width = 147;
            // 
            // section
            // 
            section.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            section.FillWeight = 3.38452816F;
            section.HeaderText = "SECTION";
            section.MinimumWidth = 8;
            section.Name = "section";
            section.ReadOnly = true;
            section.Width = 120;
            // 
            // gender
            // 
            gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gender.FillWeight = 44.87078F;
            gender.HeaderText = "GENDER";
            gender.MinimumWidth = 8;
            gender.Name = "gender";
            gender.ReadOnly = true;
            gender.Width = 116;
            // 
            // action
            // 
            action.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            action.FillWeight = 2.74193168F;
            action.HeaderText = "ACTION";
            action.MinimumWidth = 30;
            action.Name = "action";
            action.ReadOnly = true;
            action.Width = 95;
            // 
            // no_data_panel
            // 
            no_data_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            no_data_panel.Controls.Add(loadingLbl);
            no_data_panel.Controls.Add(no_data_pb);
            no_data_panel.Location = new Point(8, 93);
            no_data_panel.Margin = new Padding(2);
            no_data_panel.Name = "no_data_panel";
            no_data_panel.Size = new Size(768, 287);
            no_data_panel.TabIndex = 25;
            // 
            // loadingLbl
            // 
            loadingLbl.Anchor = AnchorStyles.None;
            loadingLbl.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            loadingLbl.ForeColor = Color.FromArgb(60, 64, 98);
            loadingLbl.Location = new Point(98, 186);
            loadingLbl.Margin = new Padding(2, 0, 2, 0);
            loadingLbl.Name = "loadingLbl";
            loadingLbl.Size = new Size(573, 23);
            loadingLbl.TabIndex = 19;
            loadingLbl.Text = "No data found!";
            loadingLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // no_data_pb
            // 
            no_data_pb.Anchor = AnchorStyles.None;
            no_data_pb.Image = (Image)resources.GetObject("no_data_pb.Image");
            no_data_pb.Location = new Point(232, 64);
            no_data_pb.Margin = new Padding(2);
            no_data_pb.Name = "no_data_pb";
            no_data_pb.Size = new Size(304, 131);
            no_data_pb.SizeMode = PictureBoxSizeMode.Zoom;
            no_data_pb.TabIndex = 0;
            no_data_pb.TabStop = false;
            no_data_pb.Visible = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(search_tb);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(8, 44);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 40);
            panel1.TabIndex = 28;
            // 
            // search_tb
            // 
            search_tb.BackColor = SystemColors.Control;
            search_tb.BorderStyle = BorderStyle.None;
            search_tb.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            search_tb.Location = new Point(36, 11);
            search_tb.Margin = new Padding(2);
            search_tb.Name = "search_tb";
            search_tb.PlaceholderText = "Search...";
            search_tb.Size = new Size(268, 18);
            search_tb.TabIndex = 29;
            search_tb.TextChanged += search_tb_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(17, 14);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
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
            next_btn.Location = new Point(612, 404);
            next_btn.Margin = new Padding(4);
            next_btn.Name = "next_btn";
            next_btn.Normalcolor = Color.FromArgb(33, 56, 77);
            next_btn.OnHovercolor = Color.FromArgb(86, 94, 169);
            next_btn.OnHoverTextColor = Color.WhiteSmoke;
            next_btn.Padding = new Padding(8, 5, 8, 5);
            next_btn.RightToLeft = RightToLeft.No;
            next_btn.selected = false;
            next_btn.Size = new Size(164, 35);
            next_btn.TabIndex = 58;
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
            previous_btn.Location = new Point(422, 404);
            previous_btn.Margin = new Padding(4);
            previous_btn.Name = "previous_btn";
            previous_btn.Normalcolor = Color.FromArgb(33, 56, 77);
            previous_btn.OnHovercolor = Color.FromArgb(86, 94, 169);
            previous_btn.OnHoverTextColor = Color.WhiteSmoke;
            previous_btn.Padding = new Padding(8, 5, 8, 5);
            previous_btn.RightToLeft = RightToLeft.No;
            previous_btn.selected = false;
            previous_btn.Size = new Size(164, 35);
            previous_btn.TabIndex = 57;
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
            data_count_lbl.Location = new Point(8, 414);
            data_count_lbl.Margin = new Padding(2, 0, 2, 0);
            data_count_lbl.Name = "data_count_lbl";
            data_count_lbl.Size = new Size(21, 25);
            data_count_lbl.TabIndex = 59;
            data_count_lbl.Text = "0";
            data_count_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReportCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 461);
            Controls.Add(data_count_lbl);
            Controls.Add(next_btn);
            Controls.Add(previous_btn);
            Controls.Add(panel1);
            Controls.Add(no_data_panel);
            Controls.Add(student_dtg);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ReportCard";
            Text = "ReportCard";
            Load += ReportCard_Load;
            ((System.ComponentModel.ISupportInitialize)student_dtg).EndInit();
            no_data_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)no_data_pb).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid student_dtg;
        private Panel no_data_panel;
        private Label loadingLbl;
        private PictureBox no_data_pb;
        private Panel panel1;
        private TextBox search_tb;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn grade_level;
        private DataGridViewTextBoxColumn section;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewImageColumn action;
        private Bunifu.Framework.UI.BunifuFlatButton next_btn;
        private Bunifu.Framework.UI.BunifuFlatButton previous_btn;
        private Label data_count_lbl;
    }
}