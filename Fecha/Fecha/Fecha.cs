using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Fecha
{
    internal class Fecha
    {
        #region "Atributos"
        private int dia { get; set; }
        private int mes { get; set; }
        private int año { get; set; }

        public static int dia_inicial = 1;
        public static int mes_inicial = 1;
        public static int año_inicial = 2000;
        #endregion

        #region "Consultas"
        public bool esIgual(Fecha fecha)
        {
            return (fecha.Dia == this.dia && fecha.Mes == this.mes && fecha.Año == this.año);
        }
        public bool mayorQue(Fecha fecha)
        {
            bool mayor = false;

            if(fecha.Año > this.año) mayor = true;
            if(fecha.Año == this.año && fecha.Mes > this.mes) mayor = true;
            if(fecha.Año == this.año && fecha.Mes == this.mes && fecha.Dia > this.dia) mayor = true;

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
            this.dia = dia_inicial;
            this.mes = mes_inicial;
            this.año = año_inicial;
        }
        public Fecha(int dia, int mes, int año)
        {
            if(esFechaValida(dia, mes, año))
            {
                this.dia = dia;
                this.mes = mes;
                this.año = año;
            }
            else
            {
                this.dia = dia_inicial;
                this.mes = mes_inicial;
                this.año = año_inicial;
            }
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
        #endregion

        #region "propiedades"
        public int Dia
        {
            get { return dia; }
            set { dia = (esFechaValida(value, mes, año)) ? value : dia_inicial; }
        }
        public int Mes
        {
            get { return mes; }
            set { mes = (value > 0 && value < 13) ? value : mes_inicial; }
        }
        public int Año
        {
            get { return año; }
            set { año = (esFechaValida(dia, mes, value)) ? value : año_inicial; }
        }
        #endregion
    }
}