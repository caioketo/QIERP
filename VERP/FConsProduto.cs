﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;

namespace VERP
{
    public partial class FConsProduto : Form
    {
        private BindingList<Produto> Produtos;
        private void GetProdutos()
        {
            Produtos = new BindingList<Produto>(DB.ProdutoRepo.GetAll().Where(p => p.Descricao.Contains(tbxProduto.Text)).ToList());
            dgvProdutos.DataSource = Produtos;
        }

        public FConsProduto()
        {
            InitializeComponent();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            GetProdutos();
        }
        
        private void FConsProduto_Load(object sender, EventArgs e)
        {
            GetProdutos();
        }
    }
}