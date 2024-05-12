namespace Student_Record.TeachersModule.GenerateRecords
{
    partial class SF10Generated
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
            student_cbx = new ComboBox();
            fullname_lbl = new Label();
            label1 = new Label();
            cancel_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            label2 = new Label();
            generate_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            dtg_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            loadingProgress = new ProgressBar();
            lbl = new Label();
            SuspendLayout();
            // 
            // student_cbx
            // 
            student_cbx.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            student_cbx.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            student_cbx.FormattingEnabled = true;
            student_cbx.Location = new Point(42, 233);
            student_cbx.Name = "student_cbx";
            student_cbx.Size = new Size(876, 50);
            student_cbx.TabIndex = 38;
            student_cbx.TextChanged += student_cbx_TextChanged;
            student_cbx.KeyDown += student_cbx_KeyDown;
            // 
            // fullname_lbl
            // 
            fullname_lbl.AutoSize = true;
            fullname_lbl.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            fullname_lbl.ForeColor = Color.WhiteSmoke;
            fullname_lbl.Location = new Point(41, 184);
            fullname_lbl.Name = "fullname_lbl";
            fullname_lbl.Size = new Size(163, 36);
            fullname_lbl.TabIndex = 37;
            fullname_lbl.Text = "Select Student ";
            fullname_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(41, 42);
            label1.Name = "label1";
            label1.Size = new Size(251, 56);
            label1.TabIndex = 39;
            label1.Text = "Generate SF10";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cancel_btn
            // 
            cancel_btn.Active = false;
            cancel_btn.Activecolor = Color.FromArgb(60, 64, 98);
            cancel_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            cancel_btn.Location = new Point(675, 372);
            cancel_btn.Margin = new Padding(6, 7, 6, 7);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Normalcolor = Color.FromArgb(255, 67, 67);
            cancel_btn.OnHovercolor = Color.FromArgb(255, 129, 129);
            cancel_btn.OnHoverTextColor = Color.WhiteSmoke;
            cancel_btn.Padding = new Padding(11, 8, 11, 8);
            cancel_btn.RightToLeft = RightToLeft.No;
            cancel_btn.selected = false;
            cancel_btn.Size = new Size(243, 58);
            cancel_btn.TabIndex = 40;
            cancel_btn.Text = "Cancel";
            cancel_btn.TextAlign = ContentAlignment.MiddleCenter;
            cancel_btn.Textcolor = Color.White;
            cancel_btn.TextFont = new Font("Poppins Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cancel_btn.Click += cancel_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(41, 98);
            label2.Name = "label2";
            label2.Size = new Size(502, 36);
            label2.TabIndex = 41;
            label2.Text = "Select the student you want to generate form 137.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // generate_btn
            // 
            generate_btn.Active = false;
            generate_btn.Activecolor = Color.FromArgb(60, 64, 98);
            generate_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            generate_btn.BackColor = Color.FromArgb(129, 142, 254);
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
            generate_btn.Location = new Point(402, 372);
            generate_btn.Margin = new Padding(6, 7, 6, 7);
            generate_btn.Name = "generate_btn";
            generate_btn.Normalcolor = Color.FromArgb(129, 142, 254);
            generate_btn.OnHovercolor = Color.FromArgb(86, 94, 169);
            generate_btn.OnHoverTextColor = Color.WhiteSmoke;
            generate_btn.Padding = new Padding(11, 8, 11, 8);
            generate_btn.RightToLeft = RightToLeft.No;
            generate_btn.selected = false;
            generate_btn.Size = new Size(243, 58);
            generate_btn.TabIndex = 42;
            generate_btn.Text = "Generate";
            generate_btn.TextAlign = ContentAlignment.MiddleCenter;
            generate_btn.Textcolor = Color.White;
            generate_btn.TextFont = new Font("Poppins Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            generate_btn.Click += generate_btn_Click;
            // 
            // dtg_rad
            // 
            dtg_rad.ElipseRadius = 10;
            dtg_rad.TargetControl = this;
            // 
            // loadingProgress
            // 
            loadingProgress.Anchor = AnchorStyles.None;
            loadingProgress.Location = new Point(42, 342);
            loadingProgress.Name = "loadingProgress";
            loadingProgress.Size = new Size(876, 10);
            loadingProgress.TabIndex = 44;
            loadingProgress.Visible = false;
            // 
            // lbl
            // 
            lbl.Anchor = AnchorStyles.None;
            lbl.AutoSize = true;
            lbl.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.ForeColor = Color.LightCoral;
            lbl.Location = new Point(41, 311);
            lbl.Name = "lbl";
            lbl.Size = new Size(256, 23);
            lbl.TabIndex = 43;
            lbl.Text = "Generating please wait...";
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Visible = false;
            // 
            // SF10Generated
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 47, 84);
            ClientSize = new Size(960, 471);
            Controls.Add(loadingProgress);
            Controls.Add(lbl);
            Controls.Add(generate_btn);
            Controls.Add(label2);
            Controls.Add(cancel_btn);
            Controls.Add(label1);
            Controls.Add(student_cbx);
            Controls.Add(fullname_lbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SF10Generated";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SF10Generated";
            Load += SF10Generated_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox student_cbx;
        private Label fullname_lbl;
        private Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton cancel_btn;
        private Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton generate_btn;
        private Bunifu.Framework.UI.BunifuElipse dtg_rad;
        private ProgressBar loadingProgress;
        private Label lbl;
    }
}