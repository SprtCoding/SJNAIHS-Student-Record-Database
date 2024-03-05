namespace Student_Record.Loaders
{
    partial class FRM_Wait
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Wait));
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(670, 457);
            label1.TabIndex = 0;
            // 
            // FRM_Wait
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 487);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FRM_Wait";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRM_Wait";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
    }
}