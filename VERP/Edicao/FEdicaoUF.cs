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

namespace VERP.Edicao
{
    public partial class FEdicaoUF : VERP.FEdicao
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

        private void FEdicaoUF_Shown(object sender, EventArgs e)
        {
            foreach (Control ctr in Controles)
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
