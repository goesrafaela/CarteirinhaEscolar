using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace CarteirinhaEscolar
{
    public partial class FrmAluno : Form
    {
        public FrmAluno()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtPDF.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Selecione a pasta onde o arquivo será salvo";
                folderDialog.ShowNewFolderButton = true;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSaida.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string pdfPath = txtPDF.Text;
            string outputPath = txtSaida.Text;

            try
            {
                if (string.IsNullOrEmpty(pdfPath) || string.IsNullOrEmpty(outputPath))
                {
                    MessageBox.Show("Por favor, selecione o arquivo PDF e a pasta de saída.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Dimensão da carteirinha em pontos (1 polegada = 72 pontos)
                float width = (float)(8.5 / 2.54 * 72);  // 8.5 cm
                float height = (float)(5.4 / 2.54 * 72); // 5.4 cm

                string novoArquivo = Path.Combine(outputPath, "carteirinha_redimensionada.pdf");

                using (PdfReader reader = new PdfReader(pdfPath))
                {
                    using (FileStream fs = new FileStream(novoArquivo, FileMode.Create, FileAccess.Write))
                    {
                        // Use iTextSharp's Rectangle class instead of System.Drawing.Rectangle
                        using (Document doc = new Document(new iTextSharp.text.Rectangle(width, height)))
                        {
                            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                            doc.Open();

                            PdfContentByte cb = writer.DirectContent;
                            PdfImportedPage page = writer.GetImportedPage(reader, 1);

                            // Centraliza o conteúdo na nova página menor
                            float scale = Math.Min(width / reader.GetPageSize(1).Width, height / reader.GetPageSize(1).Height);
                            float offsetX = (width - reader.GetPageSize(1).Width * scale) / 2;
                            float offsetY = (height - reader.GetPageSize(1).Height * scale) / 2;

                            cb.AddTemplate(page, scale, 0, 0, scale, offsetX, offsetY);
                            doc.Close();
                        }
                    }
                }

                MessageBox.Show("PDF redimensionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar o PDF: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmAluno_Load(object sender, EventArgs e)
        {

        }
    }
}
