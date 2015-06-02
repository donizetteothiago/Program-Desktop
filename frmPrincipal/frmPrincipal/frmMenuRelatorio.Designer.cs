namespace frmPrincipal
{
    partial class frmMenuRelatorio
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
            this.btnRelCategorias = new System.Windows.Forms.Button();
            this.btnRelOperadores = new System.Windows.Forms.Button();
            this.btnRelProdutos = new System.Windows.Forms.Button();
            this.btnRelVendas = new System.Windows.Forms.Button();
            this.btnNotaFiscal = new System.Windows.Forms.Button();
            this.btnRelFornecedores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRelCategorias
            // 
            this.btnRelCategorias.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRelCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelCategorias.Location = new System.Drawing.Point(274, 12);
            this.btnRelCategorias.Name = "btnRelCategorias";
            this.btnRelCategorias.Size = new System.Drawing.Size(256, 87);
            this.btnRelCategorias.TabIndex = 9;
            this.btnRelCategorias.Text = "Relatório de Categorias";
            this.btnRelCategorias.UseVisualStyleBackColor = false;
            // 
            // btnRelOperadores
            // 
            this.btnRelOperadores.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRelOperadores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelOperadores.Location = new System.Drawing.Point(12, 198);
            this.btnRelOperadores.Name = "btnRelOperadores";
            this.btnRelOperadores.Size = new System.Drawing.Size(256, 87);
            this.btnRelOperadores.TabIndex = 8;
            this.btnRelOperadores.Text = "Relatório de Operadores";
            this.btnRelOperadores.UseVisualStyleBackColor = false;
            // 
            // btnRelProdutos
            // 
            this.btnRelProdutos.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRelProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelProdutos.Location = new System.Drawing.Point(12, 105);
            this.btnRelProdutos.Name = "btnRelProdutos";
            this.btnRelProdutos.Size = new System.Drawing.Size(256, 87);
            this.btnRelProdutos.TabIndex = 7;
            this.btnRelProdutos.Text = "Relatório de Produtos";
            this.btnRelProdutos.UseVisualStyleBackColor = false;
            // 
            // btnRelVendas
            // 
            this.btnRelVendas.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRelVendas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelVendas.Location = new System.Drawing.Point(12, 12);
            this.btnRelVendas.Name = "btnRelVendas";
            this.btnRelVendas.Size = new System.Drawing.Size(256, 87);
            this.btnRelVendas.TabIndex = 6;
            this.btnRelVendas.Text = "Relatório de Vendas";
            this.btnRelVendas.UseVisualStyleBackColor = false;
            // 
            // btnNotaFiscal
            // 
            this.btnNotaFiscal.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnNotaFiscal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNotaFiscal.Location = new System.Drawing.Point(274, 198);
            this.btnNotaFiscal.Name = "btnNotaFiscal";
            this.btnNotaFiscal.Size = new System.Drawing.Size(256, 87);
            this.btnNotaFiscal.TabIndex = 11;
            this.btnNotaFiscal.Text = "Nota Fiscal";
            this.btnNotaFiscal.UseVisualStyleBackColor = false;
            // 
            // btnRelFornecedores
            // 
            this.btnRelFornecedores.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRelFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelFornecedores.Location = new System.Drawing.Point(274, 105);
            this.btnRelFornecedores.Name = "btnRelFornecedores";
            this.btnRelFornecedores.Size = new System.Drawing.Size(256, 87);
            this.btnRelFornecedores.TabIndex = 10;
            this.btnRelFornecedores.Text = "Relatório de Fornecedores";
            this.btnRelFornecedores.UseVisualStyleBackColor = false;
            // 
            // frmMenuRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(541, 297);
            this.Controls.Add(this.btnNotaFiscal);
            this.Controls.Add(this.btnRelFornecedores);
            this.Controls.Add(this.btnRelCategorias);
            this.Controls.Add(this.btnRelOperadores);
            this.Controls.Add(this.btnRelProdutos);
            this.Controls.Add(this.btnRelVendas);
            this.Name = "frmMenuRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emitir Relatório";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRelCategorias;
        private System.Windows.Forms.Button btnRelOperadores;
        private System.Windows.Forms.Button btnRelProdutos;
        private System.Windows.Forms.Button btnRelVendas;
        private System.Windows.Forms.Button btnNotaFiscal;
        private System.Windows.Forms.Button btnRelFornecedores;
    }
}