using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Arvore
{
    class ABB
    {
        Nodo raiz;

        public ABB ()
        {
            this.raiz = null;
        }

        private Nodo inserir (Nodo novo, Nodo onde)
        {
            if (onde == null)
                return novo;
            else
            {
                if (novo.CompareTo(onde) < 0)
                    onde.esq = inserir(novo, onde.esq);
                else
                    onde.dir = inserir(novo, onde.dir);

                return onde;
            }
        }

        public void inserir (Dados d)
        {
            Nodo novo = new Nodo(d);
            this.raiz = inserir(novo, raiz);
        }

        private Nodo buscar (long v, Nodo onde)
        {
            if (onde == null)
                return null;
            else
            {
                if (onde.Equals(v))
                    return onde;
                else if (onde.d.CompareTo(v) < 0)
                    return buscar(v, onde.dir);
                else
                    return buscar(v, onde.esq);
            }
        }

        public Dados buscar (long v)
        {
            Nodo achou = buscar(v, raiz);
            if (achou == null) return null;
            else return achou.d;
        }
    }
}
