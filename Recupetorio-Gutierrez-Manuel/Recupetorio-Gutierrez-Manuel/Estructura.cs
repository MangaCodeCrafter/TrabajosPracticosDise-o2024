using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recupetorio_Gutierrez_Manuel
{
    internal class Estructura
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
            set { this.material = (value == "Papel" || value == "Plastico") ? value : "0"; }
        }
        public string Acabado 
        {
            get { return this.acabado; }
            set { this.acabado = (value == "Air Cushion" || value == "Smooth" || value == "Plastic") ? value : ""; }
        }
        #endregion
    }
}
