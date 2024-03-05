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
            edit = new DataGridViewImageColumn();
            delete = new DataGridViewImageColumn();
            dtg_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            pictureBox1 = new PictureBox();
            btn_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            search_tb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            add_new_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)faculty_profile_dtg).BeginInit();
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
            label2.Size = new Size(181, 30);
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
            faculty_profile_dtg.Columns.AddRange(new DataGridViewColumn[] { id, name, email, position, edit, delete });
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
            faculty_profile_dtg.Location = new Point(8, 101);
            faculty_profile_dtg.Margin = new Padding(2, 2, 2, 2);
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
            faculty_profile_dtg.Size = new Size(773, 553);
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
            name.HeaderText = "NAME";
            name.MinimumWidth = 8;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            email.HeaderText = "EMAIL";
            email.MinimumWidth = 8;
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 101;
            // 
            // position
            // 
            position.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            position.HeaderText = "POSITION";
            position.MinimumWidth = 8;
            position.Name = "position";
            position.ReadOnly = true;
            position.Width = 125;
            // 
            // edit
            // 
            edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            edit.HeaderText = "EDIT";
            edit.MinimumWidth = 30;
            edit.Name = "edit";
            edit.ReadOnly = true;
            edit.ToolTipText = "Edit";
            edit.Width = 73;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            delete.HeaderText = "DELETE";
            delete.MinimumWidth = 30;
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.ToolTipText = "Delete";
            delete.Width = 89;
            // 
            // dtg_rad
            // 
            dtg_rad.ElipseRadius = 5;
            dtg_rad.TargetControl = faculty_profile_dtg;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 57);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(17, 14);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btn_rad
            // 
            btn_rad.ElipseRadius = 15;
            btn_rad.TargetControl = add_new_btn;
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
            search_tb.Location = new Point(8, 44);
            search_tb.Margin = new Padding(4);
            search_tb.MaxLength = 32767;
            search_tb.Name = "search_tb";
            search_tb.Padding = new Padding(45, 0, 0, 0);
            search_tb.Size = new Size(309, 39);
            search_tb.TabIndex = 9;
            search_tb.Text = "Search...";
            search_tb.TextAlign = HorizontalAlignment.Left;
            search_tb.OnValueChanged += search_tb_OnValueChanged;
            // 
            // add_new_btn
            // 
            add_new_btn.Active = false;
            add_new_btn.Activecolor = Color.FromArgb(60, 64, 98);
            add_new_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            add_new_btn.BackColor = Color.FromArgb(43, 47, 84);
            add_new_btn.BackgroundImageLayout = ImageLayout.Stretch;
            add_new_btn.BorderRadius = 5;
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
            add_new_btn.Location = new Point(746, 48);
            add_new_btn.Margin = new Padding(4);
            add_new_btn.MaximumSize = new Size(35, 35);
            add_new_btn.MinimumSize = new Size(35, 35);
            add_new_btn.Name = "add_new_btn";
            add_new_btn.Normalcolor = Color.FromArgb(43, 47, 84);
            add_new_btn.OnHovercolor = Color.FromArgb(60, 64, 98);
            add_new_btn.OnHoverTextColor = Color.White;
            add_new_btn.Padding = new Padding(7, 6, 7, 6);
            add_new_btn.RightToLeft = RightToLeft.No;
            add_new_btn.selected = false;
            add_new_btn.Size = new Size(35, 35);
            add_new_btn.TabIndex = 11;
            add_new_btn.TextAlign = ContentAlignment.MiddleRight;
            add_new_btn.Textcolor = Color.White;
            add_new_btn.TextFont = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            add_new_btn.Click += add_new_btn_Click;
            // 
            // FacultyProfiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(790, 660);
            Controls.Add(add_new_btn);
            Controls.Add(pictureBox1);
            Controls.Add(search_tb);
            Controls.Add(faculty_profile_dtg);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "FacultyProfiles";
            RightToLeft = RightToLeft.No;
            Text = "FacultyProfiles";
            Load += FacultyProfiles_Load;
            ((System.ComponentModel.ISupportInitialize)faculty_profile_dtg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid faculty_profile_dtg;
        private Bunifu.Framework.UI.BunifuElipse dtg_rad;
        private PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse btn_rad;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn position;
        private DataGridViewImageColumn edit;
        private DataGridViewImageColumn delete;
        private Bunifu.Framework.UI.BunifuFlatButton add_new_btn;
        private Bunifu.Framework.UI.BunifuMetroTextbox search_tb;
    }
}