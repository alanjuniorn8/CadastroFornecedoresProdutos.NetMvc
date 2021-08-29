using System;
using System.Linq;
using CadastroFornecedores.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroFornecedores.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
            public DbSet<Produto> Produtos { get; set; }
            public DbSet<Fornecedor> Fornecedores { get; set; }
            public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            //Change DeleteBehavior Cascade
            foreach( var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
                    relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
    }
}