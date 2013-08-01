using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QIERPDatabase.Classes;

namespace QIERPDatabase.Repositorios
{
    public abstract class ExtRepository
    {
        public abstract dynamic GetAllExt();
        public abstract dynamic GetByIdExt(int id);
        public abstract dynamic GetByText(string text);
        public abstract bool Inserir(object objeto);
        public abstract bool Salvar(object objeto);
        public abstract List<int> GetIds();
        public abstract dynamic GetFields(string field);
    }
}
