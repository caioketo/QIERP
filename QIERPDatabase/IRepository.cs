using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIERPDatabase
{
    public interface IRepository<T>
    {
        bool Salvar(T item);
        bool Inserir(T item);
        T GetById(int id);
        IQueryable<T> GetAll();
        bool Deletar(T item);
    }
}
