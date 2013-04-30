using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VERP
{
    public partial class CRUD : UserControl
    {
        private BindingSource bs = new BindingSource();
        private List<DataGridViewColumn> Colunas = new List<DataGridViewColumn>();

        public void setBingingSource(BindingSource _bs)
        {
            bs = _bs;
            dgvCRUD.AutoGenerateColumns = false;
            dgvCRUD.DataSource = bs;
        }

        public void AddColumn(string nomeColuna, string nomeCampo)
        {
            AddColumn(nomeColuna, nomeCampo, null);
        }

        public void AddColumn(string nomeColuna, string nomeCampo, string format)
        {
            DataGridViewColumn col = new DataGridViewColumn(new DataGridViewTextBoxCell());
            col.DataPropertyName = nomeCampo;
            col.DefaultCellStyle = new DataGridViewCellStyle();
            if (format != null)
            {
                col.DefaultCellStyle.Format = format;
            }
            col.HeaderText = nomeColuna;
            col.Name = nomeColuna;
            dgvCRUD.Columns.Add(col);
        }

        public CRUD()
        {
            InitializeComponent();
        }
    }
}
