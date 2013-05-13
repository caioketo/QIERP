using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VERPDatabase;

namespace VERP
{
    public partial class FConsVenda : Form
    {
        public FConsVenda()
        {
            InitializeComponent();
        }

        private void vendaBindingSource_PositionChanged(object sender, EventArgs e)
        {
            itemBindingSource.DataSource = ((Venda)vendaBindingSource.Current).Itens;
            pagamentoBindingSource.DataSource = ((Venda)vendaBindingSource.Current).Pagamentos;
        }

        private void FConsVenda_Shown(object sender, EventArgs e)
        {
            vendaBindingSource.DataSource = DB.GetInstance().VendaRepo.GetAll();
        }

        private void vendaBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            itemBindingSource.DataSource = ((Venda)vendaBindingSource.Current).Itens;
            pagamentoBindingSource.DataSource = ((Venda)vendaBindingSource.Current).Pagamentos;
        }
    }
}
