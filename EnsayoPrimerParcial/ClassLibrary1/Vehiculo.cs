using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    abstract class Vehiculo
    {
        private DateTime horaEgreso;
        private DateTime horaIngreso;
        private string patente;


        public enum EVehiculos { Automovil, Moto }

        //CONSTRUCTORES
        public Vehiculo(string patente, DateTime horaIngreso)
        {
            this.Patente = patente;
            this.horaIngreso = horaIngreso;
        }

        //PROPIEDADES
        public DateTime HoraEgreso
        {
            get { return this.horaEgreso; }
            set
            {
                if (DateTime.Compare(this.horaEgreso, this.HoraIngreso) > 0)
                {
                    this.horaEgreso = value;
                }

            }
        }
        public DateTime HoraIngreso
        {
            get { return this.horaIngreso; }
            set
            {
                this.horaIngreso = value;
            }
        }
        public string Patente
        {
            get { return this.patente; }
            set
            {
                if (ValidarPatente(value))
                {
                    this.patente = value;
                }
            }
        }

        public abstract double CostoEstadia
        {
            get;
        }
        public abstract string Descripcion
        {
            get;
        }


        //METODOS

        private static bool ValidarPatente(string patente)
        {
            if (patente.Length >= 6 && patente.Length <= 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Calcula la cantidad de horas de estadia del vehiculo instanciado
        /// </summary>
        /// <returns>La cantidad de horas de estadia del Vehiculo</returns>
        protected virtual double CargoDeEstacionamiento()
        {
            TimeSpan auxDate = this.HoraIngreso.Subtract(this.HoraEgreso); //RESTAR DIRECTAMENTE

            return auxDate.TotalHours;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder strB = new StringBuilder();

            strB.AppendLine($"La patente es :{this.Patente}");
            strB.AppendLine($"La hora de egreso es: {this.HoraEgreso}");

            return strB.ToString();

        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if(String.Equals(v1, v2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1==v2);
        }

    }
}
