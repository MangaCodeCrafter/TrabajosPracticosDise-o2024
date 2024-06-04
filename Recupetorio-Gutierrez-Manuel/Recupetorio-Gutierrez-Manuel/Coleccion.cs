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

        public void Filtro()
        {

        }
    }
}
