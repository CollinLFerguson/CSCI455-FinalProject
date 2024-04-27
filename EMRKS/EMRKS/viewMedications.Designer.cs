namespace EMRKS
{
    partial class viewMedications
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
            label19 = new Label();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 24F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label19.Location = new Point(12, 9);
            label19.Name = "label19";
            label19.Size = new Size(317, 45);
            label19.TabIndex = 6;
            label19.Text = "View All Medications";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1006, 608);
            dataGridView1.TabIndex = 7;
            // 
            // button5
            // 
            button5.Location = new Point(36, 685);
            button5.Name = "button5";
            button5.Size = new Size(135, 23);
            button5.TabIndex = 30;
            button5.Text = "Return";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // viewMedications
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(106, 167, 119);
            ClientSize = new Size(1078, 720);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(label19);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(202, 0);
            Name = "viewMedications";
            StartPosition = FormStartPosition.Manual;
            Text = "viewMedications";
            Load += viewMedications_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label19;
        private DataGridView dataGridView1;
        private Button button5;
    }
}