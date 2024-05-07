namespace SalvaOceano
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            play = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(143, 51);
            label1.Name = "label1";
            label1.Size = new Size(579, 106);
            label1.TabIndex = 0;
            label1.Text = "Save the ocean";
            // 
            // play
            // 
            play.Location = new Point(257, 246);
            play.Name = "play";
            play.Size = new Size(94, 29);
            play.TabIndex = 1;
            play.Text = "Jugar";
            play.UseVisualStyleBackColor = true;
            play.Click += play_Click;
            // 
            // exit
            // 
            exit.Location = new Point(494, 246);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 2;
            exit.Text = "Salir";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exit);
            Controls.Add(play);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button play;
        private Button exit;
    }
}
