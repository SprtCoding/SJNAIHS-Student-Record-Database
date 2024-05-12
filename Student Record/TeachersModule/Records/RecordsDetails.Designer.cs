namespace Student_Record.TeachersModule.Records
{
    partial class RecordsDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordsDetails));
            dtg_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            start_panel = new Panel();
            guardian_lbl = new Label();
            mother_contact_lbl = new Label();
            mother_lbl = new Label();
            father_contact_lbl = new Label();
            father_lbl = new Label();
            gender_lbl = new Label();
            contact_num_lbl = new Label();
            address_lbl = new Label();
            bday_lbl = new Label();
            strand_lbl = new Label();
            grade_section_lbl = new Label();
            lrn_lbl = new Label();
            student_pic = new PictureBox();
            student_name_lbl = new Label();
            end_panel = new Panel();
            close_btn = new PictureBox();
            new_docs_panel = new Panel();
            cancel_btn = new Button();
            save_btn = new Button();
            uploaded_panel = new FlowLayoutPanel();
            panel1 = new Panel();
            otherDocsFileName = new Label();
            openFileBtn = new Button();
            add_docs_title = new Label();
            list_panel = new FlowLayoutPanel();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            start_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)student_pic).BeginInit();
            end_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)close_btn).BeginInit();
            new_docs_panel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtg_rad
            // 
            dtg_rad.ElipseRadius = 10;
            dtg_rad.TargetControl = this;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(start_panel, 0, 0);
            tableLayoutPanel1.Controls.Add(end_panel, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1389, 807);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // start_panel
            // 
            start_panel.Controls.Add(guardian_lbl);
            start_panel.Controls.Add(mother_contact_lbl);
            start_panel.Controls.Add(mother_lbl);
            start_panel.Controls.Add(father_contact_lbl);
            start_panel.Controls.Add(father_lbl);
            start_panel.Controls.Add(gender_lbl);
            start_panel.Controls.Add(contact_num_lbl);
            start_panel.Controls.Add(address_lbl);
            start_panel.Controls.Add(bday_lbl);
            start_panel.Controls.Add(strand_lbl);
            start_panel.Controls.Add(grade_section_lbl);
            start_panel.Controls.Add(lrn_lbl);
            start_panel.Controls.Add(student_pic);
            start_panel.Controls.Add(student_name_lbl);
            start_panel.Dock = DockStyle.Fill;
            start_panel.Location = new Point(3, 3);
            start_panel.Name = "start_panel";
            start_panel.Size = new Size(688, 801);
            start_panel.TabIndex = 0;
            // 
            // guardian_lbl
            // 
            guardian_lbl.Font = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guardian_lbl.ForeColor = Color.WhiteSmoke;
            guardian_lbl.Location = new Point(25, 728);
            guardian_lbl.Name = "guardian_lbl";
            guardian_lbl.Size = new Size(638, 56);
            guardian_lbl.TabIndex = 57;
            guardian_lbl.Text = "Guardian's Name:";
            guardian_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mother_contact_lbl
            // 
            mother_contact_lbl.Font = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            mother_contact_lbl.ForeColor = Color.WhiteSmoke;
            mother_contact_lbl.Location = new Point(25, 672);
            mother_contact_lbl.Name = "mother_contact_lbl";
            mother_contact_lbl.Size = new Size(638, 56);
            mother_contact_lbl.TabIndex = 56;
            mother_contact_lbl.Text = "Contact #:";
            mother_contact_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mother_lbl
            // 
            mother_lbl.Font = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            mother_lbl.ForeColor = Color.WhiteSmoke;
            mother_lbl.Location = new Point(25, 616);
            mother_lbl.Name = "mother_lbl";
            mother_lbl.Size = new Size(638, 56);
            mother_lbl.TabIndex = 55;
            mother_lbl.Text = "Mother's Name:";
            mother_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // father_contact_lbl
            // 
            father_contact_lbl.Font = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            father_contact_lbl.ForeColor = Color.WhiteSmoke;
            father_contact_lbl.Location = new Point(25, 560);
            father_contact_lbl.Name = "father_contact_lbl";
            father_contact_lbl.Size = new Size(638, 56);
            father_contact_lbl.TabIndex = 54;
            father_contact_lbl.Text = "Contact #:";
            father_contact_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // father_lbl
            // 
            father_lbl.Font = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            father_lbl.ForeColor = Color.WhiteSmoke;
            father_lbl.Location = new Point(25, 504);
            father_lbl.Name = "father_lbl";
            father_lbl.Size = new Size(638, 56);
            father_lbl.TabIndex = 53;
            father_lbl.Text = "Father's Name:";
            father_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gender_lbl
            // 
            gender_lbl.Font = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gender_lbl.ForeColor = Color.WhiteSmoke;
            gender_lbl.Location = new Point(25, 448);
            gender_lbl.Name = "gender_lbl";
            gender_lbl.Size = new Size(638, 56);
            gender_lbl.TabIndex = 52;
            gender_lbl.Text = "Gender:";
            gender_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // contact_num_lbl
            // 
            contact_num_lbl.Font = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            contact_num_lbl.ForeColor = Color.WhiteSmoke;
            contact_num_lbl.Location = new Point(25, 392);
            contact_num_lbl.Name = "contact_num_lbl";
            contact_num_lbl.Size = new Size(638, 56);
            contact_num_lbl.TabIndex = 51;
            contact_num_lbl.Text = "Contact #:";
            contact_num_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // address_lbl
            // 
            address_lbl.Font = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            address_lbl.ForeColor = Color.WhiteSmoke;
            address_lbl.Location = new Point(25, 336);
            address_lbl.Name = "address_lbl";
            address_lbl.Size = new Size(638, 56);
            address_lbl.TabIndex = 50;
            address_lbl.Text = "Address:";
            address_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bday_lbl
            // 
            bday_lbl.Font = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            bday_lbl.ForeColor = Color.WhiteSmoke;
            bday_lbl.Location = new Point(25, 280);
            bday_lbl.Name = "bday_lbl";
            bday_lbl.Size = new Size(638, 56);
            bday_lbl.TabIndex = 49;
            bday_lbl.Text = "Date of Birth:";
            bday_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // strand_lbl
            // 
            strand_lbl.Font = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            strand_lbl.ForeColor = Color.WhiteSmoke;
            strand_lbl.Location = new Point(25, 224);
            strand_lbl.Name = "strand_lbl";
            strand_lbl.Size = new Size(638, 56);
            strand_lbl.TabIndex = 48;
            strand_lbl.Text = "Strand:";
            strand_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grade_section_lbl
            // 
            grade_section_lbl.Font = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            grade_section_lbl.ForeColor = Color.WhiteSmoke;
            grade_section_lbl.Location = new Point(221, 131);
            grade_section_lbl.Name = "grade_section_lbl";
            grade_section_lbl.Size = new Size(442, 56);
            grade_section_lbl.TabIndex = 47;
            grade_section_lbl.Text = "Grade/Section:";
            grade_section_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lrn_lbl
            // 
            lrn_lbl.Font = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lrn_lbl.ForeColor = Color.WhiteSmoke;
            lrn_lbl.Location = new Point(221, 89);
            lrn_lbl.Name = "lrn_lbl";
            lrn_lbl.Size = new Size(442, 56);
            lrn_lbl.TabIndex = 46;
            lrn_lbl.Text = "Lrn Number:";
            lrn_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // student_pic
            // 
            student_pic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            student_pic.Image = (Image)resources.GetObject("student_pic.Image");
            student_pic.Location = new Point(25, 27);
            student_pic.Margin = new Padding(4, 5, 4, 5);
            student_pic.Name = "student_pic";
            student_pic.Size = new Size(160, 160);
            student_pic.SizeMode = PictureBoxSizeMode.Zoom;
            student_pic.TabIndex = 45;
            student_pic.TabStop = false;
            // 
            // student_name_lbl
            // 
            student_name_lbl.Font = new Font("Poppins Medium", 14F, FontStyle.Regular, GraphicsUnit.Point);
            student_name_lbl.ForeColor = Color.WhiteSmoke;
            student_name_lbl.Location = new Point(221, 32);
            student_name_lbl.Name = "student_name_lbl";
            student_name_lbl.Size = new Size(442, 56);
            student_name_lbl.TabIndex = 44;
            student_name_lbl.Text = "Student Records Details";
            student_name_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // end_panel
            // 
            end_panel.BackColor = Color.WhiteSmoke;
            end_panel.Controls.Add(close_btn);
            end_panel.Controls.Add(new_docs_panel);
            end_panel.Controls.Add(list_panel);
            end_panel.Controls.Add(label1);
            end_panel.Dock = DockStyle.Fill;
            end_panel.Location = new Point(697, 3);
            end_panel.Name = "end_panel";
            end_panel.Size = new Size(689, 801);
            end_panel.TabIndex = 1;
            // 
            // close_btn
            // 
            close_btn.Cursor = Cursors.Hand;
            close_btn.Image = Properties.Resources.cross;
            close_btn.Location = new Point(654, 9);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(26, 25);
            close_btn.SizeMode = PictureBoxSizeMode.Zoom;
            close_btn.TabIndex = 48;
            close_btn.TabStop = false;
            close_btn.Click += close_btn_Click;
            // 
            // new_docs_panel
            // 
            new_docs_panel.Controls.Add(cancel_btn);
            new_docs_panel.Controls.Add(save_btn);
            new_docs_panel.Controls.Add(uploaded_panel);
            new_docs_panel.Controls.Add(panel1);
            new_docs_panel.Controls.Add(add_docs_title);
            new_docs_panel.Dock = DockStyle.Bottom;
            new_docs_panel.Location = new Point(0, 280);
            new_docs_panel.Name = "new_docs_panel";
            new_docs_panel.Size = new Size(689, 521);
            new_docs_panel.TabIndex = 47;
            // 
            // cancel_btn
            // 
            cancel_btn.BackColor = Color.FromArgb(255, 67, 67);
            cancel_btn.FlatAppearance.BorderColor = Color.FromArgb(255, 67, 67);
            cancel_btn.FlatStyle = FlatStyle.Flat;
            cancel_btn.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cancel_btn.ForeColor = Color.WhiteSmoke;
            cancel_btn.Location = new Point(441, 418);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(210, 55);
            cancel_btn.TabIndex = 50;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = false;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // save_btn
            // 
            save_btn.BackColor = Color.FromArgb(43, 47, 84);
            save_btn.FlatAppearance.BorderColor = Color.FromArgb(86, 94, 169);
            save_btn.FlatStyle = FlatStyle.Flat;
            save_btn.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            save_btn.ForeColor = Color.WhiteSmoke;
            save_btn.Location = new Point(197, 418);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(210, 55);
            save_btn.TabIndex = 49;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += save_btn_Click;
            // 
            // uploaded_panel
            // 
            uploaded_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uploaded_panel.BorderStyle = BorderStyle.FixedSingle;
            uploaded_panel.FlowDirection = FlowDirection.TopDown;
            uploaded_panel.Location = new Point(36, 168);
            uploaded_panel.Margin = new Padding(4, 5, 4, 5);
            uploaded_panel.Name = "uploaded_panel";
            uploaded_panel.Padding = new Padding(14, 17, 14, 17);
            uploaded_panel.Size = new Size(615, 161);
            uploaded_panel.TabIndex = 48;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(otherDocsFileName);
            panel1.Controls.Add(openFileBtn);
            panel1.Location = new Point(37, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 57);
            panel1.TabIndex = 47;
            // 
            // otherDocsFileName
            // 
            otherDocsFileName.Dock = DockStyle.Fill;
            otherDocsFileName.Font = new Font("Poppins Light", 8F, FontStyle.Regular, GraphicsUnit.Point);
            otherDocsFileName.ForeColor = Color.FromArgb(43, 47, 84);
            otherDocsFileName.Location = new Point(206, 0);
            otherDocsFileName.Name = "otherDocsFileName";
            otherDocsFileName.Padding = new Padding(10, 0, 0, 0);
            otherDocsFileName.Size = new Size(407, 55);
            otherDocsFileName.TabIndex = 47;
            otherDocsFileName.Text = "Add more Documents";
            otherDocsFileName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // openFileBtn
            // 
            openFileBtn.BackColor = Color.FromArgb(43, 47, 84);
            openFileBtn.Dock = DockStyle.Left;
            openFileBtn.FlatAppearance.BorderColor = Color.FromArgb(86, 94, 169);
            openFileBtn.FlatAppearance.BorderSize = 0;
            openFileBtn.FlatStyle = FlatStyle.Flat;
            openFileBtn.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point);
            openFileBtn.ForeColor = Color.WhiteSmoke;
            openFileBtn.Location = new Point(0, 0);
            openFileBtn.Name = "openFileBtn";
            openFileBtn.Size = new Size(206, 55);
            openFileBtn.TabIndex = 0;
            openFileBtn.Text = "Open File";
            openFileBtn.UseVisualStyleBackColor = false;
            openFileBtn.Click += openFileBtn_Click;
            // 
            // add_docs_title
            // 
            add_docs_title.Font = new Font("Poppins Medium", 10F, FontStyle.Underline, GraphicsUnit.Point);
            add_docs_title.ForeColor = Color.FromArgb(43, 47, 84);
            add_docs_title.Location = new Point(37, 26);
            add_docs_title.Name = "add_docs_title";
            add_docs_title.Size = new Size(442, 56);
            add_docs_title.TabIndex = 46;
            add_docs_title.Text = "Add more Documents";
            add_docs_title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // list_panel
            // 
            list_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            list_panel.BorderStyle = BorderStyle.FixedSingle;
            list_panel.FlowDirection = FlowDirection.TopDown;
            list_panel.Location = new Point(37, 89);
            list_panel.Margin = new Padding(4, 5, 4, 5);
            list_panel.Name = "list_panel";
            list_panel.Padding = new Padding(14, 17, 14, 17);
            list_panel.Size = new Size(615, 161);
            list_panel.TabIndex = 46;
            // 
            // label1
            // 
            label1.Font = new Font("Poppins Medium", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(43, 47, 84);
            label1.Location = new Point(37, 27);
            label1.Name = "label1";
            label1.Size = new Size(442, 56);
            label1.TabIndex = 45;
            label1.Text = "List of Submitted Documents";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RecordsDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 47, 84);
            ClientSize = new Size(1389, 807);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RecordsDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecordsDetails";
            tableLayoutPanel1.ResumeLayout(false);
            start_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)student_pic).EndInit();
            end_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)close_btn).EndInit();
            new_docs_panel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse dtg_rad;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel start_panel;
        private Label lrn_lbl;
        private PictureBox student_pic;
        private Label student_name_lbl;
        private Label grade_section_lbl;
        private Label strand_lbl;
        private Label bday_lbl;
        private Label father_lbl;
        private Label gender_lbl;
        private Label contact_num_lbl;
        private Label address_lbl;
        private Label mother_lbl;
        private Label father_contact_lbl;
        private Label guardian_lbl;
        private Label mother_contact_lbl;
        private Panel end_panel;
        private Label label1;
        private FlowLayoutPanel list_panel;
        private Panel new_docs_panel;
        private Label add_docs_title;
        private Panel panel1;
        private Label otherDocsFileName;
        private Button openFileBtn;
        private FlowLayoutPanel uploaded_panel;
        private Button save_btn;
        private Button cancel_btn;
        private PictureBox close_btn;
    }
}