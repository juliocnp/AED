using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    interface Dados : IEquatable<Dados>, IComparable<Dados>
    {
        new bool Equals(Dados other);

        new bool Equals(long other);

        new int CompareTo(Dados other);

        new int CompareTo(long other);
    }
}
