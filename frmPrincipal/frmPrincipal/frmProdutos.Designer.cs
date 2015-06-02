namespace frmPrincipal
{
    partial class frmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtvalorvenda = new System.Windows.Forms.TextBox();
            this.dtvalidade = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.txbdescricao = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbperecivel = new System.Windows.Forms.RadioButton();
            this.rbnaoperecivel = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cód = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CódigoTipoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnalterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExclui = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtdataentrada = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.txtcodigotipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtvalorcompra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(710, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(578, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Valor da Venda:";
            // 
            // txtvalorvenda
            // 
            this.txtvalorvenda.Location = new System.Drawing.Point(95, 115);
            this.txtvalorvenda.Name = "txtvalorvenda";
            this.txtvalorvenda.Size = new System.Drawing.Size(155, 20);
            this.txtvalorvenda.TabIndex = 65;
            // 
            // dtvalidade
            // 
            this.dtvalidade.Location = new System.Drawing.Point(403, 90);
            this.dtvalidade.Name = "dtvalidade";
            this.dtvalidade.Size = new System.Drawing.Size(200, 20);
            this.dtvalidade.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Validade:";
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(317, 234);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(99, 42);
            this.btnexcluir.TabIndex = 62;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(215, 234);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(99, 42);
            this.btnsalvar.TabIndex = 61;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(118, 234);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(97, 42);
            this.btneditar.TabIndex = 60;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // btnnovo
            // 
            this.btnnovo.Location = new System.Drawing.Point(19, 234);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(97, 42);
            this.btnnovo.TabIndex = 59;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = true;
            // 
            // txbdescricao
            // 
            this.txbdescricao.Location = new System.Drawing.Point(95, 168);
            this.txbdescricao.Name = "txbdescricao";
            this.txbdescricao.Size = new System.Drawing.Size(200, 60);
            this.txbdescricao.TabIndex = 58;
            this.txbdescricao.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbperecivel);
            this.groupBox1.Controls.Add(this.rbnaoperecivel);
            this.groupBox1.Location = new System.Drawing.Point(403, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 121);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // rbperecivel
            // 
            this.rbperecivel.AutoSize = true;
            this.rbperecivel.Location = new System.Drawing.Point(25, 42);
            this.rbperecivel.Name = "rbperecivel";
            this.rbperecivel.Size = new System.Drawing.Size(71, 17);
            this.rbperecivel.TabIndex = 5;
            this.rbperecivel.TabStop = true;
            this.rbperecivel.Text = "Perecível";
            this.rbperecivel.UseVisualStyleBackColor = true;
            // 
            // rbnaoperecivel
            // 
            this.rbnaoperecivel.AutoSize = true;
            this.rbnaoperecivel.Location = new System.Drawing.Point(25, 67);
            this.rbnaoperecivel.Name = "rbnaoperecivel";
            this.rbnaoperecivel.Size = new System.Drawing.Size(94, 17);
            this.rbnaoperecivel.TabIndex = 6;
            this.rbnaoperecivel.TabStop = true;
            this.rbnaoperecivel.Text = "Não Perecível";
            this.rbnaoperecivel.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "Descrição:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.Cód,
            this.Peso,
            this.Valor,
            this.Venda,
            this.DataEntrada,
            this.Descricao,
            this.CódigoTipoProduto,
            this.Quantidade,
            this.Validade,
            this.Tipo,
            this.btnalterar,
            this.BtnExclui});
            this.dataGridView1.Location = new System.Drawing.Point(4, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1348, 231);
            this.dataGridView1.TabIndex = 55;
            // 
            // name
            // 
            this.name.FillWeight = 200F;
            this.name.HeaderText = "Nome";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Cód
            // 
            this.Cód.HeaderText = "Cód.";
            this.Cód.Name = "Cód";
            this.Cód.ReadOnly = true;
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor Compra";
            this.Valor.Name = "Valor";
            // 
            // Venda
            // 
            this.Venda.HeaderText = "Valor Venda";
            this.Venda.Name = "Venda";
            // 
            // DataEntrada
            // 
            this.DataEntrada.HeaderText = "Data Entrada";
            this.DataEntrada.Name = "DataEntrada";
            this.DataEntrada.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            // 
            // CódigoTipoProduto
            // 
            this.CódigoTipoProduto.HeaderText = "Cód. Tipo Produto";
            this.CódigoTipoProduto.Name = "CódigoTipoProduto";
            this.CódigoTipoProduto.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Validade
            // 
            this.Validade.HeaderText = "Validade";
            this.Validade.Name = "Validade";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // btnalterar
            // 
            this.btnalterar.HeaderText = "Alterar";
            this.btnalterar.Name = "btnalterar";
            // 
            // BtnExclui
            // 
            this.BtnExclui.HeaderText = "Excluir";
            this.BtnExclui.Name = "BtnExclui";
            // 
            // dtdataentrada
            // 
            this.dtdataentrada.Location = new System.Drawing.Point(95, 142);
            this.dtdataentrada.Name = "dtdataentrada";
            this.dtdataentrada.Size = new System.Drawing.Size(200, 20);
            this.dtdataentrada.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Data Entrada:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Quantidade:";
            // 
            // txtquantidade
            // 
            this.txtquantidade.Location = new System.Drawing.Point(403, 64);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(155, 20);
            this.txtquantidade.TabIndex = 51;
            // 
            // txtcodigotipo
            // 
            this.txtcodigotipo.Location = new System.Drawing.Point(403, 38);
            this.txtcodigotipo.Name = "txtcodigotipo";
            this.txtcodigotipo.Size = new System.Drawing.Size(155, 20);
            this.txtcodigotipo.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Valor da Compra:";
            // 
            // txtvalorcompra
            // 
            this.txtvalorcompra.Location = new System.Drawing.Point(95, 89);
            this.txtvalorcompra.Name = "txtvalorcompra";
            this.txtvalorcompra.Size = new System.Drawing.Size(155, 20);
            this.txtvalorcompra.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Peso:";
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(95, 64);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(155, 20);
            this.txtpeso.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Código Tipo Produto:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(95, 38);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(157, 20);
            this.txtcodigo.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nome:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(95, 12);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(463, 20);
            this.txtnome.TabIndex = 42;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(46, 41);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(43, 13);
            this.Nome.TabIndex = 41;
            this.Nome.Text = "Código:";
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 523);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtvalorvenda);
            this.Controls.Add(this.dtvalidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.txbdescricao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtdataentrada);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtquantidade);
            this.Controls.Add(this.txtcodigotipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtvalorcompra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.Nome);
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtvalorvenda;
        private System.Windows.Forms.DateTimePicker dtvalidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.RichTextBox txbdescricao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbperecivel;
        private System.Windows.Forms.RadioButton rbnaoperecivel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cód;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CódigoTipoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Validade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewButtonColumn btnalterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExclui;
        private System.Windows.Forms.DateTimePicker dtdataentrada;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.TextBox txtcodigotipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtvalorcompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label Nome;
    }
}