using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Rectangulo : Figura
    {
        #region atributos
        private double baset;
        private double altura;
        #endregion

        #region property
        public double Baset
        {
            get { return baset; }
            set { baset = (value > 0) ? value : 1; }
        }
        public double Altura 
        {
            get { return altura; }
            set { altura = (value > 0) ? value : 1; }
        }
        #endregion

        #region metodos
        public override double area()
        {
            return baset * altura;
        }
        public override double perimetro()
        {
            return baset * 2 + altura * 2;
        }
        public override string ToString()
        {
            return $"Rectangulo base: {this.baset}, altura: {this.altura}";
        }
        #endregion

        #region constructor
        public Rectangulo(double baset, double altura)
        {
            this.baset = (baset > 0) ? baset : 1;
            this.altura = (altura > 0) ? altura : 1;
        }
        #endregion
    }
}
