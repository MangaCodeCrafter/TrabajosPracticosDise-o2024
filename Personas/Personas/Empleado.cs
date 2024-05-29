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
        public string legajo { get; set; }
        public string cargo { get; set; }
        #endregion

        #region property
        public string Legajo
        {
            get { return legajo; }
            set { this.legajo = value; }
        }
        public string Cargo
        {
            get { return cargo; }
            set { this.cargo = value; }
        }
        #endregion

        #region constructor
        public Empleado(string nombre, string dni, DateTime nacimiento, string legajo, string cargo) : base (nombre, dni, nacimiento)
        {
            this.legajo = legajo;
            this.cargo = cargo;
        }

        public Empleado (string dni, string legajo) : base (dni)
        {
            this.legajo = legajo;
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
                igual = (legajo == p.Legajo || dni == p.dni);
            }

            return igual;
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(dni) * Convert.ToInt32(legajo);
        }

        public override string ToString()
        {
            return $"Empleado: {nombre} {dni} {legajo}";
        }
        #endregion
    }
}
