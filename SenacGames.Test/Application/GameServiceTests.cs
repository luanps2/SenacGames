/*
 * Este arquivo contém os testes automatizados da classe GameService.
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
    public class GameServiceTests
    {
        [Fact]
        public async Task DeveRetornarNuloQuandoAtualizarIdInexistente()
        {
            // ==========================================
            // ARRANGE
            // ==========================================
            var repositoryMock = new Mock<IGameRepository>();
            
            // Simula que qualquer ID passado retornará null, significando que não foi encontrado.
            repositoryMock.Setup(repo => repo.GetByIdAsync(It.IsAny<int>()))
                          .ReturnsAsync((Game?)null);

            var service = new GameService(repositoryMock.Object);
            var updateDto = new UpdateGameDto { Title = "Novo Título", CategoryId = 1 };

            // ==========================================
            // ACT
            // ==========================================
            var result = await service.UpdateAsync(999, updateDto);

            // ==========================================
            // ASSERT
            // ==========================================
            // O comportamento esperado do UpdateAsync quando a entidade não existe é retornar null.
            Assert.Null(result);

            // Garante que não houve tentativa de salvar alterações.
            repositoryMock.Verify(repo => repo.UpdateAsync(It.IsAny<Game>()), Times.Never);
        }

        [Fact]
        public async Task DeveRetornarExcecaoEspecificaDoRepositorio()
        {
            // ==========================================
            // ARRANGE
            // ==========================================
            var repositoryMock = new Mock<IGameRepository>();
            
            // Forçamos o mock a lançar uma exceção de Banco de Dados ou ArgumentException
            repositoryMock.Setup(repo => repo.CountAsync())
                          .ThrowsAsync(new System.ArgumentException("Erro simulado no banco"));

            var service = new GameService(repositoryMock.Object);

            // ==========================================
            // ACT & ASSERT
            // ==========================================
            // O Assert.ThrowsAsync avalia se a exceção informada foi lançada
            // durante a execução do método.
            var exception = await Assert.ThrowsAsync<System.ArgumentException>(async () =>
            {
                await service.CountAsync();
            });

            Assert.Equal("Erro simulado no banco", exception.Message);
        }
    }
}
