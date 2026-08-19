# Testes Automatizados com xUnit no .NET

## O que são testes automatizados?
Testes automatizados são trechos de código escritos para verificar se o código de produção (o sistema real) está funcionando conforme o esperado. 

### Por que testar?
- **Garantia de Qualidade**: Assegura que novas alterações não quebrem funcionalidades antigas.
- **Documentação**: Testes bem escritos servem como documentação viva do que o sistema faz.
- **Confiança**: O desenvolvedor tem segurança para refatorar o código sem medo de introduzir bugs.

## Tipos de Teste

### Teste Unitário
Testa a menor unidade possível do código (geralmente um método ou classe), de forma totalmente isolada. Ele **não acessa banco de dados**, rede ou sistema de arquivos.

### Teste de Integração
Testa como duas ou mais unidades interagem juntas, como por exemplo, um Service salvando dados reais em um banco de dados de teste.

## xUnit
O **xUnit** é um dos frameworks de testes mais utilizados no .NET. Ele fornece as ferramentas para escrevermos e executarmos nossos testes.

### Atributos Principais

#### `[Fact]`
Utilizado quando o teste não recebe parâmetros. É um fato universal e estático. Ideal para cenários fixos.
```csharp
[Fact]
public void DeveInicializarListaDeGamesVazia()
{
    // ...
}
```

#### `[Theory]` e `[InlineData]`
Utilizado quando queremos executar o mesmo teste várias vezes com diferentes entradas (parâmetros). O `[InlineData]` fornece esses valores.
```csharp
[Theory]
[InlineData("Ação")]
[InlineData("Aventura")]
public async Task DeveCadastrarCategoryComDadosValidos(string categoryName)
{
    // O teste rodará duas vezes, uma para "Ação" e outra para "Aventura"
}
```

## Padrão Triple AAA
Todo bom teste segue o padrão AAA:
1. **Arrange (Preparação)**: Onde instanciamos objetos, preparamos dados e configuramos os Mocks.
2. **Act (Ação)**: Onde chamamos o método que queremos efetivamente testar.
3. **Assert (Verificação)**: Onde validamos se o resultado da ação foi o esperado.

## Asserts
O xUnit fornece a classe `Assert` para as verificações:
- `Assert.Equal(esperado, atual)`: Verifica se os valores são iguais.
- `Assert.True(condicao)`: Verifica se a condição é verdadeira.
- `Assert.False(condicao)`: Verifica se a condição é falsa.
- `Assert.Null(objeto)`: Verifica se o objeto é nulo.
- `Assert.NotNull(objeto)`: Verifica se o objeto possui valor.
- `Assert.Throws<Exception>(...)`: Verifica se uma exceção específica foi lançada.

## Moq e Mocks
Em testes unitários, não queremos acessar o banco de dados. Para isso usamos a biblioteca **Moq**.
Um **Mock** é um objeto "dublê" que finge ser uma dependência real (como um repositório).
```csharp
var repositoryMock = new Mock<ICategoryRepository>();
repositoryMock.Setup(repo => repo.GetByIdAsync(1))
              .ReturnsAsync(new Category { Id = 1, Name = "Ação" });
```

Usamos `Verify` para checar se o mock foi chamado corretamente:
```csharp
repositoryMock.Verify(repo => repo.DeleteAsync(1), Times.Once);
```

## Como executar os testes
### Pelo Terminal
Abra o terminal, navegue até a pasta do projeto `SenacGames.Test` (ou raiz da Solution) e execute:
```bash
dotnet test
```

### Pelo Visual Studio
1. Vá no menu superior em **Test > Test Explorer** (Gerenciador de Testes).
2. Clique no botão de Play verde (Run All Tests).
3. Os testes que passarem ficarão verdes; os que falharem ficarão vermelhos.
