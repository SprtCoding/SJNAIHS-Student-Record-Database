namespace Student_Record.AdminModule
{
    partial class FacultyProfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacultyProfiles));
            label2 = new Label();
            faculty_profile_dtg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            position = new DataGridViewTextBoxColumn();
            students = new DataGridViewImageColumn();
            edit = new DataGridViewImageColumn();
            delete = new DataGridViewImageColumn();
            dtg_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            btn_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            add_new_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            loadingPanel = new Panel();
            loadingTxt = new Label();
            panel1 = new Panel();
            search_tb = new TextBox();
            pictureBox2 = new PictureBox();
            next_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            previous_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            data_count_lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)faculty_profile_dtg).BeginInit();
            loadingPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(11, 8);
            label2.Name = "label2";
            label2.Size = new Size(263, 45);
            label2.TabIndex = 6;
            label2.Text = "Faculty Profiles";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // faculty_profile_dtg
            // 
            faculty_profile_dtg.AllowUserToAddRows = false;
            faculty_profile_dtg.AllowUserToDeleteRows = false;
            faculty_profile_dtg.AllowUserToResizeColumns = false;
            faculty_profile_dtg.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle1.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(43, 47, 84);
            faculty_profile_dtg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            faculty_profile_dtg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            faculty_profile_dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            faculty_profile_dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            faculty_profile_dtg.BackgroundColor = Color.WhiteSmoke;
            faculty_profile_dtg.BorderStyle = BorderStyle.None;
            faculty_profile_dtg.CellBorderStyle = DataGridViewCellBorderStyle.None;
            faculty_profile_dtg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle2.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Padding = new Padding(15);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            faculty_profile_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            faculty_profile_dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            faculty_profile_dtg.Columns.AddRange(new DataGridViewColumn[] { id, name, email, position, students, edit, delete });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle3.Padding = new Padding(15);
            dataGridViewCellStyle3.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            faculty_profile_dtg.DefaultCellStyle = dataGridViewCellStyle3;
            faculty_profile_dtg.DoubleBuffered = true;
            faculty_profile_dtg.EnableHeadersVisualStyles = false;
            faculty_profile_dtg.GridColor = Color.FromArgb(60, 64, 98);
            faculty_profile_dtg.HeaderBgColor = Color.FromArgb(43, 47, 84);
            faculty_profile_dtg.HeaderForeColor = Color.WhiteSmoke;
            faculty_profile_dtg.Location = new Point(11, 168);
            faculty_profile_dtg.Name = "faculty_profile_dtg";
            faculty_profile_dtg.ReadOnly = true;
            faculty_profile_dtg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            faculty_profile_dtg.RowHeadersVisible = false;
            faculty_profile_dtg.RowHeadersWidth = 62;
            faculty_profile_dtg.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            faculty_profile_dtg.RowTemplate.Height = 33;
            faculty_profile_dtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            faculty_profile_dtg.ShowCellErrors = false;
            faculty_profile_dtg.ShowEditingIcon = false;
            faculty_profile_dtg.ShowRowErrors = false;
            faculty_profile_dtg.Size = new Size(1101, 495);
            faculty_profile_dtg.TabIndex = 7;
            faculty_profile_dtg.CellContentClick += faculty_profile_dtg_CellContentClick;
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
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            email.HeaderText = "Email";
            email.MinimumWidth = 8;
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // position
            // 
            position.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            position.HeaderText = "Position";
            position.MinimumWidth = 8;
            position.Name = "position";
            position.ReadOnly = true;
            // 
            // students
            // 
            students.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            students.HeaderText = "Students";
            students.MinimumWidth = 8;
            students.Name = "students";
            students.ReadOnly = true;
            students.Width = 138;
            // 
            // edit
            // 
            edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            edit.HeaderText = "Edit";
            edit.MinimumWidth = 8;
            edit.Name = "edit";
            edit.ReadOnly = true;
            edit.Width = 85;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            delete.HeaderText = "Delete";
            delete.MinimumWidth = 8;
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Width = 112;
            // 
            // dtg_rad
            // 
            dtg_rad.ElipseRadius = 5;
            dtg_rad.TargetControl = faculty_profile_dtg;
            // 
            // btn_rad
            // 
            btn_rad.ElipseRadius = 15;
            btn_rad.TargetControl = add_new_btn;
            // 
            // add_new_btn
            // 
            add_new_btn.Active = false;
            add_new_btn.Activecolor = Color.FromArgb(60, 64, 98);
            add_new_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            add_new_btn.BackColor = Color.FromArgb(43, 47, 84);
            add_new_btn.BackgroundImageLayout = ImageLayout.Stretch;
            add_new_btn.BorderRadius = 2;
            add_new_btn.ButtonText = "";
            add_new_btn.DisabledColor = Color.Gray;
            add_new_btn.Iconcolor = Color.Transparent;
            add_new_btn.Iconimage = Properties.Resources.add_white;
            add_new_btn.Iconimage_right = null;
            add_new_btn.Iconimage_right_Selected = null;
            add_new_btn.Iconimage_Selected = null;
            add_new_btn.IconMarginLeft = 0;
            add_new_btn.IconMarginRight = 0;
            add_new_btn.IconRightVisible = false;
            add_new_btn.IconRightZoom = 40D;
            add_new_btn.IconVisible = true;
            add_new_btn.IconZoom = 40D;
            add_new_btn.IsTab = false;
            add_new_btn.Location = new Point(1063, 80);
            add_new_btn.Margin = new Padding(6, 7, 6, 7);
            add_new_btn.MaximumSize = new Size(50, 50);
            add_new_btn.MinimumSize = new Size(50, 50);
            add_new_btn.Name = "add_new_btn";
            add_new_btn.Normalcolor = Color.FromArgb(43, 47, 84);
            add_new_btn.OnHovercolor = Color.FromArgb(60, 64, 98);
            add_new_btn.OnHoverTextColor = Color.White;
            add_new_btn.Padding = new Padding(10, 10, 10, 10);
            add_new_btn.RightToLeft = RightToLeft.No;
            add_new_btn.selected = false;
            add_new_btn.Size = new Size(50, 50);
            add_new_btn.TabIndex = 11;
            add_new_btn.TextAlign = ContentAlignment.MiddleRight;
            add_new_btn.Textcolor = Color.White;
            add_new_btn.TextFont = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            add_new_btn.Click += add_new_btn_Click;
            // 
            // loadingPanel
            // 
            loadingPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loadingPanel.Controls.Add(loadingTxt);
            loadingPanel.Location = new Point(11, 168);
            loadingPanel.Name = "loadingPanel";
            loadingPanel.Size = new Size(1101, 495);
            loadingPanel.TabIndex = 12;
            // 
            // loadingTxt
            // 
            loadingTxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            loadingTxt.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            loadingTxt.ForeColor = Color.FromArgb(43, 47, 84);
            loadingTxt.Location = new Point(30, 228);
            loadingTxt.Name = "loadingTxt";
            loadingTxt.Size = new Size(1041, 38);
            loadingTxt.TabIndex = 0;
            loadingTxt.Text = "loading data...";
            loadingTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(search_tb);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(11, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 65);
            panel1.TabIndex = 33;
            // 
            // search_tb
            // 
            search_tb.BackColor = SystemColors.Control;
            search_tb.BorderStyle = BorderStyle.None;
            search_tb.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            search_tb.Location = new Point(51, 18);
            search_tb.Name = "search_tb";
            search_tb.PlaceholderText = "Search...";
            search_tb.Size = new Size(383, 27);
            search_tb.TabIndex = 29;
            search_tb.TextChanged += search_tb_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(17, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // next_btn
            // 
            next_btn.Active = false;
            next_btn.Activecolor = Color.FromArgb(60, 64, 98);
            next_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            next_btn.BackColor = Color.FromArgb(43, 47, 84);
            next_btn.BackgroundImageLayout = ImageLayout.Stretch;
            next_btn.BorderRadius = 2;
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
            next_btn.Location = new Point(879, 688);
            next_btn.Margin = new Padding(6, 7, 6, 7);
            next_btn.Name = "next_btn";
            next_btn.Normalcolor = Color.FromArgb(43, 47, 84);
            next_btn.OnHovercolor = Color.FromArgb(86, 94, 169);
            next_btn.OnHoverTextColor = Color.WhiteSmoke;
            next_btn.Padding = new Padding(11, 8, 11, 8);
            next_btn.RightToLeft = RightToLeft.No;
            next_btn.selected = false;
            next_btn.Size = new Size(234, 58);
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
            previous_btn.BackColor = Color.FromArgb(43, 47, 84);
            previous_btn.BackgroundImageLayout = ImageLayout.Stretch;
            previous_btn.BorderRadius = 2;
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
            previous_btn.Location = new Point(611, 688);
            previous_btn.Margin = new Padding(6, 7, 6, 7);
            previous_btn.Name = "previous_btn";
            previous_btn.Normalcolor = Color.FromArgb(43, 47, 84);
            previous_btn.OnHovercolor = Color.FromArgb(86, 94, 169);
            previous_btn.OnHoverTextColor = Color.WhiteSmoke;
            previous_btn.Padding = new Padding(11, 8, 11, 8);
            previous_btn.RightToLeft = RightToLeft.No;
            previous_btn.selected = false;
            previous_btn.Size = new Size(234, 58);
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
            data_count_lbl.ForeColor = Color.FromArgb(43, 47, 84);
            data_count_lbl.Location = new Point(11, 705);
            data_count_lbl.Name = "data_count_lbl";
            data_count_lbl.Size = new Size(28, 36);
            data_count_lbl.TabIndex = 59;
            data_count_lbl.Text = "0";
            data_count_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FacultyProfiles
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1129, 768);
            Controls.Add(data_count_lbl);
            Controls.Add(next_btn);
            Controls.Add(previous_btn);
            Controls.Add(panel1);
            Controls.Add(loadingPanel);
            Controls.Add(add_new_btn);
            Controls.Add(faculty_profile_dtg);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FacultyProfiles";
            RightToLeft = RightToLeft.No;
            Text = "FacultyProfiles";
            Load += FacultyProfiles_Load;
            ((System.ComponentModel.ISupportInitialize)faculty_profile_dtg).EndInit();
            loadingPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid faculty_profile_dtg;
        private Bunifu.Framework.UI.BunifuElipse dtg_rad;
        private Bunifu.Framework.UI.BunifuElipse btn_rad;
        private Bunifu.Framework.UI.BunifuFlatButton add_new_btn;
        private Panel loadingPanel;
        private Label loadingTxt;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn position;
        private DataGridViewImageColumn students;
        private DataGridViewImageColumn edit;
        private DataGridViewImageColumn delete;
        private Panel panel1;
        private TextBox search_tb;
        private PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton next_btn;
        private Bunifu.Framework.UI.BunifuFlatButton previous_btn;
        private Label data_count_lbl;
    }
}