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
            comboBox1 = new ComboBox();
            lblCategory = new Label();
            lbxCategoriasSelecionadas = new ListBox();
            lblCategoriasSelec = new Label();
            btnAddCategoria = new Button();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox8 = new PictureBox();
            lblTotalHoje = new Label();
            lblTot = new Label();
            pictureBox7 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Chocolate;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(427, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(11, 399);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnFinalizarVenda
            // 
            btnFinalizarVenda.BackColor = Color.Brown;
            btnFinalizarVenda.FlatStyle = FlatStyle.Popup;
            btnFinalizarVenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFinalizarVenda.ForeColor = SystemColors.ControlLight;
            btnFinalizarVenda.Location = new Point(817, 427);
            btnFinalizarVenda.Name = "btnFinalizarVenda";
            btnFinalizarVenda.Size = new Size(105, 84);
            btnFinalizarVenda.TabIndex = 1;
            btnFinalizarVenda.Text = "FINALIZAR VENDA";
            btnFinalizarVenda.UseVisualStyleBackColor = false;
            btnFinalizarVenda.Click += button1_Click;
            // 
            // btnComecar
            // 
            btnComecar.BackColor = Color.YellowGreen;
            btnComecar.BackgroundImageLayout = ImageLayout.None;
            btnComecar.FlatStyle = FlatStyle.Popup;
            btnComecar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnComecar.ForeColor = SystemColors.ControlText;
            btnComecar.Location = new Point(503, 342);
            btnComecar.Name = "btnComecar";
            btnComecar.Size = new Size(182, 34);
            btnComecar.TabIndex = 2;
            btnComecar.Text = "REGISTRAR VENDA";
            btnComecar.UseVisualStyleBackColor = false;
            btnComecar.Click += btnComecar_Click;
            // 
            // lblVendasFinalizadas
            // 
            lblVendasFinalizadas.AutoSize = true;
            lblVendasFinalizadas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblVendasFinalizadas.Location = new Point(152, 9);
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
            lstVendas.Location = new Point(90, 65);
            lstVendas.Name = "lstVendas";
            lstVendas.Size = new Size(308, 324);
            lstVendas.TabIndex = 4;
            lstVendas.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.BackColor = Color.Orange;
            lblValor.FlatStyle = FlatStyle.System;
            lblValor.Font = new Font("Microsoft Sans Serif", 20F);
            lblValor.Location = new Point(553, 444);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(83, 39);
            lblValor.TabIndex = 5;
            lblValor.Text = "0,00";
            lblValor.Click += lblValor_Click;
            // 
            // txtValorVenda
            // 
            txtValorVenda.BackColor = SystemColors.ActiveBorder;
            txtValorVenda.Font = new Font("Microsoft Sans Serif", 14F);
            txtValorVenda.Location = new Point(691, 342);
            txtValorVenda.Name = "txtValorVenda";
            txtValorVenda.Size = new Size(168, 34);
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
            lblText.BackColor = Color.LightYellow;
            lblText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblText.ForeColor = SystemColors.ControlText;
            lblText.Location = new Point(537, 287);
            lblText.Name = "lblText";
            lblText.Size = new Size(307, 28);
            lblText.TabIndex = 8;
            lblText.Text = "Coloque o valor final da venda:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._1769523054083;
            pictureBox2.Location = new Point(-34, -5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(128, 91);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ActiveBorder;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(611, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 28);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.LightYellow;
            lblCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCategory.Location = new Point(532, 24);
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
            lbxCategoriasSelecionadas.Location = new Point(573, 180);
            lbxCategoriasSelecionadas.Name = "lbxCategoriasSelecionadas";
            lbxCategoriasSelecionadas.Size = new Size(202, 104);
            lbxCategoriasSelecionadas.TabIndex = 13;
            lbxCategoriasSelecionadas.SelectedIndexChanged += lbxCategoriasSelecionadas_SelectedIndexChanged;
            // 
            // lblCategoriasSelec
            // 
            lblCategoriasSelec.AutoSize = true;
            lblCategoriasSelec.BackColor = Color.LightYellow;
            lblCategoriasSelec.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCategoriasSelec.Location = new Point(553, 136);
            lblCategoriasSelec.Name = "lblCategoriasSelec";
            lblCategoriasSelec.Size = new Size(243, 28);
            lblCategoriasSelec.TabIndex = 14;
            lblCategoriasSelec.Text = "Categorias selecionadas:";
            // 
            // btnAddCategoria
            // 
            btnAddCategoria.BackColor = Color.DodgerBlue;
            btnAddCategoria.FlatStyle = FlatStyle.Flat;
            btnAddCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddCategoria.ForeColor = SystemColors.ControlLight;
            btnAddCategoria.Location = new Point(759, 77);
            btnAddCategoria.Name = "btnAddCategoria";
            btnAddCategoria.Size = new Size(163, 33);
            btnAddCategoria.TabIndex = 15;
            btnAddCategoria.Text = "Adicionar Categoria";
            btnAddCategoria.UseVisualStyleBackColor = false;
            btnAddCategoria.Click += button1_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(444, 77);
            button1.Name = "button1";
            button1.Size = new Size(161, 33);
            button1.TabIndex = 16;
            button1.Text = "Remover Categoria";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.LightYellow;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(81, 55);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(327, 341);
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.LemonChiffon;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Location = new Point(68, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(353, 399);
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LemonChiffon;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(134, 22);
            label1.Name = "label1";
            label1.Size = new Size(207, 30);
            label1.TabIndex = 19;
            label1.Text = "Vendas Finalizadas";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.LightYellow;
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Location = new Point(68, 417);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(861, 100);
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.LightYellow;
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Location = new Point(437, 9);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(492, 399);
            pictureBox6.TabIndex = 21;
            pictureBox6.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.LightYellow;
            pictureBox8.BorderStyle = BorderStyle.FixedSingle;
            pictureBox8.Location = new Point(488, 329);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(386, 58);
            pictureBox8.TabIndex = 23;
            pictureBox8.TabStop = false;
            // 
            // lblTotalHoje
            // 
            lblTotalHoje.BackColor = Color.Orange;
            lblTotalHoje.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTotalHoje.ForeColor = Color.Black;
            lblTotalHoje.ImageAlign = ContentAlignment.TopCenter;
            lblTotalHoje.Location = new Point(297, 427);
            lblTotalHoje.Name = "lblTotalHoje";
            lblTotalHoje.Size = new Size(87, 35);
            lblTotalHoje.TabIndex = 24;
            lblTotalHoje.Text = "0,00";
            // 
            // lblTot
            // 
            lblTot.AutoSize = true;
            lblTot.BackColor = Color.LightYellow;
            lblTot.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTot.Location = new Point(124, 427);
            lblTot.Name = "lblTot";
            lblTot.Size = new Size(167, 35);
            lblTot.TabIndex = 25;
            lblTot.Text = "TOTAL HOJE:";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.LightYellow;
            pictureBox7.Image = Properties.Resources.green_money_bag_dollar_3d_illustration_png;
            pictureBox7.Location = new Point(90, 427);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(28, 30);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 26;
            pictureBox7.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.todo_list_icon_notepad_with_completed_todo_list_and_pencil_3d_render_png;
            pictureBox9.Location = new Point(100, 15);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(37, 37);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 27;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.LightYellow;
            pictureBox10.Image = Properties.Resources.impressive_classic_freshly_baked_bread_loaf_isolated_rustic_style_4k_free_png;
            pictureBox10.Location = new Point(488, 22);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(38, 37);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 28;
            pictureBox10.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSeaGreen;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(81, 465);
            button2.Name = "button2";
            button2.Size = new Size(86, 46);
            button2.TabIndex = 29;
            button2.Text = "Encerrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // frmName
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1002, 523);
            Controls.Add(button2);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox7);
            Controls.Add(lblTot);
            Controls.Add(lblTotalHoje);
            Controls.Add(label1);
            Controls.Add(lstVendas);
            Controls.Add(pictureBox3);
            Controls.Add(lblCategory);
            Controls.Add(lblComando);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(lblVendasFinalizadas);
            Controls.Add(button1);
            Controls.Add(btnAddCategoria);
            Controls.Add(lblCategoriasSelec);
            Controls.Add(lbxCategoriasSelecionadas);
            Controls.Add(pictureBox2);
            Controls.Add(lblText);
            Controls.Add(txtValorVenda);
            Controls.Add(lblValor);
            Controls.Add(btnComecar);
            Controls.Add(btnFinalizarVenda);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox6);
            MaximizeBox = false;
            Name = "frmName";
            Text = "Estação do Pão";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
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
        private ComboBox comboBox1;
        private Label lblCategory;
        private ListBox lbxCategoriasSelecionadas;
        private Label lblCategoriasSelec;
        private Button btnAddCategoria;
        private Button button1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox8;
        private Label lblTotalHoje;
        private Label lblTot;
        private PictureBox pictureBox7;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private Button button2;
    }
}
