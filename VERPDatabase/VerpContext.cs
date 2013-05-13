using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERPDatabase
{
    public class VerpContext : DbContext
    {
        public static string CreateConnectionString()
        {
            return "Server=127.0.0.1;Database=verp;User Id=sa;Password=vd7887;";
        }

        public VerpContext() : base() { }
        public VerpContext(string nameOrConnectionString) : base(nameOrConnectionString) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<FormaDePagamento> FormasDePagamento { get; set; }
        public DbSet<CondicaoDePagamento> CondicoesDePagamento { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Venda> Vendas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<VerpContext>(new DropCreateDatabaseIfModelChanges<VerpContext>());
            Database.DefaultConnectionFactory = new SqlConnectionFactory("System.Data.SqlServer");

            base.OnModelCreating(modelBuilder);
        }
    }
}
