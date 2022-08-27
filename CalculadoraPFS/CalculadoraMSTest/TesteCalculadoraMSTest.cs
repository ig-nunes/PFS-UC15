using CalculadoraPFS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraMSTest
{
    [TestClass]
    public class TesteCalculadoraMSTest
    {
        [TestMethod]
        public void TesteSomarDoisNumeros()
        {
            // Arrange - Preparação
            double pNum = 1;
            double sNum = 1;
            double resultadoEsperado = 2;

            // Act - Ação
            var resultado = Calculadora.Somar(pNum, sNum);


            // Assert - Verificação
            Assert.AreEqual(resultadoEsperado, resultado);

        }


        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 3, 3)]
        public void TesteSomarDoisNumerosLista(double pNum, double sNum, double resultadoEsperado)
        {
            // Act - Ação
            var resultado = Calculadora.Somar(pNum, sNum);

            // Assert - Verificação
            Assert.AreEqual(resultadoEsperado, resultado);

        }

    }
}