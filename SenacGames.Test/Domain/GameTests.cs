/*
 * Este arquivo contém os testes automatizados da classe Game.
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
 * Os testes aqui são Unitários, pois testam apenas a própria entidade.
 */

using SenacGames.Domain.Entities;
using System;

namespace SenacGames.Test.Domain
{
    public class GameTests
    {
        [Fact]
        public void DeveInicializarCreatedAtComDataAtual()
        {
            // ==========================================
            // ARRANGE
            // ==========================================
            // Nesta etapa preparamos todos os dados,
            // objetos e dependências necessários para o teste.
            
            // ==========================================
            // ACT
            // ==========================================
            // Nesta etapa executamos a ação que queremos
            // verificar. Instanciamos a entidade Game.
            var game = new Game();

            // ==========================================
            // ASSERT
            // ==========================================
            // Nesta etapa verificamos se o resultado
            // obtido corresponde ao comportamento esperado.
            // A propriedade CreatedAt do Game recebe DateTime.Now por padrão.
            // Verificamos se ela foi inicializada e se a data é recente.
            
            Assert.NotEqual(DateTime.MinValue, game.CreatedAt);
            
            // Permite uma variação de até 1 segundo para a validação da data
            var diferencaDeTempo = DateTime.Now - game.CreatedAt;
            Assert.True(diferencaDeTempo.TotalSeconds < 1, "CreatedAt deveria ser próximo de DateTime.Now no momento da instância.");
        }
    }
}
