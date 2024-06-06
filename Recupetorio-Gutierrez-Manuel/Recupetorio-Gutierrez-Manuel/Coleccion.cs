using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recupetorio_Gutierrez_Manuel
{
    public class Coleccion
    {
        private List<Mazo> lista;

        public Coleccion()
        {
            lista = new List<Mazo>();
        }

        public void Agregar(Mazo m)
        {
            lista.Add(m);
        }

        public void Eliminar(Mazo m)
        {
            lista.Remove(m);
        }

        public List<Mazo> Bucar()
        {
            return lista;
        }

        public List<Mazo> Buscar(Type t) 
        {
            return lista.FindAll(m => t.IsInstanceOfType(m));
        }

        public List<Mazo> Buscar(bool especial)
        {
            return (especial == true) ? lista.FindAll(m => m.Especial == especial) : lista;
        }

        public List<Mazo> Buscar(Type t, bool especial)
        {
            return (especial == true) ? lista.FindAll(m => t.IsInstanceOfType(m) && m.Especial == especial) : lista.FindAll(m => t.IsInstanceOfType(m));
        }

        public List<Mazo> Buscar(string acabado, bool especial)
        {
            return (especial == true) ? lista.FindAll(m => m.Estructura.Acabado == acabado && m.Especial == especial) : lista.FindAll(m => m.Estructura.Acabado == acabado);
        }

        public List<Mazo> Buscar(Type t, string acabado, bool especial)
        {
            return (especial == true) ? lista.FindAll(m => t.IsInstanceOfType(m) && m.Estructura.Acabado == acabado && m.Especial == especial) : lista.FindAll(m => t.IsInstanceOfType(m) && m.Estructura.Acabado == acabado);
        }
        public List<Mazo> Buscar(int cantidad, bool especial)
        {
            return (especial == true) ? lista.FindAll(m => m is Español es && es.Cantidad == cantidad && m.Especial == especial) : lista.FindAll(m => m is Español es && es.Cantidad == cantidad);
        }        
        public List<Mazo> Buscar(int cantidad, string acabado, bool especial)
        {
            return (especial == true) ? lista.FindAll(m => m is Español es && es.Cantidad == cantidad && m.Especial == especial && m.Estructura.Acabado == acabado) : lista.FindAll(m => m is Español es && es.Cantidad == cantidad && m.Estructura.Acabado == acabado);
        }
    }
}
