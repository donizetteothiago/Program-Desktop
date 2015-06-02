namespace frmPrincipal
{
    partial class frmRelatoriosTela
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
            this.RdBtnCategoria = new System.Windows.Forms.RadioButton();
            this.BtnSairRelatório = new System.Windows.Forms.Button();
            this.BtnEmitirRelatório = new System.Windows.Forms.Button();
            this.RdBtnFornecedores = new System.Windows.Forms.RadioButton();
            this.RdBtnOperadores = new System.Windows.Forms.RadioButton();
            this.RdBtnProdutos = new System.Windows.Forms.RadioButton();
            this.RdBtnVenda = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // RdBtnCategoria
            // 
            this.RdBtnCategoria.AutoSize = true;
            this.RdBtnCategoria.Location = new System.Drawing.Point(25, 120);
            this.RdBtnCategoria.Name = "RdBtnCategoria";
            this.RdBtnCategoria.Size = new System.Drawing.Size(190, 17);
            this.RdBtnCategoria.TabIndex = 14;
            this.RdBtnCategoria.TabStop = true;
            this.RdBtnCategoria.Text = "Relatório de Categoria de Produtos";
            this.RdBtnCategoria.UseVisualStyleBackColor = true;
            // 
            // BtnSairRelatório
            // 
            this.BtnSairRelatório.Location = new System.Drawing.Point(176, 170);
            this.BtnSairRelatório.Name = "BtnSairRelatório";
            this.BtnSairRelatório.Size = new System.Drawing.Size(134, 49);
            this.BtnSairRelatório.TabIndex = 13;
            this.BtnSairRelatório.Text = "Sair";
            this.BtnSairRelatório.UseVisualStyleBackColor = true;
            // 
            // BtnEmitirRelatório
            // 
            this.BtnEmitirRelatório.Location = new System.Drawing.Point(12, 170);
            this.BtnEmitirRelatório.Name = "BtnEmitirRelatório";
            this.BtnEmitirRelatório.Size = new System.Drawing.Size(134, 49);
            this.BtnEmitirRelatório.TabIndex = 12;
            this.BtnEmitirRelatório.Text = "Emitir";
            this.BtnEmitirRelatório.UseVisualStyleBackColor = true;
            // 
            // RdBtnFornecedores
            // 
            this.RdBtnFornecedores.AutoSize = true;
            this.RdBtnFornecedores.Location = new System.Drawing.Point(25, 97);
            this.RdBtnFornecedores.Name = "RdBtnFornecedores";
            this.RdBtnFornecedores.Size = new System.Drawing.Size(150, 17);
            this.RdBtnFornecedores.TabIndex = 11;
            this.RdBtnFornecedores.TabStop = true;
            this.RdBtnFornecedores.Text = "Relatório de Fornecedores";
            this.RdBtnFornecedores.UseVisualStyleBackColor = true;
            // 
            // RdBtnOperadores
            // 
            this.RdBtnOperadores.AutoSize = true;
            this.RdBtnOperadores.Location = new System.Drawing.Point(25, 74);
            this.RdBtnOperadores.Name = "RdBtnOperadores";
            this.RdBtnOperadores.Size = new System.Drawing.Size(140, 17);
            this.RdBtnOperadores.TabIndex = 10;
            this.RdBtnOperadores.TabStop = true;
            this.RdBtnOperadores.Text = "Relatório de Operadores";
            this.RdBtnOperadores.UseVisualStyleBackColor = true;
            // 
            // RdBtnProdutos
            // 
            this.RdBtnProdutos.AutoSize = true;
            this.RdBtnProdutos.Location = new System.Drawing.Point(25, 51);
            this.RdBtnProdutos.Name = "RdBtnProdutos";
            this.RdBtnProdutos.Size = new System.Drawing.Size(127, 17);
            this.RdBtnProdutos.TabIndex = 9;
            this.RdBtnProdutos.TabStop = true;
            this.RdBtnProdutos.Text = "Relatório de Produtos";
            this.RdBtnProdutos.UseVisualStyleBackColor = true;
            // 
            // RdBtnVenda
            // 
            this.RdBtnVenda.AutoSize = true;
            this.RdBtnVenda.Location = new System.Drawing.Point(25, 28);
            this.RdBtnVenda.Name = "RdBtnVenda";
            this.RdBtnVenda.Size = new System.Drawing.Size(121, 17);
            this.RdBtnVenda.TabIndex = 8;
            this.RdBtnVenda.TabStop = true;
            this.RdBtnVenda.Text = "Relatório de Vendas";
            this.RdBtnVenda.UseVisualStyleBackColor = true;
            // 
            // frmRelatoriosTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 246);
            this.Controls.Add(this.RdBtnCategoria);
            this.Controls.Add(this.BtnSairRelatório);
            this.Controls.Add(this.BtnEmitirRelatório);
            this.Controls.Add(this.RdBtnFornecedores);
            this.Controls.Add(this.RdBtnOperadores);
            this.Controls.Add(this.RdBtnProdutos);
            this.Controls.Add(this.RdBtnVenda);
            this.Name = "frmRelatoriosTela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emitir Relatório";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RdBtnCategoria;
        private System.Windows.Forms.Button BtnSairRelatório;
        private System.Windows.Forms.Button BtnEmitirRelatório;
        private System.Windows.Forms.RadioButton RdBtnFornecedores;
        private System.Windows.Forms.RadioButton RdBtnOperadores;
        private System.Windows.Forms.RadioButton RdBtnProdutos;
        private System.Windows.Forms.RadioButton RdBtnVenda;
    }
}