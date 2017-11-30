using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Pilha
    {
        public Elemento topo, final;

        public Pilha ()
        {
            topo = new Elemento(null);
            this.topo.prox = null;
            this.final = this.topo;
        }

        public void Empilhar(Dados d)
        {
            Elemento aux = new Elemento(d);

            if (this.topo == this.final)
                this.final = aux;
            aux.prox = this.topo.prox;
            this.topo.prox = aux;
        }

        public Dados Desempilhar ()
        {
            if (topo.prox != null)
            {
                Elemento aux = topo.prox;

                if (aux == this.final)
                    this.final = this.topo;

                this.topo.prox = aux.prox;
                aux.prox = null;
                return aux.d;
            }
            else return null;
        }

        public Dados OlharTopo ()
        {
            if (this.topo.prox != null)
                return this.topo.prox.d;
            else return null;
        }

        public bool UltimoElemento()
        {
            if (this.topo.prox == this.final)
                return true;
            else return false;
        }
    }
}
