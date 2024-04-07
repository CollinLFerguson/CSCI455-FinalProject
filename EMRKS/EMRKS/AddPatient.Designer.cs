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
            comboBox1 = new ComboBox();
            label20 = new Label();
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
            btnPatientAddPayment = new Button();
            groupBox3 = new GroupBox();
            btnAddPatientAllergy = new Button();
            groupBox4 = new GroupBox();
            btnAddInsurance = new Button();
            label19 = new Label();
            button4 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox6 = new GroupBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label20);
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
            groupBox1.Location = new Point(12, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(917, 208);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Patient Info";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(103, 154);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 23);
            comboBox1.TabIndex = 24;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(15, 162);
            label20.Name = "label20";
            label20.Size = new Size(87, 15);
            label20.TabIndex = 23;
            label20.Text = "Primary Doctor";
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
            txtAddress.TabIndex = 19;
            // 
            // txtMInit
            // 
            txtMInit.Location = new Point(575, 71);
            txtMInit.Name = "txtMInit";
            txtMInit.Size = new Size(134, 23);
            txtMInit.TabIndex = 18;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(339, 71);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(145, 23);
            txtFName.TabIndex = 17;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(84, 71);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(153, 23);
            txtLName.TabIndex = 16;
            // 
            // dtpDOB
            // 
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(794, 33);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(86, 23);
            dtpDOB.TabIndex = 15;
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
            groupBox2.Controls.Add(btnPatientAddPayment);
            groupBox2.Location = new Point(12, 272);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(607, 147);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Payment Info";
            // 
            // btnPatientAddPayment
            // 
            btnPatientAddPayment.Location = new Point(6, 22);
            btnPatientAddPayment.Name = "btnPatientAddPayment";
            btnPatientAddPayment.Size = new Size(135, 23);
            btnPatientAddPayment.TabIndex = 26;
            btnPatientAddPayment.Text = "+ Add Payment";
            btnPatientAddPayment.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.AutoSize = true;
            groupBox3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox3.Controls.Add(btnAddPatientAllergy);
            groupBox3.Location = new Point(0, 0);
            groupBox3.MinimumSize = new Size(304, 147);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(304, 147);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Known Allergies";
            // 
            // btnAddPatientAllergy
            // 
            btnAddPatientAllergy.Location = new Point(6, 22);
            btnAddPatientAllergy.Name = "btnAddPatientAllergy";
            btnAddPatientAllergy.Size = new Size(135, 23);
            btnAddPatientAllergy.TabIndex = 28;
            btnAddPatientAllergy.Text = "+Add Allergy";
            btnAddPatientAllergy.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnAddInsurance);
            groupBox4.Location = new Point(12, 425);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(607, 187);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Insurance Info";
            // 
            // btnAddInsurance
            // 
            btnAddInsurance.Location = new Point(6, 22);
            btnAddInsurance.Name = "btnAddInsurance";
            btnAddInsurance.Size = new Size(135, 23);
            btnAddInsurance.TabIndex = 27;
            btnAddInsurance.Text = "+ Add Insurance";
            btnAddInsurance.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 24F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label19.Location = new Point(10, 10);
            label19.Name = "label19";
            label19.Size = new Size(186, 45);
            label19.TabIndex = 3;
            label19.Text = "Add Patient";
            // 
            // button4
            // 
            button4.Location = new Point(10, 618);
            button4.Name = "button4";
            button4.Size = new Size(135, 23);
            button4.TabIndex = 32;
            button4.Text = "Add Patient";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(794, 618);
            button5.Name = "button5";
            button5.Size = new Size(135, 23);
            button5.TabIndex = 33;
            button5.Text = "Cancel Add Patient";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(groupBox3);
            panel1.Location = new Point(625, 272);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 147);
            panel1.TabIndex = 34;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(groupBox6);
            panel2.Location = new Point(625, 425);
            panel2.Name = "panel2";
            panel2.Size = new Size(304, 187);
            panel2.TabIndex = 35;
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox6.AutoSize = true;
            groupBox6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox6.Controls.Add(button1);
            groupBox6.Location = new Point(0, 0);
            groupBox6.MinimumSize = new Size(304, 187);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(304, 187);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Emergency Contacts";
            // 
            // button1
            // 
            button1.Location = new Point(6, 22);
            button1.Name = "button1";
            button1.Size = new Size(162, 23);
            button1.TabIndex = 29;
            button1.Text = "+Add Emergency Contact";
            button1.UseVisualStyleBackColor = true;
            // 
            // AddPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1078, 720);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label19);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(202, 0);
            Name = "AddPatient";
            StartPosition = FormStartPosition.Manual;
            Text = " ";
            TopMost = true;
            Load += AddPatient_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnPatientAddPayment;
        private Button btnAddPatientAllergy;
        private Button btnAddInsurance;
        private Label label19;
        private Button button4;
        private Button button5;
        private ComboBox comboBox1;
        private Label label20;
        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox6;
        private Button button1;
    }
}