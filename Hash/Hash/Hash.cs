using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    class Hash
    {
        Lista[] posicoes;
        public delegate int expressao(long n);
        expressao ex;
        int colisao;

        public Hash(int capacidade, expressao ex)
        {
            posicoes = new Lista[capacidade];
            for (int i = 0; i < posicoes.Length; i++)
            {
                posicoes[i] = new Lista();
            }
            this.ex = ex;
        }

        public expressao Ex { get { return ex; } }

        public int Colisao { get { return colisao; } }

        public void Inserir (long n, Dados novo)
        {
            try
            {
                posicoes[ex(n)].Add(novo);
                if (posicoes[ex(n)].tamanho > Colisao)
                    colisao = posicoes[ex(n)].tamanho;
            }
            catch { throw new Exception("Função fora dos limites de capacidade do vetor"); }
        }

        public Dados Buscar (long n)
        {
            try { return posicoes[ex(n)].Buscar(n); }
            catch { throw new Exception("Função fora dos limites de capacidade do vetor"); }
        }

        public Dados Remover(long n)
        {
            try { return posicoes[ex(n)].Retirar(n); }
            catch { throw new Exception("Função fora dos limites de capacidade do vetor"); }
        }
    }
}
