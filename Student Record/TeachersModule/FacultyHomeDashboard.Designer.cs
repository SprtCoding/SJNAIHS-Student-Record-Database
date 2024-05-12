namespace Student_Record.TeachersModule
{
    partial class FacultyHomeDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            enrolled_panel = new Panel();
            label6 = new Label();
            enrolled_total_lbl = new Label();
            grade12_panel = new Panel();
            label4 = new Label();
            grade12_total_lbl = new Label();
            grade11_panel = new Panel();
            label1 = new Label();
            grade11_total_lbl = new Label();
            grade11_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            grade12_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            enrolled_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            grade_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tableLayoutPanel1.SuspendLayout();
            enrolled_panel.SuspendLayout();
            grade12_panel.SuspendLayout();
            grade11_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grade_chart).BeginInit();
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
            label2.TabIndex = 6;
            label2.Text = "Dashboard";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(enrolled_panel, 2, 0);
            tableLayoutPanel1.Controls.Add(grade12_panel, 1, 0);
            tableLayoutPanel1.Controls.Add(grade11_panel, 0, 0);
            tableLayoutPanel1.Location = new Point(8, 43);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(773, 238);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // enrolled_panel
            // 
            enrolled_panel.BackColor = Color.FromArgb(129, 142, 254);
            enrolled_panel.Controls.Add(label6);
            enrolled_panel.Controls.Add(enrolled_total_lbl);
            enrolled_panel.Dock = DockStyle.Fill;
            enrolled_panel.Location = new Point(521, 6);
            enrolled_panel.Margin = new Padding(7, 6, 7, 6);
            enrolled_panel.Name = "enrolled_panel";
            enrolled_panel.Size = new Size(245, 226);
            enrolled_panel.TabIndex = 2;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(5, 5);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(235, 38);
            label6.TabIndex = 0;
            label6.Text = "Total Number of Enrolled Students";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // enrolled_total_lbl
            // 
            enrolled_total_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            enrolled_total_lbl.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            enrolled_total_lbl.ForeColor = Color.WhiteSmoke;
            enrolled_total_lbl.Location = new Point(8, 44);
            enrolled_total_lbl.Margin = new Padding(2, 0, 2, 0);
            enrolled_total_lbl.Name = "enrolled_total_lbl";
            enrolled_total_lbl.Size = new Size(228, 134);
            enrolled_total_lbl.TabIndex = 1;
            enrolled_total_lbl.Text = "0";
            enrolled_total_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grade12_panel
            // 
            grade12_panel.BackColor = Color.FromArgb(76, 162, 205);
            grade12_panel.Controls.Add(label4);
            grade12_panel.Controls.Add(grade12_total_lbl);
            grade12_panel.Dock = DockStyle.Fill;
            grade12_panel.Location = new Point(264, 6);
            grade12_panel.Margin = new Padding(7, 6, 7, 6);
            grade12_panel.Name = "grade12_panel";
            grade12_panel.Size = new Size(243, 226);
            grade12_panel.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(5, 5);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(233, 38);
            label4.TabIndex = 0;
            label4.Text = "Total Number of Grade 12 Students";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grade12_total_lbl
            // 
            grade12_total_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grade12_total_lbl.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            grade12_total_lbl.ForeColor = Color.WhiteSmoke;
            grade12_total_lbl.Location = new Point(8, 44);
            grade12_total_lbl.Margin = new Padding(2, 0, 2, 0);
            grade12_total_lbl.Name = "grade12_total_lbl";
            grade12_total_lbl.Size = new Size(226, 134);
            grade12_total_lbl.TabIndex = 1;
            grade12_total_lbl.Text = "0";
            grade12_total_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grade11_panel
            // 
            grade11_panel.BackColor = Color.FromArgb(43, 47, 84);
            grade11_panel.Controls.Add(label1);
            grade11_panel.Controls.Add(grade11_total_lbl);
            grade11_panel.Dock = DockStyle.Fill;
            grade11_panel.Location = new Point(7, 6);
            grade11_panel.Margin = new Padding(7, 6, 7, 6);
            grade11_panel.Name = "grade11_panel";
            grade11_panel.Size = new Size(243, 226);
            grade11_panel.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(5, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(233, 38);
            label1.TabIndex = 0;
            label1.Text = "Total Number of Grade 11 Students";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grade11_total_lbl
            // 
            grade11_total_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grade11_total_lbl.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            grade11_total_lbl.ForeColor = Color.WhiteSmoke;
            grade11_total_lbl.Location = new Point(8, 44);
            grade11_total_lbl.Margin = new Padding(2, 0, 2, 0);
            grade11_total_lbl.Name = "grade11_total_lbl";
            grade11_total_lbl.Size = new Size(226, 134);
            grade11_total_lbl.TabIndex = 1;
            grade11_total_lbl.Text = "0";
            grade11_total_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grade11_rad
            // 
            grade11_rad.ElipseRadius = 5;
            grade11_rad.TargetControl = grade11_panel;
            // 
            // grade12_rad
            // 
            grade12_rad.ElipseRadius = 5;
            grade12_rad.TargetControl = grade12_panel;
            // 
            // enrolled_rad
            // 
            enrolled_rad.ElipseRadius = 5;
            enrolled_rad.TargetControl = enrolled_panel;
            // 
            // grade_chart
            // 
            grade_chart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grade_chart.BorderlineColor = Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            grade_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            grade_chart.Legends.Add(legend1);
            grade_chart.Location = new Point(15, 285);
            grade_chart.Margin = new Padding(2);
            grade_chart.Name = "grade_chart";
            grade_chart.Size = new Size(759, 165);
            grade_chart.TabIndex = 8;
            grade_chart.Text = "chart1";
            // 
            // FacultyHomeDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(790, 461);
            Controls.Add(grade_chart);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FacultyHomeDashboard";
            Text = "FacultyHomeDashboard";
            Load += FacultyHomeDashboard_Load;
            tableLayoutPanel1.ResumeLayout(false);
            enrolled_panel.ResumeLayout(false);
            grade12_panel.ResumeLayout(false);
            grade11_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grade_chart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel enrolled_panel;
        private Label label6;
        private Label enrolled_total_lbl;
        private Panel grade12_panel;
        private Label label4;
        private Label grade12_total_lbl;
        private Panel grade11_panel;
        private Label label1;
        private Label grade11_total_lbl;
        private Bunifu.Framework.UI.BunifuElipse grade11_rad;
        private Bunifu.Framework.UI.BunifuElipse grade12_rad;
        private Bunifu.Framework.UI.BunifuElipse enrolled_rad;
        private System.Windows.Forms.DataVisualization.Charting.Chart grade_chart;
    }
}