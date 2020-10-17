using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_Core
{
    [TestClass]

    public class Div_Test
    {
        [TestMethod]

        [ExpectedException(typeof(DivideByZeroException))]
        public void Division_Verificar()
        {
            const int N1 = 10;
            const int N2 = 0;

            var Actual = TDD_1.Calculo.Dividir(N1, N2);

        }
    }
}
