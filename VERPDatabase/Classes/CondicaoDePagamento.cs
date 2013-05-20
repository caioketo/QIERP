using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VERPDatabase.Classes;

namespace VERPDatabase
{
    public class CondicaoDePagamento : ClasseBase
    {
        public string Descricao { get; set; }
        public FormaDePagamento Forma { get; set; }
        public string FormaDescricao
        {
            get
            {
                if (Forma == null)
                {
                    return "";
                }
                return Forma.Descricao;
            }
        }
    }
}
