using System;

namespace TDD_1
{
    public class Calculo
    {

        public static int Sumar(int Sumando1, int Sumando2)
        {
            return Sumando1 + Sumando2;
        }
        public static double Restar(int Restando1, int Restando2)
        {
            return Restando1 - Restando2;
        }
        public static double Multiplicar(int Mult1, int Mult2)
        {
            return Mult1 * Mult2;
        }
        public static double Dividir(int Div1, int Div2)
        {
            if (Div2 == 0)
            {
                throw new DivideByZeroException("No Se Puede Dividir Entre Cero...");
            }
            return Div1 / Div2;
        }

    }
}
