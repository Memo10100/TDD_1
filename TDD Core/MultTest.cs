using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_Core
{
    [TestClass]

    public class Mult_Test
    {
        [TestMethod]
        public void Mult_Verificar()
        {
            const int N1 = 3;
            const int N2 = 5;
            const int Esperado = 15;

            var Actual = TDD_1.Calculo.Multiplicar(N1, N2);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(Esperado, Actual);
        }
    }
}
