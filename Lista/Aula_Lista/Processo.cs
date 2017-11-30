using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Lista
{
    class Processo : Dados
    {
        protected int pid;
        protected string nome;
        protected int prioridade;
        protected float tempoTotal;
        protected float tempoRestante;

        public Processo (int pid, string nome, int prioridade, float tempoTotal)
        {
            this.pid = pid;
            this.nome = nome;
            this.prioridade = prioridade;
            this.tempoTotal = tempoTotal;
            this.tempoRestante = this.tempoTotal;
        }
        public int CompareTo(Dados other)
        {
            Processo aux = (Processo)other;
            if (this.pid < aux.pid) return -1;
            else if (this.pid == aux.pid) return 0;
            else return 1;
        }

        public int CompareTo(int prioridade)
        {
            if (this.prioridade < prioridade) return -1;
            else if (this.prioridade == prioridade) return 0;
            else return 1;
        }

        public bool Equals(Dados other)
        {
            Processo aux = (Processo)other;
            if (this.pid == aux.pid) return true;
            else return false;
        }
    }
}
