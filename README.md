# ERP Jurídico - API
Sistema web de gestão jurídica, processos, documentos, tarefas, prazos, minutas e indicadores.

## Tecnologias Utilizadas
* ASP.NET Core 8.0 (C#)
* PostgreSQL
* Docker
* Entity Framework Core

## Pré-requisitos
* [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
* [Docker Desktop](https://www.docker.com/products/docker-desktop)
* Git

## Como configurar e executar o ambiente
1. Clone o repositório:
   `git clone (https://github.com/emmazzeto-lang/erp-juridico.git)`
2. Acesse a pasta do projeto:
   `cd erp-juridico`
3. Crie a branch local de desenvolvimento:
   `git checkout -b develop`
4. Suba o banco de dados via Docker:
   `docker-compose up -d`
5. Acesse a pasta da API:
   `cd ErpJuridico.Api`
6. Execute o projeto:
   `dotnet run`
