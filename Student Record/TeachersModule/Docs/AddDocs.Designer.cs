namespace Student_Record.TeachersModule.Docs
{
    partial class AddDocs
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
            add_docs_title = new Label();
            file_panel = new Panel();
            otherDocsFileName = new Label();
            openFileBtn = new Button();
            label1 = new Label();
            uploaded_panel = new FlowLayoutPanel();
            save_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            cancel_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            file_panel.SuspendLayout();
            SuspendLayout();
            // 
            // add_docs_title
            // 
            add_docs_title.AutoSize = true;
            add_docs_title.Font = new Font("Poppins Medium", 14F, FontStyle.Regular, GraphicsUnit.Point);
            add_docs_title.ForeColor = Color.WhiteSmoke;
            add_docs_title.Location = new Point(44, 41);
            add_docs_title.Name = "add_docs_title";
            add_docs_title.Size = new Size(249, 50);
            add_docs_title.TabIndex = 15;
            add_docs_title.Text = "Add Documents";
            add_docs_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // file_panel
            // 
            file_panel.BorderStyle = BorderStyle.FixedSingle;
            file_panel.Controls.Add(otherDocsFileName);
            file_panel.Controls.Add(openFileBtn);
            file_panel.Location = new Point(44, 164);
            file_panel.Name = "file_panel";
            file_panel.Size = new Size(933, 60);
            file_panel.TabIndex = 16;
            // 
            // otherDocsFileName
            // 
            otherDocsFileName.Dock = DockStyle.Fill;
            otherDocsFileName.FlatStyle = FlatStyle.Flat;
            otherDocsFileName.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            otherDocsFileName.ForeColor = Color.WhiteSmoke;
            otherDocsFileName.Location = new Point(248, 0);
            otherDocsFileName.Name = "otherDocsFileName";
            otherDocsFileName.Padding = new Padding(10, 0, 0, 0);
            otherDocsFileName.Size = new Size(683, 58);
            otherDocsFileName.TabIndex = 1;
            otherDocsFileName.Text = "File Name";
            otherDocsFileName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // openFileBtn
            // 
            openFileBtn.BackColor = Color.FromArgb(190, 202, 218);
            openFileBtn.Dock = DockStyle.Left;
            openFileBtn.FlatAppearance.BorderSize = 0;
            openFileBtn.FlatStyle = FlatStyle.Flat;
            openFileBtn.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            openFileBtn.Location = new Point(0, 0);
            openFileBtn.Name = "openFileBtn";
            openFileBtn.Size = new Size(248, 58);
            openFileBtn.TabIndex = 0;
            openFileBtn.Text = "Open File";
            openFileBtn.UseVisualStyleBackColor = false;
            openFileBtn.Click += openFileBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(44, 91);
            label1.Name = "label1";
            label1.Size = new Size(517, 36);
            label1.TabIndex = 17;
            label1.Text = "Add Student Documents, Form 137, Good Moral, etc.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uploaded_panel
            // 
            uploaded_panel.FlowDirection = FlowDirection.TopDown;
            uploaded_panel.Location = new Point(44, 250);
            uploaded_panel.Margin = new Padding(4, 5, 4, 5);
            uploaded_panel.Name = "uploaded_panel";
            uploaded_panel.Padding = new Padding(14, 17, 14, 17);
            uploaded_panel.Size = new Size(932, 229);
            uploaded_panel.TabIndex = 22;
            // 
            // save_btn
            // 
            save_btn.Active = false;
            save_btn.Activecolor = Color.FromArgb(60, 64, 98);
            save_btn.BackColor = Color.FromArgb(101, 169, 232);
            save_btn.BackgroundImageLayout = ImageLayout.Stretch;
            save_btn.BorderRadius = 5;
            save_btn.ButtonText = "Save";
            save_btn.DisabledColor = Color.Gray;
            save_btn.Iconcolor = Color.Transparent;
            save_btn.Iconimage = null;
            save_btn.Iconimage_right = null;
            save_btn.Iconimage_right_Selected = null;
            save_btn.Iconimage_Selected = null;
            save_btn.IconMarginLeft = 0;
            save_btn.IconMarginRight = 0;
            save_btn.IconRightVisible = true;
            save_btn.IconRightZoom = 40D;
            save_btn.IconVisible = false;
            save_btn.IconZoom = 40D;
            save_btn.IsTab = false;
            save_btn.Location = new Point(509, 517);
            save_btn.Margin = new Padding(9, 7, 9, 7);
            save_btn.Name = "save_btn";
            save_btn.Normalcolor = Color.FromArgb(101, 169, 232);
            save_btn.OnHovercolor = Color.FromArgb(60, 64, 98);
            save_btn.OnHoverTextColor = Color.White;
            save_btn.Padding = new Padding(16, 7, 16, 7);
            save_btn.RightToLeft = RightToLeft.No;
            save_btn.selected = false;
            save_btn.Size = new Size(220, 58);
            save_btn.TabIndex = 23;
            save_btn.Text = "Save";
            save_btn.TextAlign = ContentAlignment.MiddleCenter;
            save_btn.Textcolor = Color.White;
            save_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            save_btn.Click += save_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.Active = false;
            cancel_btn.Activecolor = Color.FromArgb(60, 64, 98);
            cancel_btn.BackColor = Color.FromArgb(255, 67, 67);
            cancel_btn.BackgroundImageLayout = ImageLayout.Stretch;
            cancel_btn.BorderRadius = 5;
            cancel_btn.ButtonText = "Cancel";
            cancel_btn.DisabledColor = Color.Gray;
            cancel_btn.Iconcolor = Color.Transparent;
            cancel_btn.Iconimage = null;
            cancel_btn.Iconimage_right = null;
            cancel_btn.Iconimage_right_Selected = null;
            cancel_btn.Iconimage_Selected = null;
            cancel_btn.IconMarginLeft = 0;
            cancel_btn.IconMarginRight = 0;
            cancel_btn.IconRightVisible = true;
            cancel_btn.IconRightZoom = 40D;
            cancel_btn.IconVisible = false;
            cancel_btn.IconZoom = 40D;
            cancel_btn.IsTab = false;
            cancel_btn.Location = new Point(757, 517);
            cancel_btn.Margin = new Padding(9, 7, 9, 7);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Normalcolor = Color.FromArgb(255, 67, 67);
            cancel_btn.OnHovercolor = Color.FromArgb(248, 108, 104);
            cancel_btn.OnHoverTextColor = Color.White;
            cancel_btn.Padding = new Padding(16, 7, 16, 7);
            cancel_btn.RightToLeft = RightToLeft.No;
            cancel_btn.selected = false;
            cancel_btn.Size = new Size(220, 58);
            cancel_btn.TabIndex = 24;
            cancel_btn.Text = "Cancel";
            cancel_btn.TextAlign = ContentAlignment.MiddleCenter;
            cancel_btn.Textcolor = Color.White;
            cancel_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // AddDocs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 47, 84);
            ClientSize = new Size(1021, 615);
            Controls.Add(cancel_btn);
            Controls.Add(save_btn);
            Controls.Add(uploaded_panel);
            Controls.Add(label1);
            Controls.Add(file_panel);
            Controls.Add(add_docs_title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddDocs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddDocs";
            file_panel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label add_docs_title;
        private Panel file_panel;
        private Label label1;
        private Button openFileBtn;
        private Label otherDocsFileName;
        private FlowLayoutPanel uploaded_panel;
        private Bunifu.Framework.UI.BunifuFlatButton save_btn;
        private Bunifu.Framework.UI.BunifuFlatButton cancel_btn;
    }
}