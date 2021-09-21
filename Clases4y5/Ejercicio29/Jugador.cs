using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            partidosJugados = 0;
            promedioGoles = 0;
            totalGoles = 0;
        }
        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni, string nombre, int golesTotales, int totalPartidos) : this(dni,nombre)
        {
            this.partidosJugados = totalPartidos;
            this.totalGoles = golesTotales;
        }

        public float getPromedioGoles()
        {
            this.promedioGoles = this.totalGoles / this.partidosJugados;
            return this.promedioGoles;
        }

        public string MostrarDatos()
        {
            StringBuilder strB = new StringBuilder();
            strB.AppendLine($"Nombre: {this.nombre}");
            strB.AppendLine($"Dni: {this.dni}");
            strB.AppendLine($"Partidos jugdos: {this.partidosJugados}");
            strB.AppendLine($"Goles totales: {this.totalGoles}");
            strB.AppendLine($"Promedio Goles: {this.promedioGoles}");

            return (strB.ToString());
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }


    }
}
