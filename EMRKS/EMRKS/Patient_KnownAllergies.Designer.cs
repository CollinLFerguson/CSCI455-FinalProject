﻿namespace EMRKS
{
    partial class Patient_KnownAllergies
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtAllergy = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Allergy";
            // 
            // txtAllergy
            // 
            txtAllergy.Location = new Point(47, 13);
            txtAllergy.Name = "txtAllergy";
            txtAllergy.Size = new Size(227, 23);
            txtAllergy.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(158, 42);
            button1.Name = "button1";
            button1.Size = new Size(116, 23);
            button1.TabIndex = 2;
            button1.Text = "Remove Allergy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Patient_KnownAllergies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(txtAllergy);
            Controls.Add(label1);
            Name = "Patient_KnownAllergies";
            Size = new Size(277, 77);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAllergy;
        private Button button1;
    }
}
