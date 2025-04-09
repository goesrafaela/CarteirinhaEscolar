namespace CarteirinhaEscolar
{
    partial class FrmFunc
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
            txtNome = new TextBox();
            txtCargo = new TextBox();
            label4 = new Label();
            txtMatr = new TextBox();
            txtNomeCom = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtData = new TextBox();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            btnFoto = new Button();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnFrente = new Button();
            btnVerso = new Button();
            txtDestino = new TextBox();
            btnPasta = new Button();
            btnGerar = new Button();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(127, 28);
            label1.Name = "label1";
            label1.Size = new Size(308, 37);
            label1.TabIndex = 0;
            label1.Text = "Dados Básicos (Frente)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(140, 96);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(142, 148);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 2;
            label3.Text = "Cargo";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(245, 104);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(219, 23);
            txtNome.TabIndex = 3;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(245, 156);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(219, 23);
            txtCargo.TabIndex = 4;
            txtCargo.TextChanged += txtCargo_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label4.Location = new Point(669, 28);
            label4.Name = "label4";
            label4.Size = new Size(297, 37);
            label4.TabIndex = 5;
            label4.Text = "Dados Básicos (Verso)";
            label4.Click += label4_Click;
            // 
            // txtMatr
            // 
            txtMatr.Location = new Point(869, 153);
            txtMatr.Name = "txtMatr";
            txtMatr.Size = new Size(219, 23);
            txtMatr.TabIndex = 9;
            txtMatr.TextChanged += txtMatr_TextChanged;
            // 
            // txtNomeCom
            // 
            txtNomeCom.Location = new Point(869, 101);
            txtNomeCom.Name = "txtNomeCom";
            txtNomeCom.Size = new Size(219, 23);
            txtNomeCom.TabIndex = 8;
            txtNomeCom.TextChanged += txtNomeCom_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.Location = new Point(644, 148);
            label5.Name = "label5";
            label5.Size = new Size(103, 28);
            label5.TabIndex = 7;
            label5.Text = "Matrícula";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label6.Location = new Point(642, 96);
            label6.Name = "label6";
            label6.Size = new Size(166, 28);
            label6.TabIndex = 6;
            label6.Text = "Nome Completo";
            // 
            // txtData
            // 
            txtData.Location = new Point(869, 209);
            txtData.Name = "txtData";
            txtData.Size = new Size(219, 23);
            txtData.TabIndex = 11;
            txtData.TextChanged += txtData_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label7.Location = new Point(644, 204);
            label7.Name = "label7";
            label7.Size = new Size(207, 28);
            label7.TabIndex = 10;
            label7.Text = "Data de Contratação";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label8.Location = new Point(220, 304);
            label8.Name = "label8";
            label8.Size = new Size(110, 28);
            label8.TabIndex = 12;
            label8.Text = "Fotografia";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(189, 349);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 255);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnFoto
            // 
            btnFoto.BackColor = Color.Navy;
            btnFoto.ForeColor = Color.White;
            btnFoto.Location = new Point(189, 621);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(176, 30);
            btnFoto.TabIndex = 14;
            btnFoto.Text = "Selecionar imagem";
            btnFoto.UseVisualStyleBackColor = false;
            btnFoto.Click += btnFoto_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label9.Location = new Point(817, 318);
            label9.Name = "label9";
            label9.Size = new Size(71, 28);
            label9.TabIndex = 15;
            label9.Text = "Prévia";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(555, 349);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(287, 430);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.WaitOnLoad = true;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Location = new Point(869, 349);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(287, 430);
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // btnFrente
            // 
            btnFrente.BackColor = Color.Navy;
            btnFrente.ForeColor = Color.White;
            btnFrente.Location = new Point(1181, 455);
            btnFrente.Name = "btnFrente";
            btnFrente.Size = new Size(117, 40);
            btnFrente.TabIndex = 18;
            btnFrente.Text = "Selecionar Frente";
            btnFrente.UseVisualStyleBackColor = false;
            btnFrente.Click += btnFrente_Click;
            // 
            // btnVerso
            // 
            btnVerso.BackColor = Color.Navy;
            btnVerso.ForeColor = Color.White;
            btnVerso.Location = new Point(1181, 501);
            btnVerso.Name = "btnVerso";
            btnVerso.Size = new Size(117, 40);
            btnVerso.TabIndex = 19;
            btnVerso.Text = "Selecionar Verso";
            btnVerso.UseVisualStyleBackColor = false;
            btnVerso.Click += btnVerso_Click;
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(555, 795);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(601, 23);
            txtDestino.TabIndex = 20;
            // 
            // btnPasta
            // 
            btnPasta.BackColor = Color.Navy;
            btnPasta.ForeColor = Color.White;
            btnPasta.Location = new Point(1181, 349);
            btnPasta.Name = "btnPasta";
            btnPasta.Size = new Size(117, 40);
            btnPasta.TabIndex = 21;
            btnPasta.Text = "Selecionar pasta";
            btnPasta.UseVisualStyleBackColor = false;
            btnPasta.Click += btnPasta_Click;
            // 
            // btnGerar
            // 
            btnGerar.BackColor = Color.Teal;
            btnGerar.ForeColor = Color.White;
            btnGerar.Location = new Point(1181, 576);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(117, 40);
            btnGerar.TabIndex = 22;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = false;
            btnGerar.Click += btnGerar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Green;
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(1181, 646);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(117, 40);
            btnSalvar.TabIndex = 23;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FrmFunc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 837);
            Controls.Add(btnSalvar);
            Controls.Add(btnGerar);
            Controls.Add(btnPasta);
            Controls.Add(txtDestino);
            Controls.Add(btnVerso);
            Controls.Add(btnFrente);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label9);
            Controls.Add(btnFoto);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(txtData);
            Controls.Add(label7);
            Controls.Add(txtMatr);
            Controls.Add(txtNomeCom);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtCargo);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmFunc";
            Text = "Geração de cartão de Funcionário";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtCargo;
        private Label label4;
        private TextBox txtMatr;
        private TextBox txtNomeCom;
        private Label label5;
        private Label label6;
        private TextBox txtData;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private Button btnFoto;
        private Label label9;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnFrente;
        private Button btnVerso;
        private TextBox txtDestino;
        private Button btnPasta;
        private Button btnGerar;
        private Button btnSalvar;
    }
}