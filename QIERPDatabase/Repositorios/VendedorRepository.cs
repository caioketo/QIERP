using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using VERPDatabase.Classes;

namespace VERPDatabase.Repositorios
{
    public class VendedorRepository: ExtRepository, IRepository<Vendedor>
    {
        public IQueryable<Vendedor> GetAll()
        {
            DB.GetInstance().context.Vendedores.Load();
            return DB.GetInstance().context.Vendedores.Local.AsQueryable().Where(c => c.DataExclusao == null).AsQueryable();
        }

        public bool Salvar(Vendedor item)
        {
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public bool Inserir(Vendedor item)
        {
            DB.GetInstance().context.Vendedores.Add(item);
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public Vendedor GetById(int id)
        {
            return DB.GetInstance().context.Vendedores.Find(id);
        }

        public bool Deletar(Vendedor item)
        {
            DB.GetInstance().context.Entry<Vendedor>(item).State = System.Data.EntityState.Modified;
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
            return this.GetAll().Where(p => p.Pessoa.Nome.ToUpper().Equals(text.ToUpper())).FirstOrDefault();
        }

        public override bool Inserir(object objeto)
        {
            return this.Inserir(objeto as Vendedor);
        }

        public override bool Salvar(object objeto)
        {
            return this.Salvar(objeto as Vendedor);
        }

        public override List<int> GetIds()
        {
            var ids = from e in DB.GetInstance().context.Vendedores
                      where e.DataExclusao == null
                      select e.Id;
            return ids.ToList();
        }

        public override dynamic GetFields(string field)
        {
            if (field.Equals("Pessoa_Id"))
            {
                var fields = from e in DB.GetInstance().context.Vendedores
                             where e.DataExclusao == null
                             select e.Pessoa.Id;
                return fields.ToList();
            }
            else
            {
                return null;
            }
        }

        public Vendedor GetByPessoa(Pessoa pessoa)
        {
            Vendedor vendedor = this.GetAll().Where(v => v.Pessoa.Id == pessoa.Id).FirstOrDefault();
            return vendedor;
        }
    }
}
