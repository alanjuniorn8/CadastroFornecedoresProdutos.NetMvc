using CadastroFornecedores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroFornecedores.Services.Interfaces
{
    interface IFornecedorService
    {
        Task Adicionar(Fornecedor fornecedor);

        Task Atualizar(Fornecedor fornecedor);
        
        Task AtualizarEndereco(Fornecedor fornecedor);

        Task Remover(Guid id);

    }
}
