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
            txtSideEffects = new TextBox();
            label4 = new Label();
            txtMedicationPrice = new TextBox();
            label3 = new Label();
            txtMedicationName = new TextBox();
            label2 = new Label();
            txtMedicationID = new TextBox();
            label1 = new Label();
            groupBoxIngredients = new GroupBox();
            btnMedicationSideEffect = new Button();
            btnCancelMedication = new Button();
            btnAddMedication = new Button();
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
            groupBox1.Controls.Add(txtSideEffects);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMedicationPrice);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMedicationName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMedicationID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 237);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Medication Info";
            // 
            // txtSideEffects
            // 
            txtSideEffects.Location = new Point(6, 133);
            txtSideEffects.Multiline = true;
            txtSideEffects.Name = "txtSideEffects";
            txtSideEffects.PlaceholderText = "Headache, nausea, etc..";
            txtSideEffects.Size = new Size(261, 81);
            txtSideEffects.TabIndex = 4;
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
            // txtMedicationPrice
            // 
            txtMedicationPrice.Location = new Point(114, 80);
            txtMedicationPrice.Name = "txtMedicationPrice";
            txtMedicationPrice.PlaceholderText = "(EX:10.20)";
            txtMedicationPrice.Size = new Size(153, 23);
            txtMedicationPrice.TabIndex = 3;
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
            // txtMedicationName
            // 
            txtMedicationName.Location = new Point(114, 51);
            txtMedicationName.Name = "txtMedicationName";
            txtMedicationName.PlaceholderText = "Tylenol";
            txtMedicationName.Size = new Size(153, 23);
            txtMedicationName.TabIndex = 2;
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
            // txtMedicationID
            // 
            txtMedicationID.Location = new Point(114, 22);
            txtMedicationID.Name = "txtMedicationID";
            txtMedicationID.PlaceholderText = "123456789012";
            txtMedicationID.Size = new Size(153, 23);
            txtMedicationID.TabIndex = 1;
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
            btnMedicationSideEffect.TabIndex = 5;
            btnMedicationSideEffect.Text = "+ Add Ingredient";
            btnMedicationSideEffect.UseVisualStyleBackColor = true;
            btnMedicationSideEffect.Click += btnMedicationSideEffect_Click;
            // 
            // btnCancelMedication
            // 
            btnCancelMedication.Location = new Point(620, 300);
            btnCancelMedication.Name = "btnCancelMedication";
            btnCancelMedication.Size = new Size(141, 23);
            btnCancelMedication.TabIndex = 7;
            btnCancelMedication.Text = "Cancel Add Medication";
            btnCancelMedication.UseVisualStyleBackColor = true;
            btnCancelMedication.Click += button5_Click;
            // 
            // btnAddMedication
            // 
            btnAddMedication.Location = new Point(12, 300);
            btnAddMedication.Name = "btnAddMedication";
            btnAddMedication.Size = new Size(135, 23);
            btnAddMedication.TabIndex = 6;
            btnAddMedication.Text = "Add Medication";
            btnAddMedication.UseVisualStyleBackColor = true;
            btnAddMedication.Click += btnAddMedication_Click;
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
            Controls.Add(btnCancelMedication);
            Controls.Add(btnAddMedication);
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
        private TextBox txtMedicationID;
        private Label label1;
        private TextBox txtMedicationPrice;
        private Label label3;
        private TextBox txtMedicationName;
        private Label label2;
        private TextBox txtSideEffects;
        private Label label4;
        private GroupBox groupBoxIngredients;
        private Button btnMedicationSideEffect;
        private Button btnCancelMedication;
        private Button btnAddMedication;
        private Panel panelIngredients;
    }
}