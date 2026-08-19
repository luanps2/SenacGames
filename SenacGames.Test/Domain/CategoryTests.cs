/*
 * Este arquivo contém os testes automatizados da classe Category.
 *
 * Os testes demonstram o padrão Triple AAA:
 *
 * Arrange = preparação dos dados.
 * Act     = execução da ação.
 * Assert  = verificação do resultado.
 *
 * Também são demonstados:
 *
 * [Fact]      = teste com cenário específico.
 *
 * Os testes aqui são Unitários, pois testam apenas regras da própria classe
 * sem depender de banco de dados ou outras camadas.
 */

using SenacGames.Domain.Entities;
using System.Collections.Generic;

namespace SenacGames.Test.Domain
{
    public class CategoryTests
    {
        [Fact]
        public void DeveInicializarListaDeGamesVazia()
        {
            // ==========================================
            // ARRANGE
            // ==========================================
            // Nesta etapa preparamos todos os dados,
            // objetos e dependências necessários para o teste.
            // Para testar o construtor/inicialização, não precisamos de dados prévios.

            // ==========================================
            // ACT
            // ==========================================
            // Nesta etapa executamos a ação que queremos
            // verificar. Neste caso, a simples instanciação.
            var category = new Category();

            // ==========================================
            // ASSERT
            // ==========================================
            // Nesta etapa verificamos se o resultado
            // obtido corresponde ao comportamento esperado.
            // A classe Category possui uma inicialização padrão: Games = new List<Game>()
            Assert.NotNull(category.Games);
            Assert.Empty(category.Games);
            Assert.IsAssignableFrom<ICollection<Game>>(category.Games);
        }
    }
}
