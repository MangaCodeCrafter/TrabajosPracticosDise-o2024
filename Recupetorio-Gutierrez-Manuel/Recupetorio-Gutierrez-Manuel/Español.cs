using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recupetorio_Gutierrez_Manuel
{
    internal class Español : Mazo
    {
        #region atributo
        private int cantidad;
        #endregion

        public Español(string marca, bool especial, DateTime fechaLote, Estructura estructura, int cantidad) : base(marca, especial, fechaLote, estructura)
        {
            this.cantidad = (cantidad == 40 || cantidad == 50) ? cantidad : 40;
        }

        #region property

        public int Cantidad
        {
            get { return cantidad; }
            set { this.cantidad = (value == 40 || value == 50) ? value : 40; }
        }
        #endregion

        #region consultas
        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
