using QIERPDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using VERPDatabase.Classes;
using QIERPDatabase.Classes.DTO;

namespace VERPDatabase.Repositorios
{
    public partial class OrcamentoRepository: IRepository<Orcamento>
    {
        public IQueryable<Orcamento> GetAll()
        {
            DB.GetInstance().context.Orcamentos.Load();
            return DB.GetInstance().context.Orcamentos.Local.AsQueryable();
        }

        public bool Salvar(Orcamento item)
        {
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public bool Inserir(Orcamento item)
        {
            item.Numero = DB.GetInstance().context.GetSequence("sqnOrcamento");
            DB.GetInstance().context.Orcamentos.Add(item);
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public Orcamento GetById(int id)
        {
            return DB.GetInstance().context.Orcamentos.Find(id);
        }

        public bool Deletar(Orcamento item)
        {
            DB.GetInstance().context.Entry<Orcamento>(item).State = System.Data.EntityState.Modified;
            item.DataExclusao = DateTime.Now;
            return true;
        }

        public static List<DTO_Orcamento> SelectOrc(int Numero)
        {
            return (from o in DB.GetInstance().context.Orcamentos
                    where o.Numero == Numero
                    select new DTO_Orcamento
                    {
                        Numero = o.Numero,
                        ClienteNome = o.Cliente.Pessoa.Nome,
                        VendedorNome = o.Vendedor.Pessoa.Nome
                    }).ToList();
        }
    }
}
