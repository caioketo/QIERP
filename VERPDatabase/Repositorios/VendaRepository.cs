using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERPDatabase
{
    public class VendaRepository : IRepository<Venda>
    {
        public IQueryable<Venda> GetAll()
        {
            DB.GetInstance().context.Vendas.Load();
            return DB.GetInstance().context.Vendas.Local.AsQueryable().Where(v => v.DataExclusao == null);
        }

        public bool Salvar(Venda item)
        {
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public bool Inserir(Venda item)
        {
            item.Pedido = DB.GetInstance().context.GetSequence("sqnPedido");
            DB.GetInstance().context.Vendas.Add(item);
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public Venda GetById(int id)
        {
            return DB.GetInstance().context.Vendas.Find(id);
        }

        public bool Deletar(Venda item)
        {
            DB.GetInstance().context.Entry<Venda>(item).State = System.Data.EntityState.Modified;
            item.DataExclusao = DateTime.Now;
            return true;
        }
    }
}
