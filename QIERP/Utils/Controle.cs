using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VERP.Utils
{
    public class Controle
    {
        public Label label;
        public Control control;

        public Controle(Label lbl, Control ctr)
        {
            this.label = lbl;
            this.control = ctr;
        }
    }
}
