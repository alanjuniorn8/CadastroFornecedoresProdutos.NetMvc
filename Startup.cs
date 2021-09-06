using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CadastroFornecedores.Configurations;

namespace CadastroFornecedores
{
    public class Startup
    {

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public void ConfigureServices(IServiceCollection services)
        {


            services.AddAutoMapper(typeof(Startup));

            services.AddControllersWithViewsConfiguration();
            services.ResolveDependencies();
            services.AddIdentityConfig(Configuration);
            services.AddDbContextConfig(Configuration);

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            
            app.UseGlobalizationConfig();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"

                );

                endpoints.MapRazorPages();   
            });

            serviceProvider.DbContextProvider();
        }
    }
}
