using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    abstract class Figura
    {
        #region atributo
        protected int cantidadVertices;
        #endregion

        #region metodos abstractos

        public abstract double area();
        public abstract double perimetro();
        #endregion
    }
}
