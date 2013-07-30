using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VERP.Classes;
using VERPDatabase;
using VERPDatabase.Classes;

namespace QIERP.Edicao
{
    public partial class FEdicaoNota : VERP.FEdicao
    {
        public FEdicaoNota()
        {
            this.importacao = false;
            InitializeComponent();
        }

        private NotaFiscal nota;
        public bool importacao;

        protected override void Gravar()
        {
            if (estado == Estado.Inserir)
            {
                DB.GetInstance().NotaRepo.Inserir(nota);
            }
            else if (estado == Estado.Modificar)
            {
                DB.GetInstance().NotaRepo.Salvar(nota);
            }
            this.importacao = false;
            this.Close();
        }

        protected override void Mapear()
        {
            nota.Numero = tbxNumero.Text;
        }

        private void MapearTela()
        {
            tbxNumero.Text = nota.Numero;
            tbxVenda.Text = nota.Pedido.ToString();
        }

        private void FEdicaoNota_Shown(object sender, EventArgs e)
        {
            foreach (Control ctr in Controls)
            {
                if (ctr is TextBox)
                {
                    ((TextBox)ctr).Clear();
                }
            }
            if (estado == Estado.Inserir && (!this.importacao))
            {
                nota = new NotaFiscal();
                Objeto = nota;
            }
            else if (estado == Estado.Modificar || this.importacao)
            {
                nota = Objeto as NotaFiscal;
                MapearTela();
            }
        }
    }
}
