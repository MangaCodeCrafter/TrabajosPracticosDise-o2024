using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanguloApp
{
    public class Rectangulo
    {
        #region "Propiedades"
        private double bace { get; set; }
        private double altura { get; set; }
        #endregion

        #region "Consultas"
        public double getBase()
        {
            return bace;
        }

        public double getAltura()
        {
            return altura;
        }
        public double getPerimetro()
        {
            return 2 * bace + 2 * altura;
        }
        public double getArea()
        {
            return bace * altura;
        }
        public bool esCuadrado()
        {
            if(bace == altura) return true;
            else return false;
        }
        public bool esIgualA(Rectangulo rectangulo)
        {
            if (rectangulo.getAltura() == altura & rectangulo.getBase() == bace) return true;
            else return false;
        }
        public string mostrar()
        {
            return $"Base:{this.getBase()} cm – Altura: {this.getAltura()} cm \n";
        }
        #endregion

        #region "Comandos"
        public void setBase(double nuevaBase)
        {
            this.bace = nuevaBase;
        }
        public void setAltura(double nuevaAltura)
        {
            this.altura = nuevaAltura;
        }
        #endregion

        #region "Constructor"
        public Rectangulo(double bace, double altura)
        {
            this.bace = bace;
            this.altura = altura;
        }
        #endregion


    }
}

