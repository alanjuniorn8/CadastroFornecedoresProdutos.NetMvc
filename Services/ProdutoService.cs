using CadastroFornecedores.Models;
using CadastroFornecedores.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace CadastroFornecedores.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        public Task Adicionar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
