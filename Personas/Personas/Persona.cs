using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    internal class Persona
    {
        #region atributos
        protected string nombre;
        protected string dni;
        protected DateTime nacimiento;
        private static string dniDefecto = "99999999";
        #endregion

        #region constructores
        public Persona(string dni)
        {
            this.dni = (dni != null && dni.Length == 8) ? dni : dniDefecto;
        }
        public Persona(string nombre, string dni, DateTime nacimiento)
        {
            this.nombre = (nombre != null) ? nombre : "";
            this.dni = (dni != null && dni.Length == 8) ? dni : dniDefecto;
            this.nacimiento = (nacimiento != null) ? nacimiento : new DateTime(2000, 01, 01);
        }
        #endregion

        #region property
        public string Nombre
        {
            get { return nombre; }
            set { nombre = (value != null) ? value : ""; }
        }
        public string Dni
        {
            get { return dni; }
            set { dni = (value != null && value.Length == 8) ? value : dniDefecto; }
        }  
        public DateTime Nacimiento
        {
            get { return nacimiento; }
            set { nacimiento = (value != null) ? value : new DateTime(2000, 01, 01); }
        }
        #endregion

        #region Consultas
        public override bool Equals(object o)
        {
            bool igual = false;

            if (o == null)
            {
                igual = (this == null);
            }
            else if (this.GetType() == o.GetType())
            {
                Persona p = (Persona) o;
                igual = (dni == p.Dni);
            }

            return igual;
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(dni);
        }

        public override string ToString()
        {
            return $"Persona: {nombre} {dni}";
        }
        #endregion

        #region Comandos

        #endregion
    }
}
