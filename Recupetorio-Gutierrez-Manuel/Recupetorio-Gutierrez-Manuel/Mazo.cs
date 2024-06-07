using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recupetorio_Gutierrez_Manuel
{
    public abstract class Mazo
    {
        protected int codigo;
        protected string marca;
        protected bool especial;
        protected DateTime fechaLote;
        protected Estructura estructura;

        protected Mazo(int codigo, string marca, bool especial, DateTime fechaLote, Estructura estructura)
        {
            this.codigo = (codigo > 0) ? codigo : 0;
            this.marca = (marca != null) ? marca : "";
            this.especial = especial;
            this.fechaLote = (fechaLote != null) ? fechaLote : DateTime.Now;
            this.estructura = (estructura != null) ? estructura : new Estructura();
        }

        #region property
        public int Codigo
        {
            get { return codigo; }
            set { codigo = (value > 0) ? value : 0; }
        }
        public string Marca
        {
            get { return this.marca; }
            set { this.marca = (value != null) ? value : ""; }
        }
        public bool Especial
        {
            set { this.especial = value; }
            get { return this.especial; }
        }
        public DateTime FechaLote
        {
            get { return this.fechaLote; }
            set { this.fechaLote = (fechaLote != null) ? value : DateTime.Now; }
        }
        public Estructura Estructura
        {
            get { return this.estructura; }
            set { this.estructura = (value != null) ? value : new Estructura(); }
        }
        public string Acabado
        {
            get { return this.Estructura.Acabado; }
            set { this.Estructura.Acabado = value; }
        }

        #endregion

        public abstract override string ToString();
        public abstract override int GetHashCode();
        public abstract override bool Equals(object obj);
    }
}
