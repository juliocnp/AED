using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Arvore
{
    class Lista
    {
        public Elemento primeiro, ultimo;
        public int tamanho;
        public Lista ()
        {
            this.primeiro = new Elemento(null);
            this.ultimo = this.primeiro;
        }

        public void Add(Dados d)
        {
            Elemento novo = new Elemento(d);

            this.ultimo.prox = novo;
            this.ultimo = novo;
            tamanho++;
        }

        public Dados[] Imprimir ()
        {
            if (this.primeiro == this.ultimo)
                return null;

            Dados[] v = new Dados[tamanho];
            Elemento aux = this.primeiro.prox;

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = aux.d;
                aux = aux.prox;
            }

            return v;
        }
    }
}
