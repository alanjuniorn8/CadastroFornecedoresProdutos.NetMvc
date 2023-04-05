# Cadastro de Fornecedores

## Uma aplicação para realizar cadastro de fornecedores e produtos

<h4 align="center"> 
  🚀 Ready to run...
</h4>

### ✨ Features

- [x] Cadastro de usuário
- [x] Cadastro de fornecedores
- [x] Cadastro de produtos

### 🚧 Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina o framework [.NET 5.0](https://dotnet.microsoft.com/download/dotnet/5.0)
Além disto é necessário ter configurado um database [MySql](https://www.mysql.com/)

### 🎲 Rodando a aplicação

```bash
# Clone este repositório
$ git clone <https://github.com/alanjuniorn8/CadastroFornecedores.NetMvc>

#  No arquivo appsettings.json configure a string de conexão com banco de dados MySql

# Instale o dotnet ef tool para executar as migrations
$ dotnet tool install --global dotnet-ef

# Na pasta do projeto no terminal/cmd execute as migrations para atualizar o banco
$ dotnet ef database update --context ApplicationDbContext
$ dotnet ef database update --context IdentityContext

# Execute a aplicação em modo de desenvolvimento
$ dotnet run

# O servidor inciará na porta:5001 - acesse <https://localhost:5001>
```
Para 100% de aproveitamento é necessário dar ao usuário criado autorizações, para isso na tabela AspNetUserClaim link o UserId com claimType "Fornecedor" e "Produto" e o  ClaimValue com "Adicionar, Editar, Excluir"

<table border="1">
    <tr>
        <td>UserId</td>
        <td>ClaimType</td>
        <td>ClaimValue</td>
    </tr>
    <tr>
        <td>24dae9bf-9153-42f6-b444-c6674e2d1775</td>
        <td>Fornecedor</td>
        <td>Adicionar,Editar,Excluir</td>
    </tr>
    <tr>
        <td>24dae9bf-9153-42f6-b444-c6674e2d1775</td>
        <td>Produto</td>
        <td>Adicionar,Editar,Excluir</td>
    </tr>
</table>

### 🛠 Tecnologias

As seguintes ferramentas foram usadas na construção do projeto:
- [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/)
- [.NET 5.0](https://dotnet.microsoft.com/)
- [Entity Framework](https://docs.microsoft.com/pt-br/ef/)
- [MySql](https://www.mysql.com/)

