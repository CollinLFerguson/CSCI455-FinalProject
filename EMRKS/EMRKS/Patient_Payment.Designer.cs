namespace EMRKS
{
    partial class Patient_Payment
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
            button2 = new Button();
            txtCcv = new TextBox();
            txtCardNumber = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            txtCardType = new TextBox();
            label1 = new Label();
            dtpExp = new DateTimePicker();
            txtCardName = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(474, 37);
            button2.Name = "button2";
            button2.Size = new Size(109, 23);
            button2.TabIndex = 47;
            button2.Text = "Remove Payment";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtCcv
            // 
            txtCcv.Location = new Point(355, 37);
            txtCcv.Name = "txtCcv";
            txtCcv.Size = new Size(89, 23);
            txtCcv.TabIndex = 44;
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(123, 8);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(126, 23);
            txtCardNumber.TabIndex = 41;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(450, 16);
            label14.Name = "label14";
            label14.Size = new Size(60, 15);
            label14.TabIndex = 45;
            label14.Text = "Expiration";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(319, 41);
            label13.Name = "label13";
            label13.Size = new Size(30, 15);
            label13.TabIndex = 42;
            label13.Text = "CCV";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 16);
            label12.Name = "label12";
            label12.Size = new Size(114, 15);
            label12.TabIndex = 43;
            label12.Text = "Credit Card Number";
            // 
            // txtCardType
            // 
            txtCardType.Location = new Point(355, 8);
            txtCardType.Name = "txtCardType";
            txtCardType.Size = new Size(89, 23);
            txtCardType.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 15);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 49;
            label1.Text = "Credit Card Type";
            // 
            // dtpExp
            // 
            dtpExp.CustomFormat = "yyyy/MM";
            dtpExp.Format = DateTimePickerFormat.Custom;
            dtpExp.Location = new Point(516, 10);
            dtpExp.MaxDate = new DateTime(2024, 4, 11, 0, 0, 0, 0);
            dtpExp.MinDate = new DateTime(2024, 4, 11, 0, 0, 0, 0);
            dtpExp.Name = "dtpExp";
            dtpExp.Size = new Size(67, 23);
            dtpExp.TabIndex = 50;
            dtpExp.Value = new DateTime(2024, 4, 11, 0, 0, 0, 0);
            // 
            // txtCardName
            // 
            txtCardName.Location = new Point(110, 33);
            txtCardName.Name = "txtCardName";
            txtCardName.Size = new Size(203, 23);
            txtCardName.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 41);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 52;
            label2.Text = "Cardholder Name";
            // 
            // Patient_Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtCardName);
            Controls.Add(label2);
            Controls.Add(dtpExp);
            Controls.Add(txtCardType);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(txtCcv);
            Controls.Add(txtCardNumber);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Name = "Patient_Payment";
            Size = new Size(586, 65);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox txtCcv;
        private TextBox txtCardNumber;
        private Label label14;
        private Label label13;
        private Label label12;
        private TextBox txtCardType;
        private Label label1;
        private DateTimePicker dtpExp;
        private TextBox txtCardName;
        private Label label2;
    }
}
