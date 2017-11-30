using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Prático
{
    static class Fatorial
    {
        public static long Iterativo (int valor)
        {
            long res = 1;
            for (int i = valor; i > 0; i--)
            {
                res *= i;
            }
            return res;
        }

        public static long Recursivo (int valor)
        {
            if (valor == 0)
                return 1;
            else
                return valor * Recursivo(valor - 1);
        }
    }
}
