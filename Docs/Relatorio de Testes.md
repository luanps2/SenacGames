# Relatório de Testes Automatizados - SenacGames.Test

## 1. Resumo da Execução
- **Quantidade total de testes:** 9
- **Quantidade de testes `[Fact]`:** 6
- **Quantidade de testes `[Theory]`:** 3 (1 método Theory rodando com 3 parâmetros)
- **Resultado do comando `dotnet test`:** 100% Aprovado (Passou em todos os testes).

## 2. Cobertura Detalhada
- **Cenários positivos:** Testes que verificam se as regras de sucesso e de cadastro funcionam conforme o esperado (ex: inicializar categoria correta, cadastrar com dados válidos).
- **Cenários negativos:** Testes que garantem falha controlada (ex: retornar `null` ao deletar ID inexistente, lançar exceção específica do repositório).

### Classes e Services Testados
- **Domain:** `Game.cs`, `Category.cs`
- **Application (Services):** `CategoryService.cs`, `GameService.cs`

### Repositories Testados
- Os Repositories (`ICategoryRepository`, `IGameRepository`) foram amplamente "Mockados" em testes da camada Application, testando a interação do Service com a dependência (não o acesso ao banco em si).

## 3. Conceitos Utilizados e Locais de Aplicação

- **Triple AAA (Arrange, Act, Assert):** Utilizado explicitamente e comentado em todos os testes das classes `GameTests`, `CategoryTests`, `GameServiceTests` e `CategoryServiceTests`.
- **`[Fact]`:** Utilizado na maioria dos testes para situações estáticas (ex: `DeveInicializarListaDeGamesVazia` em `CategoryTests.cs`).
- **`[Theory]` e `[InlineData]`:** Utilizado em `CategoryServiceTests.cs` (`DeveCadastrarCategoryComDadosValidos`) demonstrando três cadastros diferentes apenas alterando a string de entrada.
- **Mocks com Moq:** 
  - Usado extensivamente em `CategoryServiceTests.cs` e `GameServiceTests.cs`.
  - Simulação de retorno usando `.ReturnsAsync()` e `.ThrowsAsync()`.
  - Verificação de chamadas utilizando `.Verify(..., Times.Once)` ou `.Verify(..., Times.Never)`.

## 4. Tipos de Teste
Todos os testes escritos nesta etapa são **Testes Unitários**, pois as dependências externas foram isoladas utilizando Mocks. Não foram feitos testes de Integração que acessam o banco real, focando na pureza e previsibilidade exigidas no contexto de unidade.

## 5. Modificações em Produção
**Nenhum código de produção precisou ser alterado.** As regras e exceções testadas representam o estado e o funcionamento exato e atual do sistema `SenacGames`.
