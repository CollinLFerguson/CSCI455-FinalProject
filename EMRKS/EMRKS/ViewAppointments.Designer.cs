namespace EMRKS
{
    partial class ViewAppointments
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
            button1 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dtpDOB = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 24F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label19.Location = new Point(12, 9);
            label19.Name = "label19";
            label19.Size = new Size(300, 45);
            label19.TabIndex = 5;
            label19.Text = "View Appointments";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(427, 81);
            button1.Name = "button1";
            button1.Size = new Size(206, 48);
            button1.TabIndex = 7;
            button1.Text = "Populate Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnPopData_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(108, 81);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 11;
            label1.Text = "Date";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Location = new Point(108, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridView1.Size = new Size(866, 389);
            dataGridView1.TabIndex = 12;
            // 
            // dtpDOB
            // 
            dtpDOB.CustomFormat = "yyyy-MM-dd";
            dtpDOB.Format = DateTimePickerFormat.Custom;
            dtpDOB.Location = new Point(108, 106);
            dtpDOB.MaxDate = new DateTime(2024, 4, 11, 0, 0, 0, 0);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(216, 23);
            dtpDOB.TabIndex = 16;
            dtpDOB.Value = new DateTime(2024, 4, 11, 0, 0, 0, 0);
            // 
            // ViewAppointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1078, 720);
            Controls.Add(dtpDOB);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label19);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(210, 0);
            Name = "ViewAppointments";
            StartPosition = FormStartPosition.Manual;
            Text = "ViewAppointments";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label19;
        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private DateTimePicker dtpDOB;
    }
}