namespace Student_Record.TeachersModule
{
    partial class GradingSheet
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradingSheet));
            label2 = new Label();
            grading_sheet_dtg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            subject = new DataGridViewTextBoxColumn();
            mid_term = new DataGridViewTextBoxColumn();
            final_term = new DataGridViewTextBoxColumn();
            final_grade = new DataGridViewTextBoxColumn();
            generate_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            add_new_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            oral_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            komunikasyon_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            century_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            math_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            philosophy_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            p_e_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            tve_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            no_data_panel = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            submit_report_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            print_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)grading_sheet_dtg).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            no_data_panel.SuspendLayout();
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
            label2.Size = new Size(166, 30);
            label2.TabIndex = 8;
            label2.Text = "Grading Sheet";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grading_sheet_dtg
            // 
            grading_sheet_dtg.AllowUserToAddRows = false;
            grading_sheet_dtg.AllowUserToDeleteRows = false;
            grading_sheet_dtg.AllowUserToResizeColumns = false;
            grading_sheet_dtg.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle4.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(43, 47, 84);
            grading_sheet_dtg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            grading_sheet_dtg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grading_sheet_dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grading_sheet_dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grading_sheet_dtg.BackgroundColor = SystemColors.Control;
            grading_sheet_dtg.BorderStyle = BorderStyle.None;
            grading_sheet_dtg.CellBorderStyle = DataGridViewCellBorderStyle.None;
            grading_sheet_dtg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle5.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.Padding = new Padding(15);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle5.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            grading_sheet_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            grading_sheet_dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grading_sheet_dtg.Columns.AddRange(new DataGridViewColumn[] { id, name, subject, mid_term, final_term, final_grade });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle6.Padding = new Padding(15);
            dataGridViewCellStyle6.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            grading_sheet_dtg.DefaultCellStyle = dataGridViewCellStyle6;
            grading_sheet_dtg.DoubleBuffered = true;
            grading_sheet_dtg.EnableHeadersVisualStyles = false;
            grading_sheet_dtg.GridColor = Color.FromArgb(60, 64, 98);
            grading_sheet_dtg.HeaderBgColor = Color.FromArgb(43, 47, 84);
            grading_sheet_dtg.HeaderForeColor = Color.WhiteSmoke;
            grading_sheet_dtg.Location = new Point(8, 125);
            grading_sheet_dtg.Margin = new Padding(2, 2, 2, 2);
            grading_sheet_dtg.Name = "grading_sheet_dtg";
            grading_sheet_dtg.ReadOnly = true;
            grading_sheet_dtg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grading_sheet_dtg.RowHeadersVisible = false;
            grading_sheet_dtg.RowHeadersWidth = 62;
            grading_sheet_dtg.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            grading_sheet_dtg.RowTemplate.Height = 33;
            grading_sheet_dtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grading_sheet_dtg.ShowCellErrors = false;
            grading_sheet_dtg.ShowEditingIcon = false;
            grading_sheet_dtg.ShowRowErrors = false;
            grading_sheet_dtg.Size = new Size(773, 528);
            grading_sheet_dtg.TabIndex = 10;
            grading_sheet_dtg.CellContentClick += student_dtg_CellContentClick;
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
            // subject
            // 
            subject.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            subject.HeaderText = "SUBJECT";
            subject.MinimumWidth = 8;
            subject.Name = "subject";
            subject.ReadOnly = true;
            subject.Width = 122;
            // 
            // mid_term
            // 
            mid_term.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            mid_term.HeaderText = "MID TERM";
            mid_term.MinimumWidth = 8;
            mid_term.Name = "mid_term";
            mid_term.ReadOnly = true;
            mid_term.Width = 129;
            // 
            // final_term
            // 
            final_term.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            final_term.HeaderText = "FINAL TERM";
            final_term.MinimumWidth = 8;
            final_term.Name = "final_term";
            final_term.ReadOnly = true;
            final_term.Width = 139;
            // 
            // final_grade
            // 
            final_grade.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            final_grade.HeaderText = "FINAL GRADE";
            final_grade.MinimumWidth = 8;
            final_grade.Name = "final_grade";
            final_grade.ReadOnly = true;
            final_grade.Width = 148;
            // 
            // generate_btn
            // 
            generate_btn.Active = false;
            generate_btn.Activecolor = Color.FromArgb(60, 64, 98);
            generate_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            generate_btn.BackColor = Color.FromArgb(43, 47, 84);
            generate_btn.BackgroundImageLayout = ImageLayout.Stretch;
            generate_btn.BorderRadius = 5;
            generate_btn.ButtonText = "Generate";
            generate_btn.DisabledColor = Color.Gray;
            generate_btn.Iconcolor = Color.Transparent;
            generate_btn.Iconimage = null;
            generate_btn.Iconimage_right = null;
            generate_btn.Iconimage_right_Selected = null;
            generate_btn.Iconimage_Selected = null;
            generate_btn.IconMarginLeft = 0;
            generate_btn.IconMarginRight = 0;
            generate_btn.IconRightVisible = true;
            generate_btn.IconRightZoom = 40D;
            generate_btn.IconVisible = false;
            generate_btn.IconZoom = 40D;
            generate_btn.IsTab = false;
            generate_btn.Location = new Point(527, 10);
            generate_btn.Margin = new Padding(4, 4, 4, 4);
            generate_btn.Name = "generate_btn";
            generate_btn.Normalcolor = Color.FromArgb(43, 47, 84);
            generate_btn.OnHovercolor = Color.FromArgb(60, 64, 98);
            generate_btn.OnHoverTextColor = Color.White;
            generate_btn.Padding = new Padding(8, 5, 8, 5);
            generate_btn.RightToLeft = RightToLeft.No;
            generate_btn.selected = false;
            generate_btn.Size = new Size(122, 32);
            generate_btn.TabIndex = 16;
            generate_btn.Text = "Generate";
            generate_btn.TextAlign = ContentAlignment.MiddleCenter;
            generate_btn.Textcolor = Color.White;
            generate_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            generate_btn.Click += generate_btn_Click;
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
            add_new_btn.Location = new Point(745, 66);
            add_new_btn.Margin = new Padding(4, 4, 4, 4);
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
            add_new_btn.TabIndex = 17;
            add_new_btn.TextAlign = ContentAlignment.MiddleRight;
            add_new_btn.Textcolor = Color.White;
            add_new_btn.TextFont = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            add_new_btn.Click += add_new_btn_Click;
            // 
            // oral_btn
            // 
            oral_btn.Active = false;
            oral_btn.Activecolor = Color.FromArgb(60, 64, 98);
            oral_btn.BackColor = Color.FromArgb(43, 47, 84);
            oral_btn.BackgroundImageLayout = ImageLayout.Stretch;
            oral_btn.BorderRadius = 5;
            oral_btn.ButtonText = "Oral Communication";
            oral_btn.DisabledColor = Color.Gray;
            oral_btn.Iconcolor = Color.Transparent;
            oral_btn.Iconimage = null;
            oral_btn.Iconimage_right = null;
            oral_btn.Iconimage_right_Selected = null;
            oral_btn.Iconimage_Selected = null;
            oral_btn.IconMarginLeft = 0;
            oral_btn.IconMarginRight = 0;
            oral_btn.IconRightVisible = true;
            oral_btn.IconRightZoom = 40D;
            oral_btn.IconVisible = false;
            oral_btn.IconZoom = 40D;
            oral_btn.IsTab = false;
            oral_btn.Location = new Point(4, 4);
            oral_btn.Margin = new Padding(4, 4, 4, 4);
            oral_btn.Name = "oral_btn";
            oral_btn.Normalcolor = Color.FromArgb(43, 47, 84);
            oral_btn.OnHovercolor = Color.FromArgb(60, 64, 98);
            oral_btn.OnHoverTextColor = Color.White;
            oral_btn.Padding = new Padding(8, 5, 8, 5);
            oral_btn.RightToLeft = RightToLeft.No;
            oral_btn.selected = false;
            oral_btn.Size = new Size(156, 32);
            oral_btn.TabIndex = 18;
            oral_btn.Text = "Oral Communication";
            oral_btn.TextAlign = ContentAlignment.MiddleCenter;
            oral_btn.Textcolor = Color.White;
            oral_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            oral_btn.Click += oral_btn_Click;
            // 
            // komunikasyon_btn
            // 
            komunikasyon_btn.Active = false;
            komunikasyon_btn.Activecolor = Color.FromArgb(60, 64, 98);
            komunikasyon_btn.BackColor = Color.FromArgb(43, 47, 84);
            komunikasyon_btn.BackgroundImageLayout = ImageLayout.Stretch;
            komunikasyon_btn.BorderRadius = 5;
            komunikasyon_btn.ButtonText = "Komunikasyon at Pananaliksik";
            komunikasyon_btn.DisabledColor = Color.Gray;
            komunikasyon_btn.Iconcolor = Color.Transparent;
            komunikasyon_btn.Iconimage = null;
            komunikasyon_btn.Iconimage_right = null;
            komunikasyon_btn.Iconimage_right_Selected = null;
            komunikasyon_btn.Iconimage_Selected = null;
            komunikasyon_btn.IconMarginLeft = 0;
            komunikasyon_btn.IconMarginRight = 0;
            komunikasyon_btn.IconRightVisible = true;
            komunikasyon_btn.IconRightZoom = 40D;
            komunikasyon_btn.IconVisible = false;
            komunikasyon_btn.IconZoom = 40D;
            komunikasyon_btn.IsTab = false;
            komunikasyon_btn.Location = new Point(515, 4);
            komunikasyon_btn.Margin = new Padding(4, 4, 4, 4);
            komunikasyon_btn.Name = "komunikasyon_btn";
            komunikasyon_btn.Normalcolor = Color.FromArgb(43, 47, 84);
            komunikasyon_btn.OnHovercolor = Color.FromArgb(60, 64, 98);
            komunikasyon_btn.OnHoverTextColor = Color.White;
            komunikasyon_btn.Padding = new Padding(8, 5, 8, 5);
            komunikasyon_btn.RightToLeft = RightToLeft.No;
            komunikasyon_btn.selected = false;
            komunikasyon_btn.Size = new Size(225, 32);
            komunikasyon_btn.TabIndex = 19;
            komunikasyon_btn.Text = "Komunikasyon at Pananaliksik";
            komunikasyon_btn.TextAlign = ContentAlignment.MiddleCenter;
            komunikasyon_btn.Textcolor = Color.White;
            komunikasyon_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            komunikasyon_btn.Click += komunikasyon_btn_Click;
            // 
            // century_btn
            // 
            century_btn.Active = false;
            century_btn.Activecolor = Color.FromArgb(60, 64, 98);
            century_btn.BackColor = Color.FromArgb(43, 47, 84);
            century_btn.BackgroundImageLayout = ImageLayout.Stretch;
            century_btn.BorderRadius = 5;
            century_btn.ButtonText = "21st Century Literature";
            century_btn.DisabledColor = Color.Gray;
            century_btn.Iconcolor = Color.Transparent;
            century_btn.Iconimage = null;
            century_btn.Iconimage_right = null;
            century_btn.Iconimage_right_Selected = null;
            century_btn.Iconimage_Selected = null;
            century_btn.IconMarginLeft = 0;
            century_btn.IconMarginRight = 0;
            century_btn.IconRightVisible = true;
            century_btn.IconRightZoom = 40D;
            century_btn.IconVisible = false;
            century_btn.IconZoom = 40D;
            century_btn.IsTab = false;
            century_btn.Location = new Point(168, 4);
            century_btn.Margin = new Padding(4, 4, 4, 4);
            century_btn.Name = "century_btn";
            century_btn.Normalcolor = Color.FromArgb(43, 47, 84);
            century_btn.OnHovercolor = Color.FromArgb(60, 64, 98);
            century_btn.OnHoverTextColor = Color.White;
            century_btn.Padding = new Padding(8, 5, 8, 5);
            century_btn.RightToLeft = RightToLeft.No;
            century_btn.selected = false;
            century_btn.Size = new Size(175, 32);
            century_btn.TabIndex = 20;
            century_btn.Text = "21st Century Literature";
            century_btn.TextAlign = ContentAlignment.MiddleCenter;
            century_btn.Textcolor = Color.White;
            century_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            century_btn.Click += century_btn_Click;
            // 
            // math_btn
            // 
            math_btn.Active = false;
            math_btn.Activecolor = Color.FromArgb(60, 64, 98);
            math_btn.BackColor = Color.FromArgb(43, 47, 84);
            math_btn.BackgroundImageLayout = ImageLayout.Stretch;
            math_btn.BorderRadius = 5;
            math_btn.ButtonText = "General Mathematics";
            math_btn.DisabledColor = Color.Gray;
            math_btn.Iconcolor = Color.Transparent;
            math_btn.Iconimage = null;
            math_btn.Iconimage_right = null;
            math_btn.Iconimage_right_Selected = null;
            math_btn.Iconimage_Selected = null;
            math_btn.IconMarginLeft = 0;
            math_btn.IconMarginRight = 0;
            math_btn.IconRightVisible = true;
            math_btn.IconRightZoom = 40D;
            math_btn.IconVisible = false;
            math_btn.IconZoom = 40D;
            math_btn.IsTab = false;
            math_btn.Location = new Point(351, 4);
            math_btn.Margin = new Padding(4, 4, 4, 4);
            math_btn.Name = "math_btn";
            math_btn.Normalcolor = Color.FromArgb(43, 47, 84);
            math_btn.OnHovercolor = Color.FromArgb(60, 64, 98);
            math_btn.OnHoverTextColor = Color.White;
            math_btn.Padding = new Padding(8, 5, 8, 5);
            math_btn.RightToLeft = RightToLeft.No;
            math_btn.selected = false;
            math_btn.Size = new Size(156, 32);
            math_btn.TabIndex = 21;
            math_btn.Text = "General Mathematics";
            math_btn.TextAlign = ContentAlignment.MiddleCenter;
            math_btn.Textcolor = Color.White;
            math_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            math_btn.Click += math_btn_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoScrollMinSize = new Size(15, 5);
            flowLayoutPanel1.Controls.Add(oral_btn);
            flowLayoutPanel1.Controls.Add(century_btn);
            flowLayoutPanel1.Controls.Add(math_btn);
            flowLayoutPanel1.Controls.Add(komunikasyon_btn);
            flowLayoutPanel1.Controls.Add(philosophy_btn);
            flowLayoutPanel1.Controls.Add(p_e_btn);
            flowLayoutPanel1.Controls.Add(tve_btn);
            flowLayoutPanel1.Location = new Point(8, 62);
            flowLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(565, 58);
            flowLayoutPanel1.TabIndex = 23;
            flowLayoutPanel1.WrapContents = false;
            // 
            // philosophy_btn
            // 
            philosophy_btn.Active = false;
            philosophy_btn.Activecolor = Color.FromArgb(60, 64, 98);
            philosophy_btn.BackColor = Color.FromArgb(43, 47, 84);
            philosophy_btn.BackgroundImageLayout = ImageLayout.Stretch;
            philosophy_btn.BorderRadius = 5;
            philosophy_btn.ButtonText = "Introduction to the Philosophy";
            philosophy_btn.DisabledColor = Color.Gray;
            philosophy_btn.Iconcolor = Color.Transparent;
            philosophy_btn.Iconimage = null;
            philosophy_btn.Iconimage_right = null;
            philosophy_btn.Iconimage_right_Selected = null;
            philosophy_btn.Iconimage_Selected = null;
            philosophy_btn.IconMarginLeft = 0;
            philosophy_btn.IconMarginRight = 0;
            philosophy_btn.IconRightVisible = true;
            philosophy_btn.IconRightZoom = 40D;
            philosophy_btn.IconVisible = false;
            philosophy_btn.IconZoom = 40D;
            philosophy_btn.IsTab = false;
            philosophy_btn.Location = new Point(748, 4);
            philosophy_btn.Margin = new Padding(4, 4, 4, 4);
            philosophy_btn.Name = "philosophy_btn";
            philosophy_btn.Normalcolor = Color.FromArgb(43, 47, 84);
            philosophy_btn.OnHovercolor = Color.FromArgb(60, 64, 98);
            philosophy_btn.OnHoverTextColor = Color.White;
            philosophy_btn.Padding = new Padding(8, 5, 8, 5);
            philosophy_btn.RightToLeft = RightToLeft.No;
            philosophy_btn.selected = false;
            philosophy_btn.Size = new Size(225, 32);
            philosophy_btn.TabIndex = 22;
            philosophy_btn.Text = "Introduction to the Philosophy";
            philosophy_btn.TextAlign = ContentAlignment.MiddleCenter;
            philosophy_btn.Textcolor = Color.White;
            philosophy_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            philosophy_btn.Click += philosophy_btn_Click;
            // 
            // p_e_btn
            // 
            p_e_btn.Active = false;
            p_e_btn.Activecolor = Color.FromArgb(60, 64, 98);
            p_e_btn.BackColor = Color.FromArgb(43, 47, 84);
            p_e_btn.BackgroundImageLayout = ImageLayout.Stretch;
            p_e_btn.BorderRadius = 5;
            p_e_btn.ButtonText = "Physical Education & Health";
            p_e_btn.DisabledColor = Color.Gray;
            p_e_btn.Iconcolor = Color.Transparent;
            p_e_btn.Iconimage = null;
            p_e_btn.Iconimage_right = null;
            p_e_btn.Iconimage_right_Selected = null;
            p_e_btn.Iconimage_Selected = null;
            p_e_btn.IconMarginLeft = 0;
            p_e_btn.IconMarginRight = 0;
            p_e_btn.IconRightVisible = true;
            p_e_btn.IconRightZoom = 40D;
            p_e_btn.IconVisible = false;
            p_e_btn.IconZoom = 40D;
            p_e_btn.IsTab = false;
            p_e_btn.Location = new Point(981, 4);
            p_e_btn.Margin = new Padding(4, 4, 4, 4);
            p_e_btn.Name = "p_e_btn";
            p_e_btn.Normalcolor = Color.FromArgb(43, 47, 84);
            p_e_btn.OnHovercolor = Color.FromArgb(60, 64, 98);
            p_e_btn.OnHoverTextColor = Color.White;
            p_e_btn.Padding = new Padding(8, 5, 8, 5);
            p_e_btn.RightToLeft = RightToLeft.No;
            p_e_btn.selected = false;
            p_e_btn.Size = new Size(200, 32);
            p_e_btn.TabIndex = 23;
            p_e_btn.Text = "Physical Education & Health";
            p_e_btn.TextAlign = ContentAlignment.MiddleCenter;
            p_e_btn.Textcolor = Color.White;
            p_e_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            p_e_btn.Click += p_e_btn_Click;
            // 
            // tve_btn
            // 
            tve_btn.Active = false;
            tve_btn.Activecolor = Color.FromArgb(60, 64, 98);
            tve_btn.BackColor = Color.FromArgb(43, 47, 84);
            tve_btn.BackgroundImageLayout = ImageLayout.Stretch;
            tve_btn.BorderRadius = 5;
            tve_btn.ButtonText = "TVE";
            tve_btn.DisabledColor = Color.Gray;
            tve_btn.Iconcolor = Color.Transparent;
            tve_btn.Iconimage = null;
            tve_btn.Iconimage_right = null;
            tve_btn.Iconimage_right_Selected = null;
            tve_btn.Iconimage_Selected = null;
            tve_btn.IconMarginLeft = 0;
            tve_btn.IconMarginRight = 0;
            tve_btn.IconRightVisible = true;
            tve_btn.IconRightZoom = 40D;
            tve_btn.IconVisible = false;
            tve_btn.IconZoom = 40D;
            tve_btn.IsTab = false;
            tve_btn.Location = new Point(1189, 4);
            tve_btn.Margin = new Padding(4, 4, 4, 4);
            tve_btn.Name = "tve_btn";
            tve_btn.Normalcolor = Color.FromArgb(43, 47, 84);
            tve_btn.OnHovercolor = Color.FromArgb(60, 64, 98);
            tve_btn.OnHoverTextColor = Color.White;
            tve_btn.Padding = new Padding(8, 5, 8, 5);
            tve_btn.RightToLeft = RightToLeft.No;
            tve_btn.selected = false;
            tve_btn.Size = new Size(166, 32);
            tve_btn.TabIndex = 24;
            tve_btn.Text = "TVE";
            tve_btn.TextAlign = ContentAlignment.MiddleCenter;
            tve_btn.Textcolor = Color.White;
            tve_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tve_btn.Click += tve_btn_Click;
            // 
            // no_data_panel
            // 
            no_data_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            no_data_panel.Controls.Add(label1);
            no_data_panel.Controls.Add(pictureBox1);
            no_data_panel.Location = new Point(8, 125);
            no_data_panel.Margin = new Padding(2, 2, 2, 2);
            no_data_panel.Name = "no_data_panel";
            no_data_panel.Size = new Size(773, 528);
            no_data_panel.TabIndex = 24;
            no_data_panel.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(60, 64, 98);
            label1.Location = new Point(100, 308);
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
            pictureBox1.Location = new Point(234, 185);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // submit_report_btn
            // 
            submit_report_btn.Active = false;
            submit_report_btn.Activecolor = Color.FromArgb(43, 47, 84);
            submit_report_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            submit_report_btn.BackColor = Color.FromArgb(43, 47, 84);
            submit_report_btn.BackgroundImageLayout = ImageLayout.Stretch;
            submit_report_btn.BorderRadius = 5;
            submit_report_btn.ButtonText = "  Submit Report";
            submit_report_btn.DisabledColor = Color.Gray;
            submit_report_btn.Iconcolor = Color.Transparent;
            submit_report_btn.Iconimage = Properties.Resources.send_message;
            submit_report_btn.Iconimage_right = null;
            submit_report_btn.Iconimage_right_Selected = null;
            submit_report_btn.Iconimage_Selected = null;
            submit_report_btn.IconMarginLeft = 0;
            submit_report_btn.IconMarginRight = 0;
            submit_report_btn.IconRightVisible = true;
            submit_report_btn.IconRightZoom = 0D;
            submit_report_btn.IconVisible = true;
            submit_report_btn.IconZoom = 25D;
            submit_report_btn.IsTab = false;
            submit_report_btn.Location = new Point(383, 10);
            submit_report_btn.Margin = new Padding(4, 4, 4, 4);
            submit_report_btn.Name = "submit_report_btn";
            submit_report_btn.Normalcolor = Color.FromArgb(43, 47, 84);
            submit_report_btn.OnHovercolor = Color.FromArgb(60, 64, 98);
            submit_report_btn.OnHoverTextColor = Color.White;
            submit_report_btn.selected = false;
            submit_report_btn.Size = new Size(135, 32);
            submit_report_btn.TabIndex = 28;
            submit_report_btn.Text = "  Submit Report";
            submit_report_btn.TextAlign = ContentAlignment.MiddleLeft;
            submit_report_btn.Textcolor = Color.White;
            submit_report_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            submit_report_btn.Click += submit_report_btn_Click;
            // 
            // print_btn
            // 
            print_btn.Active = false;
            print_btn.Activecolor = Color.FromArgb(60, 64, 98);
            print_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            print_btn.BackColor = Color.FromArgb(43, 47, 84);
            print_btn.BackgroundImageLayout = ImageLayout.Stretch;
            print_btn.BorderRadius = 5;
            print_btn.ButtonText = "Print";
            print_btn.DisabledColor = Color.Gray;
            print_btn.Iconcolor = Color.Transparent;
            print_btn.Iconimage = null;
            print_btn.Iconimage_right = null;
            print_btn.Iconimage_right_Selected = null;
            print_btn.Iconimage_Selected = null;
            print_btn.IconMarginLeft = 0;
            print_btn.IconMarginRight = 0;
            print_btn.IconRightVisible = true;
            print_btn.IconRightZoom = 40D;
            print_btn.IconVisible = false;
            print_btn.IconZoom = 40D;
            print_btn.IsTab = false;
            print_btn.Location = new Point(658, 10);
            print_btn.Margin = new Padding(4, 4, 4, 4);
            print_btn.Name = "print_btn";
            print_btn.Normalcolor = Color.FromArgb(43, 47, 84);
            print_btn.OnHovercolor = Color.FromArgb(60, 64, 98);
            print_btn.OnHoverTextColor = Color.White;
            print_btn.Padding = new Padding(8, 5, 8, 5);
            print_btn.RightToLeft = RightToLeft.No;
            print_btn.selected = false;
            print_btn.Size = new Size(122, 32);
            print_btn.TabIndex = 29;
            print_btn.Text = "Print";
            print_btn.TextAlign = ContentAlignment.MiddleCenter;
            print_btn.Textcolor = Color.White;
            print_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            print_btn.Click += print_btn_Click;
            // 
            // GradingSheet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 660);
            Controls.Add(print_btn);
            Controls.Add(submit_report_btn);
            Controls.Add(no_data_panel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(add_new_btn);
            Controls.Add(generate_btn);
            Controls.Add(grading_sheet_dtg);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "GradingSheet";
            Text = "GradingSheet";
            ((System.ComponentModel.ISupportInitialize)grading_sheet_dtg).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            no_data_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grading_sheet_dtg;
        private Bunifu.Framework.UI.BunifuFlatButton generate_btn;
        private Bunifu.Framework.UI.BunifuFlatButton add_new_btn;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn mid_term;
        private DataGridViewTextBoxColumn final_term;
        private DataGridViewTextBoxColumn final_grade;
        private Bunifu.Framework.UI.BunifuFlatButton oral_btn;
        private Bunifu.Framework.UI.BunifuFlatButton komunikasyon_btn;
        private Bunifu.Framework.UI.BunifuFlatButton century_btn;
        private Bunifu.Framework.UI.BunifuFlatButton math_btn;
        private FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton philosophy_btn;
        private Bunifu.Framework.UI.BunifuFlatButton p_e_btn;
        private Bunifu.Framework.UI.BunifuFlatButton tve_btn;
        private Panel no_data_panel;
        private Label label1;
        private PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton submit_report_btn;
        private Bunifu.Framework.UI.BunifuFlatButton print_btn;
    }
}