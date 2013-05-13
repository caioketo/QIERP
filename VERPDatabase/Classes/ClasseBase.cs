using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERPDatabase.Classes
{
    public class ClasseBase
    {
        public int Id { get; set; }

        public ClasseBase()
        {
            this.Id = -1;
        }

        public ClasseBase(int id)
        {
            this.Id = id;
        }
    }
}
