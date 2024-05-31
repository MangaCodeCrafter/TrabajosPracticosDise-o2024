using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    internal class Empleado : Persona
    {
        #region atibuto
        private string legajo;
        private string cargo;
        private static string legajoDefecto = "999999";

        #endregion

        #region property
        public string Legajo
        {
            get { return legajo; }
            set { this.legajo = (value != null && value.Length != 6) ? value : legajoDefecto; }
        }
        public string Cargo
        {
            get { return cargo; }
            set { this.cargo = (value != null) ? value : ""; }
        }
        #endregion

        #region constructor
        public Empleado(string nombre, string dni, DateTime nacimiento, string legajo, string cargo) : base (nombre, dni, nacimiento)
        {
            this.legajo = (legajo != null && legajo.Length == 6) ? legajo : legajoDefecto;
            this.cargo = (cargo != null) ? cargo : "";
        }

        public Empleado (string dni, string legajo) : base (dni)
        {
            this.legajo = (legajo != null && legajo.Length == 6) ? legajo : legajoDefecto;
            this.cargo = "Empleado";
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
                Empleado p = (Empleado)o;
                igual = (dni == p.dni || legajo == p.Legajo);
            }

            return igual;
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(dni) * Convert.ToInt32(legajo);
        }

        public override string ToString()
        {
            return base.ToString() + $" {legajo}";
        }
        #endregion
    }
}
