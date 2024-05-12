namespace Student_Record.AdminModule
{
    partial class HomeDashboard
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
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            student_panel = new Panel();
            label4 = new Label();
            total_student_lbl = new Label();
            faculty_panel = new Panel();
            label1 = new Label();
            faculty_text_value = new Label();
            panel1_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            panel2_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            panel3_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            tableLayoutPanel1.SuspendLayout();
            student_panel.SuspendLayout();
            faculty_panel.SuspendLayout();
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
            label2.Size = new Size(131, 30);
            label2.TabIndex = 5;
            label2.Text = "Dashboard";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 14F));
            tableLayoutPanel1.Controls.Add(student_panel, 1, 0);
            tableLayoutPanel1.Controls.Add(faculty_panel, 0, 0);
            tableLayoutPanel1.Location = new Point(8, 70);
            tableLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(773, 259);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // student_panel
            // 
            student_panel.BackColor = Color.FromArgb(76, 162, 205);
            student_panel.Controls.Add(label4);
            student_panel.Controls.Add(total_student_lbl);
            student_panel.Dock = DockStyle.Fill;
            student_panel.Location = new Point(393, 6);
            student_panel.Margin = new Padding(7, 6, 7, 6);
            student_panel.Name = "student_panel";
            student_panel.Size = new Size(373, 247);
            student_panel.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(2, 5);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(369, 38);
            label4.TabIndex = 0;
            label4.Text = "Total Number of Student";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // total_student_lbl
            // 
            total_student_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            total_student_lbl.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            total_student_lbl.ForeColor = Color.WhiteSmoke;
            total_student_lbl.Location = new Point(2, 56);
            total_student_lbl.Margin = new Padding(2, 0, 2, 0);
            total_student_lbl.Name = "total_student_lbl";
            total_student_lbl.Size = new Size(369, 134);
            total_student_lbl.TabIndex = 1;
            total_student_lbl.Text = "0";
            total_student_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // faculty_panel
            // 
            faculty_panel.BackColor = Color.FromArgb(43, 47, 84);
            faculty_panel.Controls.Add(label1);
            faculty_panel.Controls.Add(faculty_text_value);
            faculty_panel.Dock = DockStyle.Fill;
            faculty_panel.Location = new Point(7, 6);
            faculty_panel.Margin = new Padding(7, 6, 7, 6);
            faculty_panel.Name = "faculty_panel";
            faculty_panel.Size = new Size(372, 247);
            faculty_panel.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(2, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(368, 38);
            label1.TabIndex = 0;
            label1.Text = "Total Number of Faculty";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // faculty_text_value
            // 
            faculty_text_value.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            faculty_text_value.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            faculty_text_value.ForeColor = Color.WhiteSmoke;
            faculty_text_value.Location = new Point(2, 56);
            faculty_text_value.Margin = new Padding(2, 0, 2, 0);
            faculty_text_value.Name = "faculty_text_value";
            faculty_text_value.Size = new Size(368, 134);
            faculty_text_value.TabIndex = 1;
            faculty_text_value.Text = "0";
            faculty_text_value.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1_rad
            // 
            panel1_rad.ElipseRadius = 10;
            panel1_rad.TargetControl = faculty_panel;
            // 
            // panel2_rad
            // 
            panel2_rad.ElipseRadius = 10;
            panel2_rad.TargetControl = student_panel;
            // 
            // panel3_rad
            // 
            panel3_rad.ElipseRadius = 10;
            panel3_rad.TargetControl = this;
            // 
            // HomeDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 461);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "HomeDashboard";
            Text = "HomeDashboard";
            Load += HomeDashboard_Load;
            tableLayoutPanel1.ResumeLayout(false);
            student_panel.ResumeLayout(false);
            faculty_panel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel student_panel;
        private Label label4;
        private Label total_student_lbl;
        private Panel faculty_panel;
        private Label label1;
        private Label faculty_text_value;
        private Bunifu.Framework.UI.BunifuElipse panel1_rad;
        private Bunifu.Framework.UI.BunifuElipse panel2_rad;
        private Bunifu.Framework.UI.BunifuElipse panel3_rad;
    }
}