using System;
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
    }
}