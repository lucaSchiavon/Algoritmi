using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmi.Algoritmi2.Esercizi
{
    class Fattoriale
    {
        public int Factorial(int num)
        {
            var factorial = 1;
            for (int i = num; i > factorial; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
        public int Factorial2(int num)
        {
            //base condition
            if (num == 0)
                return 1;

            return num * Factorial2(num - 1);

          
        }
    }
}
