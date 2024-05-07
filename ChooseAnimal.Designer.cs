namespace SaveTheOcean2
{
    partial class ChooseAnimal
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
            buttonAnimal = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // buttonAnimal
            // 
            buttonAnimal.BackColor = SystemColors.ActiveCaption;
            buttonAnimal.Location = new Point(66, 12);
            buttonAnimal.Name = "buttonAnimal";
            buttonAnimal.Size = new Size(400, 88);
            buttonAnimal.TabIndex = 0;
            buttonAnimal.Text = "Jugar amb un animal existent";
            buttonAnimal.UseVisualStyleBackColor = false;
            buttonAnimal.Click += buttonAnimal_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(66, 109);
            button1.Name = "button1";
            button1.Size = new Size(400, 88);
            button1.TabIndex = 1;
            button1.Text = "Afegir un nou animal";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ChooseAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 209);
            Controls.Add(button1);
            Controls.Add(buttonAnimal);
            Name = "ChooseAnimal";
            Text = "SaveTheOcean2";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAnimal;
        private Button button1;
    }
}