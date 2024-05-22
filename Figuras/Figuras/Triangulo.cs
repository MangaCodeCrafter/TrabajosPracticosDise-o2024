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

        private double altura { get; set; }
        private double baset { get; set; }
        private double lado1 { get; set; }
        private double lado2 { get; set; }

        #endregion

        #region constructor
        public Triangulo(double baset, double altura, double lado1, double lado2)
        {
            this.baset = baset;
            this.altura = altura;
            this.lado1 = lado1;
            this.lado2 = lado2;
        }
        #endregion

        #region property
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public double Baset
        {
            get { return baset; }
            set { baset = value; }
        }
        public double Lado1
        {
            get { return lado1; }
            set { lado1 = value; }
        }
        public double Lado2
        {
            get { return lado2; }
            set { lado2 = value; }
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
        public override string mostrar()
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
