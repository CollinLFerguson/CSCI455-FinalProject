namespace EMRKS
{
    partial class AddPatient
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
            groupBox1 = new GroupBox();
            txtZip = new TextBox();
            comboState = new ComboBox();
            txtCity = new TextBox();
            txtAddress = new TextBox();
            txtMInit = new TextBox();
            txtFName = new TextBox();
            txtLName = new TextBox();
            dtpDOB = new DateTimePicker();
            comboSex = new ComboBox();
            txtPhoneNumber = new TextBox();
            lblSSN = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtZip);
            groupBox1.Controls.Add(comboState);
            groupBox1.Controls.Add(txtCity);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtMInit);
            groupBox1.Controls.Add(txtFName);
            groupBox1.Controls.Add(txtLName);
            groupBox1.Controls.Add(dtpDOB);
            groupBox1.Controls.Add(comboSex);
            groupBox1.Controls.Add(txtPhoneNumber);
            groupBox1.Controls.Add(lblSSN);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(917, 208);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Patient Info";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtZip
            // 
            txtZip.Location = new Point(794, 114);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(110, 23);
            txtZip.TabIndex = 22;
            // 
            // comboState
            // 
            comboState.DropDownStyle = ComboBoxStyle.DropDownList;
            comboState.FormattingEnabled = true;
            comboState.Items.AddRange(new object[] { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "DC", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" });
            comboState.Location = new Point(634, 115);
            comboState.Name = "comboState";
            comboState.Size = new Size(83, 23);
            comboState.TabIndex = 21;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(381, 117);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(203, 23);
            txtCity.TabIndex = 20;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(84, 119);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(255, 23);
            txtAddress.TabIndex = 18;
            // 
            // txtMInit
            // 
            txtMInit.Location = new Point(575, 71);
            txtMInit.Name = "txtMInit";
            txtMInit.Size = new Size(134, 23);
            txtMInit.TabIndex = 17;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(339, 71);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(145, 23);
            txtFName.TabIndex = 16;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(84, 71);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(153, 23);
            txtLName.TabIndex = 15;
            // 
            // dtpDOB
            // 
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(794, 33);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(86, 23);
            dtpDOB.TabIndex = 19;
            // 
            // comboSex
            // 
            comboSex.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSex.FormattingEnabled = true;
            comboSex.Items.AddRange(new object[] { "Male", "Female" });
            comboSex.Location = new Point(575, 33);
            comboSex.Name = "comboSex";
            comboSex.Size = new Size(134, 23);
            comboSex.TabIndex = 14;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(339, 33);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(145, 23);
            txtPhoneNumber.TabIndex = 13;
            // 
            // lblSSN
            // 
            lblSSN.Location = new Point(84, 33);
            lblSSN.Name = "lblSSN";
            lblSSN.Size = new Size(153, 23);
            lblSSN.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(733, 122);
            label11.Name = "label11";
            label11.Size = new Size(55, 15);
            label11.TabIndex = 11;
            label11.Text = "Zip Code";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(595, 125);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 10;
            label10.Text = "State";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(347, 125);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 9;
            label9.Text = "City";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 129);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 8;
            label8.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(544, 41);
            label7.Name = "label7";
            label7.Size = new Size(25, 15);
            label7.TabIndex = 6;
            label7.Text = "Sex";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(493, 79);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 5;
            label6.Text = "Middle Initial";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(245, 41);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 4;
            label5.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(715, 41);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 3;
            label4.Text = "Date of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 79);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 79);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 41);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "SSN";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new Point(12, 226);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(513, 197);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Payment Info";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(381, 37);
            label14.Name = "label14";
            label14.Size = new Size(60, 15);
            label14.TabIndex = 24;
            label14.Text = "Expiration";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(234, 37);
            label13.Name = "label13";
            label13.Size = new Size(30, 15);
            label13.TabIndex = 23;
            label13.Text = "CCV";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 37);
            label12.Name = "label12";
            label12.Size = new Size(114, 15);
            label12.TabIndex = 23;
            label12.Text = "Credit Card Number";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(556, 226);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(420, 388);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Known Allergies (One per line)";
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(12, 429);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(513, 195);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Payment Info";
            // 
            // AddPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(1078, 720);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(202, 0);
            Name = "AddPatient";
            StartPosition = FormStartPosition.Manual;
            Text = "AddPatient";
            TopMost = true;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox lblSSN;
        private Label label11;
        private Label label10;
        private Label label9;
        private ComboBox comboSex;
        private TextBox txtPhoneNumber;
        private DateTimePicker dtpDOB;
        private TextBox txtFName;
        private TextBox txtLName;
        private ComboBox comboState;
        private TextBox txtCity;
        private TextBox txtAddress;
        private TextBox txtMInit;
        private TextBox txtZip;
        private GroupBox groupBox4;
        private Label label14;
        private Label label13;
        private Label label12;
    }
}