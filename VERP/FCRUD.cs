using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public FCRUD()
        {
            InitializeComponent();
        }
    }
}
