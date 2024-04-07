namespace EMRKS
{
    partial class Patient_EmergencyContact
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
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(183, 99);
            button1.Name = "button1";
            button1.Size = new Size(116, 23);
            button1.TabIndex = 5;
            button1.Text = "Remove Contact";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 23);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 3;
            label1.Text = "Contact Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(105, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 23);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 44);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 7;
            label2.Text = "Contact Phone #";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 73);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 8;
            label3.Text = "Contact Relationship";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(126, 70);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(173, 23);
            textBox3.TabIndex = 9;
            // 
            // Patient_EmergencyContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Patient_EmergencyContact";
            Size = new Size(302, 132);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
    }
}
