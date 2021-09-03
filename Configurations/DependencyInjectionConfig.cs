using CadastroFornecedores.Data;
using CadastroFornecedores.Extensions;
using CadastroFornecedores.Notificacoes;
using CadastroFornecedores.Repositories;
using CadastroFornecedores.Repositories.Interfaces;
using CadastroFornecedores.Services;
using CadastroFornecedores.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;

namespace CadastroFornecedores.Configurations
{
    public static class DependencyInjectionConfig
    {

        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ApplicationDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddSingleton<IValidationAttributeAdapterProvider, MoedaValidationAttributeAdapterProvider>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IProdutoService, ProdutoService>();

            return services;
        }

    }
}
