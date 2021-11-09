using System;

namespace BibliotecaDeClases
{
    public class AutoF1
    {
        private string escuderia;
        private int posicion;
        private int puntoPartida;
        private int velocidad;

        public string Escuderia { get => escuderia; set => escuderia = value; }
        public int Posicion { get => posicion; set => posicion = value; }
        public int UbicacionEnPista
        {
            get
            {
                return this.puntoPartida;
            }

            set
            {
                this.puntoPartida = value;
            }
        }
        public int Velocidad { get => velocidad; set => velocidad = value; }

        public AutoF1()
        {
            //this.posicion = 0;
        }

        public AutoF1(string escuderia, int velocidad, int puntoPartida)
        {
            this.escuderia = escuderia;
            this.puntoPartida = puntoPartida;
            this.velocidad = velocidad;
        }

        public void Acelerar()
        {
            this.puntoPartida = this.puntoPartida + this.velocidad;
        }

        public override string ToString()
        {
            return string.Format($"Escuderia: {this.Escuderia} - Posicion: {this.Posicion}");
        }
    }
}
