namespace frmPrincipal
{
    partial class frmTipoProduto
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
            this.txbdescricao = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.dtgTipo_produto = new System.Windows.Forms.DataGridView();
            this.txtTipo_produto = new System.Windows.Forms.TextBox();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipo_produto)).BeginInit();
            this.SuspendLayout();
            // 
            // txbdescricao
            // 
            this.txbdescricao.Location = new System.Drawing.Point(76, 69);
            this.txbdescricao.Name = "txbdescricao";
            this.txbdescricao.Size = new System.Drawing.Size(236, 113);
            this.txbdescricao.TabIndex = 49;
            this.txbdescricao.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Descrição:";
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(156, 202);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 38);
            this.btnexcluir.TabIndex = 47;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(237, 202);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 38);
            this.btnsalvar.TabIndex = 46;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            // 
            // btnnovo
            // 
            this.btnnovo.Location = new System.Drawing.Point(75, 202);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(75, 38);
            this.btnnovo.TabIndex = 45;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Tipo Produto:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(76, 16);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(62, 20);
            this.txtcodigo.TabIndex = 42;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(27, 19);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(43, 13);
            this.Nome.TabIndex = 41;
            this.Nome.Text = "Código:";
            // 
            // dtgTipo_produto
            // 
            this.dtgTipo_produto.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgTipo_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTipo_produto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Tipo});
            this.dtgTipo_produto.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgTipo_produto.Location = new System.Drawing.Point(331, 12);
            this.dtgTipo_produto.Name = "dtgTipo_produto";
            this.dtgTipo_produto.Size = new System.Drawing.Size(376, 232);
            this.dtgTipo_produto.TabIndex = 50;
            // 
            // txtTipo_produto
            // 
            this.txtTipo_produto.Location = new System.Drawing.Point(76, 43);
            this.txtTipo_produto.Name = "txtTipo_produto";
            this.txtTipo_produto.Size = new System.Drawing.Size(236, 20);
            this.txtTipo_produto.TabIndex = 51;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 230;
            // 
            // frmTipoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 256);
            this.Controls.Add(this.txtTipo_produto);
            this.Controls.Add(this.dtgTipo_produto);
            this.Controls.Add(this.txbdescricao);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.Nome);
            this.Name = "frmTipoProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Tipo de Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipo_produto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txbdescricao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.DataGridView dtgTipo_produto;
        private System.Windows.Forms.TextBox txtTipo_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}