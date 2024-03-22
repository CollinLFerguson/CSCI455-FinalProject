namespace EMRKS
{
    partial class LandingPage
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
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 45F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label1.Location = new Point(251, 286);
            label1.Name = "label1";
            label1.Size = new Size(756, 81);
            label1.TabIndex = 1;
            label1.Text = "I AM THE LANDING PAGE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(1280, 720);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LandingPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LandingPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}