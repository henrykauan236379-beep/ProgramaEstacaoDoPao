namespace ProgramaPadaria
{
    partial class fFormInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblInicio = new Label();
            pictureBox2 = new PictureBox();
            lblObservação = new Label();
            lblBoasVendas = new Label();
            btnIniciarPrograma = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblInicio.Location = new Point(34, 81);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(345, 37);
            lblInicio.TabIndex = 0;
            lblInicio.Text = "Programa Estação do Pão";
            lblInicio.Click += lblInicio_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._1769523054083;
            pictureBox2.Location = new Point(34, 121);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(342, 317);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // lblObservação
            // 
            lblObservação.AutoSize = true;
            lblObservação.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblObservação.Location = new Point(558, 33);
            lblObservação.Name = "lblObservação";
            lblObservação.Size = new Size(230, 180);
            lblObservação.TabIndex = 12;
            lblObservação.Text = "O programa só deve \r\n ser iniciado uma\r\nvez por dia, caso for\r\niniciado e fechado \r\nfavor comunicar o\r\n         suporte.";
            lblObservação.Click += label1_Click;
            // 
            // lblBoasVendas
            // 
            lblBoasVendas.AutoSize = true;
            lblBoasVendas.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblBoasVendas.ForeColor = Color.Orange;
            lblBoasVendas.Location = new Point(548, 236);
            lblBoasVendas.Name = "lblBoasVendas";
            lblBoasVendas.Size = new Size(230, 46);
            lblBoasVendas.TabIndex = 13;
            lblBoasVendas.Text = "Boas Vendas!";
            lblBoasVendas.Click += lblBoasVendas_Click;
            // 
            // btnIniciarPrograma
            // 
            btnIniciarPrograma.BackColor = Color.Orange;
            btnIniciarPrograma.FlatStyle = FlatStyle.Flat;
            btnIniciarPrograma.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnIniciarPrograma.Location = new Point(579, 344);
            btnIniciarPrograma.Name = "btnIniciarPrograma";
            btnIniciarPrograma.Size = new Size(156, 56);
            btnIniciarPrograma.TabIndex = 14;
            btnIniciarPrograma.Text = "Iniciar Programa";
            btnIniciarPrograma.UseVisualStyleBackColor = false;
            btnIniciarPrograma.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._7783093;
            pictureBox1.Location = new Point(482, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_2;
            // 
            // fFormInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnIniciarPrograma);
            Controls.Add(lblBoasVendas);
            Controls.Add(lblObservação);
            Controls.Add(pictureBox2);
            Controls.Add(lblInicio);
            Name = "fFormInicial";
            Text = "Tela_Inicial";
            Load += fFormInicial_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInicio;
        private PictureBox pictureBox2;
        private Label lblObservação;
        private Label lblBoasVendas;
        private Button btnIniciarPrograma;
        private PictureBox pictureBox1;
    }
}