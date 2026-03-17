using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ProgramaPadaria
{
    public partial class fFormInicial : Form
    {
        public fFormInicial()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            frmName Form1 = new frmName();
            Form1.Show();
            this.Hide();
        }
        private void ArredondarButton(Button botao, int raio)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(botao.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(botao.Width - raio, botao.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, botao.Height - raio, raio, raio, 90, 90);

            path.CloseAllFigures();
            botao.Region = new Region(path);
        }

        private void btnIniciarPrograma_Resize(object sender, EventArgs e)
        {
            ArredondarButton(btnIniciarPrograma, 30);
        }

        private void fFormInicial_Load_1(object sender, EventArgs e)
        {
            ArredondarButton(button1, 20);
            ArredondarButton(btnIniciarPrograma, 60);
            btnIniciarPrograma.FlatStyle = FlatStyle.Flat;
            btnIniciarPrograma.FlatAppearance.BorderSize = 0;
            btnIniciarPrograma.BackColor = Color.Chocolate;
            btnIniciarPrograma.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.BackColor = Color.Chocolate;
            button1.ForeColor = Color.White;
        }

        private void button1_Click_1(object sender, EventArgs e)
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
    }
}
