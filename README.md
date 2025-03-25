# DeepList

DeepList é uma aplicação web para gerenciamento de tarefas, desenvolvida com Blazor. Ela permite adicionar, editar, concluir e filtrar tarefas de forma intuitiva, ajudando usuários a organizar suas atividades diárias.

---

## 📋 Índice

- [📌 Visão Geral](#-visão-geral)
- [🚀 Funcionalidades](#-funcionalidades)
- [🛠️ Tecnologias Utilizadas](#️-tecnologias-utilizadas)
- [⚙️ Instalação e Configuração](#️-instalação-e-configuração)
- [💡 Como Utilizar](#-como-utilizar)
- [📬 Contato](#-contato)

---

## 📌 Visão Geral

Organize suas tarefas de forma simples e eficiente. Use a barra de navegação para criar novas tarefas, e acompanhar seu progresso. Com o DeepList, você mantém o foco no que realmente importa, tornando seu dia mais produtivo. Comece agora e deixe o DeepList ajudar você a alcançar seus objetivos!

---

## 🚀 Funcionalidades

- Cadastro e Listagem de Tarefas
- Edição e Exclusão de Tarefas
- Marcação de Conclusão com checkbox
- Filtro por responsável
- Interface moderna e responsiva com Bootstrap
- Autenticação de usuário

---

## 🛠️ Tecnologias Utilizadas

- [Blazor WebAssembly versão 6-8](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
- [ASP.NET Core](https://dotnet.microsoft.com/en-us/apps/aspnet)
- [Microsoft SQL Server](https://www.microsoft.com/pt-br/evalcenter/download-sql-server-2022)
- [(SSMS) SQL Server Manager Studio](https://learn.microsoft.com/en-us/ssms/download-sql-server-management-studio-ssms?redirectedfrom=MSDN)
- [Bootstrap](https://getbootstrap.com/)
- [C#](https://docs.microsoft.com/dotnet/csharp/)
- [Git](https://git-scm.com/) & [GitHub](https://github.com)

---

## ⚙️ Instalação e Configuração

### Pré-requisitos

- [.NET 6-9](https://dotnet.microsoft.com/download)
- [Git](https://git-scm.com/)
- [Microsoft SQL Server](https://www.microsoft.com/pt-br/evalcenter/download-sql-server-2022)
- [(SSMS) SQL Server Manager Studio](https://learn.microsoft.com/en-us/ssms/download-sql-server-management-studio-ssms?redirectedfrom=MSDN)


### Passos

```bash
# Clone o repositório
git clone https://github.com/aurorarichaud/deeplist-site.git
cd DeepList
```

1. Rodar a API (backend)
```bash
cd DeepList.Api
dotnet restore
dotnet run
```
A API será iniciada (ex: http://localhost:5163)

2. Rodar o Client (frontend)
```bash
cd ../DeepList.Client
dotnet restore
dotnet run
```
A aplicação abrirá no navegador (ex: http://localhost:5140)

---

## 💡 Como Utilizar

1. Faça login com seu usuário.
2. Adicione novas tarefas usando o botão **"Adicionar Nova Tarefa"**.
3. Visualize a lista de tarefas pendentes e conclua com um clique no checkbox.
4. Expanda uma tarefa para ver detalhes como descrição e data de entrega.
5. Edite ou exclua tarefas usando os ícones de lápis e lixeira.
6. Filtre tarefas por responsável usando o campo de pesquisa no topo.

---

## 📬 Contato

- **Nome:** Aurora
- **Email:** github@aurorarichaud.com
- **GitHub:** [@aurorarichaud](https://github.com/aurorarichaud)

---

> Projeto desenvolvido com 💙 em Blazor por Aurora
