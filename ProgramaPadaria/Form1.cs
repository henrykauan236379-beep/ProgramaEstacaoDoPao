using Npgsql;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace ProgramaPadaria
{
    public partial class frmName : Form
    {
        bool vendaEmProcessamento = false;
        List<decimal> vendas = new List<decimal>();

        decimal valorVendaAtual = 0;
        int contadorVendas = 0;
        public frmName()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //conexão com o banco
            string conexao =
                ConfigurationManager.ConnectionStrings["sistema_padaria"].ConnectionString;
            using (var conn = new NpgsqlConnection(conexao))
            {
                conn.Open();


                var cmd = new NpgsqlCommand("SELECT id_categoria, nome_categoria FROM categoria", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(
                        $"{reader["id_categoria"]} - {reader["nome_categoria"]}"
                    );
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //ao clicar esse botão, o valor da venda atual é adicionado à lista de vendas e o contador é incrementado, a venda deve ser registrda no banco de dados 
        //também deve ser exibida na listbox e o valor total atualizado 
        private void button1_Click(object sender, EventArgs e)
        {
            if (vendaEmProcessamento)
                return;
            vendaEmProcessamento = true;
            decimal valorVenda;
            if (!decimal.TryParse(txtValorVenda.Text, out valorVenda) || valorVenda <= 0)
            {
                MessageBox.Show("valor da venda inválido");
                vendaEmProcessamento = false;
                return;
            }

                if(lbxCategoriasSelecionadas.Items.Count == 0)
                {
                    MessageBox.Show("Selecione pelo menos uma categoria.");
                    vendaEmProcessamento = false;
                    return;
                }
            int idVenda;
            string conexao =
                ConfigurationManager.ConnectionStrings["sistema_padaria"].ConnectionString;
            using (var conn = new NpgsqlConnection(conexao))

            using (var cmd = new NpgsqlCommand(
                "INSERT INTO venda (data_venda, valor_total) VALUES (NOW(), @valor) RETURNING id", conn))
            {
                cmd.Parameters.AddWithValue("@valor", valorVenda);
                idVenda = (int)cmd.ExecuteScalar();
            }
            conexao =
                ConfigurationManager.ConnectionStrings["sistema_padaria"].ConnectionString;
            using (var conn = new NpgsqlConnection(conexao))
                foreach (var item in lbxCategoriasSelecionadas.Items)
            {
                var idCategoria = int.Parse(item.ToString().Split('-')[0].Trim());
                using (var cmd = new NpgsqlCommand(
                    "INSERT INTO venda_categoria (id_venda, id_categoria) VALUES (@idVenda, @idCategoria)", conn))
                {
                    cmd.Parameters.AddWithValue("@idVenda", idVenda);
                    cmd.Parameters.AddWithValue("@idCategoria", idCategoria);
                    cmd.ExecuteNonQuery();
                }
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
            lstVendas.Items.Add(
            $"Venda #{idVenda} | R$ {valorVendaAtual:F2}"
            );
            lbxCategoriasSelecionadas.Items.Clear();
            txtValorVenda.Clear();
            lblValor.Text = "0,00";

            vendaEmProcessamento = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        
        private void btnSomarVendas_Click(object sender, EventArgs e)
        {
            if (vendas.Count == 0)
            {
                MessageBox.Show("Nenhuma venda registrada.");
                return;
            }
            decimal total = 0;
            foreach (var venda in vendas)
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

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma categoria");
                return;
            }

            lbxCategoriasSelecionadas.Items.Add(comboBox1.SelectedItem);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (lbxCategoriasSelecionadas.SelectedItem != null)
            {
                lbxCategoriasSelecionadas.Items.Remove(
                    lbxCategoriasSelecionadas.SelectedItem
                );
            }
        }

        private void lbxCategoriasSelecionadas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
