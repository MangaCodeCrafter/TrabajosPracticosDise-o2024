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
        private double baset { get; set; }
        private double altura { get; set; }
        #endregion

        #region property
        public double Baset
        {
            get { return baset; }
            set { baset = value; }
        }
        public double Altura 
        {
            get { return altura; }
            set { altura = value; }
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
        public override string mostrar()
        {
            return $"Rectangulo base: {this.baset}, altura: {this.altura}";
        }
        #endregion

        #region constructor
        public Rectangulo(double baset, double altura)
        {
            this.baset = baset;
            this.altura = altura;
        }
        #endregion
    }
}
