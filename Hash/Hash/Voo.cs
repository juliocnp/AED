using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    class Voo : Dados
    {
        string id;
        public Voo (string voo)
        {
            id = voo;
        }

        public string Id { get { return id; } }

        public int CompareTo(Dados other)
        {
            Voo aux = (Voo)other;
            return Id.CompareTo(aux.Id);
        }

        public int CompareTo(long other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Dados other)
        {
            Voo aux = (Voo)other;
            return Id.Equals(aux.Id);
        }

        public bool Equals(long other)
        {
            throw new NotImplementedException();
        }
    }
}
