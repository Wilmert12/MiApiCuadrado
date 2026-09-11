using Xunit;
using MiApiCuadrado.Services;

namespace MiApiCuadrado.Tests
{
    public class McdTests
    {
        [Fact]
        public void CalcularMcd_ConValoresEstandar_DebeRetornarResultadoCorrecto()
        {
            // Arrange
            var mathService = new MathService();
            int dividendo = 48;
            int divisor = 18;
            int esperado = 6;

            // Act
            int resultado = mathService.CalcularMcd(dividendo, divisor);

            // Assert
            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData(42, 56, 14)]
        [InlineData(54, 24, 6)]
        [InlineData(10, 5, 5)]
        public void CalcularMcd_ConMultiplesCasos_DebeRetornarMcdEsperado(int dividendo, int divisor, int esperado)
        {
            // Arrange
            var mathService = new MathService();

            // Act
            int resultado = mathService.CalcularMcd(dividendo, divisor);

            // Assert
            Assert.Equal(esperado, resultado);
        }
    }
}