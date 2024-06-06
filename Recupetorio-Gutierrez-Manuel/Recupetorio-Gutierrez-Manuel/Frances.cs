using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Recupetorio_Gutierrez_Manuel
{
    public class Frances : Mazo
    {
        #region atributo
        private static int cantidad = 52;
        private string modelo;
        #endregion

        public Frances(string marca, bool especial, DateTime fechaLote, Estructura estructura, string modelo) : base (marca, especial, fechaLote, estructura)
        {
            this.modelo = (modelo != null) ? modelo : "";
        }

        #region property

        public string Modelo
        {
            get { return this.modelo; }
            set { this.modelo = (value != null) ? value : ""; }
        }
        #endregion

        #region consultas
        public override string ToString()
        {
            return $"Mazo frances {marca} {modelo}";
        }
        public override bool Equals(object obj)
        {
            bool igual = false;

            if (obj == null) igual = (this == null);
            else if (obj.GetType() == this.GetType())
            {
                Frances f = (Frances)obj;
                igual = (marca == f.Marca && especial == f.Especial && fechaLote == f.FechaLote && estructura.Equals(f.estructura) && modelo == f.Modelo);
            }

            return igual;
        }
        public override int GetHashCode()
        {
            return marca.Length * fechaLote.Day * fechaLote.Month * fechaLote.Year * cantidad * modelo.Length;
        }
        #endregion
    }
}
