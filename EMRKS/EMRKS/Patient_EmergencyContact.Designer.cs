namespace EMRKS
{
    partial class Patient_EmergencyContact
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
            button1 = new Button();
            txtContactName = new TextBox();
            label1 = new Label();
            txtContactPhone = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtContactRelationship = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(183, 99);
            button1.Name = "button1";
            button1.Size = new Size(116, 23);
            button1.TabIndex = 5;
            button1.Text = "Remove Contact";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(93, 12);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(206, 23);
            txtContactName.TabIndex = 4;
            txtContactName.TextChanged += onTextChangedName;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 3;
            label1.Text = "Contact Name";
            // 
            // txtContactPhone
            // 
            txtContactPhone.Location = new Point(105, 41);
            txtContactPhone.Name = "txtContactPhone";
            txtContactPhone.Size = new Size(194, 23);
            txtContactPhone.TabIndex = 6;
            txtContactPhone.TextChanged += onPhoneModified;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 44);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 7;
            label2.Text = "Contact Phone #";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 73);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 8;
            label3.Text = "Contact Relationship";
            // 
            // txtContactRelationship
            // 
            txtContactRelationship.Location = new Point(126, 70);
            txtContactRelationship.Name = "txtContactRelationship";
            txtContactRelationship.Size = new Size(173, 23);
            txtContactRelationship.TabIndex = 9;
            txtContactRelationship.TextChanged += onRelationModified;
            // 
            // Patient_EmergencyContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtContactRelationship);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtContactPhone);
            Controls.Add(button1);
            Controls.Add(txtContactName);
            Controls.Add(label1);
            Name = "Patient_EmergencyContact";
            Size = new Size(302, 132);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtContactName;
        private Label label1;
        private TextBox txtContactPhone;
        private Label label2;
        private Label label3;
        private TextBox txtContactRelationship;
    }
}
