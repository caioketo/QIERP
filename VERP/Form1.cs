using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VERP.CRUD;
using VERP.Utils;
using VERPDatabase;

namespace VERP
{
    public partial class Form1 : BaseForm
    {
        public Splash splash;
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FVenda venda = new FVenda())
            {
                venda.ShowDialog();
            }
        }

        private void consultaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FConsVenda consVenda = new FConsVenda())
            {
                consVenda.ShowDialog();
            }
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FCRUDProduto crud = new FCRUDProduto())
            {
                crud.ShowDialog();
            }
        }

        private void formasDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FCRUDFormaDePagamento crud = new FCRUDFormaDePagamento())
            {
                crud.ShowDialog();
            }
        }

        private void condiçõesDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FCRUDCondicaoDePagamento crud = new FCRUDCondicaoDePagamento())
            {
                crud.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void movimentaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FCRUDMovimentacao crud = new FCRUDMovimentacao())
            {
                crud.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FCRUDPessoa crud = new FCRUDPessoa())
            {
                crud.ShowDialog();
            }
        }
    }
}
