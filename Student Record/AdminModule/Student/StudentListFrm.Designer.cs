namespace Student_Record.AdminModule.Student
{
    partial class StudentListFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentListFrm));
            dtg_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            label1 = new Label();
            faculty_name_lbl = new Label();
            student_dtg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            id = new DataGridViewTextBoxColumn();
            lrn = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            grade_sec = new DataGridViewTextBoxColumn();
            strand = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            adviser = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            search_tb = new TextBox();
            pictureBox2 = new PictureBox();
            close_btn = new PictureBox();
            data_count_lbl = new Label();
            previous_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            next_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)student_dtg).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)close_btn).BeginInit();
            SuspendLayout();
            // 
            // dtg_rad
            // 
            dtg_rad.ElipseRadius = 10;
            dtg_rad.TargetControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(29, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 39);
            label1.TabIndex = 40;
            label1.Text = "Students";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // faculty_name_lbl
            // 
            faculty_name_lbl.AutoSize = true;
            faculty_name_lbl.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            faculty_name_lbl.ForeColor = Color.WhiteSmoke;
            faculty_name_lbl.Location = new Point(29, 59);
            faculty_name_lbl.Margin = new Padding(2, 0, 2, 0);
            faculty_name_lbl.Name = "faculty_name_lbl";
            faculty_name_lbl.Size = new Size(106, 25);
            faculty_name_lbl.TabIndex = 42;
            faculty_name_lbl.Text = "Student list of";
            faculty_name_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // student_dtg
            // 
            student_dtg.AllowUserToAddRows = false;
            student_dtg.AllowUserToDeleteRows = false;
            student_dtg.AllowUserToResizeColumns = false;
            student_dtg.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            student_dtg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            student_dtg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            student_dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            student_dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            student_dtg.BackgroundColor = Color.FromArgb(43, 47, 84);
            student_dtg.BorderStyle = BorderStyle.None;
            student_dtg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle2.Font = new Font("Poppins Medium", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Padding = new Padding(15);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            student_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            student_dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            student_dtg.Columns.AddRange(new DataGridViewColumn[] { id, lrn, name, grade_sec, strand, gender, adviser });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Padding = new Padding(15);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle3.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            student_dtg.DefaultCellStyle = dataGridViewCellStyle3;
            student_dtg.DoubleBuffered = true;
            student_dtg.EnableHeadersVisualStyles = false;
            student_dtg.GridColor = Color.WhiteSmoke;
            student_dtg.HeaderBgColor = Color.FromArgb(43, 47, 84);
            student_dtg.HeaderForeColor = Color.WhiteSmoke;
            student_dtg.Location = new Point(30, 134);
            student_dtg.Margin = new Padding(2);
            student_dtg.Name = "student_dtg";
            student_dtg.ReadOnly = true;
            student_dtg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle4.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            student_dtg.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            student_dtg.RowHeadersVisible = false;
            student_dtg.RowHeadersWidth = 62;
            student_dtg.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            student_dtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            student_dtg.ShowCellErrors = false;
            student_dtg.ShowEditingIcon = false;
            student_dtg.ShowRowErrors = false;
            student_dtg.Size = new Size(906, 364);
            student_dtg.TabIndex = 45;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // lrn
            // 
            lrn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lrn.HeaderText = "Lrn Number";
            lrn.MinimumWidth = 8;
            lrn.Name = "lrn";
            lrn.ReadOnly = true;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Student Name";
            name.MinimumWidth = 8;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // grade_sec
            // 
            grade_sec.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grade_sec.HeaderText = "Grade/Section";
            grade_sec.MinimumWidth = 8;
            grade_sec.Name = "grade_sec";
            grade_sec.ReadOnly = true;
            // 
            // strand
            // 
            strand.HeaderText = "Strand";
            strand.MinimumWidth = 8;
            strand.Name = "strand";
            strand.ReadOnly = true;
            // 
            // gender
            // 
            gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gender.HeaderText = "Gender";
            gender.MinimumWidth = 8;
            gender.Name = "gender";
            gender.ReadOnly = true;
            // 
            // adviser
            // 
            adviser.HeaderText = "Adviser";
            adviser.MinimumWidth = 8;
            adviser.Name = "adviser";
            adviser.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(search_tb);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(30, 85);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 40);
            panel1.TabIndex = 46;
            // 
            // search_tb
            // 
            search_tb.BackColor = Color.FromArgb(43, 47, 84);
            search_tb.BorderStyle = BorderStyle.None;
            search_tb.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            search_tb.ForeColor = Color.WhiteSmoke;
            search_tb.Location = new Point(36, 11);
            search_tb.Margin = new Padding(2);
            search_tb.Name = "search_tb";
            search_tb.PlaceholderText = "Search...";
            search_tb.Size = new Size(268, 18);
            search_tb.TabIndex = 29;
            search_tb.TextChanged += search_tb_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 13);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(17, 14);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // close_btn
            // 
            close_btn.Cursor = Cursors.Hand;
            close_btn.Image = Properties.Resources.cross_white;
            close_btn.Location = new Point(939, 7);
            close_btn.Margin = new Padding(2);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(18, 15);
            close_btn.SizeMode = PictureBoxSizeMode.Zoom;
            close_btn.TabIndex = 47;
            close_btn.TabStop = false;
            close_btn.Click += close_btn_Click;
            // 
            // data_count_lbl
            // 
            data_count_lbl.AutoSize = true;
            data_count_lbl.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            data_count_lbl.ForeColor = Color.WhiteSmoke;
            data_count_lbl.Location = new Point(30, 530);
            data_count_lbl.Margin = new Padding(2, 0, 2, 0);
            data_count_lbl.Name = "data_count_lbl";
            data_count_lbl.Size = new Size(21, 25);
            data_count_lbl.TabIndex = 48;
            data_count_lbl.Text = "0";
            data_count_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // previous_btn
            // 
            previous_btn.Active = false;
            previous_btn.Activecolor = Color.FromArgb(60, 64, 98);
            previous_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            previous_btn.BackColor = Color.FromArgb(129, 142, 254);
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
            previous_btn.Location = new Point(573, 520);
            previous_btn.Margin = new Padding(4);
            previous_btn.Name = "previous_btn";
            previous_btn.Normalcolor = Color.FromArgb(129, 142, 254);
            previous_btn.OnHovercolor = Color.FromArgb(86, 94, 169);
            previous_btn.OnHoverTextColor = Color.WhiteSmoke;
            previous_btn.Padding = new Padding(8, 5, 8, 5);
            previous_btn.RightToLeft = RightToLeft.No;
            previous_btn.selected = false;
            previous_btn.Size = new Size(164, 35);
            previous_btn.TabIndex = 52;
            previous_btn.Text = "Previous";
            previous_btn.TextAlign = ContentAlignment.MiddleCenter;
            previous_btn.Textcolor = Color.White;
            previous_btn.TextFont = new Font("Poppins Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            previous_btn.Click += previous_btn_Click;
            // 
            // next_btn
            // 
            next_btn.Active = false;
            next_btn.Activecolor = Color.FromArgb(60, 64, 98);
            next_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            next_btn.BackColor = Color.FromArgb(129, 142, 254);
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
            next_btn.Location = new Point(772, 520);
            next_btn.Margin = new Padding(4);
            next_btn.Name = "next_btn";
            next_btn.Normalcolor = Color.FromArgb(129, 142, 254);
            next_btn.OnHovercolor = Color.FromArgb(86, 94, 169);
            next_btn.OnHoverTextColor = Color.WhiteSmoke;
            next_btn.Padding = new Padding(8, 5, 8, 5);
            next_btn.RightToLeft = RightToLeft.No;
            next_btn.selected = false;
            next_btn.Size = new Size(164, 35);
            next_btn.TabIndex = 54;
            next_btn.Text = "Next";
            next_btn.TextAlign = ContentAlignment.MiddleCenter;
            next_btn.Textcolor = Color.White;
            next_btn.TextFont = new Font("Poppins Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            next_btn.Click += next_btn_Click;
            // 
            // StudentListFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 47, 84);
            ClientSize = new Size(966, 580);
            Controls.Add(next_btn);
            Controls.Add(previous_btn);
            Controls.Add(data_count_lbl);
            Controls.Add(close_btn);
            Controls.Add(panel1);
            Controls.Add(student_dtg);
            Controls.Add(faculty_name_lbl);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "StudentListFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentListFrm";
            Load += StudentListFrm_Load;
            ((System.ComponentModel.ISupportInitialize)student_dtg).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)close_btn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse dtg_rad;
        private Label label1;
        private Label faculty_name_lbl;
        private Bunifu.Framework.UI.BunifuCustomDataGrid student_dtg;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn lrn;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn grade_sec;
        private DataGridViewTextBoxColumn strand;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn adviser;
        private Panel panel1;
        private TextBox search_tb;
        private PictureBox pictureBox2;
        private PictureBox close_btn;
        private Label data_count_lbl;
        private Bunifu.Framework.UI.BunifuFlatButton previous_btn;
        private Bunifu.Framework.UI.BunifuFlatButton next_btn;
    }
}