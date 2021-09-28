using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public sealed class Automovil : Vehiculo
    {
        private string marca;
        private static double valorHora;



        //CONSTRUCTORES

        static Automovil()
        {
            Automovil.ValorHora = 120;
        }

        public Automovil(string patente, DateTime horaIngreso, string marca)
            : base(patente, horaIngreso)
        {
            this.marca = marca;
        }

        //PROPIEDADES
        public static double ValorHora
        {
            set
            {
                if (value > 0)
                {
                    valorHora = value;
                }
            }
        }
        public override double CostoEstadia
        {
            get
            {
                return this.CargoDeEstacionamiento();
            }
        }

        public override string Descripcion
        {
            get{ return this.marca; } 
        }


        //METODOS
        protected override double CargoDeEstacionamiento() 
        {
            double horasDeEstadia = base.CargoDeEstacionamiento();

            return (double)(horasDeEstadia * Automovil.valorHora);


        }

        protected override string MostrarDatos()
        {
            StringBuilder strB = new StringBuilder();

            strB.AppendLine($"{base.MostrarDatos()}");
            strB.AppendLine($"Es un : AUTOMOVIL");
            strB.AppendLine($"Marca : {this.Descripcion}");

            return strB.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

    }
}
