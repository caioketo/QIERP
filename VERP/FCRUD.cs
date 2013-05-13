using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VERPDatabase;
using VERPDatabase.Classes;
using VERP.Classes;
using VERP.Utils;

namespace VERP
{
    public partial class FCRUD : Form
    {
        protected FEdicao Edicao;

        public List<Campo> Campos
        {
            get
            {
                if (tabela != null)
                {
                    return tabela.Campos;
                }
                else
                {
                    return new List<Campo>();
                }
            }
        }
        public Tabela tabela;
        public BindingSource bindingSource = new BindingSource();

        public FCRUD()
        {
            InitializeComponent();
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

            if (Edicao != null)
            {
                Edicao.CRUD = this;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Edicao.estado = Estado.Inserir;
            Edicao.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Edicao.estado = Estado.Modificar;
            Edicao.Objeto = (ClasseBase)bindingSource.Current;
            Edicao.ShowDialog();
        }

        private void FCRUD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (Mensagem.MostrarMsg(30000) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
    }
}
