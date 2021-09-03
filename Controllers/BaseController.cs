using CadastroFornecedores.Notificacoes;
using Microsoft.AspNetCore.Mvc;

namespace CadastroFornecedores.Controllers
{
    public class BaseController : Controller
    {
        private readonly INotificador _notificador;

        public BaseController(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected bool OperacaoInvalida()
        { 
            return _notificador.TemNotificacão();
        }
    }
}
