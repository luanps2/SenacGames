/*
 * Este arquivo contém os testes automatizados da classe CategoryService.
 *
 * Os testes demonstram o padrão Triple AAA:
 *
 * Arrange = preparação dos dados.
 * Act     = execução da ação.
 * Assert  = verificação do resultado.
 *
 * Também são demonstrados:
 *
 * [Fact]      = teste com cenário específico.
 * [Theory]    = teste com diferentes entradas.
 * [InlineData] = dados utilizados pelo Theory.
 *
 * Quando aplicável, este arquivo também demonstra
 * utilização de Mocks com Moq.
 */

using Moq;
using SenacGames.Application.DTOs;
using SenacGames.Application.Services;
using SenacGames.Domain.Entities;
using SenacGames.Domain.Interfaces;
using System.Threading.Tasks;

namespace SenacGames.Test.Application
{
    public class CategoryServiceTests
    {
        [Fact]
        public async Task DeveRetornarFalsoQuandoDeletarIdInexistente()
        {
            // ==========================================
            // ARRANGE
            // ==========================================
            // Um Mock é um objeto falso utilizado durante o teste para substituir 
            // uma dependência real (neste caso, o acesso ao banco de dados).
            var repositoryMock = new Mock<ICategoryRepository>();

            // Configurando o Mock: quando o GetByIdAsync for chamado com o id 99, 
            // ele deve retornar null (simulando que o registro não existe).
            repositoryMock.Setup(repo => repo.GetByIdAsync(99))
                          .ReturnsAsync((Category?)null);

            var service = new CategoryService(repositoryMock.Object);

            // ==========================================
            // ACT
            // ==========================================
            // Executamos o método DeleteAsync com o Id que não existe.
            var result = await service.DeleteAsync(99);

            // ==========================================
            // ASSERT
            // ==========================================
            // Como a categoria não foi encontrada, o método deve retornar false.
            Assert.False(result);

            // Garantimos que o repositório nunca tentou deletar de fato.
            repositoryMock.Verify(repo => repo.DeleteAsync(It.IsAny<int>()), Times.Never);
        }

        [Fact]
        public async Task DeveDeletarERetornarVerdadeiroQuandoIdExistir()
        {
            // ==========================================
            // ARRANGE
            // ==========================================
            var repositoryMock = new Mock<ICategoryRepository>();
            var category = new Category { Id = 1, Name = "Ação" };

            // Configurando o Mock para retornar uma categoria válida quando buscada.
            repositoryMock.Setup(repo => repo.GetByIdAsync(1))
                          .ReturnsAsync(category);

            // Configurando o DeleteAsync para retornar apenas sucesso (Task concluída).
            repositoryMock.Setup(repo => repo.DeleteAsync(1))
                          .Returns(Task.CompletedTask);

            var service = new CategoryService(repositoryMock.Object);

            // ==========================================
            // ACT
            // ==========================================
            var result = await service.DeleteAsync(1);

            // ==========================================
            // ASSERT
            // ==========================================
            Assert.True(result);

            // Verificamos se o método DeleteAsync do repositório foi chamado exatamente uma vez.
            repositoryMock.Verify(repo => repo.DeleteAsync(1), Times.Once);
        }

        [Theory]
        [InlineData("Ação")]
        [InlineData("Aventura")]
        [InlineData("RPG")]
        public async Task DeveCadastrarCategoryComDadosValidos(string categoryName)
        {
            // ==========================================
            // ARRANGE
            // ==========================================
            // O [Theory] permite testar o mesmo método usando diferentes valores de entrada 
            // através do [InlineData]. A string 'categoryName' assume os valores acima sequencialmente.
            var repositoryMock = new Mock<ICategoryRepository>();
            
            // Simula que o AddAsync apenas completa a execução
            repositoryMock.Setup(repo => repo.AddAsync(It.IsAny<Category>()))
                          .Returns(Task.CompletedTask);

            var service = new CategoryService(repositoryMock.Object);
            var createDto = new CreateCategoryDto { Name = categoryName };

            // ==========================================
            // ACT
            // ==========================================
            var resultDto = await service.CreateAsync(createDto);

            // ==========================================
            // ASSERT
            // ==========================================
            Assert.NotNull(resultDto);
            Assert.Equal(categoryName, resultDto.Name);

            // Verifica se o método AddAsync foi chamado uma vez, recebendo uma entidade com o nome esperado.
            repositoryMock.Verify(repo => repo.AddAsync(It.Is<Category>(c => c.Name == categoryName)), Times.Once);
        }
    }
}
