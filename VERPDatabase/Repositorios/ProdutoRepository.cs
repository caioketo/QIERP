using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VERPDatabase.Repositorios;

namespace VERPDatabase
{
    public class ProdutoRepository : ExtRepository, IRepository<Produto>
    {
        public IQueryable<Produto> GetAll()
        {
            DB.GetInstance().context.Produtos.Load();
            return DB.GetInstance().context.Produtos.Local.AsQueryable().Where(p => p.DataExclusao == null);
        }

        public bool Salvar(Produto item)
        {
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public bool Inserir(Produto item)
        {
            DB.GetInstance().context.Produtos.Add(item);
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public Produto GetById(int id)
        {
            return DB.GetInstance().context.Produtos.Find(id);
        }

        public bool Deletar(Produto item)
        {
            DB.GetInstance().context.Entry<Produto>(item).State = System.Data.EntityState.Modified;
            item.DataExclusao = DateTime.Now;
            return true;
        }

        public override dynamic GetAllExt()
        {
            return this.GetAll().ToList();
        }

        public override dynamic GetByIdExt(int id)
        {
            return this.GetById(id);
        }

        public override dynamic GetByText(string text)
        {
            return this.GetAll().Where(p => p.Codigo.ToUpper().Equals(text.ToUpper())).FirstOrDefault();
        }

        public override bool Inserir(object objeto)
        {
            return this.Inserir(objeto as Produto);
        }

        public override bool Salvar(object objeto)
        {
            return this.Salvar(objeto as Produto);
        }
    }
}
