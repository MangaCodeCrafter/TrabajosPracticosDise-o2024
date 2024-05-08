using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoApp
{
    public class Circulo
    {
        #region "atributo"

        private double radio;

        #endregion

        #region "consultas"

        public double getRadio()
        {
            return radio;
        }

        public double getArea()
        {
            return Math.Round(Math.PI * (radio * radio), 2);
        }

        public double getDiametro()
        {
            return radio * 2;
        }

        public double getPerimetro()
        {
            return Math.Round(Math.PI * radio * 2, 2);
        }

        public string mostrar()
        {

            return $"Radio: {getRadio()} cm - Diametro: {getDiametro()} cm";
        
        }

        public bool esIgualA(Circulo circulo)
        {
            return (circulo.getRadio() == this.radio);
        }

        #endregion

        #region "comandos"

        public void setRadio(double radio)
        {
            if (radio > 0)
            {
                this.radio = radio;
            }
        }
        public void setDiametro(double diametro)
        {
            if (diametro > 0)
            {
                this.radio = diametro / 2;
            }
        }

        #endregion

        #region "constructor"

        public Circulo(double radio)
        {
            if (radio >= 1) // Verificar si el radio es mayor o igual a 1
            {
                this.radio = radio;
            }
            else
            {
                this.radio = 1;
            }
            

        }

        #endregion

    }
}
