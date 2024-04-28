namespace Student_Record.TeachersModule.Docs
{
    partial class AddNewDocs
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
            new_docs_panel = new Panel();
            save_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            uploaded_panel = new FlowLayoutPanel();
            status_cb = new CheckBox();
            openFileBtn = new PictureBox();
            otherDocsFileName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            add_docs_title = new Label();
            new_docs_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)openFileBtn).BeginInit();
            SuspendLayout();
            // 
            // new_docs_panel
            // 
            new_docs_panel.Controls.Add(save_btn);
            new_docs_panel.Controls.Add(uploaded_panel);
            new_docs_panel.Controls.Add(status_cb);
            new_docs_panel.Controls.Add(openFileBtn);
            new_docs_panel.Controls.Add(otherDocsFileName);
            new_docs_panel.Controls.Add(add_docs_title);
            new_docs_panel.Dock = DockStyle.Fill;
            new_docs_panel.Location = new Point(0, 0);
            new_docs_panel.Margin = new Padding(4, 5, 4, 5);
            new_docs_panel.Name = "new_docs_panel";
            new_docs_panel.Size = new Size(1342, 500);
            new_docs_panel.TabIndex = 16;
            // 
            // save_btn
            // 
            save_btn.Active = false;
            save_btn.Activecolor = Color.FromArgb(60, 64, 98);
            save_btn.BackColor = Color.FromArgb(43, 47, 84);
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
            save_btn.Location = new Point(1038, 426);
            save_btn.Margin = new Padding(9, 7, 9, 7);
            save_btn.Name = "save_btn";
            save_btn.Normalcolor = Color.FromArgb(43, 47, 84);
            save_btn.OnHovercolor = Color.FromArgb(60, 64, 98);
            save_btn.OnHoverTextColor = Color.White;
            save_btn.Padding = new Padding(16, 7, 16, 7);
            save_btn.RightToLeft = RightToLeft.No;
            save_btn.selected = false;
            save_btn.Size = new Size(286, 58);
            save_btn.TabIndex = 22;
            save_btn.Text = "Save";
            save_btn.TextAlign = ContentAlignment.MiddleCenter;
            save_btn.Textcolor = Color.White;
            save_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            save_btn.Click += save_btn_Click;
            // 
            // uploaded_panel
            // 
            uploaded_panel.FlowDirection = FlowDirection.TopDown;
            uploaded_panel.Location = new Point(21, 135);
            uploaded_panel.Margin = new Padding(4, 5, 4, 5);
            uploaded_panel.Name = "uploaded_panel";
            uploaded_panel.Padding = new Padding(14, 17, 14, 17);
            uploaded_panel.Size = new Size(1301, 279);
            uploaded_panel.TabIndex = 21;
            // 
            // status_cb
            // 
            status_cb.AutoSize = true;
            status_cb.CheckAlign = ContentAlignment.MiddleCenter;
            status_cb.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            status_cb.Location = new Point(26, 95);
            status_cb.Margin = new Padding(4, 5, 4, 5);
            status_cb.Name = "status_cb";
            status_cb.Size = new Size(22, 21);
            status_cb.TabIndex = 15;
            status_cb.UseVisualStyleBackColor = true;
            // 
            // openFileBtn
            // 
            openFileBtn.Image = Properties.Resources.open_file;
            openFileBtn.Location = new Point(1286, 83);
            openFileBtn.Name = "openFileBtn";
            openFileBtn.Size = new Size(30, 30);
            openFileBtn.SizeMode = PictureBoxSizeMode.Zoom;
            openFileBtn.TabIndex = 20;
            openFileBtn.TabStop = false;
            openFileBtn.Click += openFileBtn_Click;
            // 
            // otherDocsFileName
            // 
            otherDocsFileName.AutoCompleteMode = AutoCompleteMode.None;
            otherDocsFileName.AutoCompleteSource = AutoCompleteSource.None;
            otherDocsFileName.characterCasing = CharacterCasing.Normal;
            otherDocsFileName.Enabled = false;
            otherDocsFileName.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            otherDocsFileName.ForeColor = Color.FromArgb(64, 64, 64);
            otherDocsFileName.HintForeColor = Color.Empty;
            otherDocsFileName.HintText = "Open file...";
            otherDocsFileName.isPassword = false;
            otherDocsFileName.LineFocusedColor = Color.FromArgb(43, 47, 84);
            otherDocsFileName.LineIdleColor = Color.FromArgb(60, 64, 98);
            otherDocsFileName.LineMouseHoverColor = Color.FromArgb(43, 47, 84);
            otherDocsFileName.LineThickness = 2;
            otherDocsFileName.Location = new Point(57, 75);
            otherDocsFileName.Margin = new Padding(6, 5, 6, 5);
            otherDocsFileName.MaxLength = 32767;
            otherDocsFileName.Name = "otherDocsFileName";
            otherDocsFileName.Size = new Size(1265, 50);
            otherDocsFileName.TabIndex = 19;
            otherDocsFileName.TextAlign = HorizontalAlignment.Left;
            // 
            // add_docs_title
            // 
            add_docs_title.AutoSize = true;
            add_docs_title.Font = new Font("Poppins", 10F, FontStyle.Underline, GraphicsUnit.Point);
            add_docs_title.ForeColor = SystemColors.ControlText;
            add_docs_title.Location = new Point(16, 18);
            add_docs_title.Name = "add_docs_title";
            add_docs_title.Size = new Size(176, 36);
            add_docs_title.TabIndex = 14;
            add_docs_title.Text = "Add Documents";
            add_docs_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddNewDocs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 500);
            Controls.Add(new_docs_panel);
            Name = "AddNewDocs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewDocs";
            new_docs_panel.ResumeLayout(false);
            new_docs_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)openFileBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel new_docs_panel;
        private Bunifu.Framework.UI.BunifuFlatButton save_btn;
        private FlowLayoutPanel uploaded_panel;
        private CheckBox status_cb;
        private PictureBox openFileBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox otherDocsFileName;
        private Label add_docs_title;
    }
}