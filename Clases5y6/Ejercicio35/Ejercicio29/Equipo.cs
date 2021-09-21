using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio32
{
    class Equipo
    {
        private short cantidadJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();

        }
        public Equipo(short cantidad, string nombre): this()
        {
            this.cantidadJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            
            if (e.jugadores.Count < e.cantidadJugadores)
            {
                foreach (Jugador item in e.jugadores)
                {
                   
                    if (item == j)
                    return false;
                }
                e.jugadores.Add(j);
                return true;
            }
            else
            {
                return false;
            }


        }

    }
}
