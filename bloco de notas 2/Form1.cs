using Microsoft.VisualBasic.ApplicationServices;

namespace bloco_de_notas_2
{
    public partial class Form1 : Form
    {
        string nomeArquivo = ("C:\\");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frmSobre = new frmSobre();
            frmSobre.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*) |*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, rtbConteudo.Text);
            }

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("C:\\");
            // DialogResult retorno = MessageBox.Show("Tem certeza que deseja criar um novo arquivo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            DialogResult retorno = MessageBox.Show("Tem certeza que deseja criar um novo arquivo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (retorno == DialogResult.Yes)
            {

                rtbConteudo.Clear();
            }

            else if (retorno == DialogResult.No)
            {

                return;
            }


        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            if (fd.ShowDialog() == DialogResult.OK)
                this.rtbConteudo.Font = fd.Font;
        }

        private void rtbConteudo_TextChanged(object sender, EventArgs e)
        {


        }

        private void formatarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*) |*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbConteudo.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbConteudo.Text);
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbConteudo.Text = Clipboard.GetText();

        }
    }
}