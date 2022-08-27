using CalculadoraPFS;
using Xunit;

namespace CalculadoraXUnit
{
    public class TesteCalculadoraXUnit
    {
        [Fact]
        public void TesteSomarDoisNumeros()
        {
            // Arrange - Prepara��o
            double pNum = 1;
            double sNum = 1;
            double resultadoEsperado = 2;

            // Act - A��o
            var resultado = Calculadora.Somar(pNum, sNum);

            // Assert - Verifica��o
            Assert.Equal(resultadoEsperado, resultado);

        }


        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 3, 4)]
        public void TesteSomarDoisNumerosLista(double pNum, double sNum, double resultadoEsperado)
        {
            // Act - A��o
            var resultado = Calculadora.Somar(pNum, sNum);

            // Assert - Verifica��o
            Assert.Equal(resultadoEsperado, resultado);

        }
    }
}