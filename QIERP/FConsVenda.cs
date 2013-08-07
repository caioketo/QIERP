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
using QIERP.Utils;
using QIERPDatabase;
using QIERPDatabase.Classes;
using QIERP.Relatorios;

namespace QIERP
{
    public partial class FConsVenda : BaseForm
    {
        public bool Orcamento = false;

        public FConsVenda()
        {
            InitializeComponent();
        }

        public void BindItensFps()
        {
            try
            {
                if (!Orcamento)
                {
                    itemBindingSource.DataSource = ((Venda)vendaBindingSource.Current).Itens;
                    pagamentoBindingSource.DataSource = ((Venda)vendaBindingSource.Current).Pagamentos;
                }
                else
                {
                    itemBindingSource.DataSource = ((Orcamento)vendaBindingSource.Current).Itens;
                }
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
            if (Orcamento)
            {
                vendaBindingSource.DataSource = DB.GetInstance().OrcamentoRepo.GetAll().OrderByDescending(o => o.Numero);
                dataGridView1.Columns[0].HeaderText = "Número";
                dataGridView1.Columns[0].DataPropertyName = "Numero";
                pnlBotoes.Visible = true;
            }
            else
            {
                vendaBindingSource.DataSource = DB.GetInstance().VendaRepo.GetAll().OrderByDescending(v => v.Pedido);
                dataGridView1.Columns[0].HeaderText = "Pedido";
                dataGridView1.Columns[0].DataPropertyName = "Pedido";
                pnlBotoes.Visible = false;
            }
            MudaCor();
        }

        private void vendaBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            BindItensFps();
        }

        private void FConsVenda_Load(object sender, EventArgs e)
        {
            DB.GetInstance().context.Vendas.Load();
            DB.GetInstance().context.Orcamentos.Load();
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

        public void MudaCor()
        {
            DataGridViewCellStyle RedCellStyle = null;
            RedCellStyle = new DataGridViewCellStyle();
            RedCellStyle.BackColor = Color.Red;
            DataGridViewCellStyle YellowCellStyle = null;
            YellowCellStyle = new DataGridViewCellStyle();
            YellowCellStyle.BackColor = Color.Yellow;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (((BaseVenda)row.DataBoundItem).DataExclusao != null)
                {
                    row.DefaultCellStyle = RedCellStyle;
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (Mensagem.MostrarMsg(30003) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (Orcamento)
                    {
                        DB.GetInstance().OrcamentoRepo.Deletar((Orcamento)vendaBindingSource.Current);
                        DB.GetInstance().context.SaveChanges();
                        vendaBindingSource.DataSource = DB.GetInstance().OrcamentoRepo.GetAll();
                    }
                    else
                    {
                        DB.GetInstance().VendaRepo.Deletar((Venda)vendaBindingSource.Current);
                        DB.GetInstance().context.SaveChanges();
                        vendaBindingSource.DataSource = DB.GetInstance().VendaRepo.GetAll();
                    }
                    MudaCor();
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            using (RPOrcamento rel = new RPOrcamento())
            {
                rel.ShowDialog();
            }
        }
    }
}
