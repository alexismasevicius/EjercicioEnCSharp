using System;

namespace Ejercicio50Clases
{
    public class GuardarTexto<T,V>
    {
        public bool Guardar(S obj)
        {
            return true;
        }

        public V Leer()
        {
            string sAux = "Texto Leido";

            return (V)Convert.ChangeType(sAux, typeof(V));
        }

    }
}
