using Dapper;
using Npgsql;
using ProgramaPadaria.Helpers;
using ProgramaPadaria.Repositories;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
namespace ProgramaPadaria
{
    public partial class frmName : Form
    {
        public frmName()
        {
            InitializeComponent();

            // Adicione essa linha:
            SqlMapper.AddTypeHandler(new DateOnlyTypeHandler());
        }
        bool vendaEmProcessamento = false;
        List<decimal> vendas = new List<decimal>();

        decimal valorVendaAtual = 0;
        int contadorVendas = 0;
        private void AtualizarTotalHoje()
        {
            string conexao =
                ConfigurationManager.ConnectionStrings["sistema_padaria"].ConnectionString;

            using (var conn = new NpgsqlConnection(conexao))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand(
                    @"SELECT COALESCE(SUM(valor_total), 0)
              FROM venda
              WHERE DATE(data_venda) = CURRENT_DATE", conn))
                {
                    decimal totalHoje = (decimal)cmd.ExecuteScalar();

                    lblTotalHoje.Text = totalHoje.ToString("F2");
                }
            }
        }
        private void ArredondarLabel(Label label, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(label.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(label.Width - raio, label.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, label.Height - raio, raio, raio, 90, 90);
            path.CloseFigure();
            label.Region = new Region(path);
        }

        private void Arrendondar(PictureBox picturebox, int raio)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(picturebox.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(picturebox.Width - raio, picturebox.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, picturebox.Height - raio, raio, raio, 90, 90);
            path.CloseFigure();
            picturebox.Region = new Region(path);
        }
        private void ArredondarBotao(Button botao, int raio)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(botao.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(botao.Width - raio, botao.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, botao.Height - raio, raio, raio, 90, 90);
            path.CloseFigure();
            botao.Region = new Region(path);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ArredondarBotao(btnComecar, 25);
            ArredondarBotao(button2, 25);
            ArredondarBotao(btnAddCategoria, 25);
            ArredondarBotao(btnFinalizarVenda, 25);
            Arrendondar(pictureBox5, 30);
            Arrendondar(pictureBox6, 30);
            Arrendondar(pictureBox4, 30);
            Arrendondar(pictureBox11, 30);
            Arrendondar(pictureBox8, 30);
            ArredondarLabel(lblValor, 30);
            CarregarVendas();
            AtualizarTotalHoje();
            AdicionarBordaArredondada(pictureBox12, 30, Color.Chocolate, 2f);


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
        private void AdicionarBordaArredondada(PictureBox pb, int raio, Color corBorda, float espessura = 2f)
        {
            pb.Paint += (s, pe) =>
            {
                pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                float offset = espessura / 2f;
                float w = pb.Width - espessura;
                float h = pb.Height - espessura;

                GraphicsPath path = new GraphicsPath();
                path.AddArc(offset, offset, raio, raio, 180, 90);
                path.AddArc(offset + w - raio, offset, raio, raio, 270, 90);
                path.AddArc(offset + w - raio, offset + h - raio, raio, raio, 0, 90);
                path.AddArc(offset, offset + h - raio, raio, raio, 90, 90);
                path.CloseFigure();

                // Atualiza a região com o path corrigido
                pb.Region = new Region(path);

                using Pen pen = new Pen(corBorda, espessura);
                pe.Graphics.DrawPath(pen, path);
            };
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

            if (lbxCategoriasSelecionadas.Items.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos uma categoria.");
                vendaEmProcessamento = false;
                return;
            }

            var repo = new VendaRepository();

            int idVenda = repo.InserirVenda(valorVenda, DateTime.Now);

            foreach (var item in lbxCategoriasSelecionadas.Items)
            {
                int idCategoria = int.Parse(item.ToString().Split('-')[0].Trim());
                repo.InserirVendaCategoria(idVenda, idCategoria);
            }

            CarregarVendas();
            AtualizarTotalHoje();
            AtualizarTotal();



            txtValorVenda.Clear();
            lbxCategoriasSelecionadas.Items.Clear();
            lblValor.Text = "0,00";

            vendaEmProcessamento = false;
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
        private void lbxCategoriasSelecionadas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(
                "Deseja encerrar o programa?",
                "Fechar Sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma categoria");
                return;
            }

            lbxCategoriasSelecionadas.Items.Add(comboBox1.SelectedItem);
        }

        private void CarregarVendas()
        {
            var repo = new VendaRepository();
            var vendas = repo.BuscarVendasHoje();

            lstVendas.Items.Clear();

            foreach   (var v in vendas)
            {
                lstVendas.Items.Add($"Venda #{v.id_venda} | R$ {v.valor_total: F2}");
            }
        }
        private void AtualizarTotal()
        {
            var repo = new VendaRepository();
            decimal total = repo.TotalVendas();

            lblTotalHoje.Text = total.ToString("F2");
        }


        private void btnFinalizarVenda_Leave(object sender, EventArgs e)
        {
        }
    }
}
