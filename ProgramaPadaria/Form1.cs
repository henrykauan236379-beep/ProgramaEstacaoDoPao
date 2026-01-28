using System.Windows.Forms;

namespace ProgramaPadaria
{
    public partial class frmName : Form
    {
        decimal valorVendaAtual = 0;
        int contadorVendas = 0;
        public frmName()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valorVendaAtual > 0)
            {
                contadorVendas++;

                lstVendas.Items.Add(
                    $"Venda {contadorVendas} - {valorVendaAtual.ToString("C")}"
                    );

                // Zerar venda atual
                valorVendaAtual = 0;
                lblValor.Text = "0,00";
                txtValorVenda.Clear();

            }
            else
            {
                MessageBox.Show("nenhuma venda iniciada.");
            }
        }

        private void lblValor_Click(object sender, EventArgs e)
        {

        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtValorVenda.Text, out valorVendaAtual))
            {
                lblValor.Text = valorVendaAtual.ToString("C");
            }
            else
            {
                MessageBox.Show("Digite um valor válido.");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
