using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fecha
{
    internal class Fecha
    {
        #region "Atributos"
        private int dia { get; set; }
        private int mes { get; set; }
        private int año { get; set; }
        #endregion

        #region "Consultas"
        public int getDia()
        {
            return this.dia; 
        }        
        public int getMes()
        {
            return this.mes; 
        }        
        public int getAño()
        {
            return this.año; 
        }
        public bool esIgual(Fecha fecha)
        {
            return (fecha.getDia() == this.dia && fecha.getMes() == this.mes && fecha.getAño() == this.año);
        }
        public bool mayorQue(Fecha fecha)
        {
            bool mayor = false;

            if(fecha.getAño() > this.año) mayor = true;
            if(fecha.getAño() == this.año && fecha.getMes() > this.mes) mayor = true;
            if(fecha.getAño() == this.año && fecha.getMes() == this.mes && fecha.getDia() > this.dia) mayor = true;

            return mayor;
        }
        public bool menorQue(Fecha fecha)
        {
            return (!mayorQue(fecha) && !esIgual(fecha));
        }
        public string mostrar()
        {
            return $"{this.dia}/{this.mes}/{this.año}";
        }
        #endregion

        #region "Comandos"
        public void setDia(int dia)
        {
            this.dia = dia;
        }        
        public void setMes(int mes)
        {
            this.mes = mes;
        }        
        public void setAño(int año)
        {
            this.año = año;
        }
        public Fecha Incrementar()
        {
            int dia = this.dia;
            int mes = this.mes;
            int año = this.año;

            if (esFechaValida(dia + 1, mes, año)) dia++;
            else if (esFechaValida(dia = 1 , mes + 1, año))
            {
                dia = 1;
                mes++;
            }
            else
            {
                dia = 1;
                mes = 1;
                año++;
            }

            Fecha fecha = new Fecha(dia, mes, año);

            return fecha;
        }

        public Fecha Decrementar()
        {
            int dia = this.dia;
            int mes = this.mes;
            int año = this.año;

            if (esFechaValida(dia - 1, mes, año)) dia--;
            else if (esFechaValida(dia = ultimoDiaMes(mes - 1, año), mes - 1, año))
            {
                mes--;
                dia = ultimoDiaMes(mes, año);
            }
            else
            {
                año--;
                dia = ultimoDiaMes(mes, año);
                mes = 12;
            }

            Fecha fecha = new Fecha(dia, mes, año);

            return fecha;
        }
        #endregion

        #region "Constructores"
        public Fecha()
        {
            this.dia = 01;
            this.mes = 01;
            this.año = 2000;
        }
        public Fecha(int dia, int mes, int año)
        {
            this.dia = dia;
            this.mes = mes;
            this.año = año;
        }
        #endregion

        #region "Metodos estáticos"
        public static bool esAñoBiciesto(int año)
        {
            return (año % 4 == 0 && año % 100 != 0) || (año % 100 == 0 && año % 400 == 0);
        }

        public static int ultimoDiaMes(int mes, int año)
        {
            int ultimoDia;

            if (mes == 4 | mes == 6 | mes == 9 | mes == 11) ultimoDia = 30;
            else if (mes == 2) ultimoDia = esAñoBiciesto(año) ? 29 :  28;
            else ultimoDia = 31;

            return ultimoDia;
        }

        public static bool esFechaValida(int dia, int mes, int año)
        {
            return (dia > 0 && mes > 0 && mes <= 12 && dia <= ultimoDiaMes(mes, año));
        }
        public int contarDiasEntre(Fecha fechaSegunda)
        {
            int cantidadDias = 0;

            Fecha fecha = new Fecha(dia, mes, año);

            while (fecha.mayorQue(fechaSegunda))
            {
                cantidadDias++;
                fecha = fecha.Incrementar();
            }

            return cantidadDias;
        }
    }
        #endregion
}