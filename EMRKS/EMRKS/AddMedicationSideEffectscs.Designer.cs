namespace EMRKS
{
    partial class AddMedicationSideEffectscs
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
            txtIngredient = new TextBox();
            label15 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtIngredient
            // 
            txtIngredient.Location = new Point(81, 3);
            txtIngredient.Name = "txtIngredient";
            txtIngredient.Size = new Size(341, 23);
            txtIngredient.TabIndex = 45;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(11, 12);
            label15.Name = "label15";
            label15.Size = new Size(64, 15);
            label15.TabIndex = 46;
            label15.Text = "Ingredient:";
            // 
            // button1
            // 
            button1.Location = new Point(306, 28);
            button1.Name = "button1";
            button1.Size = new Size(116, 23);
            button1.TabIndex = 50;
            button1.Text = "Remove Ingredient";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddMedicationSideEffectscs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(txtIngredient);
            Controls.Add(label15);
            Name = "AddMedicationSideEffectscs";
            Size = new Size(426, 54);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIngredient;
        private Label label15;
        private Button button1;
    }
}
