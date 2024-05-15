using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Cuadrado : Rectangulo
    {
        #region atributos
        private double lado { get; set; }
        #endregion

        #region property
        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }
        #endregion

        #region metodos
        public override double area()
        {
            return lado * lado;
        }
        public override double perimetro()
        {
            return lado * 4;
        }
        public override string mostrar()
        {
            return $"Cuadrado lado: {this.lado}";
        }
        #endregion

        #region constructor
        public Cuadrado(double lado) : base(lado, lado) { }
        #endregion
    }
}
