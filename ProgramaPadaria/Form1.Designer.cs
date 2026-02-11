namespace ProgramaPadaria
{
    partial class frmName
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            btnFinalizarVenda = new Button();
            btnComecar = new Button();
            lblVendasFinalizadas = new Label();
            lstVendas = new ListBox();
            lblValor = new Label();
            txtValorVenda = new TextBox();
            lblComando = new Label();
            lblText = new Label();
            pictureBox2 = new PictureBox();
            btnSomarVendas = new Button();
            comboBox1 = new ComboBox();
            lblCategory = new Label();
            lbxCategoriasSelecionadas = new ListBox();
            lblCategoriasSelec = new Label();
            btnAddCategoria = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Chocolate;
            pictureBox1.Location = new Point(451, -36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 580);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnFinalizarVenda
            // 
            btnFinalizarVenda.BackColor = Color.Brown;
            btnFinalizarVenda.FlatStyle = FlatStyle.Popup;
            btnFinalizarVenda.Font = new Font("Segoe UI", 9F);
            btnFinalizarVenda.Location = new Point(749, 451);
            btnFinalizarVenda.Name = "btnFinalizarVenda";
            btnFinalizarVenda.Size = new Size(149, 59);
            btnFinalizarVenda.TabIndex = 1;
            btnFinalizarVenda.Text = "FINALIZAR VENDA";
            btnFinalizarVenda.UseVisualStyleBackColor = false;
            btnFinalizarVenda.Click += button1_Click;
            // 
            // btnComecar
            // 
            btnComecar.BackColor = Color.Chartreuse;
            btnComecar.BackgroundImageLayout = ImageLayout.None;
            btnComecar.FlatStyle = FlatStyle.Popup;
            btnComecar.ForeColor = SystemColors.ControlText;
            btnComecar.Location = new Point(467, 7);
            btnComecar.Name = "btnComecar";
            btnComecar.Size = new Size(151, 39);
            btnComecar.TabIndex = 2;
            btnComecar.Text = "REGISTRAR VENDA";
            btnComecar.UseVisualStyleBackColor = false;
            btnComecar.Click += btnComecar_Click;
            // 
            // lblVendasFinalizadas
            // 
            lblVendasFinalizadas.AutoSize = true;
            lblVendasFinalizadas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblVendasFinalizadas.Location = new Point(135, 9);
            lblVendasFinalizadas.Name = "lblVendasFinalizadas";
            lblVendasFinalizadas.Size = new Size(189, 28);
            lblVendasFinalizadas.TabIndex = 3;
            lblVendasFinalizadas.Text = "Vendas Finalizadas";
            // 
            // lstVendas
            // 
            lstVendas.BackColor = Color.Orange;
            lstVendas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lstVendas.FormattingEnabled = true;
            lstVendas.Location = new Point(88, 40);
            lstVendas.Name = "lstVendas";
            lstVendas.Size = new Size(308, 424);
            lstVendas.TabIndex = 4;
            lstVendas.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.BackColor = Color.Orange;
            lblValor.Font = new Font("Microsoft Sans Serif", 25F);
            lblValor.Location = new Point(519, 455);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(101, 48);
            lblValor.TabIndex = 5;
            lblValor.Text = "0,00";
            lblValor.Click += lblValor_Click;
            // 
            // txtValorVenda
            // 
            txtValorVenda.BackColor = SystemColors.ActiveBorder;
            txtValorVenda.Font = new Font("Microsoft Sans Serif", 14F);
            txtValorVenda.Location = new Point(618, 397);
            txtValorVenda.Name = "txtValorVenda";
            txtValorVenda.Size = new Size(142, 34);
            txtValorVenda.TabIndex = 6;
            txtValorVenda.TextAlign = HorizontalAlignment.Center;
            // 
            // lblComando
            // 
            lblComando.AutoSize = true;
            lblComando.Location = new Point(669, 116);
            lblComando.Name = "lblComando";
            lblComando.Size = new Size(0, 20);
            lblComando.TabIndex = 7;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblText.ForeColor = SystemColors.ControlText;
            lblText.Location = new Point(552, 366);
            lblText.Name = "lblText";
            lblText.Size = new Size(307, 28);
            lblText.TabIndex = 8;
            lblText.Text = "Coloque o valor final da venda:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._1769523054083;
            pictureBox2.Location = new Point(-14, -16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(96, 91);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnSomarVendas
            // 
            btnSomarVendas.BackColor = Color.Blue;
            btnSomarVendas.Location = new Point(69, 481);
            btnSomarVendas.Name = "btnSomarVendas";
            btnSomarVendas.Size = new Size(124, 29);
            btnSomarVendas.TabIndex = 10;
            btnSomarVendas.Text = "Somar vendas";
            btnSomarVendas.UseVisualStyleBackColor = false;
            btnSomarVendas.Click += btnSomarVendas_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ActiveBorder;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(618, 129);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 28);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCategory.Location = new Point(532, 88);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(327, 28);
            lblCategory.TabIndex = 12;
            lblCategory.Text = "Selecione as categorias vendidas:";
            lblCategory.Click += lblCategory_Click;
            // 
            // lbxCategoriasSelecionadas
            // 
            lbxCategoriasSelecionadas.BackColor = SystemColors.ActiveBorder;
            lbxCategoriasSelecionadas.FormattingEnabled = true;
            lbxCategoriasSelecionadas.Location = new Point(618, 217);
            lbxCategoriasSelecionadas.Name = "lbxCategoriasSelecionadas";
            lbxCategoriasSelecionadas.Size = new Size(142, 104);
            lbxCategoriasSelecionadas.TabIndex = 13;
            lbxCategoriasSelecionadas.SelectedIndexChanged += lbxCategoriasSelecionadas_SelectedIndexChanged;
            // 
            // lblCategoriasSelec
            // 
            lblCategoriasSelec.AutoSize = true;
            lblCategoriasSelec.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCategoriasSelec.Location = new Point(574, 186);
            lblCategoriasSelec.Name = "lblCategoriasSelec";
            lblCategoriasSelec.Size = new Size(243, 28);
            lblCategoriasSelec.TabIndex = 14;
            lblCategoriasSelec.Text = "Categorias selecionadas:";
            // 
            // btnAddCategoria
            // 
            btnAddCategoria.BackColor = Color.DodgerBlue;
            btnAddCategoria.Location = new Point(766, 128);
            btnAddCategoria.Name = "btnAddCategoria";
            btnAddCategoria.Size = new Size(153, 29);
            btnAddCategoria.TabIndex = 15;
            btnAddCategoria.Text = "Adicionar Categoria";
            btnAddCategoria.UseVisualStyleBackColor = false;
            btnAddCategoria.Click += button1_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(467, 128);
            button1.Name = "button1";
            button1.Size = new Size(145, 29);
            button1.TabIndex = 16;
            button1.Text = "Remover Categoria";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // frmName
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(934, 522);
            Controls.Add(button1);
            Controls.Add(btnAddCategoria);
            Controls.Add(lblCategoriasSelec);
            Controls.Add(lbxCategoriasSelecionadas);
            Controls.Add(lblCategory);
            Controls.Add(comboBox1);
            Controls.Add(btnSomarVendas);
            Controls.Add(lstVendas);
            Controls.Add(pictureBox2);
            Controls.Add(lblText);
            Controls.Add(lblComando);
            Controls.Add(txtValorVenda);
            Controls.Add(lblValor);
            Controls.Add(lblVendasFinalizadas);
            Controls.Add(btnComecar);
            Controls.Add(btnFinalizarVenda);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "frmName";
            Text = "Estação do Pão";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnFinalizarVenda;
        private Button btnComecar;
        private Label lblVendasFinalizadas;
        private ListBox lstVendas;
        private Label lblValor;
        private TextBox txtValorVenda;
        private Label lblComando;
        private Label lblText;
        private PictureBox pictureBox2;
        private Button btnSomarVendas;
        private ComboBox comboBox1;
        private Label lblCategory;
        private ListBox lbxCategoriasSelecionadas;
        private Label lblCategoriasSelec;
        private Button btnAddCategoria;
        private Button button1;
    }
}
