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
            textBox5 = new TextBox();
            patientInfoPrimaryDoctor = new TextBox();
            patientInfoDOB = new TextBox();
            patientInfoSex = new TextBox();
            label20 = new Label();
            txtZip = new TextBox();
            txtCity = new TextBox();
            txtAddress = new TextBox();
            patientInfoMI = new TextBox();
            patientInfoPhoneNumber = new TextBox();
            patientInfoLastName = new TextBox();
            patientInfoFirstName = new TextBox();
            patientInfoSSN = new TextBox();
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
            patientSearchPanel.Location = new Point(382, 263);
            patientSearchPanel.Name = "patientSearchPanel";
            patientSearchPanel.Size = new Size(338, 120);
            patientSearchPanel.TabIndex = 0;
            // 
            // patientSearchButton
            // 
            patientSearchButton.Location = new Point(244, 64);
            patientSearchButton.Name = "patientSearchButton";
            patientSearchButton.Size = new Size(28, 23);
            patientSearchButton.TabIndex = 2;
            patientSearchButton.Text = "->";
            patientSearchButton.UseVisualStyleBackColor = true;
            patientSearchButton.Click += onPatientSearch;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(99, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(117, 22);
            label1.Name = "label1";
            label1.Size = new Size(105, 19);
            label1.TabIndex = 0;
            label1.Text = "Patient Search";
            // 
            // patientInfoPanel
            // 
            patientInfoPanel.Controls.Add(textBox5);
            patientInfoPanel.Controls.Add(patientInfoPrimaryDoctor);
            patientInfoPanel.Controls.Add(patientInfoDOB);
            patientInfoPanel.Controls.Add(patientInfoSex);
            patientInfoPanel.Controls.Add(label20);
            patientInfoPanel.Controls.Add(txtZip);
            patientInfoPanel.Controls.Add(txtCity);
            patientInfoPanel.Controls.Add(txtAddress);
            patientInfoPanel.Controls.Add(patientInfoMI);
            patientInfoPanel.Controls.Add(patientInfoPhoneNumber);
            patientInfoPanel.Controls.Add(patientInfoLastName);
            patientInfoPanel.Controls.Add(patientInfoFirstName);
            patientInfoPanel.Controls.Add(patientInfoSSN);
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
            patientInfoPanel.Location = new Point(87, 34);
            patientInfoPanel.Name = "patientInfoPanel";
            patientInfoPanel.Size = new Size(917, 155);
            patientInfoPanel.TabIndex = 3;
            patientInfoPanel.TabStop = false;
            patientInfoPanel.Text = "Patient Info";
            patientInfoPanel.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(613, 113);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(25, 23);
            textBox5.TabIndex = 28;
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // patientInfoPrimaryDoctor
            // 
            patientInfoPrimaryDoctor.Location = new Point(353, 70);
            patientInfoPrimaryDoctor.Name = "patientInfoPrimaryDoctor";
            patientInfoPrimaryDoctor.ReadOnly = true;
            patientInfoPrimaryDoctor.Size = new Size(110, 23);
            patientInfoPrimaryDoctor.TabIndex = 27;
            // 
            // patientInfoDOB
            // 
            patientInfoDOB.Location = new Point(776, 35);
            patientInfoDOB.Name = "patientInfoDOB";
            patientInfoDOB.ReadOnly = true;
            patientInfoDOB.Size = new Size(80, 23);
            patientInfoDOB.TabIndex = 26;
            // 
            // patientInfoSex
            // 
            patientInfoSex.Location = new Point(708, 35);
            patientInfoSex.Name = "patientInfoSex";
            patientInfoSex.ReadOnly = true;
            patientInfoSex.Size = new Size(25, 23);
            patientInfoSex.TabIndex = 25;
            patientInfoSex.TextAlign = HorizontalAlignment.Center;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(260, 73);
            label20.Name = "label20";
            label20.Size = new Size(87, 15);
            label20.TabIndex = 23;
            label20.Text = "Primary Doctor";
            // 
            // txtZip
            // 
            txtZip.Location = new Point(705, 113);
            txtZip.Name = "txtZip";
            txtZip.ReadOnly = true;
            txtZip.Size = new Size(110, 23);
            txtZip.TabIndex = 22;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(365, 113);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(203, 23);
            txtCity.TabIndex = 20;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(70, 113);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(255, 23);
            txtAddress.TabIndex = 19;
            // 
            // patientInfoMI
            // 
            patientInfoMI.Location = new Point(417, 35);
            patientInfoMI.Name = "patientInfoMI";
            patientInfoMI.ReadOnly = true;
            patientInfoMI.Size = new Size(26, 23);
            patientInfoMI.TabIndex = 18;
            patientInfoMI.TextAlign = HorizontalAlignment.Center;
            // 
            // patientInfoPhoneNumber
            // 
            patientInfoPhoneNumber.Location = new Point(109, 68);
            patientInfoPhoneNumber.Name = "patientInfoPhoneNumber";
            patientInfoPhoneNumber.ReadOnly = true;
            patientInfoPhoneNumber.Size = new Size(145, 23);
            patientInfoPhoneNumber.TabIndex = 17;
            // 
            // patientInfoLastName
            // 
            patientInfoLastName.Location = new Point(518, 35);
            patientInfoLastName.Name = "patientInfoLastName";
            patientInfoLastName.ReadOnly = true;
            patientInfoLastName.Size = new Size(153, 23);
            patientInfoLastName.TabIndex = 16;
            // 
            // patientInfoFirstName
            // 
            patientInfoFirstName.Location = new Point(239, 35);
            patientInfoFirstName.Name = "patientInfoFirstName";
            patientInfoFirstName.ReadOnly = true;
            patientInfoFirstName.Size = new Size(145, 23);
            patientInfoFirstName.TabIndex = 13;
            // 
            // patientInfoSSN
            // 
            patientInfoSSN.Location = new Point(49, 35);
            patientInfoSSN.Name = "patientInfoSSN";
            patientInfoSSN.ReadOnly = true;
            patientInfoSSN.Size = new Size(114, 23);
            patientInfoSSN.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(644, 116);
            label11.Name = "label11";
            label11.Size = new Size(55, 15);
            label11.TabIndex = 11;
            label11.Text = "Zip Code";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(574, 116);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 10;
            label10.Text = "State";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(331, 116);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 9;
            label9.Text = "City";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 116);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 8;
            label8.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(677, 38);
            label7.Name = "label7";
            label7.Size = new Size(25, 15);
            label7.TabIndex = 6;
            label7.Text = "Sex";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(390, 38);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 5;
            label6.Text = "MI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 73);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 4;
            label5.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(739, 38);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "DOB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 38);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(449, 38);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 38);
            label12.Name = "label12";
            label12.Size = new Size(28, 15);
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
            goodPanel.Location = new Point(293, 195);
            goodPanel.Name = "goodPanel";
            goodPanel.Size = new Size(711, 513);
            goodPanel.TabIndex = 5;
            goodPanel.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(116, 216);
            label13.Name = "label13";
            label13.Size = new Size(493, 15);
            label13.TabIndex = 0;
            label13.Text = "This can be where fanancial info dispalyed, appointment manager, and medicaiton manager";
            // 
            // patientOptionsPanel
            // 
            patientOptionsPanel.Controls.Add(button8);
            patientOptionsPanel.Controls.Add(button7);
            patientOptionsPanel.Controls.Add(button6);
            patientOptionsPanel.Controls.Add(button5);
            patientOptionsPanel.Location = new Point(89, 195);
            patientOptionsPanel.Name = "patientOptionsPanel";
            patientOptionsPanel.Size = new Size(200, 211);
            patientOptionsPanel.TabIndex = 6;
            patientOptionsPanel.Visible = false;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button8.Location = new Point(15, 154);
            button8.Name = "button8";
            button8.Size = new Size(170, 41);
            button8.TabIndex = 3;
            button8.Text = "Medication Manager";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button7.Location = new Point(15, 107);
            button7.Name = "button7";
            button7.Size = new Size(170, 41);
            button7.TabIndex = 2;
            button7.Text = "Financials Manager";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button6.Location = new Point(15, 60);
            button6.Name = "button6";
            button6.Size = new Size(170, 41);
            button6.TabIndex = 1;
            button6.Text = "Appointment Manager";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button5.Location = new Point(15, 13);
            button5.Name = "button5";
            button5.Size = new Size(170, 41);
            button5.TabIndex = 0;
            button5.Text = "Edit Personl Info";
            button5.UseVisualStyleBackColor = true;
            button5.Click += onEditPatientPersonalInfo;
            // 
            // FindPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1078, 720);
            Controls.Add(patientOptionsPanel);
            Controls.Add(goodPanel);
            Controls.Add(patientInfoPanel);
            Controls.Add(patientSearchPanel);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(202, 0);
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
        private Label label20;
        private TextBox txtZip;
        private TextBox txtCity;
        private TextBox txtAddress;
        private TextBox patientInfoMI;
        private TextBox patientInfoPhoneNumber;
        private TextBox patientInfoLastName;
        private TextBox patientInfoFirstName;
        private TextBox patientInfoSSN;
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
        private TextBox patientInfoSex;
        private TextBox patientInfoPrimaryDoctor;
        private TextBox patientInfoDOB;
        private TextBox textBox5;
    }
}