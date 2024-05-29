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
        #endregion

        #region constructores

        public Estudiante(string dni, string legajo) : base(dni)
        {
            this.legajo = legajo;
        }

        public Estudiante(string nombre, string dni, DateTime nacimiento, string legajo, string carrera) : base(nombre, dni, nacimiento)
        {
            this.legajo = legajo;
            this.carrera = carrera;
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
        #endregion

        #region consultas
        public override bool Equals(object o)
        {
            bool igual = false;

            if (o == null)
            {
                igual = (this == null);
            }
            else if (this.GetType() == o.GetType())
            {
                Estudiante p = (Estudiante)o;
                igual = (legajo == p.Legajo || dni == p.Dni);
            }

            return igual;
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(dni) * Convert.ToInt32(legajo);
        }

        public override string ToString()
        {
            return $"Estudiante: {nombre} {dni} {legajo}";
        }
        #endregion

        #region comandos

        #endregion
    }
}
