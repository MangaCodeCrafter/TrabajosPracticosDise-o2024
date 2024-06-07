using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public void insertarDatos(int codigo, Type tipo, string marca, string modelo, Estructura estructura, DateTime fechaLote, bool especiales, int cantidad)
        {
            if(codigo > 0 && lista.Count != 0)
            {
                Mazo mazo = lista.Find(m => m.Codigo == codigo);

                mazo.Marca = marca;
                mazo.Estructura = estructura;
                mazo.FechaLote = fechaLote;
                mazo.Especial = especiales;

                if (mazo is Frances f) f.Modelo = modelo;
                if (mazo is Español e) e.Cantidad = cantidad;
            }
            else
            {
                codigo = lista.Count;

                if(tipo == typeof(Frances))
                {
                    Frances f = new Frances(codigo, marca, especiales, fechaLote, estructura, modelo);
                    lista.Add(f);
                }
                else
                {
                    Español e = new Español(codigo, marca, especiales, fechaLote, estructura, cantidad);
                    lista.Add(e);
                }
            }
        }

        public void Eliminar(int codigo)
        {
            lista.Remove(lista.Find(m => m.Codigo == codigo));
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
        public Mazo Buscar(int codigo)
        {
            return lista.Find(m => m.Codigo == codigo);
        }
    }
}
