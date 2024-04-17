namespace EMRKS
{
    partial class addMedicationForm
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
            label19 = new Label();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            txtSSN = new TextBox();
            label1 = new Label();
            groupBoxIngredients = new GroupBox();
            btnMedicationSideEffect = new Button();
            button5 = new Button();
            btnAddPatient = new Button();
            panelIngredients = new Panel();
            groupBox1.SuspendLayout();
            groupBoxIngredients.SuspendLayout();
            panelIngredients.SuspendLayout();
            SuspendLayout();
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 24F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label19.Location = new Point(12, 9);
            label19.Name = "label19";
            label19.Size = new Size(248, 45);
            label19.TabIndex = 5;
            label19.Text = "Add Medication";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSSN);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 237);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Medication Info";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 133);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(261, 81);
            textBox3.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 115);
            label4.Name = "label4";
            label4.Size = new Size(130, 15);
            label4.TabIndex = 19;
            label4.Text = "Medication Side Effects";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(114, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(153, 23);
            textBox2.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 88);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 17;
            label3.Text = "Medication Price";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 23);
            textBox1.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 59);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 15;
            label2.Text = "Medication Name";
            // 
            // txtSSN
            // 
            txtSSN.Location = new Point(114, 22);
            txtSSN.Name = "txtSSN";
            txtSSN.Size = new Size(153, 23);
            txtSSN.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 13;
            label1.Text = "Medication ID";
            // 
            // groupBoxIngredients
            // 
            groupBoxIngredients.AutoSize = true;
            groupBoxIngredients.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxIngredients.Controls.Add(btnMedicationSideEffect);
            groupBoxIngredients.Location = new Point(0, 0);
            groupBoxIngredients.MinimumSize = new Size(457, 237);
            groupBoxIngredients.Name = "groupBoxIngredients";
            groupBoxIngredients.Size = new Size(457, 237);
            groupBoxIngredients.TabIndex = 21;
            groupBoxIngredients.TabStop = false;
            groupBoxIngredients.Text = "Ingredients";
            // 
            // btnMedicationSideEffect
            // 
            btnMedicationSideEffect.Location = new Point(6, 21);
            btnMedicationSideEffect.Name = "btnMedicationSideEffect";
            btnMedicationSideEffect.Size = new Size(135, 23);
            btnMedicationSideEffect.TabIndex = 27;
            btnMedicationSideEffect.Text = "+ Add Side Effect";
            btnMedicationSideEffect.UseVisualStyleBackColor = true;
            btnMedicationSideEffect.Click += btnMedicationSideEffect_Click;
            // 
            // button5
            // 
            button5.Location = new Point(626, 300);
            button5.Name = "button5";
            button5.Size = new Size(135, 23);
            button5.TabIndex = 35;
            button5.Text = "Cancel Add Patient";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnAddPatient
            // 
            btnAddPatient.Location = new Point(12, 300);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(135, 23);
            btnAddPatient.TabIndex = 34;
            btnAddPatient.Text = "Add Patient";
            btnAddPatient.UseVisualStyleBackColor = true;
            btnAddPatient.Click += btnAddPatient_Click;
            // 
            // panelIngredients
            // 
            panelIngredients.AutoScroll = true;
            panelIngredients.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelIngredients.Controls.Add(groupBoxIngredients);
            panelIngredients.Location = new Point(304, 57);
            panelIngredients.Name = "panelIngredients";
            panelIngredients.Size = new Size(474, 237);
            panelIngredients.TabIndex = 36;
            // 
            // addMedicationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1062, 681);
            ControlBox = false;
            Controls.Add(panelIngredients);
            Controls.Add(button5);
            Controls.Add(btnAddPatient);
            Controls.Add(label19);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(202, 0);
            Name = "addMedicationForm";
            StartPosition = FormStartPosition.Manual;
            Text = "addMedicationForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxIngredients.ResumeLayout(false);
            panelIngredients.ResumeLayout(false);
            panelIngredients.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label19;
        private GroupBox groupBox1;
        private TextBox txtSSN;
        private Label label1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox3;
        private Label label4;
        private GroupBox groupBoxIngredients;
        private Button btnMedicationSideEffect;
        private Button button5;
        private Button btnAddPatient;
        private Panel panelIngredients;
    }
}