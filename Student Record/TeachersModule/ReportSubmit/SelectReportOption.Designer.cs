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
            title_lbl = new Label();
            label1 = new Label();
            report_type_cbx = new ComboBox();
            status_cbx = new ComboBox();
            label2 = new Label();
            cancel_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            submit_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            SuspendLayout();
            // 
            // title_lbl
            // 
            title_lbl.AutoSize = true;
            title_lbl.Font = new Font("Poppins Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            title_lbl.ForeColor = SystemColors.ControlText;
            title_lbl.Location = new Point(45, 33);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(197, 42);
            title_lbl.TabIndex = 8;
            title_lbl.Text = "Report Options";
            title_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(45, 120);
            label1.Name = "label1";
            label1.Size = new Size(136, 36);
            label1.TabIndex = 9;
            label1.Text = "Report Type";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // report_type_cbx
            // 
            report_type_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            report_type_cbx.FlatStyle = FlatStyle.Flat;
            report_type_cbx.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            report_type_cbx.FormattingEnabled = true;
            report_type_cbx.Items.AddRange(new object[] { "Student Profile Report", "Student Grade Report" });
            report_type_cbx.Location = new Point(45, 170);
            report_type_cbx.Name = "report_type_cbx";
            report_type_cbx.Size = new Size(655, 44);
            report_type_cbx.TabIndex = 10;
            // 
            // status_cbx
            // 
            status_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            status_cbx.FlatStyle = FlatStyle.Flat;
            status_cbx.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            status_cbx.FormattingEnabled = true;
            status_cbx.Items.AddRange(new object[] { "On Going", "Pending", "Done" });
            status_cbx.Location = new Point(45, 285);
            status_cbx.Name = "status_cbx";
            status_cbx.Size = new Size(655, 44);
            status_cbx.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(45, 235);
            label2.Name = "label2";
            label2.Size = new Size(79, 36);
            label2.TabIndex = 11;
            label2.Text = "Status";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cancel_btn
            // 
            cancel_btn.Active = false;
            cancel_btn.Activecolor = Color.FromArgb(60, 64, 98);
            cancel_btn.BackColor = Color.FromArgb(207, 53, 59);
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
            cancel_btn.Location = new Point(540, 386);
            cancel_btn.Margin = new Padding(6, 7, 6, 7);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Normalcolor = Color.FromArgb(207, 53, 59);
            cancel_btn.OnHovercolor = Color.FromArgb(223, 120, 124);
            cancel_btn.OnHoverTextColor = Color.White;
            cancel_btn.Padding = new Padding(11, 8, 11, 8);
            cancel_btn.RightToLeft = RightToLeft.No;
            cancel_btn.selected = false;
            cancel_btn.Size = new Size(160, 53);
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
            submit_btn.BackColor = Color.FromArgb(43, 47, 84);
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
            submit_btn.Location = new Point(368, 386);
            submit_btn.Margin = new Padding(6, 7, 6, 7);
            submit_btn.Name = "submit_btn";
            submit_btn.Normalcolor = Color.FromArgb(43, 47, 84);
            submit_btn.OnHovercolor = Color.FromArgb(60, 64, 98);
            submit_btn.OnHoverTextColor = Color.White;
            submit_btn.Padding = new Padding(11, 8, 11, 8);
            submit_btn.RightToLeft = RightToLeft.No;
            submit_btn.selected = false;
            submit_btn.Size = new Size(160, 53);
            submit_btn.TabIndex = 24;
            submit_btn.Text = "Submit";
            submit_btn.TextAlign = ContentAlignment.MiddleCenter;
            submit_btn.Textcolor = Color.White;
            submit_btn.TextFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            submit_btn.Click += submit_btn_Click;
            // 
            // SelectReportOption
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 493);
            Controls.Add(submit_btn);
            Controls.Add(cancel_btn);
            Controls.Add(status_cbx);
            Controls.Add(label2);
            Controls.Add(report_type_cbx);
            Controls.Add(label1);
            Controls.Add(title_lbl);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SelectReportOption";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title_lbl;
        private Label label1;
        private ComboBox report_type_cbx;
        private ComboBox status_cbx;
        private Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton cancel_btn;
        private Bunifu.Framework.UI.BunifuFlatButton submit_btn;
    }
}