namespace Student_Record.TeachersModule
{
    partial class StudentRecordPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRecordPage));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            search_tb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            student_dtg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            grade_level = new DataGridViewTextBoxColumn();
            section = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            no_data_panel = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)student_dtg).BeginInit();
            no_data_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(11, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 30);
            label2.TabIndex = 10;
            label2.Text = "Student Record";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 56);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(17, 14);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // search_tb
            // 
            search_tb.BorderColorFocused = Color.FromArgb(129, 142, 254);
            search_tb.BorderColorIdle = Color.FromArgb(43, 47, 84);
            search_tb.BorderColorMouseHover = Color.FromArgb(129, 142, 254);
            search_tb.BorderThickness = 1;
            search_tb.characterCasing = CharacterCasing.Normal;
            search_tb.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            search_tb.ForeColor = Color.FromArgb(64, 64, 64);
            search_tb.isPassword = false;
            search_tb.Location = new Point(11, 43);
            search_tb.Margin = new Padding(4);
            search_tb.MaxLength = 32767;
            search_tb.Name = "search_tb";
            search_tb.Padding = new Padding(35, 0, 0, 0);
            search_tb.Size = new Size(309, 39);
            search_tb.TabIndex = 28;
            search_tb.Text = "Search...";
            search_tb.TextAlign = HorizontalAlignment.Left;
            search_tb.OnValueChanged += search_tb_OnValueChanged;
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
            student_dtg.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
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
            student_dtg.Columns.AddRange(new DataGridViewColumn[] { id, name, grade_level, section, gender });
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
            student_dtg.Location = new Point(11, 88);
            student_dtg.Margin = new Padding(2);
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
            student_dtg.Size = new Size(768, 562);
            student_dtg.TabIndex = 30;
            student_dtg.CellClick += student_dtg_CellClick;
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
            // no_data_panel
            // 
            no_data_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            no_data_panel.Controls.Add(label1);
            no_data_panel.Controls.Add(pictureBox1);
            no_data_panel.Location = new Point(11, 88);
            no_data_panel.Margin = new Padding(2);
            no_data_panel.Name = "no_data_panel";
            no_data_panel.Size = new Size(768, 562);
            no_data_panel.TabIndex = 31;
            no_data_panel.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(60, 64, 98);
            label1.Location = new Point(98, 331);
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
            pictureBox1.Location = new Point(232, 209);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // StudentRecordPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 661);
            Controls.Add(no_data_panel);
            Controls.Add(student_dtg);
            Controls.Add(pictureBox2);
            Controls.Add(search_tb);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentRecordPage";
            Text = "StudentRecordPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)student_dtg).EndInit();
            no_data_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMetroTextbox search_tb;
        private Bunifu.Framework.UI.BunifuCustomDataGrid student_dtg;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn grade_level;
        private DataGridViewTextBoxColumn section;
        private DataGridViewTextBoxColumn gender;
        private Panel no_data_panel;
        private Label label1;
        private PictureBox pictureBox1;
    }
}