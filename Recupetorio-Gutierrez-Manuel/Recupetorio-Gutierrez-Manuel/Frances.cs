using System;
using System.Collections.Generic;
using System.Linq;
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
