using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Arvore
{
    class Nodo : Dados
    {
        public Dados d;
        public Nodo esq, dir;

        public Nodo (Dados d)
        {
            this.d = d;

            esq = null;
            dir = null;
        }

        public int CompareTo(long other)
        {
            return this.d.CompareTo(other);
        }

        public int CompareTo(Dados other)
        {
            return this.d.CompareTo(other);
        }

        public bool Equals(Dados other)
        {
            if (this.d == other)
                return true;
            else return false;
        }
    }
}
