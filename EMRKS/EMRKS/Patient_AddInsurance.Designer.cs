namespace EMRKS
{
    partial class Patient_AddInsurance
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
            txtNameOnInsurance = new TextBox();
            txtGroupNumber = new TextBox();
            label18 = new Label();
            txtPolicyNumber = new TextBox();
            label17 = new Label();
            label16 = new Label();
            txtProvider = new TextBox();
            label15 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(417, 69);
            button1.Name = "button1";
            button1.Size = new Size(116, 23);
            button1.TabIndex = 49;
            button1.Text = "Remove Insurance";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNameOnInsurance
            // 
            txtNameOnInsurance.Location = new Point(368, 40);
            txtNameOnInsurance.Name = "txtNameOnInsurance";
            txtNameOnInsurance.Size = new Size(165, 23);
            txtNameOnInsurance.TabIndex = 48;
            // 
            // txtGroupNumber
            // 
            txtGroupNumber.Location = new Point(90, 40);
            txtGroupNumber.Name = "txtGroupNumber";
            txtGroupNumber.Size = new Size(138, 23);
            txtGroupNumber.TabIndex = 47;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(252, 48);
            label18.Name = "label18";
            label18.Size = new Size(110, 15);
            label18.TabIndex = 46;
            label18.Text = "Name on insurance";
            // 
            // txtPolicyNumber
            // 
            txtPolicyNumber.Location = new Point(380, 8);
            txtPolicyNumber.Name = "txtPolicyNumber";
            txtPolicyNumber.Size = new Size(153, 23);
            txtPolicyNumber.TabIndex = 45;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(3, 48);
            label17.Name = "label17";
            label17.Size = new Size(87, 15);
            label17.TabIndex = 41;
            label17.Text = "Group Number";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(288, 16);
            label16.Name = "label16";
            label16.Size = new Size(86, 15);
            label16.TabIndex = 42;
            label16.Text = "Policy Number";
            // 
            // txtProvider
            // 
            txtProvider.Location = new Point(114, 8);
            txtProvider.Name = "txtProvider";
            txtProvider.Size = new Size(155, 23);
            txtProvider.TabIndex = 43;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 17);
            label15.Name = "label15";
            label15.Size = new Size(105, 15);
            label15.TabIndex = 44;
            label15.Text = "Insurance Provider";
            // 
            // Patient_AddInsurance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(txtNameOnInsurance);
            Controls.Add(txtGroupNumber);
            Controls.Add(label18);
            Controls.Add(txtPolicyNumber);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(txtProvider);
            Controls.Add(label15);
            Name = "Patient_AddInsurance";
            Size = new Size(536, 97);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtNameOnInsurance;
        private TextBox txtGroupNumber;
        private Label label18;
        private TextBox txtPolicyNumber;
        private Label label17;
        private Label label16;
        private TextBox txtProvider;
        private Label label15;
    }
}
