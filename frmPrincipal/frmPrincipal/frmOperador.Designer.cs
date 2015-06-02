namespace frmPrincipal
{
    partial class frmOperador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.DtgOperador = new System.Windows.Forms.DataGridView();
            this.MaskTxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.DateTimeNascimento = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.MaskTxtTel = new System.Windows.Forms.MaskedTextBox();
            this.MaskTxtCel = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DateTimeAdmissão = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MaskTxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.TxtUF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtLogradouro = new System.Windows.Forms.TextBox();
            this.TxtCargo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNomeOperador = new System.Windows.Forms.TextBox();
            this.TxtCodOperador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgOperador)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(467, 184);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 32);
            this.BtnPesquisar.TabIndex = 129;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(248, 184);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 32);
            this.BtnExcluir.TabIndex = 128;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(86, 184);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 32);
            this.BtnSalvar.TabIndex = 127;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(167, 184);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 32);
            this.BtnAlterar.TabIndex = 126;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(5, 184);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 32);
            this.BtnNovo.TabIndex = 125;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            // 
            // DtgOperador
            // 
            this.DtgOperador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgOperador.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgOperador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgOperador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgOperador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Nome,
            this.CPF,
            this.Tel_celular,
            this.Cargo});
            this.DtgOperador.Location = new System.Drawing.Point(10, 232);
            this.DtgOperador.Name = "DtgOperador";
            this.DtgOperador.Size = new System.Drawing.Size(685, 274);
            this.DtgOperador.TabIndex = 124;
            // 
            // MaskTxtCPF
            // 
            this.MaskTxtCPF.Location = new System.Drawing.Point(329, 85);
            this.MaskTxtCPF.Mask = "000.000.000.00";
            this.MaskTxtCPF.Name = "MaskTxtCPF";
            this.MaskTxtCPF.Size = new System.Drawing.Size(84, 20);
            this.MaskTxtCPF.TabIndex = 123;
            // 
            // DateTimeNascimento
            // 
            this.DateTimeNascimento.Location = new System.Drawing.Point(77, 85);
            this.DateTimeNascimento.Name = "DateTimeNascimento";
            this.DateTimeNascimento.Size = new System.Drawing.Size(210, 20);
            this.DateTimeNascimento.TabIndex = 122;
            this.DateTimeNascimento.Value = new System.DateTime(2015, 5, 20, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 121;
            this.label13.Text = "Nascimento:";
            // 
            // MaskTxtTel
            // 
            this.MaskTxtTel.Location = new System.Drawing.Point(472, 50);
            this.MaskTxtTel.Mask = "(99) 0000-0000";
            this.MaskTxtTel.Name = "MaskTxtTel";
            this.MaskTxtTel.Size = new System.Drawing.Size(84, 20);
            this.MaskTxtTel.TabIndex = 120;
            // 
            // MaskTxtCel
            // 
            this.MaskTxtCel.Location = new System.Drawing.Point(471, 85);
            this.MaskTxtCel.Mask = "(99) 00000-0000";
            this.MaskTxtCel.Name = "MaskTxtCel";
            this.MaskTxtCel.Size = new System.Drawing.Size(85, 20);
            this.MaskTxtCel.TabIndex = 119;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(440, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 118;
            this.label12.Text = "Cel:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(419, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 117;
            this.label11.Text = "Tel Fixo:";
            // 
            // DateTimeAdmissão
            // 
            this.DateTimeAdmissão.Location = new System.Drawing.Point(480, 17);
            this.DateTimeAdmissão.Name = "DateTimeAdmissão";
            this.DateTimeAdmissão.Size = new System.Drawing.Size(215, 20);
            this.DateTimeAdmissão.TabIndex = 116;
            this.DateTimeAdmissão.Value = new System.DateTime(2015, 5, 20, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(419, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 115;
            this.label10.Text = "Admissão:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 114;
            this.label9.Text = "CPF:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(318, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 113;
            this.label8.Text = "CEP:";
            // 
            // MaskTxtCEP
            // 
            this.MaskTxtCEP.Location = new System.Drawing.Point(355, 147);
            this.MaskTxtCEP.Mask = "00000-999";
            this.MaskTxtCEP.Name = "MaskTxtCEP";
            this.MaskTxtCEP.Size = new System.Drawing.Size(58, 20);
            this.MaskTxtCEP.TabIndex = 112;
            // 
            // TxtUF
            // 
            this.TxtUF.Location = new System.Drawing.Point(472, 147);
            this.TxtUF.MaxLength = 2;
            this.TxtUF.Name = "TxtUF";
            this.TxtUF.Size = new System.Drawing.Size(42, 20);
            this.TxtUF.TabIndex = 111;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 110;
            this.label7.Text = "UF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 109;
            this.label6.Text = "Cidade:";
            // 
            // TxtCidade
            // 
            this.TxtCidade.Location = new System.Drawing.Point(77, 147);
            this.TxtCidade.MaxLength = 50;
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(197, 20);
            this.TxtCidade.TabIndex = 108;
            // 
            // TxtBairro
            // 
            this.TxtBairro.Location = new System.Drawing.Point(472, 118);
            this.TxtBairro.MaxLength = 50;
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(197, 20);
            this.TxtBairro.TabIndex = 107;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 106;
            this.label5.Text = "Bairro:";
            // 
            // TxtLogradouro
            // 
            this.TxtLogradouro.Location = new System.Drawing.Point(77, 118);
            this.TxtLogradouro.MaxLength = 50;
            this.TxtLogradouro.Name = "TxtLogradouro";
            this.TxtLogradouro.Size = new System.Drawing.Size(336, 20);
            this.TxtLogradouro.TabIndex = 105;
            // 
            // TxtCargo
            // 
            this.TxtCargo.Location = new System.Drawing.Point(216, 17);
            this.TxtCargo.MaxLength = 50;
            this.TxtCargo.Name = "TxtCargo";
            this.TxtCargo.Size = new System.Drawing.Size(197, 20);
            this.TxtCargo.TabIndex = 104;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 103;
            this.label4.Text = "Logradouro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 102;
            this.label3.Text = "Cargo:";
            // 
            // TxtNomeOperador
            // 
            this.TxtNomeOperador.Location = new System.Drawing.Point(77, 50);
            this.TxtNomeOperador.MaxLength = 50;
            this.TxtNomeOperador.Name = "TxtNomeOperador";
            this.TxtNomeOperador.Size = new System.Drawing.Size(336, 20);
            this.TxtNomeOperador.TabIndex = 101;
            // 
            // TxtCodOperador
            // 
            this.TxtCodOperador.Location = new System.Drawing.Point(77, 17);
            this.TxtCodOperador.Name = "TxtCodOperador";
            this.TxtCodOperador.Size = new System.Drawing.Size(74, 20);
            this.TxtCodOperador.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Cód:";
            // 
            // Cod
            // 
            this.Cod.HeaderText = "Cod";
            this.Cod.Name = "Cod";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 200;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // Tel_celular
            // 
            this.Tel_celular.HeaderText = "Tel_celular";
            this.Tel_celular.Name = "Tel_celular";
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.Width = 130;
            // 
            // frmOperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 522);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.DtgOperador);
            this.Controls.Add(this.MaskTxtCPF);
            this.Controls.Add(this.DateTimeNascimento);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.MaskTxtTel);
            this.Controls.Add(this.MaskTxtCel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DateTimeAdmissão);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MaskTxtCEP);
            this.Controls.Add(this.TxtUF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCidade);
            this.Controls.Add(this.TxtBairro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtLogradouro);
            this.Controls.Add(this.TxtCargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNomeOperador);
            this.Controls.Add(this.TxtCodOperador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOperador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Operador";
            this.Load += new System.EventHandler(this.frmOperador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgOperador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.DataGridView DtgOperador;
        private System.Windows.Forms.MaskedTextBox MaskTxtCPF;
        private System.Windows.Forms.DateTimePicker DateTimeNascimento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox MaskTxtTel;
        private System.Windows.Forms.MaskedTextBox MaskTxtCel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DateTimeAdmissão;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox MaskTxtCEP;
        private System.Windows.Forms.TextBox TxtUF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtLogradouro;
        private System.Windows.Forms.TextBox TxtCargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNomeOperador;
        private System.Windows.Forms.TextBox TxtCodOperador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel_celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
    }
}