using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TDD_1
{
    public class Calculo
    {

        public static int Sumar(int S1, int S2)
        {
            return S1 + S2;
        }
        public static double Restar(int R1, int R2)
        {
            return R1 - R2;
        }
        public static double Multiplicar(int M1, int M2)
        {
            return M1 *  M2;
        }
        public static double Dividir(int D1, int D2)
        {
            if (D2 == 0)
            {
                throw new DivideByZeroException("No Se Puede Dividir Entre Cero...");
            }
            return D1 / D2;
        }

    }
}
