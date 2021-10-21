using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio50Clases
{
    public class Serializar<S,V> : IGuardar<S,V>
    {
        public bool Guardar(S obj)
        {
            return true;
        }

        public V Leer()
        {
            string sAux = "Objeto Leido";

            return (V)Convert.ChangeType(sAux, typeof(V));
        }

    }
}
