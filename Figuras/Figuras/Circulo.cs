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
        private double radio;
        #endregion

        #region propertys
        public double Radio
        {
            get { return radio; }
            set { radio = (value > 0) ? value : 1; }
        }
        #endregion

        #region metodos
        public override double area()
        {
            return Math.PI * radio * radio;
        }
        public override double perimetro()
        {
            return Math.PI * radio * 2;
        }
        public override string ToString()
        {
            return $"Circulo radio: {this.radio}";
        }
        #endregion

        #region constructor
        public Circulo(double radio)
        {
            this.radio = (radio > 0) ? radio : 1;
        }
        #endregion
    }
}
