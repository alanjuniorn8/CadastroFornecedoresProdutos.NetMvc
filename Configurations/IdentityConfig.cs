using CadastroFornecedores.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace CadastroFornecedores.Configurations
{
    public static class IdentityConfig
    {
        public static IServiceCollection AddIdentityConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDefaultIdentity<IdentityUser>()
                    .AddDefaultUI()
                    .AddEntityFrameworkStores<IdentityContext>();

            var connection = configuration.GetConnectionString("Default");
            services.AddDbContext<IdentityContext>(options => options.UseMySql(connection, ServerVersion.AutoDetect(connection)));

            return services;
        }
    }
}
