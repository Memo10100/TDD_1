using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;

namespace TDD_Core
{
    [TestFixture]

    public class Sumar_Tests
    {
        [Test]
        public void Suma_Verificar()
        {
            const int Sumando1 = 3;
            const int Sumando2 = 5;
            const int Esperado = 8;

            var Actual = TDD_1.Calculo.Sumar(Sumando1, Sumando2);
            Assert.AreEqual(Esperado, Actual);
        }
    }
}