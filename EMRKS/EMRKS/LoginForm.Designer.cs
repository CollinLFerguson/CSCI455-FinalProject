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
            label1.Location = new Point(141, 127);
            label1.Name = "label1";
            label1.Size = new Size(164, 30);
            label1.TabIndex = 0;
            label1.Text = "Member Login";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(141, 332);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(121, 41);
            button1.TabIndex = 1;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += onLogin;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtUsername.Location = new Point(141, 194);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "ID Number";
            txtUsername.Size = new Size(163, 31);
            txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 402);
            label2.Name = "label2";
            label2.Size = new Size(123, 19);
            label2.TabIndex = 4;
            label2.Text = "Trouble signing in?";
            // 
            // txtPin
            // 
            txtPin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtPin.Location = new Point(141, 261);
            txtPin.Margin = new Padding(3, 4, 3, 4);
            txtPin.Name = "txtPin";
            txtPin.PasswordChar = '*';
            txtPin.PlaceholderText = "Pin";
            txtPin.Size = new Size(163, 28);
            txtPin.TabIndex = 5;
            txtPin.UseSystemPasswordChar = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(430, 561);
            Controls.Add(txtPin);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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