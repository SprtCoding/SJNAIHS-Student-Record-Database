namespace Student_Record.TeachersModule.ReportSubmit
{
    partial class SelectReportOption
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
            cancel_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            submit_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            label2 = new Label();
            label1 = new Label();
            report_cbx = new ComboBox();
            fullname_lbl = new Label();
            label3 = new Label();
            docs_panel = new Panel();
            file_name_tb = new Label();
            open_file_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            status_cbx = new ComboBox();
            label4 = new Label();
            loadingProgress = new ProgressBar();
            lbl = new Label();
            dtg_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            docs_panel.SuspendLayout();
            SuspendLayout();
            // 
            // cancel_btn
            // 
            cancel_btn.Active = false;
            cancel_btn.Activecolor = Color.FromArgb(60, 64, 98);
            cancel_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            cancel_btn.Location = new Point(675, 634);
            cancel_btn.Margin = new Padding(6, 7, 6, 7);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Normalcolor = Color.FromArgb(255, 67, 67);
            cancel_btn.OnHovercolor = Color.FromArgb(223, 120, 124);
            cancel_btn.OnHoverTextColor = Color.White;
            cancel_btn.Padding = new Padding(11, 8, 11, 8);
            cancel_btn.RightToLeft = RightToLeft.No;
            cancel_btn.selected = false;
            cancel_btn.Size = new Size(243, 58);
            cancel_btn.TabIndex = 23;
            cancel_btn.Text = "Cancel";
            cancel_btn.TextAlign = ContentAlignment.MiddleCenter;
            cancel_btn.Textcolor = Color.White;
            cancel_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cancel_btn.Click += cancel_btn_Click;
            // 
            // submit_btn
            // 
            submit_btn.Active = false;
            submit_btn.Activecolor = Color.FromArgb(60, 64, 98);
            submit_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            submit_btn.BackColor = Color.FromArgb(129, 142, 254);
            submit_btn.BackgroundImageLayout = ImageLayout.Stretch;
            submit_btn.BorderRadius = 5;
            submit_btn.ButtonText = "Submit";
            submit_btn.DisabledColor = Color.Gray;
            submit_btn.Iconcolor = Color.Transparent;
            submit_btn.Iconimage = null;
            submit_btn.Iconimage_right = null;
            submit_btn.Iconimage_right_Selected = null;
            submit_btn.Iconimage_Selected = null;
            submit_btn.IconMarginLeft = 0;
            submit_btn.IconMarginRight = 0;
            submit_btn.IconRightVisible = true;
            submit_btn.IconRightZoom = 40D;
            submit_btn.IconVisible = false;
            submit_btn.IconZoom = 40D;
            submit_btn.IsTab = false;
            submit_btn.Location = new Point(404, 634);
            submit_btn.Margin = new Padding(6, 7, 6, 7);
            submit_btn.Name = "submit_btn";
            submit_btn.Normalcolor = Color.FromArgb(129, 142, 254);
            submit_btn.OnHovercolor = Color.FromArgb(86, 94, 169);
            submit_btn.OnHoverTextColor = Color.White;
            submit_btn.Padding = new Padding(11, 8, 11, 8);
            submit_btn.RightToLeft = RightToLeft.No;
            submit_btn.selected = false;
            submit_btn.Size = new Size(243, 58);
            submit_btn.TabIndex = 24;
            submit_btn.Text = "Submit";
            submit_btn.TextAlign = ContentAlignment.MiddleCenter;
            submit_btn.Textcolor = Color.White;
            submit_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            submit_btn.Click += submit_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(42, 92);
            label2.Name = "label2";
            label2.Size = new Size(253, 36);
            label2.TabIndex = 43;
            label2.Text = "Submit report to admin.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(42, 36);
            label1.Name = "label1";
            label1.Size = new Size(253, 56);
            label1.TabIndex = 42;
            label1.Text = "Submit Report";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // report_cbx
            // 
            report_cbx.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            report_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            report_cbx.FlatStyle = FlatStyle.Flat;
            report_cbx.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            report_cbx.FormattingEnabled = true;
            report_cbx.Items.AddRange(new object[] { "SF10", "SF9" });
            report_cbx.Location = new Point(42, 210);
            report_cbx.Name = "report_cbx";
            report_cbx.Size = new Size(876, 50);
            report_cbx.TabIndex = 45;
            // 
            // fullname_lbl
            // 
            fullname_lbl.AutoSize = true;
            fullname_lbl.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            fullname_lbl.ForeColor = Color.WhiteSmoke;
            fullname_lbl.Location = new Point(43, 162);
            fullname_lbl.Name = "fullname_lbl";
            fullname_lbl.Size = new Size(85, 36);
            fullname_lbl.TabIndex = 44;
            fullname_lbl.Text = "Report ";
            fullname_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(44, 295);
            label3.Name = "label3";
            label3.Size = new Size(176, 36);
            label3.TabIndex = 46;
            label3.Text = "Add Documents";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // docs_panel
            // 
            docs_panel.BorderStyle = BorderStyle.FixedSingle;
            docs_panel.Controls.Add(file_name_tb);
            docs_panel.Controls.Add(open_file_btn);
            docs_panel.Location = new Point(42, 337);
            docs_panel.Name = "docs_panel";
            docs_panel.Size = new Size(876, 63);
            docs_panel.TabIndex = 47;
            // 
            // file_name_tb
            // 
            file_name_tb.Dock = DockStyle.Fill;
            file_name_tb.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point);
            file_name_tb.ForeColor = Color.WhiteSmoke;
            file_name_tb.Location = new Point(229, 0);
            file_name_tb.Name = "file_name_tb";
            file_name_tb.Padding = new Padding(15, 0, 0, 0);
            file_name_tb.Size = new Size(645, 61);
            file_name_tb.TabIndex = 47;
            file_name_tb.Text = "File Name";
            file_name_tb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // open_file_btn
            // 
            open_file_btn.Active = false;
            open_file_btn.Activecolor = Color.FromArgb(60, 64, 98);
            open_file_btn.BackColor = Color.FromArgb(228, 229, 229);
            open_file_btn.BackgroundImageLayout = ImageLayout.Stretch;
            open_file_btn.BorderRadius = 0;
            open_file_btn.ButtonText = "Open File";
            open_file_btn.DisabledColor = Color.Gray;
            open_file_btn.Dock = DockStyle.Left;
            open_file_btn.Iconcolor = Color.Transparent;
            open_file_btn.Iconimage = null;
            open_file_btn.Iconimage_right = null;
            open_file_btn.Iconimage_right_Selected = null;
            open_file_btn.Iconimage_Selected = null;
            open_file_btn.IconMarginLeft = 0;
            open_file_btn.IconMarginRight = 0;
            open_file_btn.IconRightVisible = true;
            open_file_btn.IconRightZoom = 40D;
            open_file_btn.IconVisible = false;
            open_file_btn.IconZoom = 40D;
            open_file_btn.IsTab = false;
            open_file_btn.Location = new Point(0, 0);
            open_file_btn.Margin = new Padding(6, 7, 6, 7);
            open_file_btn.Name = "open_file_btn";
            open_file_btn.Normalcolor = Color.FromArgb(228, 229, 229);
            open_file_btn.OnHovercolor = Color.FromArgb(86, 94, 169);
            open_file_btn.OnHoverTextColor = Color.White;
            open_file_btn.Padding = new Padding(11, 8, 11, 8);
            open_file_btn.RightToLeft = RightToLeft.No;
            open_file_btn.selected = false;
            open_file_btn.Size = new Size(229, 61);
            open_file_btn.TabIndex = 25;
            open_file_btn.Text = "Open File";
            open_file_btn.TextAlign = ContentAlignment.MiddleCenter;
            open_file_btn.Textcolor = Color.FromArgb(43, 47, 84);
            open_file_btn.TextFont = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point);
            open_file_btn.Click += open_file_btn_Click;
            // 
            // status_cbx
            // 
            status_cbx.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            status_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            status_cbx.FlatStyle = FlatStyle.Flat;
            status_cbx.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            status_cbx.FormattingEnabled = true;
            status_cbx.Items.AddRange(new object[] { "NOT DONE", "ON GOING", "DONE" });
            status_cbx.Location = new Point(42, 477);
            status_cbx.Name = "status_cbx";
            status_cbx.Size = new Size(876, 50);
            status_cbx.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(42, 428);
            label4.Name = "label4";
            label4.Size = new Size(78, 36);
            label4.TabIndex = 48;
            label4.Text = "Status";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loadingProgress
            // 
            loadingProgress.Anchor = AnchorStyles.None;
            loadingProgress.Location = new Point(42, 589);
            loadingProgress.Name = "loadingProgress";
            loadingProgress.Size = new Size(876, 10);
            loadingProgress.TabIndex = 51;
            loadingProgress.Visible = false;
            // 
            // lbl
            // 
            lbl.Anchor = AnchorStyles.None;
            lbl.AutoSize = true;
            lbl.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.ForeColor = Color.LightCoral;
            lbl.Location = new Point(42, 550);
            lbl.Name = "lbl";
            lbl.Size = new Size(246, 23);
            lbl.TabIndex = 50;
            lbl.Text = "Submitting please wait...";
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Visible = false;
            // 
            // dtg_rad
            // 
            dtg_rad.ElipseRadius = 10;
            dtg_rad.TargetControl = this;
            // 
            // SelectReportOption
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 47, 84);
            ClientSize = new Size(960, 734);
            Controls.Add(loadingProgress);
            Controls.Add(lbl);
            Controls.Add(status_cbx);
            Controls.Add(label4);
            Controls.Add(docs_panel);
            Controls.Add(label3);
            Controls.Add(report_cbx);
            Controls.Add(fullname_lbl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(submit_btn);
            Controls.Add(cancel_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SelectReportOption";
            StartPosition = FormStartPosition.CenterScreen;
            Load += SelectReportOption_Load;
            docs_panel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton cancel_btn;
        private Bunifu.Framework.UI.BunifuFlatButton submit_btn;
        private Label label2;
        private Label label1;
        private ComboBox report_cbx;
        private Label fullname_lbl;
        private Label label3;
        private Panel docs_panel;
        private Label file_name_tb;
        private Bunifu.Framework.UI.BunifuFlatButton open_file_btn;
        private ComboBox status_cbx;
        private Label label4;
        private ProgressBar loadingProgress;
        private Label lbl;
        private Bunifu.Framework.UI.BunifuElipse dtg_rad;
    }
}