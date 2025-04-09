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
    public partial class FrmFunc : Form
    {
        private int yFoto;

        public FrmFunc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeCom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Selecione a foto do aluno";
                openFileDialog.Filter = "Imagens (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Ajusta para preencher o espaço do PictureBox
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

        private void btnVerso_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Selecione o modelo do verso da carteirinha";
                openFileDialog.Filter = "Imagens (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox3.Image = Image.FromFile(openFileDialog.FileName);
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

                    // (Opcional) Armazena o caminho para usar depois ao gerar o PDF
                    pictureBox3.Tag = openFileDialog.FileName;
                }
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            // ====== PARTE DA FRENTE ======
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Selecione o modelo da parte da frente da carteirinha.");
                return;
            }

            Bitmap baseFrente = new Bitmap(pictureBox2.Image);
            using (Graphics gFrente = Graphics.FromImage(baseFrente))
            {
                gFrente.SmoothingMode = SmoothingMode.AntiAlias;
                gFrente.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gFrente.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

                // Configurações de fonte
                Font fonteNome = new Font("Arial", 22f, FontStyle.Bold);
                Font fonteCargo = new Font("Arial", 16f, FontStyle.Regular);
                Brush pincel = Brushes.Black;

                string nome = txtNome.Text;
                string cargo = txtCargo.Text;

                // Centralização
                float centroX = baseFrente.Width / 2;
                StringFormat centralizado = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                // === FOTO CENTRALIZADA NO QUADRADO CINZA ===
                if (pictureBox1.Image != null)
                {
                    // Dimensões ajustadas para o template
                    int larguraFoto = 140;
                    int alturaFoto = 170;
                    int xFoto = (baseFrente.Width - larguraFoto) / 2;
                    int yFoto = 220; // Posição Y ajustada para o template

                    gFrente.DrawImage(pictureBox1.Image, xFoto, yFoto, larguraFoto, alturaFoto);
                }

                // === TEXTOS ABAIXO DA FOTO CENTRALIZADOS ===
                float posYNome = 420; // Posição fixa para o nome no template
                float posYCargo = 460; // Posição fixa para o cargo no template

                gFrente.DrawString(nome, fonteNome, pincel, new PointF(centroX, posYNome), centralizado);
                gFrente.DrawString(cargo, fonteCargo, pincel, new PointF(centroX, posYCargo), centralizado);
            }

            pictureBox2.Image = baseFrente;

            // ====== PARTE DE TRÁS ======
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

                // Configurações de fonte
                Font fonteCampo = new Font("Arial", 14f, FontStyle.Regular); // Usando a mesma fonte para centralizar melhor
                Brush pincel = Brushes.Black;

                string nomeCompleto = txtNomeCom.Text;
                string matricula = txtMatr.Text;
                string dataContratacao = txtData.Text;

                float centroX = baseVerso.Width / 2;

                StringFormat centralizadoRetangulo = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                // *** AJUSTE MANUAL PARA SUBIR O TEXTO ***
                float ajusteSubir = 25f; // Experimente valores como 5, 8, 10...

                float yRetanguloNomeCentro = 165f - ajusteSubir;
                float yRetanguloMatriculaCentro = 225f - ajusteSubir;
                float yRetanguloDataCentro = 285f - ajusteSubir;

                // Desenha os campos centralizados nos retângulos
                gVerso.DrawString(nomeCompleto, fonteCampo, pincel, new PointF(centroX, yRetanguloNomeCentro), centralizadoRetangulo);
                gVerso.DrawString(matricula, fonteCampo, pincel, new PointF(centroX, yRetanguloMatriculaCentro), centralizadoRetangulo);
                gVerso.DrawString(dataContratacao, fonteCampo, pincel, new PointF(centroX, yRetanguloDataCentro), centralizadoRetangulo);
            }

            pictureBox3.Image = baseVerso;
        }
        private void btnPasta_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Selecione a pasta onde o arquivo será salvo";
                folderDialog.ShowNewFolderButton = true;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDestino.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Obtenha o caminho da pasta de destino da TextBox txtBox7  
            string pastaDestino = txtDestino.Text;

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
    }
}
