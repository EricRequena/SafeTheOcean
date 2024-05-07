namespace SaveTheOcean2
{
    partial class AddAnimal
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtBoxName = new TextBox();
            txtBoxFamily = new TextBox();
            txtBoxPlace = new TextBox();
            txtBoxSpecies = new TextBox();
            txtBoxWeight = new TextBox();
            errorProviderString = new ErrorProvider(components);
            errorProviderInt = new ErrorProvider(components);
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProviderString).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderInt).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 24);
            label1.Name = "label1";
            label1.Size = new Size(264, 38);
            label1.TabIndex = 0;
            label1.Text = "Inserta les Dades";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 9F);
            label2.Location = new Point(88, 113);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "Nom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(379, 183);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 9F);
            label4.Location = new Point(88, 183);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 3;
            label4.Text = "Lloc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 9F);
            label5.Location = new Point(331, 113);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 4;
            label5.Text = "Família";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 9F);
            label6.Location = new Point(576, 113);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 5;
            label6.Text = "Espècie";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Emoji", 9F);
            label7.Location = new Point(348, 188);
            label7.Name = "label7";
            label7.Size = new Size(31, 20);
            label7.TabIndex = 6;
            label7.Text = "Pes";
            // 
            // txtBoxName
            // 
            txtBoxName.BackColor = SystemColors.InactiveCaption;
            txtBoxName.Location = new Point(136, 113);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(125, 25);
            txtBoxName.TabIndex = 7;
            // 
            // txtBoxFamily
            // 
            txtBoxFamily.BackColor = SystemColors.InactiveCaption;
            txtBoxFamily.Location = new Point(394, 110);
            txtBoxFamily.Name = "txtBoxFamily";
            txtBoxFamily.Size = new Size(125, 25);
            txtBoxFamily.TabIndex = 8;
            // 
            // txtBoxPlace
            // 
            txtBoxPlace.BackColor = SystemColors.InactiveCaption;
            txtBoxPlace.Location = new Point(130, 183);
            txtBoxPlace.Name = "txtBoxPlace";
            txtBoxPlace.Size = new Size(125, 25);
            txtBoxPlace.TabIndex = 9;
            // 
            // txtBoxSpecies
            // 
            txtBoxSpecies.BackColor = SystemColors.InactiveCaption;
            txtBoxSpecies.Location = new Point(641, 108);
            txtBoxSpecies.Name = "txtBoxSpecies";
            txtBoxSpecies.Size = new Size(125, 25);
            txtBoxSpecies.TabIndex = 10;
            // 
            // txtBoxWeight
            // 
            txtBoxWeight.BackColor = SystemColors.InactiveCaption;
            txtBoxWeight.Location = new Point(394, 183);
            txtBoxWeight.Name = "txtBoxWeight";
            txtBoxWeight.Size = new Size(125, 25);
            txtBoxWeight.TabIndex = 11;
            // 
            // errorProviderString
            // 
            errorProviderString.ContainerControl = this;
            // 
            // errorProviderInt
            // 
            errorProviderInt.ContainerControl = this;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.ActiveCaption;
            buttonSave.Location = new Point(165, 311);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(487, 59);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Insereix";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // AddAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 382);
            Controls.Add(buttonSave);
            Controls.Add(txtBoxWeight);
            Controls.Add(txtBoxSpecies);
            Controls.Add(txtBoxPlace);
            Controls.Add(txtBoxFamily);
            Controls.Add(txtBoxName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AddAnimal";
            Text = "AddAnimal";
            ((System.ComponentModel.ISupportInitialize)errorProviderString).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderInt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtBoxName;
        private TextBox txtBoxFamily;
        private TextBox txtBoxPlace;
        private TextBox txtBoxSpecies;
        private TextBox txtBoxWeight;
        private ErrorProvider errorProviderString;
        private Button buttonSave;
        private ErrorProvider errorProviderInt;
    }
}