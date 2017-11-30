using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Arvore
{
    class Cpf : Dados
    {
        long cpf;
        Lista contas;

        public long _Cpf
        {
            get
            {
                return cpf;
            }
        }

        internal Lista Contas
        {
            get
            {
                return contas;
            }
        }

        public Cpf (long cpf)
        {
            this.cpf = cpf;
            contas = new Lista();
        }

        public bool Equals(Dados other)
        {
            Cpf aux = (Cpf)other;
            if (this._Cpf == aux._Cpf) return true;
            else return false;
        }

        public int CompareTo(Dados other)
        {
            Cpf aux = (Cpf)other;
            if (this._Cpf < aux._Cpf) return -1;
            else if (this._Cpf == aux._Cpf) return 0;
            else return 1;
        }

        public int CompareTo(long other)
        {
            if (this._Cpf < other)  return -1;
            else if (this._Cpf == other) return 0;
            else return 1;
        }
    }
}
