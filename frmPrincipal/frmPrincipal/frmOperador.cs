using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frmOperador : Form
    {
        private bool Incluir = true;

        public frmOperador()
        {
            InitializeComponent();
        }

        private void frmOperador_Load(object sender, EventArgs e)
        {
            CarregaGrid();
          
        }

        private void CarregaGrid()
        {
            COperador.COperadorClient WSOperador = new COperador.COperadorClient();
            WSOperador.Open();
            SubCarregaGrid(WSOperador);
            WSOperador.Close();

  
        }

        private  void SubCarregaGrid(COperador.COperadorClient WSOperador)
        {
            COperador.Operador[] oLista = WSOperador.SelecionarTodos();
            DtgOperador.AutoGenerateColumns = false;
            DtgOperador.DataSource = oLista;

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            COperador.Operador oOp = new COperador.Operador();
            oOp.Nome = TxtNomeOperador.Text;
          //  oOp.Cod_op =int.Parse(TxtCodOperador.Text);
            oOp.Cargo = TxtCargo.Text;
            oOp.Telefone_fixo = MaskTxtTel.Text;
            oOp.CPF = MaskTxtCPF.Text;
            oOp.Telefone_celular = MaskTxtCel.Text;
            oOp.Logradouro = TxtLogradouro.Text;
            oOp.Bairro = TxtBairro.Text;
            oOp.Cidade = TxtCidade.Text;
            oOp.CEP = MaskTxtCEP.Text;
            oOp.UF = TxtUF.Text;
            oOp.Data_admissão = DateTime.Parse(DateTimeAdmissão.Text);
            oOp.Data_nascimento = DateTime.Parse(DateTimeNascimento.Text);


            COperador.COperadorClient WSOperador = new COperador.COperadorClient();
            WSOperador.Open();
            if (Incluir)
            {
                WSOperador.Incluir(oOp);
            }
            else
            {
                oOp.Cod_op = int.Parse(TxtCodOperador.Text);
                WSOperador.Alterar(oOp);
            }
            SubCarregaGrid(WSOperador);
            WSOperador.Close();
        }
    }
}
