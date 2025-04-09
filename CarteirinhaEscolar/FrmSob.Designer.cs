namespace CarteirinhaEscolar
{
    partial class FrmSob
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Fluent Icons", 20F, FontStyle.Bold);
            label1.Location = new Point(36, 61);
            label1.Name = "label1";
            label1.Size = new Size(333, 27);
            label1.TabIndex = 0;
            label1.Text = "Sistema de ajuste de carteirinha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Fluent Icons", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 160);
            label2.Name = "label2";
            label2.Size = new Size(361, 20);
            label2.TabIndex = 1;
            label2.Text = "Desenvolvido para uso exclusivo da Fatec Itu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 305);
            label3.Name = "label3";
            label3.Size = new Size(166, 15);
            label3.TabIndex = 2;
            label3.Text = "©Todos os direitos reservados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 305);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "2025";
            // 
            // FrmSob
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 391);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmSob";
            Text = "Sobre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}