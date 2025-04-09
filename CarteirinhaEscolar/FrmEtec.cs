using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarteirinhaEscolar
{
    public partial class FrmEtec : Form
    {
        private System.Windows.Forms.TextBox txtBox7; // Replace 'object' with the correct type

        public FrmEtec()
        {
            InitializeComponent();
            txtBox7 = new System.Windows.Forms.TextBox(); // Initialize the TextBox
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                Title = "Selecione uma imagem",
                Filter = "Imagens (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgEtec.Image = Image.FromFile(openFileDialog.FileName);
                imgEtec.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            using var folderDialog = new FolderBrowserDialog
            {
                Description = "Selecione a pasta para salvar a carteirinha"
            };

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                textBox7.Text = folderDialog.SelectedPath;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFrente_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                Title = "Selecione o modelo da frente da carteirinha",
                Filter = "Imagens (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private string GetNome()
        {
            return txtNome.Text;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            // ========== PARTE DE TRÁS ==========
            if (pictureBox3.Image == null)
            {
                MessageBox.Show("Selecione o modelo da parte de trás da carteirinha.");
                return;
            }

            Bitmap baseVerso = new Bitmap(pictureBox3.Image);
            using (Graphics gVerso = Graphics.FromImage(baseVerso))
            {
                gVerso.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                gVerso.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                // Fonte do conteúdo
                Font fonteCampo = new Font("Arial", 17f, FontStyle.Regular);
                Font fontCodigo = new Font("IDAutomationHC39M", 30f);
                Brush pincel = Brushes.Black;

                // Dados
                string curso = txtCurso.Text;
                string matricula = txtMatr.Text;
                string emissao = txtEmiss.Text;
                string validade = txtData.Text;

                // Centralização
                float centroX = baseVerso.Width / 2;
                float yStart = 72;
                float espacoEntreGrupos = 84;

                StringFormat centralizadoVerso = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                // Curso (sem título)
                gVerso.DrawString(curso, fonteCampo, pincel,
                    new PointF(centroX, yStart + 24), centralizadoVerso);

                // Matrícula (sem título)
                gVerso.DrawString(matricula, fonteCampo, pincel,
                    new PointF(centroX, yStart + espacoEntreGrupos + 24), centralizadoVerso);

                // Emissão (sem título)
                gVerso.DrawString(emissao, fonteCampo, pincel,
                    new PointF(centroX, yStart + espacoEntreGrupos * 2 + 24), centralizadoVerso);

                // Validade (sem título)
                gVerso.DrawString(validade, fonteCampo, pincel,
                    new PointF(centroX, yStart + espacoEntreGrupos * 3 + 24), centralizadoVerso);
            }

            pictureBox3.Image = baseVerso;


            // ========== PARTE DA FRENTE ==========
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Selecione o modelo da frente da carteirinha.");
                return;
            }

            if (imgEtec.Image == null)
            {
                MessageBox.Show("Selecione a foto do aluno.");
                return;
            }

            // Carrega a imagem base do crachá
            Bitmap baseFrente = new Bitmap(pictureBox2.Image);
            using (Graphics gFrente = Graphics.FromImage(baseFrente))
            {
                gFrente.SmoothingMode = SmoothingMode.AntiAlias;
                gFrente.InterpolationMode = InterpolationMode.HighQualityBicubic;

                // Fontes (maiores e legíveis)
                Font fonteNome = new Font("Arial", 22f, FontStyle.Bold);
                Font fonteCargo = new Font("Arial", 16f, FontStyle.Regular);
                Brush pincel = Brushes.Black;

                // Textos digitados
                string nome = txtNome.Text;
                string cargo = txtCargo.Text;

                // Centralização
                float centroX = baseFrente.Width / 2;
                StringFormat centralizado = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                // ==== FOTO (ajustada para o quadrado cinza) ====
                int larguraFoto = 140;
                int alturaFoto = 170;
                int xFoto = (baseFrente.Width - larguraFoto) / 2;
                int yFoto = 245; // Alinha dentro do quadrado da imagem original

                gFrente.DrawImage(imgEtec.Image, xFoto, yFoto, larguraFoto, alturaFoto);

                // ==== TEXTOS ====
                float yNome = yFoto + alturaFoto + 25;   // abaixo da foto
                float yCargo = yNome + 40;

                gFrente.DrawString(nome, fonteNome, pincel, new PointF(centroX, yNome), centralizado);
                gFrente.DrawString(cargo, fonteCargo, pincel, new PointF(centroX, yCargo), centralizado);
            }

            // Atualiza o PictureBox com o novo crachá
            pictureBox2.Image = baseFrente;

        }

        private void btnVerso_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                Title = "Selecione o modelo do verso da carteirinha",
                Filter = "Imagens (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

                // (Opcional) Armazena o caminho para usar depois ao gerar o PDF    
                pictureBox3.Tag = openFileDialog.FileName;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmiss_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Obtenha o caminho da pasta de destino da TextBox txtBox7  
            string pastaDestino = textBox7.Text;

            // Verifique se a pasta de destino é válida  
            if (string.IsNullOrEmpty(pastaDestino) || !Directory.Exists(pastaDestino))
            {
                MessageBox.Show("A pasta de destino não é válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Salvar o conteúdo da PictureBox2  
            if (pictureBox2.Image != null)
            {
                try
                {
                    string nomeArquivo2 = Path.Combine(pastaDestino, "imagem_pb2_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png");
                    pictureBox2.Image.Save(nomeArquivo2, ImageFormat.Png);
                    MessageBox.Show($"Imagem da PictureBox2 salva em: {nomeArquivo2}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar a imagem da PictureBox2: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("A PictureBox2 está vazia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Salvar o conteúdo da PictureBox3  
            if (pictureBox3.Image != null)
            {
                try
                {
                    string nomeArquivo3 = Path.Combine(pastaDestino, "imagem_pb3_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png");
                    pictureBox3.Image.Save(nomeArquivo3, ImageFormat.Png);
                    MessageBox.Show($"Imagem da PictureBox3 salva em: {nomeArquivo3}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar a imagem da PictureBox3: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("A PictureBox3 está vazia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmEtec_Load(object sender, EventArgs e)
        {

        }
    }
}
