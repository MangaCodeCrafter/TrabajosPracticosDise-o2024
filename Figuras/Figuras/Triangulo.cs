using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Triangulo : Figura
    {
        #region atributos

        private double altura;
        private double baset;
        private double lado1;
        private double lado2;

        #endregion

        #region constructor
        public Triangulo(double baset, double altura, double lado1, double lado2)
        {
            this.baset = (baset > 0) ? baset : 1;
            this.altura = (altura > 0) ? altura : 1;
            this.lado1 = (lado1 > 0) ? lado1 : 1;
            this.lado2 = (lado2 > 0) ? lado2 : 1;
        }
        #endregion

        #region property
        public double Altura
        {
            get { return altura; }
            set { altura = (value > 0) ? value : 1; }
        }
        public double Baset
        {
            get { return baset; }
            set { baset = (value > 0) ? value : 1; }
        }
        public double Lado1
        {
            get { return lado1; }
            set { lado1 = (value > 0) ? value : 1; }
        }
        public double Lado2
        {
            get { return lado2; }
            set { lado2 = (value > 0) ? value : 1; }
        }
        #endregion

        #region metodos
        public override double area()
        {
            return (baset * altura) / 2;
        }
        public override double perimetro()
        {
            return baset + lado1 + lado2;
        }
        public override string ToString()
        {
            return $"Triangulo base: {this.baset}, lado 1: {this.lado1}, lado 2: {this.lado2}";
        }
        public static bool esValido(double baset, double altura, double lado1, double lado2)
        {
            return !((baset + lado1 > lado2) && (baset + lado2 > lado1) && (lado2 + lado1 > baset) && (altura < lado2) && (altura < lado1) && (altura < baset));
        }
        #endregion
    }
}
