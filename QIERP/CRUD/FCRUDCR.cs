using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QIERP.Utils;
using QIERPDatabase;
using QIERPDatabase.Classes;
using QIERP.Edicao;

namespace QIERP.CRUD
{
    public partial class FCRUDCR : QIERP.FCRUD
    {
        protected override void GetRecords()
        {
            bindingSource.DataSource = DB.GetInstance().CRRepo.GetAll().Where(p => p.Descricao.ToUpper().Contains(tbxPesquisa.Text) && p.Baixa == null);
        }

        public FCRUDCR()
        {
            tabela = DB.GetInstance().GetTabela("CR");
            Edicao = new FEdicaoCR();
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Mensagem.MostrarMsg(30002) == System.Windows.Forms.DialogResult.Yes)
            {
                DB.GetInstance().CRRepo.Deletar((ContaReceber)bindingSource.Current);
                DB.GetInstance().context.SaveChanges();
                GetRecords();
            }
        }

        private void FCRUDCR_Shown(object sender, EventArgs e)
        {
            DataGridViewCellStyle RedCellStyle = null;
            RedCellStyle = new DataGridViewCellStyle();
            RedCellStyle.BackColor = Color.Red;
            DataGridViewCellStyle YellowCellStyle = null;
            YellowCellStyle = new DataGridViewCellStyle();
            YellowCellStyle.BackColor = Color.Yellow;

            foreach (DataGridViewRow row in dgvCRUD.Rows)
            {
                if (row.Cells[2] != null)
                {
                    if (((DateTime)row.Cells[2].Value).Date <= (DateTime.Now.Date.AddDays(2)))
                    {
                        row.DefaultCellStyle = RedCellStyle;
                    }
                    else if (((DateTime)row.Cells[2].Value).Date <= (DateTime.Now.Date.AddDays(4)))
                    {
                        row.DefaultCellStyle = YellowCellStyle;
                    }
                }
            }
        }

        private void FCRUDCR_Activated(object sender, EventArgs e)
        {
            DataGridViewCellStyle RedCellStyle = null;
            RedCellStyle = new DataGridViewCellStyle();
            RedCellStyle.BackColor = Color.Red;
            DataGridViewCellStyle YellowCellStyle = null;
            YellowCellStyle = new DataGridViewCellStyle();
            YellowCellStyle.BackColor = Color.Yellow;

            foreach (DataGridViewRow row in dgvCRUD.Rows)
            {
                if (row.Cells[2] != null)
                {
                    if (((DateTime)row.Cells[2].Value).Date <= (DateTime.Now.Date.AddDays(2)))
                    {
                        row.DefaultCellStyle = RedCellStyle;
                    }
                    else if (((DateTime)row.Cells[2].Value).Date <= (DateTime.Now.Date.AddDays(4)))
                    {
                        row.DefaultCellStyle = YellowCellStyle;
                    }
                }
            }
        }

        public override void btnGridClick(int column, int row)
        {
            //Baixar Conta
            ContaReceber cr = dgvCRUD.Rows[row].DataBoundItem as ContaReceber;
            if (cr != null)
            {
                if (cr.Baixa != null)
                {
                    cr.Baixa = DateTime.Now;
                    DB.GetInstance().CRRepo.Salvar(cr);
                    GetRecords();
                }
            }
        }
        
    }
}
