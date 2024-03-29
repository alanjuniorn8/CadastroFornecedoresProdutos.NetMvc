﻿using CadastroFornecedores.Models;
using CadastroFornecedores.Notificacoes;
using CadastroFornecedores.Repositories.Interfaces;
using CadastroFornecedores.Services.Interfaces;
using CadastroFornecedores.Validators;
using System;
using System.Threading.Tasks;

namespace CadastroFornecedores.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository, INotificador notificador) : base(notificador)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Adicionar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidator(), produto)) return;

            await _produtoRepository.Adicionar(produto);
        }

        public async Task Atualizar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidator(), produto)) return;

            await _produtoRepository.Atualizar(produto);
        }

        public async Task Remover(Guid id)
        {

            await _produtoRepository.Remover(id);

        }

        public void Dispose()
        {
            _produtoRepository?.Dispose();
        }

    }
}
