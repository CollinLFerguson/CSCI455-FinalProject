namespace EMRKS
{
    partial class NoForm
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 100F);
            label1.Location = new Point(285, 252);
            label1.Name = "label1";
            label1.Size = new Size(492, 177);
            label1.TabIndex = 7;
            label1.Text = "EMRKS";
            // 
            // NoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 681);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(202, 0);
            Name = "NoForm";
            StartPosition = FormStartPosition.Manual;
            Text = "NoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}