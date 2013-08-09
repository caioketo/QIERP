﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QIERPDatabase;
using QIERP.Utils;
using QIERPDatabase.Classes;

namespace QIERP
{
    public partial class FVenda : BaseForm
    {
        private Produto produtoAchado;
        public Venda VendaAtual;
        public BaseVenda VendaOrcAtual;
        public bool Orcamento = false;

        public FVenda()
        {
            InitializeComponent();
        }

        public void AddItem(Item item)
        {
            //if (VendaAtual == null)
            //{
                //VendaAtual = new Venda();
                //itemBindingSource.DataSource = VendaAtual.Itens;
            //}
            if (VendaOrcAtual == null)
            {
                VendaOrcAtual = new Venda();
                itemBindingSource.DataSource = VendaOrcAtual.Itens;
            }
            VendaOrcAtual.Itens.Add(item);
            //VendaAtual.Itens.Add(item);
            produtoAchado.Quantidade -= item.Quantidade;
            //rtbTotal.Text = "Total: " + VendaAtual.Total.ToString("C2") + Environment.NewLine 
                //+ "Total Itens: " + VendaAtual.Itens.Count.ToString();
            rtbTotal.Text = "Total: " + VendaOrcAtual.Total.ToString("C2") + Environment.NewLine
                + "Total Itens: " + VendaOrcAtual.Itens.Count.ToString();
        }


        private void Venda_Shown(object sender, EventArgs e)
        {
            itemBindingSource.DataSource = null;
            rtbTotal.Text = "CAIXA ABERTO" + Environment.NewLine + "PASSE O ITEM";
        }

        public void textBox2_Leave(object sender, EventArgs e)
        {
            Produto prod = DB.GetInstance().ProdutoRepo.GetAll().Where(p => p.Codigo == tbxProduto.Text).FirstOrDefault();
            if (prod != null)
            {
                produtoAchado = prod;
            }
            else
            {
                using (FCRUDProduto crud = new FCRUDProduto())
                {
                    crud.TextoInicial = tbxProduto.Text;
                    object resultado = crud.Selecionar();
                    if (resultado != null)
                    {
                        prod = (Produto)resultado;
                        produtoAchado = prod;
                        tbxProduto.Text = produtoAchado.Codigo;
                        tbxQtde.Focus();
                    }
                    else
                    {
                        tbxProduto.Focus();
                    }
                }
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(tbxQtde.Text);
            }
            catch (Exception)
            {
                Mensagem.MostrarMsg(40004);
                tbxQtde.Focus();
                return;
            }

            if (!Orcamento)
            {
                AddItem(new Item(produtoAchado, Convert.ToDouble(tbxQtde.Text)));
                tbxProduto.Clear();
                tbxQtde.Clear();
            }
        }

        private void FecharVenda(FormaDePagamento fp)
        {
            using (FFechaVenda fechaVenda = new FFechaVenda())
            {
                if (!Orcamento)
                {
                    fechaVenda.FP = fp;
                }
                fechaVenda.fVenda = this;
                fechaVenda.VendaOrcAtual = this.VendaOrcAtual;
                fechaVenda.Orcamento = this.Orcamento;
                fechaVenda.ShowDialog();

                //if (VendaAtual == null)
                if (VendaOrcAtual == null)
                {
                    itemBindingSource.DataSource = null;
                    if (Orcamento)
                    {
                        rtbTotal.Text = "ORÇAMENTO" + Environment.NewLine + "PASSE O ITEM";
                    }
                    else
                    {
                        rtbTotal.Text = "CAIXA ABERTO" + Environment.NewLine + "PASSE O ITEM";
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FecharVenda(null);
        }

        private void FVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                //if (VendaAtual != null)
                if (VendaOrcAtual != null) 
                {
                    if (Mensagem.MostrarMsg(30001) != System.Windows.Forms.DialogResult.Yes)
                    {
                        return;
                    }
                }
                this.Close();
            }

            if (Util.GetFP(e.KeyCode) != null)
            {
                FecharVenda(Util.GetFP(e.KeyCode));
            }
        }

        private void tbxQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !e.KeyChar.Equals(','))
            {
                e.Handled = true;
            }

        }

        private void tbxPreco_Leave(object sender, EventArgs e)
        {
            
        }

        private void importarOrçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
