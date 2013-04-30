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

namespace VERP
{
    public partial class FCRUD : Form
    {
        private string[] campos;
        public string[] Campos
        {
            get
            {
                return campos;
            }
            set
            {
                campos = value;
            }
        }

        private string[] titulos;
        public string[] Titulos
        {
            get
            {
                return titulos;
            }
            set
            {
                titulos = value;
            }
        }

        private string[] formats;
        public string[] Formats
        {
            get
            {
                return formats;
            }
            set
            {
                formats = value;
            }
        }

        private string[] tiposCampos;
        public string[] TiposCampos
        {
            get
            {
                return tiposCampos;
            }
            set
            {
                tiposCampos = value;
            }
        }

        public BindingSource bindingSource = new BindingSource();


        public FCRUD()
        {
            InitializeComponent();
        }

        private void FCRUD_Shown(object sender, EventArgs e)
        {
            if (campos != null)
            {
                for (int i = 0; i < campos.Length; i++)
                {
                    DataGridViewColumn col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    col.DataPropertyName = campos[i];
                    col.DefaultCellStyle = new DataGridViewCellStyle();
                    if (!formats[i].Equals(""))
                    {
                        col.DefaultCellStyle.Format = formats[i];
                    }
                    col.HeaderText = titulos[i];
                    col.Name = titulos[i];
                    dgvCRUD.Columns.Add(col);
                }
            }

            dgvCRUD.AutoGenerateColumns = false;
            dgvCRUD.DataSource = bindingSource;
        }
    }
}
