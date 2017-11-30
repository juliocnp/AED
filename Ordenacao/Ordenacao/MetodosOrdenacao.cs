using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenacao
{
    static class MetodosOrdenacao
    {
        public static int[] BubbleSort(int[] vetor)
        {
            return BubbleSort(vetor, 0, vetor.Length - 1);
        }

        private static int[] BubbleSort(int[] vetor, int inicio, int referencia)
        {
            if (inicio < referencia)
            {
                bool troca = false;
                for (int i = inicio; i < referencia; i++)
                {
                    if (vetor[i].CompareTo(vetor[i + 1]) > 0)
                    {
                        int aux = vetor[i];
                        vetor[i] = vetor[i + 1];
                        vetor[i + 1] = aux;
                        troca = true;
                    }
                }
                if (troca)
                    BubbleSort(vetor, inicio, referencia - 1);
                else
                    return vetor;
            }
            return vetor;
        }

        public static int[] Selecao(int[] vetor)
        {
            return Selecao(vetor, 0);
        }

        private static int[] Selecao(int[] vetor, int referencia)
        {
            if (referencia < vetor.Length)
            {
                int menor = referencia;
                for (int i = referencia; i < vetor.Length; i++)
                {
                    if (vetor[i] < vetor[menor])
                        menor = i;
                }
                if (menor == int.MaxValue)
                    return vetor;
                else
                {
                    int aux = vetor[menor];
                    vetor[menor] = vetor[referencia];
                    vetor[referencia] = aux;
                    return Selecao(vetor, referencia + 1);
                }
            }
            else
                return vetor;
        }

        public static int[] Insercao(int[] vetor)
        {
            return Insercao(vetor, 1);
        }

        private static int[] Insercao(int[] vetor, int referencia)
        {
            if (referencia < vetor.Length)
            {
                int posicao = referencia - 1;
                while (posicao >= 0 && vetor[posicao] > vetor[referencia])
                    posicao -= 1;
                if (posicao == referencia - 1)
                    return Insercao(vetor, referencia + 1);
                else
                {
                    int aux = vetor[referencia];
                    for (int i = referencia - 1; i > posicao + 2; i--)
                        vetor[i + 1] = vetor[i];
                    vetor[posicao + 1] = aux;
                    return Insercao(vetor, referencia + 1);
                }
            }
            else
                return vetor;
        }

        public static int[] QuickSort (int[] vetor)
        {
            QuickSort(vetor, 0, vetor.Length - 1);
            return vetor;
        }

        private static void QuickSort (int[] vetor, int inicio, int fim)
        {
            int part;
            if (inicio < fim)
            {
                part = Particao(vetor, inicio, fim);
                QuickSort(vetor, inicio, part - 1);
                QuickSort(vetor, part + 1, fim);
            }
        }

        private static int Particao (int[] vetor, int inicio, int fim)
        {
            int aux;
            int pivot = vetor[fim];
            int part = inicio - 1;
            for (int i = inicio; i < fim; i++)
            {
                if (vetor[i] < pivot)
                {
                    part = part + 1;
                    aux = vetor[part];
                    vetor[part] = vetor[i];
                    vetor[i] = aux;
                }
            }
            aux = vetor[part + 1];
            vetor[part + 1] = vetor[fim];
            vetor[fim] = aux;
            return (part + 1);
        }
    }
}
