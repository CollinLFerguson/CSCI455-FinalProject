namespace EMRKS
{
    partial class AddStaff
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
            dtpHireDate = new DateTimePicker();
            txtAddressLn2 = new TextBox();
            comboStaffType = new ComboBox();
            label8 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            txtDocYearsPracticing = new TextBox();
            label13 = new Label();
            txtDocSpeciality = new TextBox();
            label12 = new Label();
            txtZip = new TextBox();
            label7 = new Label();
            comboState = new ComboBox();
            txtMInit = new TextBox();
            txtCity = new TextBox();
            txtFName = new TextBox();
            txtAddressLn1 = new TextBox();
            label11 = new Label();
            txtLName = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txtPin = new TextBox();
            label14 = new Label();
            txtSSN = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label19 = new Label();
            button5 = new Button();
            btnAddStaff = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpHireDate);
            groupBox1.Controls.Add(txtAddressLn2);
            groupBox1.Controls.Add(comboStaffType);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(txtZip);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comboState);
            groupBox1.Controls.Add(txtMInit);
            groupBox1.Controls.Add(txtCity);
            groupBox1.Controls.Add(txtFName);
            groupBox1.Controls.Add(txtAddressLn1);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtLName);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtPin);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txtSSN);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(723, 254);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Staff Info";
            // 
            // dtpHireDate
            // 
            dtpHireDate.CustomFormat = "yyyy/MM/dd";
            dtpHireDate.Format = DateTimePickerFormat.Custom;
            dtpHireDate.Location = new Point(379, 22);
            dtpHireDate.MaxDate = new DateTime(2024, 4, 11, 0, 0, 0, 0);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(85, 23);
            dtpHireDate.TabIndex = 14;
            dtpHireDate.Value = new DateTime(2024, 4, 11, 0, 0, 0, 0);
            // 
            // txtAddressLn2
            // 
            txtAddressLn2.Location = new Point(416, 95);
            txtAddressLn2.Name = "txtAddressLn2";
            txtAddressLn2.Size = new Size(221, 23);
            txtAddressLn2.TabIndex = 21;
            // 
            // comboStaffType
            // 
            comboStaffType.FormattingEnabled = true;
            comboStaffType.Items.AddRange(new object[] { "Administration", "Doctor", "Nurse" });
            comboStaffType.Location = new Point(550, 22);
            comboStaffType.Name = "comboStaffType";
            comboStaffType.Size = new Size(121, 23);
            comboStaffType.TabIndex = 16;
            comboStaffType.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(327, 103);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 44;
            label8.Text = "Address Line 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 30);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Hire Date";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDocYearsPracticing);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(txtDocSpeciality);
            groupBox2.Controls.Add(label12);
            groupBox2.Enabled = false;
            groupBox2.Location = new Point(6, 183);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(490, 65);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Doctor Specific Information";
            // 
            // txtDocYearsPracticing
            // 
            txtDocYearsPracticing.Location = new Point(331, 21);
            txtDocYearsPracticing.Name = "txtDocYearsPracticing";
            txtDocYearsPracticing.Size = new Size(153, 23);
            txtDocYearsPracticing.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(237, 29);
            label13.Name = "label13";
            label13.Size = new Size(90, 15);
            label13.TabIndex = 27;
            label13.Text = "Years Practicing";
            // 
            // txtDocSpeciality
            // 
            txtDocSpeciality.Location = new Point(70, 21);
            txtDocSpeciality.Name = "txtDocSpeciality";
            txtDocSpeciality.Size = new Size(153, 23);
            txtDocSpeciality.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 29);
            label12.Name = "label12";
            label12.Size = new Size(57, 15);
            label12.TabIndex = 29;
            label12.Text = "Speciality";
            // 
            // txtZip
            // 
            txtZip.Location = new Point(475, 127);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(122, 23);
            txtZip.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(486, 30);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 23;
            label7.Text = "Staff Type";
            // 
            // comboState
            // 
            comboState.DropDownStyle = ComboBoxStyle.DropDownList;
            comboState.FormattingEnabled = true;
            comboState.Items.AddRange(new object[] { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "DC", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" });
            comboState.Location = new Point(320, 128);
            comboState.Name = "comboState";
            comboState.Size = new Size(83, 23);
            comboState.TabIndex = 23;
            // 
            // txtMInit
            // 
            txtMInit.Location = new Point(575, 58);
            txtMInit.Name = "txtMInit";
            txtMInit.Size = new Size(134, 23);
            txtMInit.TabIndex = 19;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(66, 128);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(203, 23);
            txtCity.TabIndex = 22;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(339, 58);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(145, 23);
            txtFName.TabIndex = 18;
            // 
            // txtAddressLn1
            // 
            txtAddressLn1.Location = new Point(105, 95);
            txtAddressLn1.Name = "txtAddressLn1";
            txtAddressLn1.Size = new Size(216, 23);
            txtAddressLn1.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(414, 135);
            label11.Name = "label11";
            label11.Size = new Size(55, 15);
            label11.TabIndex = 39;
            label11.Text = "Zip Code";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(84, 58);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(153, 23);
            txtLName.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(281, 135);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 38;
            label10.Text = "State";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 136);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 37;
            label9.Text = "City";
            // 
            // txtPin
            // 
            txtPin.Location = new Point(235, 22);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(79, 23);
            txtPin.TabIndex = 13;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(16, 103);
            label14.Name = "label14";
            label14.Size = new Size(83, 15);
            label14.TabIndex = 36;
            label14.Text = "Address Line 1";
            // 
            // txtSSN
            // 
            txtSSN.Location = new Point(46, 22);
            txtSSN.Name = "txtSSN";
            txtSSN.Size = new Size(153, 23);
            txtSSN.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(493, 66);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 5;
            label6.Text = "Middle Initial";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(205, 30);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 4;
            label5.Text = "Pin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 66);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 66);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "SSN";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 24F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label19.Location = new Point(10, 10);
            label19.Name = "label19";
            label19.Size = new Size(151, 45);
            label19.TabIndex = 4;
            label19.Text = "Add Staff";
            // 
            // button5
            // 
            button5.Location = new Point(600, 318);
            button5.Name = "button5";
            button5.Size = new Size(135, 23);
            button5.TabIndex = 29;
            button5.Text = "Cancel Add Staff";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnAddStaff
            // 
            btnAddStaff.Location = new Point(10, 318);
            btnAddStaff.Name = "btnAddStaff";
            btnAddStaff.Size = new Size(135, 23);
            btnAddStaff.TabIndex = 28;
            btnAddStaff.Text = "Add Staff";
            btnAddStaff.UseVisualStyleBackColor = true;
            btnAddStaff.Click += btnAddStaff_Click;
            // 
            // AddStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1078, 720);
            Controls.Add(button5);
            Controls.Add(btnAddStaff);
            Controls.Add(label19);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(202, 0);
            Name = "AddStaff";
            StartPosition = FormStartPosition.Manual;
            Text = "AddStaff";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMInit;
        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox txtPin;
        private TextBox txtSSN;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private ComboBox comboStaffType;
        private GroupBox groupBox2;
        private Label label19;
        private TextBox txtDocYearsPracticing;
        private Label label13;
        private TextBox txtDocSpeciality;
        private Label label12;
        private Button button5;
        private Button btnAddStaff;
        private TextBox txtAddressLn2;
        private Label label8;
        private TextBox txtZip;
        private ComboBox comboState;
        private TextBox txtCity;
        private TextBox txtAddressLn1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label14;
        private DateTimePicker dtpHireDate;
    }
}