using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;

namespace TDD_Core
{
    [TestClass]
    //siempre terner la referencia de la solucion

    public class Sumar_Tests
    {
        [TestMethod]
        public void Suma_Verificar()
        {
            const int N1 = 3;
            const int N2 = 5;
            const int Esperado = 8;

            var Actual = TDD_1.Calculo.Sumar(N1, N2);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(Esperado, Actual);
        }
    }
}