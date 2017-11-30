using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Arvore
{
    class Conta : Dados
    {
        int tipo;
        double leituraAtual, leituraAnterior;
        long identificador, cpf;

        public int Tipo
        {
            get
            {
                return tipo;
            }
        }

        public double LeituraAtual
        {
            get
            {
                return leituraAtual;
            }

            set
            {
                leituraAtual = value;
            }
        }

        public double LeituraAnterior
        {
            get
            {
                return leituraAnterior;
            }

            set
            {
                leituraAnterior = value;
            }
        }

        public long Identificador
        {
            get
            {
                return identificador;
            }
        }

        public long Cpf
        {
            get
            {
                return cpf;
            }
        }

        public Conta (long identificador, long cpf, int tipo)
        {
            this.identificador = identificador;
            this.cpf = cpf;
            this.tipo = tipo;
        }

        public bool Equals(Dados other)
        {
            if (this.Identificador.Equals(other)) return true;
            else return false;
        }

        public int CompareTo(Dados other)
        {
            Conta aux = (Conta)other;

            if (this.Identificador < aux.Identificador) return -1;
            else if (this.Identificador == aux.Identificador) return 0;
            else return 1;
        }

        public int CompareTo(long other)
        {
            if (this.identificador < other) return -1;
            else if (this.Identificador == other) return 0;
            else return 1;
        }
    }
}
