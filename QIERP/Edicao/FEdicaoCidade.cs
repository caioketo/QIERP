using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QIERP.Classes;
using QIERP.CRUD;
using QIERP.Utils;
using QIERPDatabase;
using QIERPDatabase.Classes;

namespace QIERP.Edicao
{
    public partial class FEdicaoCidade : QIERP.FEdicao
    {
        private Cidade cidade;

        public FEdicaoCidade()
        {
            InitializeComponent();
        }

        protected override void Gravar()
        {
            if (estado == Estado.Inserir)
            {
                DB.GetInstance().CidadeRepo.Inserir(cidade);
            }
            else if (estado == Estado.Modificar)
            {
                DB.GetInstance().CidadeRepo.Salvar(cidade);
            }

            this.Close();
        }

        protected override void Mapear()
        {
            cidade.Descricao = tbxDescricao.Text;
            cidade.Estado = pesEstado.Objeto as UF;
        }

        private void MapearTela()
        {
            tbxDescricao.Text = cidade.Descricao;
            pesEstado.Objeto = cidade.Estado;
            pesEstado.Selecionar();
        }

        private void FEdicaoCidade_Shown(object sender, EventArgs e)
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
                cidade = new Cidade();
                Objeto = cidade;
            }
            else if (estado == Estado.Modificar)
            {
                cidade = Objeto as Cidade;
                MapearTela();
            }
        }

        private void FEdicaoCidade_Load(object sender, EventArgs e)
        {
            pesEstado.CRUD = new FCRUDUF();
            pesEstado.Campo = "Codigo";
            pesEstado.CampoDisplay = "Descricao";
            pesEstado.Titulo = "UF";
            pesEstado.Repo = Util.GetRepo("UFs");
        }

    }
}
