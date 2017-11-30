using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Prático
{
    static class Hanoi
    {
        static public void Recursivo (int discos, Stack<int>[] pilhas, int origem, int destino, int auxiliar)
        {
            if (discos == 1)
            {
                pilhas[destino].Push(pilhas[origem].Pop());
            }
            else
            {
                Recursivo(discos - 1, pilhas, origem, auxiliar, destino);
                pilhas[destino].Push(pilhas[origem].Pop());
                Recursivo(discos - 1, pilhas, auxiliar, destino, origem);
            }
        }
    }
}
