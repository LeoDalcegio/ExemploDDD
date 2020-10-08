using ExemploDDD.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ExemploDDD.Infra.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext() { }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }
        
        public virtual DbSet<Categoria> Categorias { get; set; }

        public virtual DbSet<Produto> Produtos{ get; set; }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null);

            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;

                    entry.Property("DataModificacao").CurrentValue = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}