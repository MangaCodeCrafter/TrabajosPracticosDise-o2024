using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recupetorio_Gutierrez_Manuel
{
    public class Español : Mazo
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
            return $"Mazo Español {marca} de {cantidad} cartas.";
        }

        public override bool Equals(object obj)
        {
            bool igual = false;

            if (obj == null)
            {
                igual = (this == null);
            }
            else if (this.GetType() == obj.GetType())
            {
                Español e = (Español)obj;
                igual = (marca == e.Marca && especial == e.Especial && fechaLote == e.FechaLote && estructura.Equals(e.estructura) && cantidad == e.Cantidad);
            }

            return igual;
        }

        public override int GetHashCode()
        {
            return marca.Length * fechaLote.Day * fechaLote.Month * fechaLote.Year * cantidad;
        }
        #endregion
    }
}
