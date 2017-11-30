using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenacao
{
    interface Dados : IComparable, IEquatable<Dados>
    {
        int CompareTo(Dados other);
        bool Equals(Dados other);
    }
}
