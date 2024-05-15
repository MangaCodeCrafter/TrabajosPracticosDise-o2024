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

        public double altura { get; set; }
        public double baset { get; set; }
        public double lado1 { get; set; }
        public double lado2 { get; set; }

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
            throw new NotImplementedException();
        }
        public override double perimetro()
        {
            throw new NotImplementedException();
        }
        public override string mostrar()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
