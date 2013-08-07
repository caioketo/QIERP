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
using QIERP.CRUD;
using QIERP.Utils;
using QIERPDatabase;

namespace QIERP
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
                venda.Orcamento = false;
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
            //this.Close();
        }

        private void movimentaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FCRUDMovimentacao crud = new FCRUDMovimentacao())
            {
                crud.ShowDialog();
            }
        }

        private void clientesVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FCRUDPessoa crud = new FCRUDPessoa())
            {
                crud.ShowDialog();
            }
        }

        private void contasÀReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FCRUDCR crud = new FCRUDCR())
            {
                crud.ShowDialog();
            }
        }

        private void contasÀPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FCRUDCP crud = new FCRUDCP())
            {
                crud.ShowDialog();
            }
        }

        private void chequesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FCRUDCheque crud = new FCRUDCheque())
            {
                crud.ShowDialog();
            }
        }

        private void notasFiscaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FCRUDNota crud = new FCRUDNota())
            {
                crud.ShowDialog();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void criarOrçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FVenda venda = new FVenda())
            {
                venda.Orcamento = true;
                venda.ShowDialog();
            }
        }

        private void consultaOrçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FConsVenda consulta = new FConsVenda())
            {
                consulta.Orcamento = true;
                consulta.ShowDialog();
            }
        }
    }
}
