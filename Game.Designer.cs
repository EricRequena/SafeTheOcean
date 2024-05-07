﻿namespace SalvaOceano
{
    partial class Game
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
            bttnSaveHere = new Button();
            bttnSaveCram = new Button();
            labelWelcome = new Label();
            groupBoxRescue = new GroupBox();
            lblPlace = new Label();
            lblGA = new Label();
            lblFamily = new Label();
            lblDate = new Label();
            lblRescueNum = new Label();
            labelPlace = new Label();
            labelGA = new Label();
            labelFamily = new Label();
            labelDate = new Label();
            labelResNum = new Label();
            groupBoxFile = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            labelWeight = new Label();
            labelSpecies = new Label();
            labelSF = new Label();
            labelName = new Label();
            groupBoxRescue.SuspendLayout();
            groupBoxFile.SuspendLayout();
            SuspendLayout();
            // 
            // bttnSaveHere
            // 
            bttnSaveHere.Location = new Point(48, 371);
            bttnSaveHere.Name = "bttnSaveHere";
            bttnSaveHere.Size = new Size(292, 67);
            bttnSaveHere.TabIndex = 0;
            bttnSaveHere.Text = "Salvar aquí";
            bttnSaveHere.UseVisualStyleBackColor = true;
            bttnSaveHere.Click += bttnSaveHere_Click;
            // 
            // bttnSaveCram
            // 
            bttnSaveCram.Location = new Point(423, 371);
            bttnSaveCram.Name = "bttnSaveCram";
            bttnSaveCram.Size = new Size(292, 67);
            bttnSaveCram.TabIndex = 1;
            bttnSaveCram.Text = "Portar al CRAM";
            bttnSaveCram.UseVisualStyleBackColor = true;
            bttnSaveCram.Click += bttnSaveCram_Click;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Location = new Point(22, 18);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(29, 20);
            labelWelcome.TabIndex = 2;
            labelWelcome.Text = "\" \" ";
            // 
            // groupBoxRescue
            // 
            groupBoxRescue.BackColor = Color.IndianRed;
            groupBoxRescue.Controls.Add(lblPlace);
            groupBoxRescue.Controls.Add(lblGA);
            groupBoxRescue.Controls.Add(lblFamily);
            groupBoxRescue.Controls.Add(lblDate);
            groupBoxRescue.Controls.Add(lblRescueNum);
            groupBoxRescue.Controls.Add(labelPlace);
            groupBoxRescue.Controls.Add(labelGA);
            groupBoxRescue.Controls.Add(labelFamily);
            groupBoxRescue.Controls.Add(labelDate);
            groupBoxRescue.Controls.Add(labelResNum);
            groupBoxRescue.Location = new Point(22, 92);
            groupBoxRescue.Name = "groupBoxRescue";
            groupBoxRescue.Size = new Size(360, 273);
            groupBoxRescue.TabIndex = 3;
            groupBoxRescue.TabStop = false;
            groupBoxRescue.Text = "Rescat";
            // 
            // lblPlace
            // 
            lblPlace.AutoSize = true;
            lblPlace.BackColor = SystemColors.ButtonHighlight;
            lblPlace.Location = new Point(212, 226);
            lblPlace.Name = "lblPlace";
            lblPlace.Size = new Size(129, 20);
            lblPlace.TabIndex = 9;
            lblPlace.Text = "                              ";
            // 
            // lblGA
            // 
            lblGA.AutoSize = true;
            lblGA.BackColor = SystemColors.ButtonHighlight;
            lblGA.Location = new Point(212, 185);
            lblGA.Name = "lblGA";
            lblGA.Size = new Size(129, 20);
            lblGA.TabIndex = 8;
            lblGA.Text = "                              ";
            // 
            // lblFamily
            // 
            lblFamily.AutoSize = true;
            lblFamily.BackColor = SystemColors.ButtonHighlight;
            lblFamily.Location = new Point(212, 142);
            lblFamily.Name = "lblFamily";
            lblFamily.Size = new Size(129, 20);
            lblFamily.TabIndex = 7;
            lblFamily.Text = "                              ";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = SystemColors.ButtonHighlight;
            lblDate.Location = new Point(212, 97);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(129, 20);
            lblDate.TabIndex = 6;
            lblDate.Text = "                              ";
            // 
            // lblRescueNum
            // 
            lblRescueNum.AutoSize = true;
            lblRescueNum.BackColor = SystemColors.ButtonHighlight;
            lblRescueNum.Location = new Point(212, 53);
            lblRescueNum.Name = "lblRescueNum";
            lblRescueNum.Size = new Size(129, 20);
            lblRescueNum.TabIndex = 5;
            lblRescueNum.Text = "                              ";
            // 
            // labelPlace
            // 
            labelPlace.AutoSize = true;
            labelPlace.Location = new Point(26, 226);
            labelPlace.Name = "labelPlace";
            labelPlace.Size = new Size(88, 20);
            labelPlace.TabIndex = 4;
            labelPlace.Text = "Localització";
            // 
            // labelGA
            // 
            labelGA.AutoSize = true;
            labelGA.Location = new Point(26, 185);
            labelGA.Name = "labelGA";
            labelGA.Size = new Size(29, 20);
            labelGA.TabIndex = 3;
            labelGA.Text = "GA";
            // 
            // labelFamily
            // 
            labelFamily.AutoSize = true;
            labelFamily.Location = new Point(26, 142);
            labelFamily.Name = "labelFamily";
            labelFamily.Size = new Size(93, 20);
            labelFamily.TabIndex = 2;
            labelFamily.Text = "Superfamília";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(26, 97);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(41, 20);
            labelDate.TabIndex = 1;
            labelDate.Text = "Data";
            // 
            // labelResNum
            // 
            labelResNum.AutoSize = true;
            labelResNum.Location = new Point(26, 53);
            labelResNum.Name = "labelResNum";
            labelResNum.Size = new Size(43, 20);
            labelResNum.TabIndex = 0;
            labelResNum.Text = "RES#";
            // 
            // groupBoxFile
            // 
            groupBoxFile.BackColor = Color.FromArgb(192, 255, 192);
            groupBoxFile.Controls.Add(label4);
            groupBoxFile.Controls.Add(label3);
            groupBoxFile.Controls.Add(label2);
            groupBoxFile.Controls.Add(label1);
            groupBoxFile.Controls.Add(labelWeight);
            groupBoxFile.Controls.Add(labelSpecies);
            groupBoxFile.Controls.Add(labelSF);
            groupBoxFile.Controls.Add(labelName);
            groupBoxFile.Location = new Point(388, 92);
            groupBoxFile.Name = "groupBoxFile";
            groupBoxFile.Size = new Size(360, 273);
            groupBoxFile.TabIndex = 4;
            groupBoxFile.TabStop = false;
            groupBoxFile.Text = "Fitxa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 185);
            label4.Name = "label4";
            label4.Size = new Size(30, 20);
            label4.TabIndex = 15;
            label4.Text = "Pes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 142);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 14;
            label3.Text = "Espècie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 97);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 10;
            label2.Text = "Superfamília";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 53);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 10;
            label1.Text = "Nom";
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.BackColor = SystemColors.ButtonHighlight;
            labelWeight.Location = new Point(213, 185);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(129, 20);
            labelWeight.TabIndex = 13;
            labelWeight.Text = "                              ";
            // 
            // labelSpecies
            // 
            labelSpecies.AutoSize = true;
            labelSpecies.BackColor = SystemColors.ButtonHighlight;
            labelSpecies.Location = new Point(213, 142);
            labelSpecies.Name = "labelSpecies";
            labelSpecies.Size = new Size(129, 20);
            labelSpecies.TabIndex = 12;
            labelSpecies.Text = "                              ";
            // 
            // labelSF
            // 
            labelSF.AutoSize = true;
            labelSF.BackColor = SystemColors.ButtonHighlight;
            labelSF.Location = new Point(213, 97);
            labelSF.Name = "labelSF";
            labelSF.Size = new Size(129, 20);
            labelSF.TabIndex = 11;
            labelSF.Text = "                              ";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = SystemColors.ButtonHighlight;
            labelName.Location = new Point(213, 53);
            labelName.Name = "labelName";
            labelName.Size = new Size(129, 20);
            labelName.TabIndex = 10;
            labelName.Text = "                              ";
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxFile);
            Controls.Add(groupBoxRescue);
            Controls.Add(labelWelcome);
            Controls.Add(bttnSaveCram);
            Controls.Add(bttnSaveHere);
            Name = "Game";
            Text = "SaveTheOcean2";
            Load += Game_Load;
            groupBoxRescue.ResumeLayout(false);
            groupBoxRescue.PerformLayout();
            groupBoxFile.ResumeLayout(false);
            groupBoxFile.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttnSaveHere;
        private Button bttnSaveCram;
        private Label labelWelcome;
        private GroupBox groupBoxRescue;
        private GroupBox groupBoxFile;
        private Label lblPlace;
        private Label lblGA;
        private Label lblFamily;
        private Label lblDate;
        private Label lblRescueNum;
        private Label labelPlace;
        private Label labelGA;
        private Label labelFamily;
        private Label labelDate;
        private Label labelResNum;
        private Label label1;
        private Label labelWeight;
        private Label labelSpecies;
        private Label labelSF;
        private Label labelName;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}