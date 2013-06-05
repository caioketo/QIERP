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
using VERP.Utils;
using VERPDatabase;

namespace VERP
{
    public partial class FConsVenda : BaseForm
    {
        public FConsVenda()
        {
            InitializeComponent();
        }

        public void BindItensFps()
        {
            try
            {
                itemBindingSource.DataSource = ((Venda)vendaBindingSource.Current).Itens;
                pagamentoBindingSource.DataSource = ((Venda)vendaBindingSource.Current).Pagamentos;
            }
            catch
            {
                return;
            }
        }

        private void vendaBindingSource_PositionChanged(object sender, EventArgs e)
        {
            BindItensFps();
        }

        private void FConsVenda_Shown(object sender, EventArgs e)
        {
            vendaBindingSource.DataSource = DB.GetInstance().VendaRepo.GetAll();
        }

        private void vendaBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            BindItensFps();
        }

        private void FConsVenda_Load(object sender, EventArgs e)
        {
            DB.GetInstance().context.Vendas.Load();
            DB.GetInstance().context.Items.Load();
            DB.GetInstance().context.Pagamentos.Load();
        }

        private void FConsVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (Mensagem.MostrarMsg(30000) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
    }
}
