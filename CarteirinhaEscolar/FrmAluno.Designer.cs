namespace CarteirinhaEscolar
{
    partial class FrmAluno
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
            txtPDF = new TextBox();
            label2 = new Label();
            txtSaida = new TextBox();
            btnArquivo = new Button();
            btnPasta = new Button();
            btnGerar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(79, 113);
            label1.Name = "label1";
            label1.Size = new Size(183, 37);
            label1.TabIndex = 0;
            label1.Text = "Local do PDF";
            // 
            // txtPDF
            // 
            txtPDF.Location = new Point(294, 127);
            txtPDF.Name = "txtPDF";
            txtPDF.Size = new Size(240, 23);
            txtPDF.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(79, 202);
            label2.Name = "label2";
            label2.Size = new Size(199, 37);
            label2.TabIndex = 2;
            label2.Text = "Pasta de saída";
            label2.Click += label2_Click;
            // 
            // txtSaida
            // 
            txtSaida.Location = new Point(294, 216);
            txtSaida.Name = "txtSaida";
            txtSaida.Size = new Size(240, 23);
            txtSaida.TabIndex = 3;
            // 
            // btnArquivo
            // 
            btnArquivo.BackColor = Color.Navy;
            btnArquivo.ForeColor = Color.FromArgb(255, 192, 128);
            btnArquivo.Location = new Point(560, 119);
            btnArquivo.Name = "btnArquivo";
            btnArquivo.Size = new Size(120, 39);
            btnArquivo.TabIndex = 4;
            btnArquivo.Text = "Selecionar Arquivo";
            btnArquivo.UseVisualStyleBackColor = false;
            btnArquivo.Click += btnArquivo_Click;
            // 
            // btnPasta
            // 
            btnPasta.BackColor = Color.Teal;
            btnPasta.ForeColor = Color.White;
            btnPasta.Location = new Point(560, 207);
            btnPasta.Name = "btnPasta";
            btnPasta.Size = new Size(120, 39);
            btnPasta.TabIndex = 5;
            btnPasta.Text = "Selecionar Pasta";
            btnPasta.UseVisualStyleBackColor = false;
            btnPasta.Click += btnPasta_Click;
            // 
            // btnGerar
            // 
            btnGerar.BackColor = Color.Green;
            btnGerar.ForeColor = Color.White;
            btnGerar.Location = new Point(346, 350);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(136, 54);
            btnGerar.TabIndex = 6;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = false;
            btnGerar.Click += btnGerar_Click;
            // 
            // FrmAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGerar);
            Controls.Add(btnPasta);
            Controls.Add(btnArquivo);
            Controls.Add(txtSaida);
            Controls.Add(label2);
            Controls.Add(txtPDF);
            Controls.Add(label1);
            Name = "FrmAluno";
            Text = "Recortar PDF";
            Load += FrmAluno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPDF;
        private Label label2;
        private TextBox txtSaida;
        private Button btnArquivo;
        private Button btnPasta;
        private Button btnGerar;
    }
}