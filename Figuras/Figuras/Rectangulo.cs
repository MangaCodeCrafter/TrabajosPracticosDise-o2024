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
        public double baset { get; set; }
        public double altura { get; set; }
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

        #region constructor
        public Rectangulo(double baset, double altura)
        {
            this.baset = baset;
            this.altura = altura;
        }
        #endregion
    }
}
