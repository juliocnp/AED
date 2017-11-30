using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    public class Calculos
    {
        public long FatIterativo (int num)
        {
            long aux = 1;
            for (long i = num; i > 1; i--)
            {
                aux *= i;
            }
            return aux;
        }

        public long FatRecursivo (int num)
        {
            if (num == 0)
                return 1;
            else
                return num * FatRecursivo(num - 1);
        }

        public long FiboRecursivo (int num)
        {
            if (num == 1 || num == 2)
                return 1;
            else
                return FiboRecursivo(num - 1) + FiboRecursivo(num - 2);
        }
    }
}
