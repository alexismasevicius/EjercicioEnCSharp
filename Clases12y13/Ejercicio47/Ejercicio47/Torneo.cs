using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio47
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        private Torneo()
        {
            this.equipos = new List<T>();
        }

        public Torneo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            foreach (T item in torneo.equipos)
            {
                if (item == equipo)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo==equipo);
        }


        public static bool operator +(Torneo<T> torneo, T equipo)
        {
            if (torneo!=equipo)
            {
                torneo.equipos.Add(equipo);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Mostrar()
        {
            StringBuilder strB = new StringBuilder();

            strB.AppendLine($"Nmbre del torneo : {this.nombre}");
            strB.AppendLine($"EQUIPOS PARTICIPANTES : {this.nombre}");
            foreach (T item in this.equipos)
            {
                strB.AppendLine($"{item.nombre}");
            }

            return strB.ToString();
        }

        private string CalcularPartido(T obj1, T obj2)
        {
            Random rnd = new Random();

            return string.Format("[{0}][{1}]-[{2}][{3}]", obj1.nombre, rnd.Next(0, 4), obj2.nombre, rnd.Next(0, 4));

        }

        public string JugarPartido
        {
            get
            {
                Random r = new Random();
                return this.CalcularPartido(this.equipos[r.Next(0, this.equipos.Count - 1)], this.equipos[r.Next(0, this.equipos.Count - 1)]);
            }
        }

    }
}
