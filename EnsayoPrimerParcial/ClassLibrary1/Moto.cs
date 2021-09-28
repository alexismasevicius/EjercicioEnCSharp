using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public sealed class Moto:Vehiculo
    {

        public enum ETipo{Ciclomotor, Scooter, Sport}
        private ETipo tipo;
        private static double valorHora;

        //CONSTRUCTORES
        static Moto()
        {
            Moto.valorHora = 100;
        }

        public Moto(string patente, DateTime horaIngreso, ETipo tipo)
        : base(patente, horaIngreso)
        {
            this.tipo = tipo;
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
        public override string Descripcion
        {
            get{ return this.tipo.ToString(); }
        }
        public override double CostoEstadia
        {
            get{ return this.CargoDeEstacionamiento(); }
        }

        //METODOS
        protected override double CargoDeEstacionamiento()
        {
            double horasDeEstadia = base.CargoDeEstacionamiento();

            return (double)(horasDeEstadia * Moto.valorHora);

        }
        protected override string MostrarDatos()
        {
            StringBuilder strB = new StringBuilder();

            strB.AppendLine($"{base.MostrarDatos()}");
            strB.AppendLine($"Es una : MOTO");
            strB.AppendLine($"Tipo : {this.Descripcion}");

            return strB.ToString();

        }
        public override string ToString()
        {
            return MostrarDatos();
        }



    }

}
