using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace ProgramaPadaria
{
    public partial class frmName : Form
    {
        List<decimal> vendas = new List<decimal>();

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
                vendas.Add(valorVendaAtual);

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

        private void btnSomarVendas_Click(object sender, EventArgs e)
        {
           if(vendas.Count == 0)
            {
                MessageBox.Show("Nenhuma venda registrada.");
                return;
            }
           decimal total = 0;
            foreach(var venda in vendas)
                {
                 total += venda;

                //mandar para um arquivo txt

                string caminho = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string arquivo = Path.Combine(caminho, "TotalVendas.txt");

                using (StreamWriter writer = new StreamWriter(arquivo))
                {
                    writer.WriteLine("RELATÓRIO DE VENDAS");
                    writer.WriteLine($"Data: {DateTime.Now:dd/MM/yyyy}");
                    writer.WriteLine();
                    writer.WriteLine($"Total das vendas: {total.ToString("C")}");
                }

                MessageBox.Show("Total salvo em 'TotalVendas.txt' na Área de Trabalho.");
            }
        }
    }
}
