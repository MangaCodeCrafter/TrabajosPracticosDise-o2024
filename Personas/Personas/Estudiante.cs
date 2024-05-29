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
        private string legajo;
        private string carrera;
        private static string legajoDefecto = "999999";
        #endregion

        #region constructores

        public Estudiante(string dni, string legajo) : base(dni)
        {
            this.legajo = (legajo != null && legajo.Length == 6) ? legajo : legajoDefecto;
            this.carrera = "";
        }

        public Estudiante(string nombre, string dni, DateTime nacimiento, string legajo, string carrera) : base(nombre, dni, nacimiento)
        {
            this.legajo = (legajo != null && legajo.Length == 6) ? legajo : legajoDefecto;
            this.carrera = (carrera != null) ? carrera : "";
        }

        #endregion

        #region property
        public string Legajo
        {
            get { return legajo; }
            set { legajo = (value != null && value.Length == 6) ? value : legajoDefecto; }
        }
        public string Carrera
        {
            get { return carrera; }
            set { carrera = (value != null) ? value : ""; }
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
                igual = (dni == p.Dni || legajo == p.Legajo);
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
