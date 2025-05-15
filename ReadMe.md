          
# Sistema de Gestão de Filmes - Documentação

## Participantes
- Afonso Correia Pereira - RM557863
- Adel Mouhaidly - RM557705 
- Felipe Horta Gresele - RM556955 
- Tiago Augusto Desiderato - RM558485 
- Arthur - RM550615 
- João Henrique - RM556221

## Descrição do Projeto
O Sistema de Gestão de Filmes é uma aplicação web desenvolvida em ASP.NET Core MVC que permite o gerenciamento completo de um catálogo de filmes. O sistema oferece operações CRUD (Create, Read, Update, Delete) e funcionalidades de pesquisa.

## Tecnologias Utilizadas
- ASP.NET Core MVC (.NET 9.0)
- C#
- Bootstrap
- HTML5/CSS3
- JavaScript

## Repositório no GitHub:
https://github.com/afonsocp/ProjetoGestaoDeFilmes

## Estrutura do Projeto
O projeto segue a arquitetura MVC (Model-View-Controller) e está organizado da seguinte forma:

### Models
- `Movie.cs`: Define a estrutura de dados para filmes com os seguintes campos:
  - Id (identificador único)
  - Título (obrigatório)
  - Gênero (enum: Ação, Aventura, Comédia, etc.)
  - Data de Lançamento (obrigatório)
  - Duração em minutos (obrigatório, entre 1-999)
  - Classificação (enum: Livre, 10 anos, 12 anos, etc.)
  - Sinopse

### Controllers
- `MoviesController.cs`: Gerencia todas as operações CRUD e pesquisa

### Views
- `Index.cshtml`: Lista de filmes
- `Create.cshtml`: Formulário de criação
- `Edit.cshtml`: Formulário de edição
- `Delete.cshtml`: Confirmação de exclusão

## Telas do Sistema e Funcionalidades

### 1. Tela Inicial - Lista de Filmes
![Image](https://github.com/user-attachments/assets/58d61968-7b4d-4303-b581-8f7a3974ed5a)

**Implementação**: 
- Tabela responsiva usando Bootstrap
- Colunas para todas as informações principais dos filmes
- Botões de ação para editar e excluir
- Barra de pesquisa por título e gênero

**Funcionamento**:
- Exibe todos os filmes cadastrados em formato tabular
- Permite ordenação por colunas
- Botões de ação para cada filme

### 2. Tela de Cadastro
![Image](https://github.com/user-attachments/assets/3c8f589b-33cb-42ee-9722-5f5515a962db)

**Implementação**:
- Formulário com validação em tempo real
- Campos obrigatórios marcados
- Dropdowns para gênero e classificação
- Editor de texto para sinopse

**Funcionamento**:
- Validação dos campos obrigatórios
- Formatação automática de data
- Feedback visual de erros

### 3. Tela de Edição
![Image](https://github.com/user-attachments/assets/4ca3686b-2c27-45fd-b9d5-db3924b2add1)

**Implementação**:
- Formulário idêntico ao de cadastro
- Campos pré-preenchidos com dados atuais
- Validações mantidas

**Funcionamento**:
- Carrega dados existentes
- Permite alteração de qualquer campo
- Mantém ID do filme inalterado

### 4. Tela de Exclusão
![Image](https://github.com/user-attachments/assets/3e5a6e37-495f-4dd5-91e7-d02445a8e2c3)

**Implementação**:
- Tela de confirmação com dados do filme
- Botões de confirmar e cancelar
- Mensagem de alerta

**Funcionamento**:
- Exibe detalhes do filme a ser excluído
- Requer confirmação explícita
- Opção de cancelamento

### 5. Funcionalidade de Pesquisa
![Image](https://github.com/user-attachments/assets/b48f0ccb-e8c0-479f-9921-e7474174c83e)

**Implementação**:
- Campo de busca por texto
- Filtro por gênero
- Atualização dinâmica dos resultados

**Funcionamento**:
- Busca por título do filme
- Filtragem por gênero
- Combinação de filtros

## Considerações Técnicas
- Validações implementadas usando Data Annotations
- Interface responsiva com Bootstrap
- Não utiliza banco de dados (armazenamento em memória)
- Código organizado seguindo boas práticas
- Tratamento de erros implementado


        
