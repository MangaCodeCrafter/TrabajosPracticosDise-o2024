using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recupetorio_Gutierrez_Manuel
{
    internal abstract class Mazo
    {
        public abstract override string ToString();
        public abstract override int GetHashCode();
        public abstract override bool Equals(object obj);
    }
}
