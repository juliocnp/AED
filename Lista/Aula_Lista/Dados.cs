using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Lista
{
    interface Dados: IEquatable<Dados>
    {
        bool Equals(Dados other);
        int CompareTo(Dados other);
    }
}
