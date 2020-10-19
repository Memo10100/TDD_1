using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;

namespace TDD_Core
{
    [TestFixture]

    public class Div_Test
    {
        [Test]

        [ExpectedException(typeof(DivideByZeroException))]
        public void Division_Verificar()
        {
            const int Div1 = 10;
            const int Div2 = 0;

            var Actual = TDD_1.Calculo.Dividir(Div1, Div2);

        }
    }
}
