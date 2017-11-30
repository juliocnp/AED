using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Arvore
{
    interface Dados : IEquatable<Dados>, IComparable<Dados>
    {
        new bool Equals(Dados other);

        new int CompareTo(Dados other);

        new int CompareTo(long other);
    }
}
