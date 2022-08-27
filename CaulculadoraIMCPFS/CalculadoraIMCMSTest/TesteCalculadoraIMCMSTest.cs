using CaulculadoraIMCPFS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraIMCMSTest
{
    [TestClass]
    public class TesteCalculadoraIMCMSTest
    {
        [TestMethod]
        public void TesteQuadradoAltura()
        {
            // Arrange - Prepara��o
            double altura = 1.80;
            double resultadoEsperado = 3.24;

            // Act - A��o
            var resultado = Calculadora.QuadradoAltura(altura);

            // Assert - Verifica��o
            Assert.AreEqual(resultadoEsperado, resultado);

        }


        [DataTestMethod]
        [DataRow(1.7, 2.89)]
        [DataRow(1.6, 2.56)]
        [DataRow(1.9, 3.61)]
        public void TesteQuadradoAlturaLista(double altura, double resultadoEsperado)
        {
            // Act - A��o
            var resultado = Calculadora.QuadradoAltura(altura);

            // Assert - Verifica��o
            Assert.AreEqual(resultadoEsperado, resultado);
        }

    }
}