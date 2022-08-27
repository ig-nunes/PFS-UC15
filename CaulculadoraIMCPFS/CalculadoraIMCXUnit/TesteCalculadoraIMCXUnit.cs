using CaulculadoraIMCPFS;
using Xunit;

namespace CalculadoraIMCXUnit
{
    public class TesteCalculadoraIMCXUnit
    {
        [Fact]
        public void TesteCalcularIMC()
        {
            // Arrange - Preparação
            double altura = 1.80;
            double peso = 70.0;
            string resultadoEsperado = "Categoria: Peso normal";

            // Act - Ação
            var resultado = Calculadora.CalcularIMC(altura, peso);

            // Assert - Verificação
            Assert.Contains(resultadoEsperado, resultado);
        }


        [Theory]
        [InlineData(1.8, 50.0, "Categoria: Abaixo do peso")]
        [InlineData(1.8, 90.0, "Categoria: Sobrepeso")]
        [InlineData(1.8, 110.0, "Categoria: Obesidade Grau I")]
        [InlineData(1.8, 120.0, "Categoria: Obesidade Grau II")]
        [InlineData(1.8, 140.0, "Categoria: Obesidade Grau III")]
        [InlineData(0, 120.0, "Altura inválida!")]
        [InlineData(-1.8, 120.0, "Opa! Ocorreu um erro!")]
        public void TesteCalcularIMCLista(double altura, double peso, string resultadoEsperado)
        {
            // Act - Ação
            var resultado = Calculadora.CalcularIMC(altura, peso);

            // Assert - Verificação
            Assert.Contains(resultadoEsperado, resultado);
        }
    }
}