﻿namespace EMRKS
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
            panel1 = new Panel();
            button6 = new Button();
            viewMedButton = new Button();
            viewPatientButton = new Button();
            btnAddMedication = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(viewMedButton);
            panel1.Controls.Add(viewPatientButton);
            panel1.Controls.Add(btnAddMedication);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 720);
            panel1.TabIndex = 0;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button6.Location = new Point(1, 641);
            button6.Name = "button6";
            button6.Size = new Size(200, 55);
            button6.TabIndex = 8;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // viewMedButton
            // 
            viewMedButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            viewMedButton.Location = new Point(0, 378);
            viewMedButton.Name = "viewMedButton";
            viewMedButton.Size = new Size(200, 55);
            viewMedButton.TabIndex = 7;
            viewMedButton.Text = "View Medications";
            viewMedButton.UseVisualStyleBackColor = true;
            viewMedButton.Click += viewMedButton_Click;
            // 
            // viewPatientButton
            // 
            viewPatientButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            viewPatientButton.Location = new Point(0, 324);
            viewPatientButton.Name = "viewPatientButton";
            viewPatientButton.Size = new Size(200, 55);
            viewPatientButton.TabIndex = 6;
            viewPatientButton.Text = "View Patients";
            viewPatientButton.UseVisualStyleBackColor = true;
            viewPatientButton.Click += viewPatientButton_Click;
            // 
            // btnAddMedication
            // 
            btnAddMedication.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddMedication.Location = new Point(0, 162);
            btnAddMedication.Name = "btnAddMedication";
            btnAddMedication.Size = new Size(200, 55);
            btnAddMedication.TabIndex = 5;
            btnAddMedication.Text = "Add Medication";
            btnAddMedication.UseVisualStyleBackColor = true;
            btnAddMedication.Click += btnAddMedication_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.Location = new Point(0, 270);
            button5.Name = "button5";
            button5.Size = new Size(200, 55);
            button5.TabIndex = 4;
            button5.Text = "View Appointments";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button6_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.Location = new Point(0, 216);
            button4.Name = "button4";
            button4.Size = new Size(200, 55);
            button4.TabIndex = 3;
            button4.Text = "Unprocessed Reports";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button5_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.Location = new Point(0, 108);
            button3.Name = "button3";
            button3.Size = new Size(200, 55);
            button3.TabIndex = 2;
            button3.Text = "Add Staff";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(0, 54);
            button2.Name = "button2";
            button2.Size = new Size(200, 55);
            button2.TabIndex = 1;
            button2.Text = "Add Patient";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(200, 55);
            button1.TabIndex = 0;
            button1.Text = "Find Patient";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button4_Click;
            // 
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(205, 720);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LandingPage";
            StartPosition = FormStartPosition.Manual;
            Text = "LandingPage";
            TopMost = true;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button btnAddMedication;
        private Button button8;
        private Button viewMedButton;
        private Button viewPatientButton;
        private Button button6;
    }
}