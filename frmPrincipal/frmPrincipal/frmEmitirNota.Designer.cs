namespace frmPrincipal
{
    partial class frmEmitirNota
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
            this.BtnPesquisarNota = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtValorNota = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtCódigoOperador = new System.Windows.Forms.TextBox();
            this.TxtCódigoVenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DateTimeNota = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodNota = new System.Windows.Forms.TextBox();
            this.BtnImprimirNota = new System.Windows.Forms.Button();
            this.DtgNota = new System.Windows.Forms.DataGridView();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cód_Venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgNota)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPesquisarNota
            // 
            this.BtnPesquisarNota.Location = new System.Drawing.Point(439, 107);
            this.BtnPesquisarNota.Name = "BtnPesquisarNota";
            this.BtnPesquisarNota.Size = new System.Drawing.Size(115, 38);
            this.BtnPesquisarNota.TabIndex = 173;
            this.BtnPesquisarNota.Text = "Pesquisar";
            this.BtnPesquisarNota.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(72, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 172;
            this.label3.Text = "Valor:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtValorNota
            // 
            this.TxtValorNota.Location = new System.Drawing.Point(112, 64);
            this.TxtValorNota.Name = "TxtValorNota";
            this.TxtValorNota.Size = new System.Drawing.Size(75, 20);
            this.TxtValorNota.TabIndex = 171;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Location = new System.Drawing.Point(245, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 170;
            this.label10.Text = "Código Operador:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtCódigoOperador
            // 
            this.TxtCódigoOperador.Location = new System.Drawing.Point(341, 37);
            this.TxtCódigoOperador.Name = "TxtCódigoOperador";
            this.TxtCódigoOperador.Size = new System.Drawing.Size(113, 20);
            this.TxtCódigoOperador.TabIndex = 169;
            // 
            // TxtCódigoVenda
            // 
            this.TxtCódigoVenda.Location = new System.Drawing.Point(112, 38);
            this.TxtCódigoVenda.Name = "TxtCódigoVenda";
            this.TxtCódigoVenda.Size = new System.Drawing.Size(75, 20);
            this.TxtCódigoVenda.TabIndex = 168;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 167;
            this.label1.Text = "Código da Venda:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 166;
            this.label9.Text = "Data da Venda:";
            // 
            // DateTimeNota
            // 
            this.DateTimeNota.Location = new System.Drawing.Point(332, 8);
            this.DateTimeNota.Name = "DateTimeNota";
            this.DateTimeNota.Size = new System.Drawing.Size(213, 20);
            this.DateTimeNota.TabIndex = 165;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(22, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 164;
            this.label2.Text = "Código da Nota:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtCodNota
            // 
            this.TxtCodNota.Location = new System.Drawing.Point(112, 12);
            this.TxtCodNota.Name = "TxtCodNota";
            this.TxtCodNota.Size = new System.Drawing.Size(75, 20);
            this.TxtCodNota.TabIndex = 163;
            // 
            // BtnImprimirNota
            // 
            this.BtnImprimirNota.Location = new System.Drawing.Point(12, 107);
            this.BtnImprimirNota.Name = "BtnImprimirNota";
            this.BtnImprimirNota.Size = new System.Drawing.Size(115, 38);
            this.BtnImprimirNota.TabIndex = 162;
            this.BtnImprimirNota.Text = "Imprimir";
            this.BtnImprimirNota.UseVisualStyleBackColor = true;
            // 
            // DtgNota
            // 
            this.DtgNota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgNota.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgNota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nota,
            this.Cód_Venda,
            this.Valor,
            this.Data,
            this.Operador});
            this.DtgNota.Location = new System.Drawing.Point(4, 161);
            this.DtgNota.Name = "DtgNota";
            this.DtgNota.Size = new System.Drawing.Size(558, 206);
            this.DtgNota.TabIndex = 161;
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            // 
            // Cód_Venda
            // 
            this.Cód_Venda.HeaderText = "Cód_ Venda";
            this.Cód_Venda.Name = "Cód_Venda";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // Operador
            // 
            this.Operador.HeaderText = "Operador";
            this.Operador.Name = "Operador";
            // 
            // frmEmitirNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 369);
            this.Controls.Add(this.BtnPesquisarNota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtValorNota);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtCódigoOperador);
            this.Controls.Add(this.TxtCódigoVenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DateTimeNota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCodNota);
            this.Controls.Add(this.BtnImprimirNota);
            this.Controls.Add(this.DtgNota);
            this.Name = "frmEmitirNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emitir Nota Fiscal";
            ((System.ComponentModel.ISupportInitialize)(this.DtgNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPesquisarNota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtValorNota;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtCódigoOperador;
        private System.Windows.Forms.TextBox TxtCódigoVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DateTimeNota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodNota;
        private System.Windows.Forms.Button BtnImprimirNota;
        private System.Windows.Forms.DataGridView DtgNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cód_Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operador;
    }
}