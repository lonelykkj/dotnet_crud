# DotnetCRUD

Projeto de exemplo CRUD (Create, Read, Update, Delete) utilizando .NET, Entity Framework Core e SQLite.

## Funcionalidades

- Cadastro de pessoas
- Listagem de pessoas
- Atualização de dados de pessoas
- Remoção (lógica) de pessoas

## Estrutura do Projeto

```
DotnetCRUD/
├── Data/
│   └── PersonContext.cs
├── Models/
│   ├── PersonModel.cs
│   └── PersonRequest.cs
├── Routes/
│   └── PersonRoute.cs
├── Migrations/
│   └── (arquivos de migração do banco)
├── Program.cs
├── appsettings.json
├── person.sqlite
└── ...
```

## Tecnologias Utilizadas

- [.NET 7/8/9+](https://dotnet.microsoft.com/download)
- [Entity Framework Core](https://docs.microsoft.com/ef/core/)
- [SQLite](https://www.sqlite.org/index.html)
- [Swagger/OpenAPI](https://swagger.io/) (para documentação e testes de API)

## Como rodar o projeto

1. **Clone o repositório**
   ```sh
   git clone <url-do-repositorio>
   cd DotnetCRUD
   ```

2. **Restaure as dependências**
   ```sh
   dotnet restore
   ```

3. **Aplique as migrações e crie o banco**
   ```sh
   dotnet ef database update
   ```

4. **Execute o projeto**
   ```sh
   dotnet run
   ```

5. **Acesse a documentação da API**
   - Abra o navegador em: [https://localhost:5001/swagger](https://localhost:5001/swagger) (ou a porta indicada no terminal)

## Observações

- O banco de dados SQLite é criado automaticamente no arquivo `person.sqlite`.
- As rotas da API estão agrupadas em `/person`.
- O projeto segue o padrão minimal API do .NET.

