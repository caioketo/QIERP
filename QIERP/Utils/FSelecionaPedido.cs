using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QIERP.Utils;
using QIERPDatabase;
using QIERPDatabase.Classes;

namespace QIERP.Utils
{
    public partial class FSelecionaPedido : Form
    {
        public Expression<Func<T, bool>> Combine<T>(Expression<Func<T, Boolean>> first, Expression<Func<T, Boolean>> second)
        {
            var toInvoke = Expression.Invoke(second, first.Parameters);

            return (Expression<Func<T, Boolean>>)Expression.Lambda(Expression.AndAlso(first.Body, toInvoke), first.Parameters);
        }

        public Expression<Func<Venda, bool>> Filtro = x => x.DataExclusao == null;
        public Expression<Func<Orcamento, bool>> FiltroOrc = x => x.DataExclusao == null;
        public Venda resultado = null;
        public Orcamento resultadoOrc = null;

        public bool Orcamento = false;

        public FSelecionaPedido()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (tbxPedido.Text.Equals(""))
            {
                return;
            }
            if (!Orcamento)
            {
                Filtro = Combine<Venda>(Filtro, x => x.Pedido == Convert.ToInt32(tbxPedido.Text));
                Venda venda = DB.GetInstance().VendaRepo.GetAll().Where(Filtro).FirstOrDefault();
                if (venda != null)
                {
                    tbxPedido.ReadOnly = true;
                    tbxPedido.Text = venda.Pedido.ToString() + " - " + venda.Total.ToString("c") + " - " + venda.ClienteNome;
                    tbxPedido.BackColor = Color.LightGray;
                    resultado = venda;
                }
                else
                {
                    Mensagem.MostrarMsg(40006);
                    tbxPedido.Focus();
                }
            }
            else
            {
                FiltroOrc = Combine<Orcamento>(FiltroOrc, x => x.Numero == Convert.ToInt32(tbxPedido.Text));
                Orcamento orc = DB.GetInstance().OrcamentoRepo.GetAll().Where(FiltroOrc).FirstOrDefault();
                if (orc != null)
                {
                    tbxPedido.ReadOnly = true;
                    tbxPedido.Text = orc.Numero.ToString() + " - " + orc.Total.ToString("c") + " - " + orc.ClienteNome;
                    tbxPedido.BackColor = Color.LightGray;
                    resultadoOrc = orc;
                }
                else
                {
                    Mensagem.MostrarMsg(40006);
                    tbxPedido.Focus();
                }
            }
        }

        private void tbxPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back && tbxPedido.ReadOnly)
            {
                resultado = null;
                tbxPedido.Text = "";
                tbxPedido.ReadOnly = false;
                tbxPedido.BackColor = SystemColors.Window;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resultado = null;
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (resultado != null)
            {
                Close();
            }
        }
    }
}
