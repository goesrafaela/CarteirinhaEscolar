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

        // The issue is caused by a missing closing brace for the `btnGerar_Click` method.  
        // Below is the corrected code with the missing closing brace added.

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
                gVerso.SmoothingMode = SmoothingMode.AntiAlias;
                gVerso.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gVerso.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

                // Fonte e pincel  
                Font fonteCampo = new Font("Arial", 17f, FontStyle.Regular);
                Brush pincel = Brushes.Black;
                StringFormat centralizadoVerso = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                // Dados  
                string curso = txtCurso.Text;
                string matricula = txtMatr.Text;
                string emissao = txtEmiss.Text;
                string validade = txtData.Text;

                // Posições dos retângulos (baseado na imagem de referência)  
                gVerso.DrawString(curso, fonteCampo, pincel, new RectangleF(100, 80, 310, 40), centralizadoVerso);
                gVerso.DrawString(matricula, fonteCampo, pincel, new RectangleF(100, 145, 310, 40), centralizadoVerso);
                gVerso.DrawString(emissao, fonteCampo, pincel, new RectangleF(100, 210, 310, 40), centralizadoVerso);
                gVerso.DrawString(validade, fonteCampo, pincel, new RectangleF(100, 275, 310, 40), centralizadoVerso);
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

            Bitmap baseFrente = new Bitmap(pictureBox2.Image);
            using (Graphics gFrente = Graphics.FromImage(baseFrente))
            {
                gFrente.SmoothingMode = SmoothingMode.AntiAlias;
                gFrente.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gFrente.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

                // Configuração de fontes (ajustadas para match com a primeira imagem)
                Font fonteNome = new Font("Arial", 14, FontStyle.Bold);      // Aumentado para 14pt
                Font fonteCargo = new Font("Arial", 11, FontStyle.Regular);  // Aumentado para 11pt
                Brush pincel = Brushes.Black;

                // Centralização  
                float centroX = baseFrente.Width / 2;
                StringFormat centralizado = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                // === FOTO CENTRALIZADA ===  
                if (imgEtec.Image != null)
                {
                    // Dimensões ajustadas para match com a primeira imagem
                    int larguraFoto = 130;  // Reduzido de 140 para 130
                    int alturaFoto = 160;   // Reduzido de 170 para 160

                    // Posicionamento vertical ajustado (removido o -50)
                    int xFoto = (baseFrente.Width - larguraFoto) / 2;
                    int yFoto = (baseFrente.Height - alturaFoto) / 3; // Ajuste para posição mais alta

                    Image originalFoto = imgEtec.Image;

                    // Mantém o aspect ratio original
                    float ratioDestino = (float)larguraFoto / alturaFoto;
                    float ratioOriginal = (float)originalFoto.Width / originalFoto.Height;

                    Rectangle srcRect;
                    if (ratioOriginal > ratioDestino)
                    {
                        int larguraCrop = (int)(originalFoto.Height * ratioDestino);
                        int xCrop = (originalFoto.Width - larguraCrop) / 2;
                        srcRect = new Rectangle(xCrop, 0, larguraCrop, originalFoto.Height);
                    }
                    else
                    {
                        int alturaCrop = (int)(originalFoto.Width / ratioDestino);
                        int yCrop = (originalFoto.Height - alturaCrop) / 2;
                        srcRect = new Rectangle(0, yCrop, originalFoto.Width, alturaCrop);
                    }

                    // Desenha a imagem
                    gFrente.DrawImage(originalFoto,
                                     new Rectangle(xFoto, yFoto, larguraFoto, alturaFoto),
                                     srcRect,
                                     GraphicsUnit.Pixel);

                    // === TEXTOS ABAIXO DA FOTO ===  
                    float espacoAbaixoFoto = 20;  // Reduzido o espaçamento
                    float espacoEntreLinhas = 15; // Reduzido o espaçamento

                    float posYNome = yFoto + alturaFoto + espacoAbaixoFoto;
                    float posYCargo = posYNome + fonteNome.Height + espacoEntreLinhas;

                    // Desenha os textos (ajuste para caixa alta e centralização)
                    gFrente.DrawString(txtNome.Text.ToUpper(), fonteNome, pincel,
                                      new PointF(centroX, posYNome), centralizado);
                    gFrente.DrawString(txtCargo.Text.ToUpper(), fonteCargo, pincel,
                                      new PointF(centroX, posYCargo), centralizado);
                }

                pictureBox2.Image = baseFrente;
            }
            
        }
         // Added this missing closing brace to fix the error.
       
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

