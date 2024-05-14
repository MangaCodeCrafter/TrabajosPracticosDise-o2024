using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    internal class Estudiante : Persona
    {
        #region atributos
        private string legajo { get; set; }
        private string carrera { get; set; }
        private DateTime ingreso { get; set; }
        #endregion

        #region constructores

        public Estudiante(string dni, string legajo) : base(dni)
        {
            this.legajo = legajo;
        }

        public Estudiante(string nombre, string apellido, string dni, DateTime nacimiento, string legajo, string carrera, DateTime ingreso) : base(nombre, apellido, dni, nacimiento)
        {
            this.legajo = legajo;
            this.carrera = carrera;
            this.ingreso = ingreso;
        }

        #endregion

        #region property
        public string Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public DateTime Ingreso
        {
            get { return ingreso; }
            set { ingreso = value; }
        }
        #endregion

        #region consultas
        public bool Existe(Estudiante e)
        {
            return (e.Legajo == this.Legajo);
        }
        #endregion

        #region comandos

        #endregion
    }
}
