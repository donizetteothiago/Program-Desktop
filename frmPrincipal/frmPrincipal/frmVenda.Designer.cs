namespace frmPrincipal
{
    partial class frmVenda
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
            this.BtnEmitirNota = new System.Windows.Forms.Button();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAddProduto = new System.Windows.Forms.Button();
            this.BtnNovaVenda = new System.Windows.Forms.Button();
            this.DtgVenda = new System.Windows.Forms.DataGridView();
            this.MaskTxtTotalVenda = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtQtdProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCodProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTimeVenda = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtCodOperador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodVenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MaskTxtSubTotal = new System.Windows.Forms.MaskedTextBox();
            this.MaskTxtValorUn = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmBoxNomeProduto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cód_Venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cód_Operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgVenda)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEmitirNota
            // 
            this.BtnEmitirNota.Location = new System.Drawing.Point(453, 167);
            this.BtnEmitirNota.Name = "BtnEmitirNota";
            this.BtnEmitirNota.Size = new System.Drawing.Size(105, 37);
            this.BtnEmitirNota.TabIndex = 129;
            this.BtnEmitirNota.Text = "Emitir Nota";
            this.BtnEmitirNota.UseVisualStyleBackColor = true;
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.Location = new System.Drawing.Point(342, 167);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(105, 37);
            this.BtnFinalizar.TabIndex = 128;
            this.BtnFinalizar.Text = "Finalizar Venda";
            this.BtnFinalizar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(233, 167);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(105, 37);
            this.BtnCancelar.TabIndex = 127;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnAddProduto
            // 
            this.BtnAddProduto.Location = new System.Drawing.Point(122, 167);
            this.BtnAddProduto.Name = "BtnAddProduto";
            this.BtnAddProduto.Size = new System.Drawing.Size(105, 37);
            this.BtnAddProduto.TabIndex = 126;
            this.BtnAddProduto.Text = "Adicionar Produto";
            this.BtnAddProduto.UseVisualStyleBackColor = true;
            // 
            // BtnNovaVenda
            // 
            this.BtnNovaVenda.Location = new System.Drawing.Point(8, 167);
            this.BtnNovaVenda.Name = "BtnNovaVenda";
            this.BtnNovaVenda.Size = new System.Drawing.Size(108, 37);
            this.BtnNovaVenda.TabIndex = 125;
            this.BtnNovaVenda.Text = "Nova venda";
            this.BtnNovaVenda.UseVisualStyleBackColor = true;
            // 
            // DtgVenda
            // 
            this.DtgVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgVenda.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cód_Venda,
            this.Cód_Operador,
            this.Data});
            this.DtgVenda.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DtgVenda.Location = new System.Drawing.Point(10, 210);
            this.DtgVenda.Name = "DtgVenda";
            this.DtgVenda.Size = new System.Drawing.Size(550, 266);
            this.DtgVenda.TabIndex = 124;
            // 
            // MaskTxtTotalVenda
            // 
            this.MaskTxtTotalVenda.Location = new System.Drawing.Point(110, 119);
            this.MaskTxtTotalVenda.Mask = "00000.00";
            this.MaskTxtTotalVenda.Name = "MaskTxtTotalVenda";
            this.MaskTxtTotalVenda.Size = new System.Drawing.Size(61, 20);
            this.MaskTxtTotalVenda.TabIndex = 123;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 122;
            this.label8.Text = "Total Venda:";
            // 
            // TxtQtdProduto
            // 
            this.TxtQtdProduto.Location = new System.Drawing.Point(110, 90);
            this.TxtQtdProduto.Name = "TxtQtdProduto";
            this.TxtQtdProduto.Size = new System.Drawing.Size(61, 20);
            this.TxtQtdProduto.TabIndex = 118;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 117;
            this.label6.Text = "Quantidade:";
            // 
            // TxtCodProduto
            // 
            this.TxtCodProduto.Location = new System.Drawing.Point(110, 64);
            this.TxtCodProduto.Name = "TxtCodProduto";
            this.TxtCodProduto.Size = new System.Drawing.Size(61, 20);
            this.TxtCodProduto.TabIndex = 113;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 112;
            this.label3.Text = "Código Produto:";
            // 
            // DateTimeVenda
            // 
            this.DateTimeVenda.Location = new System.Drawing.Point(329, 12);
            this.DateTimeVenda.Name = "DateTimeVenda";
            this.DateTimeVenda.Size = new System.Drawing.Size(230, 20);
            this.DateTimeVenda.TabIndex = 111;
            this.DateTimeVenda.Value = new System.DateTime(2015, 5, 20, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(290, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 110;
            this.label10.Text = "Data:";
            // 
            // TxtCodOperador
            // 
            this.TxtCodOperador.Location = new System.Drawing.Point(110, 38);
            this.TxtCodOperador.Name = "TxtCodOperador";
            this.TxtCodOperador.Size = new System.Drawing.Size(61, 20);
            this.TxtCodOperador.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 108;
            this.label2.Text = "Código Operador:";
            // 
            // TxtCodVenda
            // 
            this.TxtCodVenda.Location = new System.Drawing.Point(110, 12);
            this.TxtCodVenda.Name = "TxtCodVenda";
            this.TxtCodVenda.Size = new System.Drawing.Size(61, 20);
            this.TxtCodVenda.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Código da Venda:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MaskTxtSubTotal);
            this.groupBox1.Controls.Add(this.MaskTxtValorUn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CmBoxNomeProduto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(208, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 100);
            this.groupBox1.TabIndex = 130;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MaskTxtSubTotal
            // 
            this.MaskTxtSubTotal.Location = new System.Drawing.Point(273, 55);
            this.MaskTxtSubTotal.Mask = "00000.00";
            this.MaskTxtSubTotal.Name = "MaskTxtSubTotal";
            this.MaskTxtSubTotal.Size = new System.Drawing.Size(71, 20);
            this.MaskTxtSubTotal.TabIndex = 127;
            // 
            // MaskTxtValorUn
            // 
            this.MaskTxtValorUn.Location = new System.Drawing.Point(114, 55);
            this.MaskTxtValorUn.Mask = "000.00";
            this.MaskTxtValorUn.Name = "MaskTxtValorUn";
            this.MaskTxtValorUn.Size = new System.Drawing.Size(45, 20);
            this.MaskTxtValorUn.TabIndex = 126;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 125;
            this.label7.Text = "Sub-Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 124;
            this.label5.Text = "Valor Unitário:";
            // 
            // CmBoxNomeProduto
            // 
            this.CmBoxNomeProduto.FormattingEnabled = true;
            this.CmBoxNomeProduto.Location = new System.Drawing.Point(114, 26);
            this.CmBoxNomeProduto.Name = "CmBoxNomeProduto";
            this.CmBoxNomeProduto.Size = new System.Drawing.Size(230, 21);
            this.CmBoxNomeProduto.TabIndex = 123;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 122;
            this.label4.Text = "Nome do Produto:";
            // 
            // Cód_Venda
            // 
            this.Cód_Venda.HeaderText = "Cód_Venda";
            this.Cód_Venda.Name = "Cód_Venda";
            // 
            // Cód_Operador
            // 
            this.Cód_Operador.HeaderText = "Cód_Operador";
            this.Cód_Operador.Name = "Cód_Operador";
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.Width = 200;
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnEmitirNota);
            this.Controls.Add(this.BtnFinalizar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAddProduto);
            this.Controls.Add(this.BtnNovaVenda);
            this.Controls.Add(this.DtgVenda);
            this.Controls.Add(this.MaskTxtTotalVenda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtQtdProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCodProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateTimeVenda);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtCodOperador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCodVenda);
            this.Controls.Add(this.label1);
            this.Name = "frmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Venda";
            ((System.ComponentModel.ISupportInitialize)(this.DtgVenda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEmitirNota;
        private System.Windows.Forms.Button BtnFinalizar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAddProduto;
        private System.Windows.Forms.Button BtnNovaVenda;
        private System.Windows.Forms.DataGridView DtgVenda;
        private System.Windows.Forms.MaskedTextBox MaskTxtTotalVenda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtQtdProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCodProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateTimeVenda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtCodOperador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox MaskTxtSubTotal;
        private System.Windows.Forms.MaskedTextBox MaskTxtValorUn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmBoxNomeProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cód_Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cód_Operador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
    }
}