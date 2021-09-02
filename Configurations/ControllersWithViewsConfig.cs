using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroFornecedores.Configurations
{
    public static class ControllersWithViewsConfig
    {
        public static IServiceCollection AddControllersWithViewsConfiguration(this IServiceCollection services)
        {
            services.AddControllersWithViews(o =>
            {
                o.ModelBindingMessageProvider.SetAttemptedValueIsInvalidAccessor((x, y) => "O valor preenchido é invalido para este campo.");
                o.ModelBindingMessageProvider.SetMissingBindRequiredValueAccessor((x) => "O campo {0} é obrogatório");
                o.ModelBindingMessageProvider.SetMissingKeyOrValueAccessor(() => "Este campo é obrigatório");
                o.ModelBindingMessageProvider.SetMissingRequestBodyRequiredValueAccessor(() => "É necessário que o corpo da requisição não esteja vazio");
                o.ModelBindingMessageProvider.SetNonPropertyAttemptedValueIsInvalidAccessor((x) => "O valor preenchido é invalido para este campo");
                o.ModelBindingMessageProvider.SetNonPropertyUnknownValueIsInvalidAccessor(() => "O valor preenchido é invalido para este campo");
                o.ModelBindingMessageProvider.SetNonPropertyValueMustBeANumberAccessor(() => "O campo deve ser numérico");
                o.ModelBindingMessageProvider.SetUnknownValueIsInvalidAccessor((x) => "O valor preenchido é invalido para este campo");
                o.ModelBindingMessageProvider.SetValueIsInvalidAccessor((x) => "O valor preenchido é invalido para este campo");
                o.ModelBindingMessageProvider.SetValueMustBeANumberAccessor((x) => "O campo deve ser numérico");
                o.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor((x) => "O campo {0} é obrogatório");
            });

            return services;
        }
    }
}
