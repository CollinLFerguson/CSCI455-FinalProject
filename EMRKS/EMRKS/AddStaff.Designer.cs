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
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            label13 = new Label();
            textBox1 = new TextBox();
            label12 = new Label();
            label7 = new Label();
            txtZip = new TextBox();
            comboState = new ComboBox();
            txtCity = new TextBox();
            txtAddress = new TextBox();
            txtMInit = new TextBox();
            txtFName = new TextBox();
            txtLName = new TextBox();
            dtpDOB = new DateTimePicker();
            txtPhoneNumber = new TextBox();
            lblSSN = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label19 = new Label();
            button5 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtZip);
            groupBox1.Controls.Add(comboState);
            groupBox1.Controls.Add(txtCity);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtMInit);
            groupBox1.Controls.Add(txtFName);
            groupBox1.Controls.Add(txtLName);
            groupBox1.Controls.Add(dtpDOB);
            groupBox1.Controls.Add(txtPhoneNumber);
            groupBox1.Controls.Add(lblSSN);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 73);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1048, 322);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Staff Info";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Administration", "Doctor", "Nurse" });
            comboBox1.Location = new Point(738, 23);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 27);
            comboBox1.TabIndex = 24;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label12);
            groupBox2.Enabled = false;
            groupBox2.Location = new Point(17, 190);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(560, 82);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Doctor Specific Information";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(378, 27);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 26);
            textBox2.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(271, 37);
            label13.Name = "label13";
            label13.Size = new Size(104, 19);
            label13.TabIndex = 27;
            label13.Text = "Years Practicing";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 27);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 26);
            textBox1.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 37);
            label12.Name = "label12";
            label12.Size = new Size(65, 19);
            label12.TabIndex = 29;
            label12.Text = "Speciality";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(665, 33);
            label7.Name = "label7";
            label7.Size = new Size(68, 19);
            label7.TabIndex = 23;
            label7.Text = "Staff Type";
            // 
            // txtZip
            // 
            txtZip.Location = new Point(891, 123);
            txtZip.Margin = new Padding(3, 4, 3, 4);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(125, 26);
            txtZip.TabIndex = 22;
            // 
            // comboState
            // 
            comboState.DropDownStyle = ComboBoxStyle.DropDownList;
            comboState.FormattingEnabled = true;
            comboState.Items.AddRange(new object[] { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "DC", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" });
            comboState.Location = new Point(709, 123);
            comboState.Margin = new Padding(3, 4, 3, 4);
            comboState.Name = "comboState";
            comboState.Size = new Size(94, 27);
            comboState.TabIndex = 21;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(418, 123);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(231, 26);
            txtCity.TabIndex = 20;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(80, 123);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(291, 26);
            txtAddress.TabIndex = 19;
            // 
            // txtMInit
            // 
            txtMInit.Location = new Point(657, 73);
            txtMInit.Margin = new Padding(3, 4, 3, 4);
            txtMInit.Name = "txtMInit";
            txtMInit.Size = new Size(153, 26);
            txtMInit.TabIndex = 18;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(387, 73);
            txtFName.Margin = new Padding(3, 4, 3, 4);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(165, 26);
            txtFName.TabIndex = 17;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(96, 73);
            txtLName.Margin = new Padding(3, 4, 3, 4);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(174, 26);
            txtLName.TabIndex = 16;
            // 
            // dtpDOB
            // 
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(543, 23);
            dtpDOB.Margin = new Padding(3, 4, 3, 4);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(98, 26);
            dtpDOB.TabIndex = 15;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(274, 27);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(165, 26);
            txtPhoneNumber.TabIndex = 13;
            // 
            // lblSSN
            // 
            lblSSN.Location = new Point(56, 27);
            lblSSN.Margin = new Padding(3, 4, 3, 4);
            lblSSN.Name = "lblSSN";
            lblSSN.Size = new Size(174, 26);
            lblSSN.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(822, 133);
            label11.Name = "label11";
            label11.Size = new Size(64, 19);
            label11.TabIndex = 11;
            label11.Text = "Zip Code";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(664, 133);
            label10.Name = "label10";
            label10.Size = new Size(40, 19);
            label10.TabIndex = 10;
            label10.Text = "State";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(387, 130);
            label9.Name = "label9";
            label9.Size = new Size(33, 19);
            label9.TabIndex = 9;
            label9.Text = "City";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 136);
            label8.Name = "label8";
            label8.Size = new Size(58, 19);
            label8.TabIndex = 8;
            label8.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(563, 84);
            label6.Name = "label6";
            label6.Size = new Size(88, 19);
            label6.TabIndex = 5;
            label6.Text = "Middle Initial";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(240, 37);
            label5.Name = "label5";
            label5.Size = new Size(28, 19);
            label5.TabIndex = 4;
            label5.Text = "Pin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(472, 37);
            label4.Name = "label4";
            label4.Size = new Size(67, 19);
            label4.TabIndex = 3;
            label4.Text = "Hire Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 84);
            label3.Name = "label3";
            label3.Size = new Size(75, 19);
            label3.TabIndex = 2;
            label3.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 84);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 37);
            label1.Name = "label1";
            label1.Size = new Size(33, 19);
            label1.TabIndex = 0;
            label1.Text = "SSN";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 24F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label19.Location = new Point(11, 13);
            label19.Name = "label19";
            label19.Size = new Size(175, 50);
            label19.TabIndex = 4;
            label19.Text = "Add Staff";
            // 
            // button5
            // 
            button5.Location = new Point(907, 403);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(154, 29);
            button5.TabIndex = 35;
            button5.Text = "Cancel Add Staff";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(11, 403);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(154, 29);
            button4.TabIndex = 34;
            button4.Text = "Add Staff";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // AddStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1232, 912);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label19);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(202, 0);
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox txtZip;
        private ComboBox comboState;
        private TextBox txtCity;
        private TextBox txtAddress;
        private TextBox txtMInit;
        private TextBox txtFName;
        private TextBox txtLName;
        private DateTimePicker dtpDOB;
        private TextBox txtPhoneNumber;
        private TextBox lblSSN;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private Label label19;
        private TextBox textBox2;
        private Label label13;
        private TextBox textBox1;
        private Label label12;
        private Button button5;
        private Button button4;
    }
}