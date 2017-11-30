using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    interface Dados : IEquatable<Dados>, IComparable<Dados>
    {
        bool Equals(Dados other);
        int CompareTo(Dados other);

        bool IsNumber();

        bool IsOperator();

        string ToString();
    }
}
