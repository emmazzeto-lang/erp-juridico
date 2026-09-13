# Sistema de Gestão Financeira e Prestação de Contas
Desenvolvido para a Fundação Amigos de João Bidu, como parte do projeto Fábrica de Software.

**Objetivo Geral**
Modernizar a gestão da Fundação, reduzir processos manuais e centralizar informações para organizar receitas, despesas, notas fiscais, pagamentos, documentos, contas bancárias, metas e fontes de recursos[cite: 3]. O sistema visa garantir maior eficiência, transparência, segurança e agilidade na prestação de contas.

**Tecnologias Utilizadas**
* ASP.NET Core 8.0 (C#)
* PostgreSQL
* Docker
* Entity Framework Core

**Pré-requisitos**
* [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
* [Docker Desktop](https://www.docker.com/products/docker-desktop)
* Git

**Como configurar e executar o ambiente**
1. Clone o repositório:
   `git clone https://github.com/emmazzeto-lang/gestao-financeira-bidu.git`
2. Acesse a pasta do projeto:
   `cd gestao-financeira-bidu`
3. Mude para a branch de desenvolvimento:
   `git checkout develop`
4. Suba o banco de dados via Docker:
   `docker-compose up -d`
5. Acesse a pasta da API:
   `cd GestaoFinanceira.Api`
6. Execute o projeto:
   `dotnet run`
