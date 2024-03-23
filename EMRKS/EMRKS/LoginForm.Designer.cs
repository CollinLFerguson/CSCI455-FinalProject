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
            txtUsername = new TextBox();
            label2 = new Label();
            txtPin = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(123, 100);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 0;
            label1.Text = "Member Login";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(123, 262);
            button1.Name = "button1";
            button1.Size = new Size(106, 32);
            button1.TabIndex = 1;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += onLogin;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtUsername.Location = new Point(123, 153);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "ID Number";
            txtUsername.Size = new Size(143, 25);
            txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 317);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 4;
            label2.Text = "Trouble signing in?";
            // 
            // txtPin
            // 
            txtPin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtPin.Location = new Point(123, 206);
            txtPin.Name = "txtPin";
            txtPin.PasswordChar = '*';
            txtPin.PlaceholderText = "Pin";
            txtPin.Size = new Size(143, 25);
            txtPin.TabIndex = 5;
            txtPin.UseSystemPasswordChar = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(376, 443);
            Controls.Add(txtPin);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox txtUsername;
        private Label label2;
        private TextBox txtPin;
    }
}