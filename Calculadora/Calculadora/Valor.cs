using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Valor : Dados
    {
        private double num;

        public double Num
        {
            get
            {
                return num;
            }
        }

        public Valor (double valor)
        {
            this.num = valor;
        }

        public int CompareTo(Dados other)
        {
            Valor aux = (Valor)other;
            if (this.num < aux.num) return -1;
            else if (this.num == aux.num) return 0;
            else return 1;
        }

        public bool Equals(Dados other)
        {
            Valor aux = (Valor)other;
            if (aux.num == this.num) return true;
            else return false;
        }


        static public bool IsNumber(char dado)
        {
            string aux = dado.ToString();
            try
            {
                int.Parse(aux);
                return true;
            }
            catch
            {
                return false;
            }
        }

        static public bool IsNumber(string dado)
        {
            try
            {
                double.Parse(dado);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool IsNumber()
        {
            try
            {
                double.Parse(this.num.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool IsOperator()
        {
            return false;
        }

        public override string ToString()
        {
            return num.ToString();
        }
    }
}
