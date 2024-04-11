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
            comboBoxDoctor = new ComboBox();
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
            txtSSN = new TextBox();
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
            groupBoxPayment = new GroupBox();
            btnPatientAddPayment = new Button();
            groupBoxAllergies = new GroupBox();
            btnAddPatientAllergy = new Button();
            groupBoxInsurance = new GroupBox();
            btnAddInsurance = new Button();
            label19 = new Label();
            btnAddPatient = new Button();
            button5 = new Button();
            panelAllergies = new Panel();
            panelEMContact = new Panel();
            groupBoxEmContact = new GroupBox();
            btnAddEmContact = new Button();
            panelPayment = new Panel();
            panelInsurance = new Panel();
            groupBox1.SuspendLayout();
            groupBoxPayment.SuspendLayout();
            groupBoxAllergies.SuspendLayout();
            groupBoxInsurance.SuspendLayout();
            panelAllergies.SuspendLayout();
            panelEMContact.SuspendLayout();
            groupBoxEmContact.SuspendLayout();
            panelPayment.SuspendLayout();
            panelInsurance.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxDoctor);
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
            groupBox1.Controls.Add(txtSSN);
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
            groupBox1.Size = new Size(937, 208);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Patient Info";
            // 
            // comboBoxDoctor
            // 
            comboBoxDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDoctor.FormattingEnabled = true;
            comboBoxDoctor.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxDoctor.Location = new Point(103, 154);
            comboBoxDoctor.Name = "comboBoxDoctor";
            comboBoxDoctor.Size = new Size(134, 23);
            comboBoxDoctor.TabIndex = 24;
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
            dtpDOB.CustomFormat = "yyyy/MM/dd";
            dtpDOB.Format = DateTimePickerFormat.Custom;
            dtpDOB.Location = new Point(794, 33);
            dtpDOB.MaxDate = new DateTime(2024, 4, 11, 0, 0, 0, 0);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(85, 23);
            dtpDOB.TabIndex = 15;
            dtpDOB.Value = new DateTime(2024, 4, 11, 0, 0, 0, 0);
            // 
            // comboSex
            // 
            comboSex.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSex.FormattingEnabled = true;
            comboSex.Items.AddRange(new object[] { "M", "F" });
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
            // txtSSN
            // 
            txtSSN.Location = new Point(84, 33);
            txtSSN.Name = "txtSSN";
            txtSSN.Size = new Size(153, 23);
            txtSSN.TabIndex = 12;
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
            // groupBoxPayment
            // 
            groupBoxPayment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxPayment.AutoSize = true;
            groupBoxPayment.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxPayment.Controls.Add(btnPatientAddPayment);
            groupBoxPayment.Location = new Point(0, 0);
            groupBoxPayment.MinimumSize = new Size(607, 147);
            groupBoxPayment.Name = "groupBoxPayment";
            groupBoxPayment.Size = new Size(607, 147);
            groupBoxPayment.TabIndex = 1;
            groupBoxPayment.TabStop = false;
            groupBoxPayment.Text = "Payment Info";
            // 
            // btnPatientAddPayment
            // 
            btnPatientAddPayment.Location = new Point(6, 22);
            btnPatientAddPayment.Name = "btnPatientAddPayment";
            btnPatientAddPayment.Size = new Size(135, 23);
            btnPatientAddPayment.TabIndex = 26;
            btnPatientAddPayment.Text = "+ Add Payment";
            btnPatientAddPayment.UseVisualStyleBackColor = true;
            btnPatientAddPayment.Click += btnPatientAddPayment_Click;
            // 
            // groupBoxAllergies
            // 
            groupBoxAllergies.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxAllergies.AutoSize = true;
            groupBoxAllergies.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxAllergies.Controls.Add(btnAddPatientAllergy);
            groupBoxAllergies.Location = new Point(0, 0);
            groupBoxAllergies.MinimumSize = new Size(324, 147);
            groupBoxAllergies.Name = "groupBoxAllergies";
            groupBoxAllergies.Size = new Size(324, 147);
            groupBoxAllergies.TabIndex = 2;
            groupBoxAllergies.TabStop = false;
            groupBoxAllergies.Text = "Known Allergies";
            // 
            // btnAddPatientAllergy
            // 
            btnAddPatientAllergy.Location = new Point(6, 22);
            btnAddPatientAllergy.Name = "btnAddPatientAllergy";
            btnAddPatientAllergy.Size = new Size(135, 23);
            btnAddPatientAllergy.TabIndex = 28;
            btnAddPatientAllergy.Text = "+Add Allergy";
            btnAddPatientAllergy.UseVisualStyleBackColor = true;
            btnAddPatientAllergy.Click += btnAddPatientAllergy_Click;
            // 
            // groupBoxInsurance
            // 
            groupBoxInsurance.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxInsurance.AutoSize = true;
            groupBoxInsurance.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxInsurance.Controls.Add(btnAddInsurance);
            groupBoxInsurance.Location = new Point(0, 0);
            groupBoxInsurance.MinimumSize = new Size(609, 187);
            groupBoxInsurance.Name = "groupBoxInsurance";
            groupBoxInsurance.Size = new Size(609, 187);
            groupBoxInsurance.TabIndex = 2;
            groupBoxInsurance.TabStop = false;
            groupBoxInsurance.Text = "Insurance Info";
            // 
            // btnAddInsurance
            // 
            btnAddInsurance.Location = new Point(6, 22);
            btnAddInsurance.Name = "btnAddInsurance";
            btnAddInsurance.Size = new Size(135, 23);
            btnAddInsurance.TabIndex = 27;
            btnAddInsurance.Text = "+ Add Insurance";
            btnAddInsurance.UseVisualStyleBackColor = true;
            btnAddInsurance.Click += btnAddInsurance_Click;
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
            // btnAddPatient
            // 
            btnAddPatient.Location = new Point(10, 618);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(135, 23);
            btnAddPatient.TabIndex = 32;
            btnAddPatient.Text = "Add Patient";
            btnAddPatient.UseVisualStyleBackColor = true;
            btnAddPatient.Click += btnAddPatient_Click;
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
            // panelAllergies
            // 
            panelAllergies.AutoScroll = true;
            panelAllergies.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelAllergies.Controls.Add(groupBoxAllergies);
            panelAllergies.Location = new Point(625, 272);
            panelAllergies.Name = "panelAllergies";
            panelAllergies.Size = new Size(324, 150);
            panelAllergies.TabIndex = 34;
            // 
            // panelEMContact
            // 
            panelEMContact.AutoScroll = true;
            panelEMContact.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelEMContact.Controls.Add(groupBoxEmContact);
            panelEMContact.Location = new Point(625, 425);
            panelEMContact.Name = "panelEMContact";
            panelEMContact.Size = new Size(324, 190);
            panelEMContact.TabIndex = 35;
            // 
            // groupBoxEmContact
            // 
            groupBoxEmContact.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxEmContact.AutoSize = true;
            groupBoxEmContact.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxEmContact.Controls.Add(btnAddEmContact);
            groupBoxEmContact.Location = new Point(0, 0);
            groupBoxEmContact.MinimumSize = new Size(324, 187);
            groupBoxEmContact.Name = "groupBoxEmContact";
            groupBoxEmContact.Size = new Size(324, 187);
            groupBoxEmContact.TabIndex = 2;
            groupBoxEmContact.TabStop = false;
            groupBoxEmContact.Text = "Emergency Contacts";
            // 
            // btnAddEmContact
            // 
            btnAddEmContact.Location = new Point(6, 22);
            btnAddEmContact.Name = "btnAddEmContact";
            btnAddEmContact.Size = new Size(162, 23);
            btnAddEmContact.TabIndex = 29;
            btnAddEmContact.Text = "+Add Emergency Contact";
            btnAddEmContact.UseVisualStyleBackColor = true;
            btnAddEmContact.Click += btnAddEmContact_Click;
            // 
            // panelPayment
            // 
            panelPayment.AutoScroll = true;
            panelPayment.Controls.Add(groupBoxPayment);
            panelPayment.Location = new Point(12, 272);
            panelPayment.Name = "panelPayment";
            panelPayment.Size = new Size(607, 147);
            panelPayment.TabIndex = 36;
            // 
            // panelInsurance
            // 
            panelInsurance.AutoScroll = true;
            panelInsurance.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelInsurance.Controls.Add(groupBoxInsurance);
            panelInsurance.Location = new Point(10, 425);
            panelInsurance.MinimumSize = new Size(609, 190);
            panelInsurance.Name = "panelInsurance";
            panelInsurance.Size = new Size(609, 190);
            panelInsurance.TabIndex = 37;
            // 
            // AddPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1078, 720);
            Controls.Add(panelInsurance);
            Controls.Add(panelPayment);
            Controls.Add(panelEMContact);
            Controls.Add(panelAllergies);
            Controls.Add(button5);
            Controls.Add(btnAddPatient);
            Controls.Add(label19);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(202, 0);
            Name = "AddPatient";
            StartPosition = FormStartPosition.Manual;
            Text = " ";
            TopMost = true;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxPayment.ResumeLayout(false);
            groupBoxAllergies.ResumeLayout(false);
            groupBoxInsurance.ResumeLayout(false);
            panelAllergies.ResumeLayout(false);
            panelAllergies.PerformLayout();
            panelEMContact.ResumeLayout(false);
            panelEMContact.PerformLayout();
            groupBoxEmContact.ResumeLayout(false);
            panelPayment.ResumeLayout(false);
            panelPayment.PerformLayout();
            panelInsurance.ResumeLayout(false);
            panelInsurance.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBoxPayment;
        private GroupBox groupBoxAllergies;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtSSN;
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
        private GroupBox groupBoxInsurance;
        private Button btnPatientAddPayment;
        private Button btnAddPatientAllergy;
        private Button btnAddInsurance;
        private Label label19;
        private Button btnAddPatient;
        private Button button5;
        private ComboBox comboBoxDoctor;
        private Label label20;
        private Panel panelAllergies;
        private Panel panelEMContact;
        private GroupBox groupBoxEmContact;
        private Button btnAddEmContact;
        private Panel panelPayment;
        private Panel panelInsurance;
    }
}