using CadastroFornecedores.Models;
using CadastroFornecedores.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace CadastroFornecedores.Services
{
    public class FornecedorService : BaseService, IFornecedorService
    {
        public Task Adicionar(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarEndereco(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
