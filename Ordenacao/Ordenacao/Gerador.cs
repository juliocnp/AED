using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenacao
{
    class Gerador
    {
        int arraySize;

        public int ArraySize
        {
            get
            {
                return arraySize;
            }

            set
            {
                arraySize = value;
            }
        }

        public Gerador (int tamanho)
        {
            ArraySize = tamanho;
        }

        public int[] vetCrescente()
        {
            int[] aux = new int[ArraySize];
            for (int i = 0; i < ArraySize; i++)
            {
                aux[i] = (i + 1);
            }
            return aux;
        }

        public int[] vetDecrescente()
        {
            int[] aux = new int[ArraySize];
            for (int i = 0; i < ArraySize; i++)
            {
                aux[i] = ArraySize - (i + 1);
            }
            return aux;
        }

        public int[] quaseOrdenado()
        {
            Random aleat = new Random(42);

            int[] aux = new int[ArraySize];
            for (int i = 0; i < ArraySize; i++)
            {
                aux[i] = (i + 1);
            }

            for (int i = 0; i < (ArraySize / 20); i++)
            {
                int p1 = aleat.Next(0, ArraySize);
                int p2 = aleat.Next(0, ArraySize);
                int temp = aux[p1];
                aux[p1] = aux[p2];
                aux[p2] = temp;
            }
            return aux;
        }

        public int[] vetAleatorio()
        {
            Random aleat = new Random(42);

            int[] aux = new int[ArraySize];
            for (int i = 0; i < ArraySize; i++)
            {
                aux[i] = aleat.Next(0, ArraySize);
            }
            return aux;
        }
    }
}
