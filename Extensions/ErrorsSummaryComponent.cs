using CadastroFornecedores.Notificacoes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroFornecedores.Extensions
{
    public class ErrorsSummaryComponent : ViewComponent
    {
        private readonly INotificador _notificador;

        public ErrorsSummaryComponent(INotificador notificador)
        {
            _notificador = notificador;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var notificacoes = await Task.FromResult(_notificador.ObterNotificacoes());

            notificacoes.ForEach(c => ViewData.ModelState.AddModelError(string.Empty, c.Mensagem));

            return View();
        }
    }
}
