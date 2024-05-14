using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    internal class Circulo : Figura
    {

        #region atributo
        private double radio { get; set; }
        #endregion

        #region propertys
        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }
        #endregion

        #region metodos
        public override double area()
        {
            return 0; //Agregar implementación
        }
        public override double perimetro()
        {
            return 0; //Agregar implementación
        }
        public override string mostrar()
        {
            return $"Agregar implementación";
        }
        #endregion

        #region constructor
        public Circulo(double radio)
        {
            this.radio = radio;
        }
        #endregion
    }
}
