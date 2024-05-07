namespace SalvaOceano
{
    partial class ChooseRole
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
            TXT_Name = new TextBox();
            BTN_Next = new Button();
            CB_Rol = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 105);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // TXT_Name
            // 
            TXT_Name.Location = new Point(301, 102);
            TXT_Name.Name = "TXT_Name";
            TXT_Name.Size = new Size(125, 27);
            TXT_Name.TabIndex = 3;
            // 
            // BTN_Next
            // 
            BTN_Next.Location = new Point(666, 387);
            BTN_Next.Name = "BTN_Next";
            BTN_Next.Size = new Size(94, 29);
            BTN_Next.TabIndex = 4;
            BTN_Next.Text = "Next";
            BTN_Next.UseVisualStyleBackColor = true;
            BTN_Next.Click += BTN_Next_Click;
            // 
            // CB_Rol
            // 
            CB_Rol.FormattingEnabled = true;
            CB_Rol.Items.AddRange(new object[] { "Veterinario", "Tecnico" });
            CB_Rol.Location = new Point(258, 158);
            CB_Rol.Name = "CB_Rol";
            CB_Rol.Size = new Size(151, 28);
            CB_Rol.TabIndex = 5;
            // 
            // EscogerRol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CB_Rol);
            Controls.Add(BTN_Next);
            Controls.Add(TXT_Name);
            Controls.Add(label1);
            Name = "EscogerRol";
            Text = "EscogerRol";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN_Next;
        private Button button2;
        private Label label1;
        private TextBox TXT_Name;
        private ComboBox CB_Rol;
    }
}