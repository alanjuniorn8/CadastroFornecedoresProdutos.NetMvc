using CadastroFornecedores.Models;
using FluentValidation;
using FluentValidation.Results;

namespace CadastroFornecedores.Services
{
    public abstract class BaseService
    {
        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            }
        }

        protected void Notificar(string errorMessage)
        {
            
        }

        protected bool ExecutarValidacao<TV, TE>(TV validator, TE entidade) where TV : AbstractValidator<TE> where TE : Entity
        {
            var validationResult = validator.Validate(entidade);

            if (validationResult.IsValid) return true;
            
            Notificar(validationResult);

            return false;
        }
    }
}
