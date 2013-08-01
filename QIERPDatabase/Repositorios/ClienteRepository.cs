using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using QIERPDatabase.Classes;

namespace QIERPDatabase.Repositorios
{
    public class ClienteRepository : ExtRepository, IRepository<Cliente>
    {
        public IQueryable<Cliente> GetAll()
        {
            DB.GetInstance().context.Clientes.Load();
            return DB.GetInstance().context.Clientes.Local.AsQueryable().Where(c => c.DataExclusao == null).AsQueryable();
        }

        public bool Salvar(Cliente item)
        {
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public bool Inserir(Cliente item)
        {
            DB.GetInstance().context.Clientes.Add(item);
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public Cliente GetById(int id)
        {
            return DB.GetInstance().context.Clientes.Find(id);
        }

        public bool Deletar(Cliente item)
        {
            DB.GetInstance().context.Entry<Cliente>(item).State = System.Data.EntityState.Modified;
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
            return this.Inserir(objeto as Cliente);
        }

        public override bool Salvar(object objeto)
        {
            return this.Salvar(objeto as Cliente);
        }

        public override List<int> GetIds()
        {
            var ids = from e in DB.GetInstance().context.Clientes
                      where e.DataExclusao == null
                      select e.Id;
            return ids.ToList();
        }

        public override dynamic GetFields(string field)
        {
            if (field.Equals("Pessoa_Id"))
            {
                var fields = from e in DB.GetInstance().context.Clientes
                             where e.DataExclusao == null
                             select e.Pessoa.Id;
                return fields.ToList();
            }
            else
            {
                return null;
            }
        }

        public Cliente GetByPessoa(Pessoa pessoa)
        {
            Cliente cliente = this.GetAll().Where(c => c.Pessoa.Id == pessoa.Id).FirstOrDefault();
            return cliente;
        }
    }
}
