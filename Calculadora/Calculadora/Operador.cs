using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operador : Dados
    {
        private int prioridade;
        private string op;

        public int Prioridade
        {
            get
            {
                return prioridade;
            }
        }

        public string Op
        {
            get
            {
                return op;
            }
        }

        public Operador (string operador)
        {
            this.op = operador;
            string aux = "TAN SEN COS COSSEC SEC COTG MOD LOG LOGe";

            if (operador.Equals("(") || operador.Equals(")")) this.prioridade = 0;
            else if (operador.Equals("+") || operador.Equals("-")) this.prioridade = 1;
            else if (operador.Equals("*") || operador.Equals("/")) this.prioridade = 2;
            else if (operador.Equals("^") || operador.Equals("√")) this.prioridade = 3;
            else if (aux.Contains(operador)) this.prioridade = 4;
        }

        public bool Equals(Dados other)
        {
            Operador aux = (Operador)other;
            if (this.op.Equals(aux)) return true;
            else return false;
        }

        public int CompareTo(Dados other)
        {
            Operador aux = (Operador)other;
            if (this.Prioridade < aux.Prioridade) return -1;
            else if (this.Prioridade == aux.Prioridade) return 0;
            else return 1;
        }

        static public bool IsOperator (string dado)
        {
            string aux = "-+*/^()√ TAN COS SEN MOD LOG COTG LOGe COSSEC SEC";
            if (aux.Contains(dado))
                return true;
            else return false;
        }

        static public bool IsEspecial (string dado)
        {
            string aux = "-+*/^()√";
            if (aux.Contains(dado))
                return false;
            else return true;
        }

        public bool IsNumber()
        {
            return false;
        }

        public bool IsOperator()
        {
            string aux = "-+*/^()√ TAN COS SEN";
            if (aux.Contains(this.op.ToString()))
                return true;
            else return false;
        }

        public override string ToString()
        {
            return this.op.ToString();
        }

        static public bool Need2Numbers(Operador op)
        {
            string aux = "-+*/^";
            if (aux.Contains(op.Op))
                return true;
            else
                return false;
        }

        public double FazerOperacao (double[] numeros)
        {
            switch (this.op)
            {
                case "-":
                    return numeros[0] - numeros[1];
                case "+":
                    return numeros[0] + numeros[1];
                case "*":
                    return numeros[0] * numeros[1];
                case "/":
                    return numeros[0] / numeros[1];
                case "^":
                    return Math.Pow(numeros[0], numeros[1]);
                case "√":
                    return Math.Sqrt(numeros[0]);
                case "TAN":
                    return Math.Tan(numeros[0]);
                case "COS":
                    return Math.Cos(numeros[0]);
                case "SEN":
                    return Math.Sin(numeros[0]);
                case "COSSEC":
                    return Math.Asin(numeros[0]);
                case "COTG":
                    return Math.Atan(numeros[0]);
                case "SEC":
                    return Math.Acos(numeros[0]);
                case "MOD":
                    return Math.Abs(numeros[0]);
                case "LOG":
                    return Math.Log10(numeros[0]);
                case "LOGe":
                    return Math.Log(numeros[0]);
                default:
                    throw new Exception("Operação inválida!");
            }
        }
    }
}
