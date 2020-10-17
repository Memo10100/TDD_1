using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_Core
{
    [TestClass]
    public class Restar_Test
    {
        [TestMethod]
        public void Restar_Verificar()
        {
            const int N1 = 10;
            const int N2 = 5;
            const int Esperado = 5;

            var Actual = TDD_1.Calculo.Restar(N1, N2);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(Esperado, Actual);
        }
    }
}
