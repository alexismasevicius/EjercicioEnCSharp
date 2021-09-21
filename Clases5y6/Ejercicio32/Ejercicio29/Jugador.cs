using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio32
{
    class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        //CONSTRUCTORES
        private Jugador()
        {
            partidosJugados = 0;
            promedioGoles = 0;
            totalGoles = 0;
        }
        public Jugador(int dni, string nombre) : this()
        {
            this.Dni = dni;
            this.Nombre = nombre;
        }
        public Jugador(int dni, string nombre, int golesTotales, int totalPartidos) : this(dni,nombre)
        {
            this.partidosJugados = totalPartidos;
            this.totalGoles = golesTotales;
        }

        //PROPIEDADES
        public int PartidosJugados
        {
            get { return this.partidosJugados; }

        }
        public float PromedioGoles
        {
            get { return this.TotalGoles / this.PartidosJugados; }

        }
        public int TotalGoles
        {
            get { return this.totalGoles; }

        }

        public int Dni
        {
            get { return dni; }
            set
            {
                this.dni = value;
            }
        }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                this.nombre = value;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder strB = new StringBuilder();
            strB.AppendLine($"Nombre: {this.Nombre}");
            strB.AppendLine($"Dni: {this.Dni}");
            strB.AppendLine($"Partidos jugdos: {this.PartidosJugados}");
            strB.AppendLine($"Goles totales: {this.TotalGoles}");
            strB.AppendLine($"Promedio Goles: {this.PromedioGoles}");

            return (strB.ToString());
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }


    }
}
