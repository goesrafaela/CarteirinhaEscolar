namespace CarteirinhaEscolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void impirmirToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void cartãoEstudanteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void recortarPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAluno frm = new FrmAluno();
            frm.ShowDialog();
        }

        private void gerarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFunc frm = new FrmFunc();
            frm.ShowDialog();
        }

        private void etecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEtec frm = new FrmEtec();
            frm.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmSob frm = new FrmSob();
            frm.ShowDialog();
        }

        private void conjuntoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConj frm = new FrmConj();
            frm.ShowDialog();
        }
    }
}
