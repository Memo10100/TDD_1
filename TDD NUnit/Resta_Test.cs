using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;

namespace TDD_Core
{
    [TestFixture]
    public class Restar_Test
    {
        [Test]
        public void Restar_Verificar()
        {
            const int Restando1 = 10;
            const int Restando2 = 5;
            const int Esperado = 5;

            var Actual = TDD_1.Calculo.Restar(Restando1, Restando2);

            Assert.AreEqual(Esperado, Actual);
        }
    }
}
