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
        protected string nombre { get; set; }
        protected string dni { get; set; }
        protected DateTime nacimiento { get; set; }
        #endregion

        #region constructores
        public Persona(string dni)
        {
            this.dni = dni;
        }
        public Persona(string nombre, string dni, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.nacimiento = nacimiento;
        }
        #endregion

        #region property
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }  
        public DateTime Nacimiento
        {
            get { return nacimiento; }
            set { nacimiento = value;}
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
        #endregion

        #region Comandos

        #endregion
    }
}
