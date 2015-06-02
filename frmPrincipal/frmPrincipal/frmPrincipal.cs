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
    public partial class btnVenda : Form
    {
        public btnVenda()
        {
            InitializeComponent();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMenuRelatorio frm = new frmMenuRelatorio();
            frm.Show();
        }

        private void btnCadProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos Outroform = new frmProdutos();
            Outroform.Show();
        }

        private void btnCadFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedor Outroform = new frmFornecedor();
            Outroform.Show();
        }

        private void btnCadOperador_Click(object sender, EventArgs e)
        {
            frmOperador Outroform = new frmOperador();
            Outroform.Show();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            frmVenda Outroform = new frmVenda();
            Outroform.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cadastroDeOperadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOperador Outroform = new frmOperador();
            Outroform.Show();
        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutos Outroform = new frmProdutos();
            Outroform.Show();
        }

        private void cadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor Outroform = new frmFornecedor();
            Outroform.Show();
        }

        private void cadastrarVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenda Outroform = new frmVenda();
            Outroform.Show();
        }

        private void cadastrarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoProduto Outroform = new frmTipoProduto();
            Outroform.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
