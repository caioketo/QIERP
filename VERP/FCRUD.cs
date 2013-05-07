using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;
using VERP.Classes;

namespace VERP
{
    public partial class FCRUD : Form
    {
        private FEdicao Edicao;

        public List<Campo> Campos = new List<Campo>();
        public BindingSource bindingSource = new BindingSource();


        public FCRUD()
        {
            InitializeComponent();
            Edicao = new FEdicao();
            Edicao.CRUD = this;
        }

        private void FCRUD_Shown(object sender, EventArgs e)
        {
            foreach (Campo campo in Campos)
            {
                if (campo.MostraGrid)
                {
                    DataGridViewColumn col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    col.DataPropertyName = campo.Nome;
                    col.DefaultCellStyle = new DataGridViewCellStyle();
                    if (!campo.Formatacao.Equals(""))
                    {
                        col.DefaultCellStyle.Format = campo.Formatacao;
                    }
                    col.HeaderText = campo.Titulo;
                    col.Name = campo.Titulo;
                    dgvCRUD.Columns.Add(col);
                }
            }

            dgvCRUD.AutoGenerateColumns = false;
            dgvCRUD.DataSource = bindingSource;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Edicao.ShowDialog();
        }
    }
}
