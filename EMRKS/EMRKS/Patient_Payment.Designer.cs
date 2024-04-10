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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(465, 37);
            button2.Name = "button2";
            button2.Size = new Size(116, 23);
            button2.TabIndex = 47;
            button2.Text = "Remove Payment";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(492, 8);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(89, 23);
            textBox3.TabIndex = 46;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(327, 8);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(89, 23);
            textBox2.TabIndex = 44;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 23);
            textBox1.TabIndex = 41;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(431, 16);
            label14.Name = "label14";
            label14.Size = new Size(60, 15);
            label14.TabIndex = 45;
            label14.Text = "Expiration";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(291, 16);
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
            // Patient_Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Name = "Patient_Payment";
            Size = new Size(607, 65);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label14;
        private Label label13;
        private Label label12;
    }
}
