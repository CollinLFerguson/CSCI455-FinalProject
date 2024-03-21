namespace EMRKS
{
    partial class LoginForm
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
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(73, 52);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 0;
            label1.Text = "Member Login";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(73, 220);
            button1.Name = "button1";
            button1.Size = new Size(106, 32);
            button1.TabIndex = 1;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += onLogin;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            textBox1.Location = new Point(73, 109);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 25);
            textBox1.TabIndex = 2;
            textBox1.Text = "ID Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 255);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 4;
            label2.Text = "Trouble signing in?";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            textBox2.Location = new Point(73, 162);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 25);
            textBox2.TabIndex = 5;
            textBox2.Text = "Pin";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(327, 322);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
    }
}