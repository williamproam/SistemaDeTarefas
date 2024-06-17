# SistemaDeTarefas
Projeto A3
API 
Descrição
O Sistema de Tarefas API é uma aplicação escrita em C# que fornece uma API de gerenciamento de tarefas RESTful. Esta API permite que os usuários realizem operações CRUD (criar, ler, atualizar e apagar) sobre tarefas e usuários, usando o framework ASP.NET Core e o banco de dados SQL Server.

Pré-requisitos
.NET Core SDK (6.0 ou posterior)
.SQL Server 
.Visual Studio 

Configuração necessária para o Banco de Dados
1. A conexão String:
- Abra o arquivo appsettings.json e configure a string de conexão para o banco de dados SQL Server:
json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings": {
    "DataBase": "Server=SEU_SERVIDOR;DataBase=DB_SistemaTarefas;Trusted_Connection=True"
  },
  "AllowedHosts": "*"
}
2. Migrações:
Realize as migrações para construir o banco de dados e as tabelas requeridos. Na pasta raiz do projeto, abra o terminal e execute o comando:

SQL
dotnet ef database update

Executando o Projeto
1. Restaurar Dependências:
Abra o terminal na pasta raiz do projeto e execute o seguinte comando:
dotnet restore

2. Compilar o Projeto:
dotnet build

3. Executar o Projeto:
arduino
dotnet run

4. Experimente a API.

Estrutura do Projeto
Data: inclui o mapeamento das entidades e as classes de contexto do banco de dados.
Models: Define os modelos de dados da aplicação 
Repositórios: Implementa os repositórios para interação com o banco de dados
Enums: inclui os enums que foram usados na aplicação.
Migrations: Migrações do Entity Framework Core para criação do banco de dados.

Uso e Teste da API

Passo 1: Para abrir a interface do Swagger, execute o projeto e você será direcionado diretamente para a interface do Swagger

Passo 2: Testando os Endpoints
Na interface do Swagger, você verá todos os endpoints disponíveis da API. Clique em um endpoint para expandir e ver detalhes sobre os métodos suportados (GET, POST, GET,PUT, DELETE).

Passo 3: GET Busca todos usuarios cadastrados, POST Cadastra um novo usuario, GET busca usuario por ID, PUT Atualiza usuarios cadstrados e DELETE Deleta usuarios.

Utilize os endpoints disponíveis na API para realizar operações CRUD sobre os usuários. Alguns exemplos de endpoints e operações:

Para buscar todos os usuarios, utilize o endpoint GET /api/usuario e selecione "EXECUTE" e será fornecido                                                   todos os usuarios cadastrados no banco de dados.

Para criar um novo usuario, utilize o endpoint POST /api/usuario e forneça os dados necessários no corpo da requisição.

Para buscar usuario por ID, utilize o endpoint GET /api/usuario{id} e forneça o ID do usuario e logo em seguida será fornecido o usuario do ID.

Para atualizar um usuario, utilize o endpoint PUT /api/usuario/{id} e forneça o ID do usuario que será atualizado, juntamente com os novos dados no corpo da requisição.

Para deletar um usuario, utilize o endpoint DELETE /api/usuario/{id} e forneça o ID da tarefa a ser excluída.
