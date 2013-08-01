using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QIERP.Classes;
using QIERPDatabase;
using QIERPDatabase.Classes;

namespace QIERP.Edicao
{
    public partial class FEdicaoUF : QIERP.FEdicao
    {
        private UF uf;

        public FEdicaoUF()
        {
            InitializeComponent();
        }

        protected override void Gravar()
        {
            if (estado == Estado.Inserir)
            {
                DB.GetInstance().UFRepo.Inserir(uf);
            }
            else if (estado == Estado.Modificar)
            {
                DB.GetInstance().UFRepo.Salvar(uf);
            }

            this.Close();
        }

        protected override void Mapear()
        {
            uf.Descricao = tbxDescricao.Text;
            uf.Codigo = tbxCodigo.Text;
        }

        private void MapearTela()
        {
            tbxDescricao.Text = uf.Descricao;
            tbxCodigo.Text = uf.Codigo;
        }

        private void FEdicaoUF_Shown(object sender, EventArgs e)
        {
            foreach (Control ctr in Controls)
            {
                if (ctr is TextBox)
                {
                    ((TextBox)ctr).Clear();
                }
            }
            if (estado == Estado.Inserir)
            {
                uf = new UF();
                Objeto = uf;
            }
            else if (estado == Estado.Modificar)
            {
                uf = Objeto as UF;
                MapearTela();
            }
        }
    }
}
