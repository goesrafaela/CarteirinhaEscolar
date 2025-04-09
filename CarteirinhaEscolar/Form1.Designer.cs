namespace CarteirinhaEscolar
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
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            cartãoEstudanteToolStripMenuItem = new ToolStripMenuItem();
            recortarPDFToolStripMenuItem = new ToolStripMenuItem();
            etecToolStripMenuItem = new ToolStripMenuItem();
            conjuntoToolStripMenuItem = new ToolStripMenuItem();
            cartãoFuncionárioToolStripMenuItem = new ToolStripMenuItem();
            gerarNovoToolStripMenuItem = new ToolStripMenuItem();
            conjuntoToolStripMenuItem1 = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 15F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1359, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cartãoEstudanteToolStripMenuItem, cartãoFuncionárioToolStripMenuItem });
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(71, 32);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // cartãoEstudanteToolStripMenuItem
            // 
            cartãoEstudanteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { recortarPDFToolStripMenuItem, etecToolStripMenuItem, conjuntoToolStripMenuItem });
            cartãoEstudanteToolStripMenuItem.Name = "cartãoEstudanteToolStripMenuItem";
            cartãoEstudanteToolStripMenuItem.Size = new Size(250, 32);
            cartãoEstudanteToolStripMenuItem.Text = "Cartão Estudante";
            cartãoEstudanteToolStripMenuItem.Click += cartãoEstudanteToolStripMenuItem_Click;
            // 
            // recortarPDFToolStripMenuItem
            // 
            recortarPDFToolStripMenuItem.Name = "recortarPDFToolStripMenuItem";
            recortarPDFToolStripMenuItem.Size = new Size(180, 32);
            recortarPDFToolStripMenuItem.Text = "Fatec";
            recortarPDFToolStripMenuItem.Click += recortarPDFToolStripMenuItem_Click;
            // 
            // etecToolStripMenuItem
            // 
            etecToolStripMenuItem.Name = "etecToolStripMenuItem";
            etecToolStripMenuItem.Size = new Size(180, 32);
            etecToolStripMenuItem.Text = "Etec";
            etecToolStripMenuItem.Click += etecToolStripMenuItem_Click;
            // 
            // conjuntoToolStripMenuItem
            // 
            conjuntoToolStripMenuItem.Name = "conjuntoToolStripMenuItem";
            conjuntoToolStripMenuItem.Size = new Size(180, 32);
            conjuntoToolStripMenuItem.Text = "Conjunto";
            conjuntoToolStripMenuItem.Click += conjuntoToolStripMenuItem_Click;
            // 
            // cartãoFuncionárioToolStripMenuItem
            // 
            cartãoFuncionárioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerarNovoToolStripMenuItem, conjuntoToolStripMenuItem1 });
            cartãoFuncionárioToolStripMenuItem.Name = "cartãoFuncionárioToolStripMenuItem";
            cartãoFuncionárioToolStripMenuItem.Size = new Size(250, 32);
            cartãoFuncionárioToolStripMenuItem.Text = "Cartão Funcionário";
            // 
            // gerarNovoToolStripMenuItem
            // 
            gerarNovoToolStripMenuItem.Name = "gerarNovoToolStripMenuItem";
            gerarNovoToolStripMenuItem.Size = new Size(182, 32);
            gerarNovoToolStripMenuItem.Text = "Gerar novo";
            gerarNovoToolStripMenuItem.Click += gerarNovoToolStripMenuItem_Click;
            // 
            // conjuntoToolStripMenuItem1
            // 
            conjuntoToolStripMenuItem1.Name = "conjuntoToolStripMenuItem1";
            conjuntoToolStripMenuItem1.Size = new Size(182, 32);
            conjuntoToolStripMenuItem1.Text = "Conjunto";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(76, 32);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ChatGPT_Image_7_de_abr__de_2025__07_43_09;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1359, 803);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Sistema de Impressão de carteirinha Fatec Itu - Versão 2.0";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem cartãoEstudanteToolStripMenuItem;
        private ToolStripMenuItem cartãoFuncionárioToolStripMenuItem;
        private ToolStripMenuItem recortarPDFToolStripMenuItem;
        private ToolStripMenuItem gerarNovoToolStripMenuItem;
        private ToolStripMenuItem etecToolStripMenuItem;
        private ToolStripMenuItem conjuntoToolStripMenuItem;
        private ToolStripMenuItem conjuntoToolStripMenuItem1;
        private ToolStripMenuItem sobreToolStripMenuItem;
    }
}
