using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Fila
    {
        Elemento prim, ult;

        public Fila()
        {
            this.prim = new Elemento(null);
            this.ult = this.prim;
        }

        public void Inserir (Dados d)
        {
            Elemento aux = new Elemento(d);

            this.ult.prox = aux;
            this.ult = aux;
        }

        public Dados Retirar()
        {
            if (this.prim.prox != null)
            {
                Elemento aux = this.prim.prox;

                if (aux == this.ult)
                    this.ult = this.prim;

                this.prim.prox = aux.prox;
                aux.prox = null;
                return aux.d;
            }
            else
                return null;
        }

        public bool Vazia()
        {
            if (this.ult == this.prim)
                return true;
            else return false;
        }

        public bool UltimoElemento()
        {
            if (this.prim.prox == this.ult)
                return true;
            else return false;
        }
    }
}
