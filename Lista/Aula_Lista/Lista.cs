using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Lista
{
    class Lista
    {
        Elemento prim, ult;
        public Lista()
        {
            this.prim = new Elemento(null);
            this.ult = this.prim;
        }

        public void Inserir (Dados novo)
        {
            Elemento aux = new Elemento(novo);
            this.ult.prox = aux;
            this.ult = aux;
        }
        public Dados Localizar (Object obj)
        {
            Elemento aux = this.prim.prox;
            while ((aux != null) && (!aux.d.Equals(obj)))
                aux = aux.prox;
            if (aux == null) return null;
            else return aux.d;
        }

        public Dados Retirar (Object obj)
        {
            Elemento aux = this.prim;
            while ((aux.prox != null) && (!aux.prox.d.Equals(obj)))
                aux = aux.prox;
            if (aux.prox!=null)
            {
                Elemento auxRet = aux.prox;
                aux.prox = auxRet.prox;
                if (auxRet == this.ult) this.ult = aux;
                else auxRet.prox = null;
                return auxRet.d;
            }
            return null;
        }
    }
}
