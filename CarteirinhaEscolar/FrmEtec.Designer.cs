namespace CarteirinhaEscolar
{
    partial class FrmEtec
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
            txtNome = new TextBox();
            txtCargo = new TextBox();
            txtMatr = new TextBox();
            txtCurso = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtEmiss = new TextBox();
            label8 = new Label();
            txtData = new TextBox();
            label9 = new Label();
            imgEtec = new PictureBox();
            btnSelect = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label10 = new Label();
            btnPasta = new Button();
            textBox7 = new TextBox();
            btnSalvar = new Button();
            btnGerar = new Button();
            btnVerso = new Button();
            btnFrente = new Button();
            ((System.ComponentModel.ISupportInitialize)imgEtec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.Location = new Point(126, 43);
            label1.Name = "label1";
            label1.Size = new Size(354, 46);
            label1.TabIndex = 0;
            label1.Text = "Dados Básico(frente)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label2.Location = new Point(850, 35);
            label2.Name = "label2";
            label2.Size = new Size(343, 46);
            label2.TabIndex = 1;
            label2.Text = "Dados Básico(verso)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(101, 124);
            label3.Name = "label3";
            label3.Size = new Size(69, 28);
            label3.TabIndex = 2;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.Location = new Point(103, 161);
            label4.Name = "label4";
            label4.Size = new Size(67, 28);
            label4.TabIndex = 3;
            label4.Text = "Cargo";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(228, 129);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(236, 23);
            txtNome.TabIndex = 4;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(228, 169);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(236, 23);
            txtCargo.TabIndex = 5;
            txtCargo.TextChanged += txtCargo_TextChanged;
            // 
            // txtMatr
            // 
            txtMatr.Location = new Point(1024, 140);
            txtMatr.Name = "txtMatr";
            txtMatr.Size = new Size(236, 23);
            txtMatr.TabIndex = 9;
            txtMatr.TextChanged += txtMatr_TextChanged;
            // 
            // txtCurso
            // 
            txtCurso.Location = new Point(1024, 100);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(236, 23);
            txtCurso.TabIndex = 8;
            txtCurso.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.Location = new Point(800, 139);
            label5.Name = "label5";
            label5.Size = new Size(217, 28);
            label5.TabIndex = 7;
            label5.Text = "Registro de Matrícula";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label6.Location = new Point(800, 94);
            label6.Name = "label6";
            label6.Size = new Size(201, 28);
            label6.TabIndex = 6;
            label6.Text = "Curso/Turma/Grupo";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label7.Location = new Point(800, 183);
            label7.Name = "label7";
            label7.Size = new Size(168, 28);
            label7.TabIndex = 10;
            label7.Text = "Data de Emissão";
            // 
            // txtEmiss
            // 
            txtEmiss.Location = new Point(1024, 186);
            txtEmiss.Name = "txtEmiss";
            txtEmiss.Size = new Size(236, 23);
            txtEmiss.TabIndex = 11;
            txtEmiss.TextChanged += txtEmiss_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label8.Location = new Point(800, 231);
            label8.Name = "label8";
            label8.Size = new Size(178, 28);
            label8.TabIndex = 12;
            label8.Text = "Data de Vallidade";
            // 
            // txtData
            // 
            txtData.Location = new Point(1024, 231);
            txtData.Name = "txtData";
            txtData.Size = new Size(236, 23);
            txtData.TabIndex = 13;
            txtData.TextChanged += txtData_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label9.Location = new Point(261, 300);
            label9.Name = "label9";
            label9.Size = new Size(110, 28);
            label9.TabIndex = 14;
            label9.Text = "Fotografia";
            // 
            // imgEtec
            // 
            imgEtec.BorderStyle = BorderStyle.Fixed3D;
            imgEtec.Location = new Point(225, 345);
            imgEtec.Name = "imgEtec";
            imgEtec.Size = new Size(190, 273);
            imgEtec.TabIndex = 15;
            imgEtec.TabStop = false;
            imgEtec.Click += pictureBox1_Click;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.Navy;
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(225, 634);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(190, 34);
            btnSelect.TabIndex = 16;
            btnSelect.Text = "Selecionar Imagem";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(646, 345);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(265, 435);
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Location = new Point(938, 345);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(265, 435);
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label10.Location = new Point(885, 300);
            label10.Name = "label10";
            label10.Size = new Size(71, 28);
            label10.TabIndex = 19;
            label10.Text = "Prévia";
            // 
            // btnPasta
            // 
            btnPasta.BackColor = Color.Navy;
            btnPasta.ForeColor = Color.White;
            btnPasta.Location = new Point(1209, 345);
            btnPasta.Name = "btnPasta";
            btnPasta.Size = new Size(117, 36);
            btnPasta.TabIndex = 20;
            btnPasta.Text = "Selecione a pasta";
            btnPasta.UseVisualStyleBackColor = false;
            btnPasta.Click += btnPasta_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(646, 802);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(557, 23);
            textBox7.TabIndex = 21;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Green;
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(1209, 578);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(117, 40);
            btnSalvar.TabIndex = 27;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnGerar
            // 
            btnGerar.BackColor = Color.Teal;
            btnGerar.ForeColor = Color.White;
            btnGerar.Location = new Point(1209, 516);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(117, 40);
            btnGerar.TabIndex = 26;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = false;
            btnGerar.Click += btnGerar_Click;
            // 
            // btnVerso
            // 
            btnVerso.BackColor = Color.Navy;
            btnVerso.ForeColor = Color.White;
            btnVerso.Location = new Point(1209, 449);
            btnVerso.Name = "btnVerso";
            btnVerso.Size = new Size(117, 40);
            btnVerso.TabIndex = 25;
            btnVerso.Text = "Selecionar Verso";
            btnVerso.UseVisualStyleBackColor = false;
            btnVerso.Click += btnVerso_Click;
            // 
            // btnFrente
            // 
            btnFrente.BackColor = Color.Navy;
            btnFrente.ForeColor = Color.White;
            btnFrente.Location = new Point(1209, 403);
            btnFrente.Name = "btnFrente";
            btnFrente.Size = new Size(117, 40);
            btnFrente.TabIndex = 24;
            btnFrente.Text = "Selecionar Frente";
            btnFrente.UseVisualStyleBackColor = false;
            btnFrente.Click += btnFrente_Click;
            // 
            // FrmEtec
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 886);
            Controls.Add(btnSalvar);
            Controls.Add(btnGerar);
            Controls.Add(btnVerso);
            Controls.Add(btnFrente);
            Controls.Add(textBox7);
            Controls.Add(btnPasta);
            Controls.Add(label10);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnSelect);
            Controls.Add(imgEtec);
            Controls.Add(label9);
            Controls.Add(txtData);
            Controls.Add(label8);
            Controls.Add(txtEmiss);
            Controls.Add(label7);
            Controls.Add(txtMatr);
            Controls.Add(txtCurso);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtCargo);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmEtec";
            Text = "Geração Cartão Etec";
            Load += FrmEtec_Load;
            ((System.ComponentModel.ISupportInitialize)imgEtec).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtCargo;
        private TextBox txtMatr;
        private TextBox txtCurso;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtEmiss;
        private Label label8;
        private TextBox txtData;
        private Label label9;
        private PictureBox imgEtec;
        private Button btnSelect;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label10;
        private Button btnPasta;
        private TextBox textBox7;
        private Button btnSalvar;
        private Button btnGerar;
        private Button btnVerso;
        private Button btnFrente;
    }
}