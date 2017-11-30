using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Prático
{
    static class Pesquisa
    {
        public static int Sequencial (int[] vetor, int valor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == valor)
                    return i;
            }
            return -1;
        }

        public static int Binaria (int[] vetor, int valor, int posInicial, int posFinal)
        {
            int posMeio = (posInicial + posFinal) / 2;
            if (valor == vetor[posMeio])
                return posMeio;
            else if (posInicial >= posMeio)
                return -1;
            else if (valor > vetor[posMeio])
                return Binaria(vetor, valor, posMeio, posFinal);
            else
                return Binaria(vetor, valor, posInicial, posMeio);
        }
    }
}
