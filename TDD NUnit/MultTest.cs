using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;

namespace TDD_Core
{
    [TestFixture]

    public class Mult_Tests
    {
        [Test]
        public void Mult_Verificar()
        {
            const int Mult1 = 3;
            const int Mult2 = 5;
            const int Esperado = 15;

            var Actual = TDD_1.Calculo.Multiplicar(Mult1, Mult2);
            Assert.AreEqual(Esperado, Actual);
        }
    }
}
