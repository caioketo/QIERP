using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERPDatabase.Repositorios
{
    public abstract class ExtRepository
    {
        public abstract dynamic GetAllExt();
        public abstract dynamic GetByIdExt(int id);
    }
}
