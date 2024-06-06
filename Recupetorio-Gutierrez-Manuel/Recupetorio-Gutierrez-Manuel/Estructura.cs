using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recupetorio_Gutierrez_Manuel
{
    public class Estructura
    {
        private string material;
        private string acabado;

        #region constructores
        public Estructura()
        {
            material = "";
            acabado = "";
        }

        public Estructura(string material, string acabado)
        {
            this.material = (material == "Papel" || material == "Plastico") ? material : "";
            this.acabado = (acabado == "Air Cushion" || acabado == "Smooth" || acabado == "Plastic") ? acabado : "";
        }
        #endregion

        #region property

        public string Material
        {
            get { return material; }
            set { this.material = (value == "Papel" || value == "Plastico") ? value : ""; }
        }
        public string Acabado 
        {
            get { return this.acabado; }
            set { this.acabado = (value == "Air Cushion" || value == "Smooth" || value == "Plastic") ? value : ""; }
        }
        #endregion

        public override bool Equals(object obj)
        {
            bool igual = false;

            if (obj == null)
            {
                igual = (this == null);
            }
            else if (obj.GetType() == this.GetType())
            {
                 Estructura e = (Estructura)obj;
                 igual = (acabado == e.Acabado && material == e.Material);
            }

            return igual;
        }
    }
}
