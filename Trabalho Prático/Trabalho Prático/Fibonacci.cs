using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Prático
{
    static class Fibonacci
    {

        public static long Iterativo (int pos)
        {
            long pos0 = 1, pos1 = 1, res = 0;
            for (int i = 2; i <= pos; i++)
            {
                res = pos0 + pos1;
                pos0 = pos1;
                pos1 = res;
            }
            return pos1;
        }

        public static long Recursivo(int pos)
        {
            if (pos == 0 || pos == 1)
                return 1;
            else
                return Recursivo(pos - 2) + Recursivo(pos - 1);
        }
    }
}
