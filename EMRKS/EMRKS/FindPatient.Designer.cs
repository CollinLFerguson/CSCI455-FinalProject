namespace EMRKS
{
    partial class FindPatient
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
            patientSearchPanel = new Panel();
            patientSearchButton = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            patientInfoPanel = new GroupBox();
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
            label12 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            goodPanel = new Panel();
            label13 = new Label();
            patientOptionsPanel = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            helpProvider1 = new HelpProvider();
            patientSearchPanel.SuspendLayout();
            patientInfoPanel.SuspendLayout();
            goodPanel.SuspendLayout();
            patientOptionsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // patientSearchPanel
            // 
            patientSearchPanel.BackColor = SystemColors.Control;
            patientSearchPanel.Controls.Add(patientSearchButton);
            patientSearchPanel.Controls.Add(textBox1);
            patientSearchPanel.Controls.Add(label1);
            patientSearchPanel.Location = new Point(437, 333);
            patientSearchPanel.Margin = new Padding(3, 4, 3, 4);
            patientSearchPanel.Name = "patientSearchPanel";
            patientSearchPanel.Size = new Size(386, 152);
            patientSearchPanel.TabIndex = 0;
            // 
            // patientSearchButton
            // 
            patientSearchButton.Location = new Point(279, 81);
            patientSearchButton.Margin = new Padding(3, 4, 3, 4);
            patientSearchButton.Name = "patientSearchButton";
            patientSearchButton.Size = new Size(32, 29);
            patientSearchButton.TabIndex = 2;
            patientSearchButton.Text = "->";
            patientSearchButton.UseVisualStyleBackColor = true;
            patientSearchButton.Click += onPatientSearch;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 81);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 26);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(134, 28);
            label1.Name = "label1";
            label1.Size = new Size(120, 21);
            label1.TabIndex = 0;
            label1.Text = "Patient Search";
            // 
            // patientInfoPanel
            // 
            patientInfoPanel.Controls.Add(comboBox1);
            patientInfoPanel.Controls.Add(label20);
            patientInfoPanel.Controls.Add(txtZip);
            patientInfoPanel.Controls.Add(comboState);
            patientInfoPanel.Controls.Add(txtCity);
            patientInfoPanel.Controls.Add(txtAddress);
            patientInfoPanel.Controls.Add(txtMInit);
            patientInfoPanel.Controls.Add(txtFName);
            patientInfoPanel.Controls.Add(txtLName);
            patientInfoPanel.Controls.Add(dtpDOB);
            patientInfoPanel.Controls.Add(comboSex);
            patientInfoPanel.Controls.Add(txtPhoneNumber);
            patientInfoPanel.Controls.Add(lblSSN);
            patientInfoPanel.Controls.Add(label11);
            patientInfoPanel.Controls.Add(label10);
            patientInfoPanel.Controls.Add(label9);
            patientInfoPanel.Controls.Add(label8);
            patientInfoPanel.Controls.Add(label7);
            patientInfoPanel.Controls.Add(label6);
            patientInfoPanel.Controls.Add(label5);
            patientInfoPanel.Controls.Add(label4);
            patientInfoPanel.Controls.Add(label3);
            patientInfoPanel.Controls.Add(label2);
            patientInfoPanel.Controls.Add(label12);
            patientInfoPanel.Location = new Point(99, 43);
            patientInfoPanel.Margin = new Padding(3, 4, 3, 4);
            patientInfoPanel.Name = "patientInfoPanel";
            patientInfoPanel.Padding = new Padding(3, 4, 3, 4);
            patientInfoPanel.Size = new Size(1048, 263);
            patientInfoPanel.TabIndex = 3;
            patientInfoPanel.TabStop = false;
            patientInfoPanel.Text = "Patient Info";
            patientInfoPanel.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(123, 201);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 27);
            comboBox1.TabIndex = 24;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(17, 205);
            label20.Name = "label20";
            label20.Size = new Size(102, 19);
            label20.TabIndex = 23;
            label20.Text = "Primary Doctor";
            // 
            // txtZip
            // 
            txtZip.Location = new Point(907, 151);
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
            comboState.Location = new Point(725, 151);
            comboState.Margin = new Padding(3, 4, 3, 4);
            comboState.Name = "comboState";
            comboState.Size = new Size(94, 27);
            comboState.TabIndex = 21;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(435, 155);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(231, 26);
            txtCity.TabIndex = 20;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(96, 158);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(291, 26);
            txtAddress.TabIndex = 19;
            // 
            // txtMInit
            // 
            txtMInit.Location = new Point(657, 96);
            txtMInit.Margin = new Padding(3, 4, 3, 4);
            txtMInit.Name = "txtMInit";
            txtMInit.Size = new Size(153, 26);
            txtMInit.TabIndex = 18;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(387, 96);
            txtFName.Margin = new Padding(3, 4, 3, 4);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(165, 26);
            txtFName.TabIndex = 17;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(96, 96);
            txtLName.Margin = new Padding(3, 4, 3, 4);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(174, 26);
            txtLName.TabIndex = 16;
            // 
            // dtpDOB
            // 
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(907, 48);
            dtpDOB.Margin = new Padding(3, 4, 3, 4);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(98, 26);
            dtpDOB.TabIndex = 15;
            // 
            // comboSex
            // 
            comboSex.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSex.FormattingEnabled = true;
            comboSex.Items.AddRange(new object[] { "Male", "Female" });
            comboSex.Location = new Point(657, 46);
            comboSex.Margin = new Padding(3, 4, 3, 4);
            comboSex.Name = "comboSex";
            comboSex.Size = new Size(153, 27);
            comboSex.TabIndex = 14;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(387, 46);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(165, 26);
            txtPhoneNumber.TabIndex = 13;
            // 
            // lblSSN
            // 
            lblSSN.Location = new Point(96, 48);
            lblSSN.Margin = new Padding(3, 4, 3, 4);
            lblSSN.Name = "lblSSN";
            lblSSN.Size = new Size(174, 26);
            lblSSN.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(838, 155);
            label11.Name = "label11";
            label11.Size = new Size(64, 19);
            label11.TabIndex = 11;
            label11.Text = "Zip Code";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(680, 158);
            label10.Name = "label10";
            label10.Size = new Size(40, 19);
            label10.TabIndex = 10;
            label10.Text = "State";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(397, 158);
            label9.Name = "label9";
            label9.Size = new Size(33, 19);
            label9.TabIndex = 9;
            label9.Text = "City";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 163);
            label8.Name = "label8";
            label8.Size = new Size(58, 19);
            label8.TabIndex = 8;
            label8.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(622, 52);
            label7.Name = "label7";
            label7.Size = new Size(29, 19);
            label7.TabIndex = 6;
            label7.Text = "Sex";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(563, 100);
            label6.Name = "label6";
            label6.Size = new Size(88, 19);
            label6.TabIndex = 5;
            label6.Text = "Middle Initial";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(280, 52);
            label5.Name = "label5";
            label5.Size = new Size(102, 19);
            label5.TabIndex = 4;
            label5.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(817, 52);
            label4.Name = "label4";
            label4.Size = new Size(87, 19);
            label4.TabIndex = 3;
            label4.Text = "Date of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 100);
            label3.Name = "label3";
            label3.Size = new Size(75, 19);
            label3.TabIndex = 2;
            label3.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 100);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(57, 52);
            label12.Name = "label12";
            label12.Size = new Size(33, 19);
            label12.TabIndex = 0;
            label12.Text = "SSN";
            // 
            // button4
            // 
            button4.Location = new Point(27, 120);
            button4.Name = "button4";
            button4.Size = new Size(143, 43);
            button4.TabIndex = 3;
            button4.Text = "Appointment Manager";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(27, 169);
            button3.Name = "button3";
            button3.Size = new Size(143, 43);
            button3.TabIndex = 2;
            button3.Text = "Medication Manager";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(27, 71);
            button2.Name = "button2";
            button2.Size = new Size(143, 43);
            button2.TabIndex = 1;
            button2.Text = "Financial Information";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(27, 22);
            button1.Name = "button1";
            button1.Size = new Size(143, 43);
            button1.TabIndex = 0;
            button1.Text = "Edit Patient Info";
            button1.UseVisualStyleBackColor = true;
            // 
            // goodPanel
            // 
            goodPanel.BackColor = Color.SeaGreen;
            goodPanel.Controls.Add(label13);
            goodPanel.Location = new Point(335, 317);
            goodPanel.Margin = new Padding(3, 4, 3, 4);
            goodPanel.Name = "goodPanel";
            goodPanel.Size = new Size(813, 580);
            goodPanel.TabIndex = 5;
            goodPanel.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(133, 274);
            label13.Name = "label13";
            label13.Size = new Size(566, 19);
            label13.TabIndex = 0;
            label13.Text = "This can be where fanancial info dispalyed, appointment manager, and medicaiton manager";
            // 
            // patientOptionsPanel
            // 
            patientOptionsPanel.Controls.Add(button8);
            patientOptionsPanel.Controls.Add(button7);
            patientOptionsPanel.Controls.Add(button6);
            patientOptionsPanel.Controls.Add(button5);
            patientOptionsPanel.Location = new Point(99, 317);
            patientOptionsPanel.Margin = new Padding(3, 4, 3, 4);
            patientOptionsPanel.Name = "patientOptionsPanel";
            patientOptionsPanel.Size = new Size(229, 267);
            patientOptionsPanel.TabIndex = 6;
            patientOptionsPanel.Visible = false;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button8.Location = new Point(17, 195);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(194, 52);
            button8.TabIndex = 3;
            button8.Text = "Medication Manager";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button7.Location = new Point(17, 136);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(194, 52);
            button7.TabIndex = 2;
            button7.Text = "Financials Manager";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button6.Location = new Point(17, 76);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(194, 52);
            button6.TabIndex = 1;
            button6.Text = "Appointment Manager";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button5.Location = new Point(17, 16);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(194, 52);
            button5.TabIndex = 0;
            button5.Text = "Edit Personl Info";
            button5.UseVisualStyleBackColor = true;
            // 
            // FindPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1232, 912);
            Controls.Add(patientOptionsPanel);
            Controls.Add(goodPanel);
            Controls.Add(patientInfoPanel);
            Controls.Add(patientSearchPanel);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(202, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FindPatient";
            StartPosition = FormStartPosition.Manual;
            Text = "FindPatient";
            patientSearchPanel.ResumeLayout(false);
            patientSearchPanel.PerformLayout();
            patientInfoPanel.ResumeLayout(false);
            patientInfoPanel.PerformLayout();
            goodPanel.ResumeLayout(false);
            goodPanel.PerformLayout();
            patientOptionsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel patientSearchPanel;
        private TextBox textBox1;
        private Label label1;
        private Button patientSearchButton;
        private GroupBox patientInfoPanel;
        private ComboBox comboBox1;
        private Label label20;
        private TextBox txtZip;
        private ComboBox comboState;
        private TextBox txtCity;
        private TextBox txtAddress;
        private TextBox txtMInit;
        private TextBox txtFName;
        private TextBox txtLName;
        private DateTimePicker dtpDOB;
        private ComboBox comboSex;
        private TextBox txtPhoneNumber;
        private TextBox lblSSN;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label12;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel goodPanel;
        private Label label13;
        private Panel patientOptionsPanel;
        private HelpProvider helpProvider1;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
    }
}