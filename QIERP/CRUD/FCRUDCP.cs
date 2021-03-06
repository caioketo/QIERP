﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QIERPDatabase;
using QIERPDatabase.Classes;
using QIERP.Utils;
using QIERP.Edicao;

namespace QIERP.CRUD
{
    public partial class FCRUDCP : QIERP.FCRUD
    {
        protected override void GetRecords()
        {
            bindingSource.DataSource = DB.GetInstance().CPRepo.GetAll().Where(p => p.Descricao.ToUpper().Contains(tbxPesquisa.Text) && p.Baixa == null);
        }

        public override void btnGridClick(int column, int row)
        {
            //Baixar Conta
            ContaPagar cp = dgvCRUD.Rows[row].DataBoundItem as ContaPagar;
            if (cp != null)
            {
                if (column == 4 && cp.Baixa == null && Mensagem.MostrarMsg(30003) == System.Windows.Forms.DialogResult.Yes)
                {
                    cp.Baixa = DateTime.Now;
                    DB.GetInstance().CPRepo.Salvar(cp);
                    GetRecords();
                }
            }
        }

        public FCRUDCP()
        {
            tabela = DB.GetInstance().GetTabela("CR");
            Edicao = new FEdicaoCP();
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Mensagem.MostrarMsg(30002) == System.Windows.Forms.DialogResult.Yes)
            {
                DB.GetInstance().CPRepo.Deletar((ContaPagar)bindingSource.Current);
                DB.GetInstance().context.SaveChanges();
                GetRecords();
            }
        }

        private void FCRUDCP_Shown(object sender, EventArgs e)
        {
            DataGridViewCellStyle RedCellStyle = null;
            RedCellStyle = new DataGridViewCellStyle();
            RedCellStyle.BackColor = Color.Red;
            DataGridViewCellStyle YellowCellStyle = null;
            YellowCellStyle = new DataGridViewCellStyle();
            YellowCellStyle.BackColor = Color.Yellow;

            foreach (DataGridViewRow row in dgvCRUD.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    if (((DateTime)row.Cells[2].Value).Date <= (DateTime.Now.Date.AddDays(3)))
                    {
                        row.DefaultCellStyle = RedCellStyle;
                    }
                    else if (((DateTime)row.Cells[2].Value).Date <= (DateTime.Now.Date.AddDays(10)))
                    {
                        row.DefaultCellStyle = YellowCellStyle;
                    }
                }
            }
        }

        private void FCRUDCP_Activated(object sender, EventArgs e)
        {
            DataGridViewCellStyle RedCellStyle = null;
            RedCellStyle = new DataGridViewCellStyle();
            RedCellStyle.BackColor = Color.Red;
            DataGridViewCellStyle YellowCellStyle = null;
            YellowCellStyle = new DataGridViewCellStyle();
            YellowCellStyle.BackColor = Color.Yellow;

            foreach (DataGridViewRow row in dgvCRUD.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    if (((DateTime)row.Cells[2].Value).Date <= (DateTime.Now.Date.AddDays(3)))
                    {
                        row.DefaultCellStyle = RedCellStyle;
                    }
                    else if (((DateTime)row.Cells[2].Value).Date <= (DateTime.Now.Date.AddDays(10)))
                    {
                        row.DefaultCellStyle = YellowCellStyle;
                    }
                }
            }
        }
    }
}
