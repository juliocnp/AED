using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    class Pessoa : Dados
    {
        private long cpf;
        private string nome;
        private Lista voos;

        public string Nome { get { return this.nome; } }
        public long Cpf { get { return this.cpf; }  }
        public Lista Voos { get { return voos; } }

        public int CompareTo(Dados other)
        {
            Pessoa aux = (Pessoa)other;
            return this.Cpf.CompareTo(aux.Cpf);
        }

        public int CompareTo(long other)
        {
            return this.Cpf.CompareTo(other);
        }

        public bool Equals(Dados other)
        {
            Pessoa aux = (Pessoa)other;
            return this.Cpf.Equals(aux.Cpf);
        }

        public bool Equals(long other)
        {
            return this.Cpf.Equals(other);
        }

        public Pessoa(long cpf, string nome)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.voos = new Lista();
        }

        public void AddVoo (string voo)
        {
            Voo aux = new Voo(voo);
            this.voos.Add(aux);
        }
    }
}
