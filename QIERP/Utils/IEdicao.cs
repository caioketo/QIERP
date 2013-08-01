using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QIERPDatabase.Classes;
using QIERPDatabase.Repositorios;

namespace QIERP.Utils
{
    public interface IEdicao
    {
        Control GetControl(string nome);
        ExtRepository GetRepo();
        Campo GetCampo(string nome);
        void tbx_Leave(object sender, EventArgs e);
    }
}
