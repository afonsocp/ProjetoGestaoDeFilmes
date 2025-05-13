          
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
(Print da tela inicial que mostra a tabela com a lista de todos os filmes)

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
(Print do formulário de cadastro de novo filme)

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
(Print do formulário de edição com dados preenchidos)

**Implementação**:
- Formulário idêntico ao de cadastro
- Campos pré-preenchidos com dados atuais
- Validações mantidas

**Funcionamento**:
- Carrega dados existentes
- Permite alteração de qualquer campo
- Mantém ID do filme inalterado

### 4. Tela de Exclusão
(Print da tela de confirmação de exclusão)

**Implementação**:
- Tela de confirmação com dados do filme
- Botões de confirmar e cancelar
- Mensagem de alerta

**Funcionamento**:
- Exibe detalhes do filme a ser excluído
- Requer confirmação explícita
- Opção de cancelamento

### 5. Funcionalidade de Pesquisa
(Print da barra de pesquisa em uso)

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


        