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
        public double lado { get; set; }
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
            return 0;
        }
        public override double perimetro()
        {
            return 0;
        }
        public override string mostrar()
        {
            return "";
        }
        #endregion

        #region constructor
        public Cuadrado(double lado) : base(lado, lado) { }
        #endregion
    }
}
