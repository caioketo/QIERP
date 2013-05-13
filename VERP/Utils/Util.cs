using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERP.Utils
{
    public class Util
    {
        public static string GetNomeReal(string nomeCampo)
        {
            if (nomeCampo.Contains("cao"))
            {
                nomeCampo.Replace("cao", "ção");
            }

            if (nomeCampo.ToUpper().Equals("CODIGO"))
            {
                nomeCampo = "Código";
            }

            return nomeCampo;
        }
    }
}
