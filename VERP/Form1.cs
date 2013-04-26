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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FVenda venda = new FVenda())
            {
                venda.ShowDialog();
            }
        }

        private void consultaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FConsVenda consVenda = new FConsVenda())
            {
                consVenda.ShowDialog();
            }
        }
    }
}
