using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CadastroFornecedores.Models;

namespace CadastroFornecedores.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("erro/{id:length(3,3)}")]
        public IActionResult Errors(int id)
        {
            var modelErro = new ErrorViewModel();

            if(id == 500)
            {
                modelErro.Mensagem = "Ocorreu um erro! Tente novamente mais tarde.";
                modelErro.Titulo = "Ocorreu um erro!";
                modelErro.ErrorCode = id;
            }
            else if(id == 404)
            {
                modelErro.Mensagem = "A pagina que está procurando não existe!";
                modelErro.Titulo = "Ops! Página não encontrada!";
                modelErro.ErrorCode = id;
            }
            else if(id == 403)
            {
                modelErro.Mensagem = "Vocẽ não possui permissão para executar esta ação!";
                modelErro.Titulo = "Acesso Negado!";
                modelErro.ErrorCode = id;
            }else
            {  
                return StatusCode(404);
            }
            return View("Error", modelErro);
        }
    }
}
