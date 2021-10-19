using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    public abstract class Equipo
    {
        public string nombre;
        public DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fecha)
        {
            this.nombre = nombre;
            this.fechaCreacion = fecha;
        }



        public static bool operator ==(Equipo equipoUno, Equipo equipoDos)
        {
            if (equipoUno.nombre == equipoDos.nombre && equipoUno.fechaCreacion == equipoDos.fechaCreacion)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Equipo equipoUno, Equipo equipoDos)
        {

            return !(equipoUno==equipoDos);
        }

        public string Ficha()
        {
            return string.Format("[{0}] fundado el [{1}]", this.nombre, this.fechaCreacion);
        }

    }
}
