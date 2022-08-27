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
            // Arrange - Preparação
            double altura = 1.80;
            double resultadoEsperado = 3.24;

            // Act - Ação
            var resultado = Calculadora.QuadradoAltura(altura);

            // Assert - Verificação
            Assert.AreEqual(resultadoEsperado, resultado);

        }


        [DataTestMethod]
        [DataRow(1.7, 2.89)]
        [DataRow(1.6, 2.56)]
        [DataRow(1.9, 3.61)]
        public void TesteQuadradoAlturaLista(double altura, double resultadoEsperado)
        {
            // Act - Ação
            var resultado = Calculadora.QuadradoAltura(altura);

            // Assert - Verificação
            Assert.AreEqual(resultadoEsperado, resultado);
        }

    }
}