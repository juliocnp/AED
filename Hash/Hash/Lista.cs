using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
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

        public Dados Buscar (long n)
        {
            Elemento aux = this.primeiro.prox;
            while (aux != null)
            {
                if (aux.d.Equals(n))
                    return aux.d;
                else
                    aux = aux.prox;
            }
            return null;
        }

        public Dados Buscar(int n)
        {
            Elemento aux = this.primeiro.prox;
            while (aux != null)
            {
                if (aux.Equals(n))
                    return aux.d;
                else
                    aux = aux.prox;
            }
            return null;
        }

        public Dados Buscar(string n)
        {
            Elemento aux = this.primeiro.prox;
            while (aux != null)
            {
                if (aux.Equals(n))
                    return aux.d;
                else
                    aux = aux.prox;
            }
            return null;
        }

        public Dados Retirar(long n)
        {
            Elemento aux = this.primeiro;
            Elemento aux2 = aux.prox;
            while (aux2 != null)
            {
                if (aux2.Equals(n))
                {
                    aux.prox = aux2.prox;
                    aux2.prox = null;
                    return aux.d;
                }
                else
                {
                    aux = aux.prox;
                    aux2 = aux.prox;
                }
            }
            return null;
        }
        public Dados Retirar(int n)
        {
            Elemento aux = this.primeiro;
            Elemento aux2 = aux.prox;
            while (aux2 != null)
            {
                if (aux2.Equals(n))
                {
                    aux.prox = aux2.prox;
                    aux2.prox = null;
                    return aux.d;
                }
                else
                {
                    aux = aux.prox;
                    aux2 = aux.prox;
                }
            }
            return null;
        }
        public Dados Retirar(string n)
        {
            Elemento aux = this.primeiro;
            Elemento aux2 = aux.prox;
            while (aux2 != null)
            {
                if (aux2.Equals(n))
                {
                    aux.prox = aux2.prox;
                    aux2.prox = null;
                    return aux.d;
                }
                else
                {
                    aux = aux.prox;
                    aux2 = aux.prox;
                }
            }
            return null;
        }
    }
}
