using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Estacionamiento
    {
        private int capacidadEstacionamiento;
        private static Estacionamiento estacionamiento;
        private List<Vehiculo> listadoVehiculos;
        private  string nombre;

        //CONSTRUCTORES

        private Estacionamiento(string nombre, int capacidad)
        {
            this.nombre = nombre;
            this.capacidadEstacionamiento = capacidad;
            this.listadoVehiculos = new List<Vehiculo>();
        }

       

        //PROPIEDADES
        public List<Vehiculo> ListadoVehiculos
        {
            get { return this.listadoVehiculos; }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }
        //METODOS

        public static Estacionamiento GetEstacionamiento(string nombre, int capacidad)
        {

            if(Estacionamiento.estacionamiento is null)
            {
                Estacionamiento.estacionamiento = new Estacionamiento(nombre, capacidad);
            }
            else
            {
                Estacionamiento.estacionamiento.capacidadEstacionamiento = capacidad;
            }
            return Estacionamiento.estacionamiento;
        }
        public string InformarSalida(Vehiculo vehiculo)
        {
            StringBuilder strB = new StringBuilder();

            strB.AppendLine($"{vehiculo.ToString()}");
            strB.AppendLine($"Nombre de estacionamiento : {this.nombre}");
            strB.AppendLine($"Hora de egreso: {vehiculo.HoraEgreso}");

            return strB.ToString();
        }


        //OPERADORES
        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo) 
        {
            foreach (Vehiculo item in estacionamiento.ListadoVehiculos)
            {
                if (item == vehiculo)
                {
                    return true;
                }
            }

            return false;

        }
        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }
        public static bool operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(estacionamiento.listadoVehiculos.Count < estacionamiento.capacidadEstacionamiento &&
                estacionamiento != vehiculo)
            {
                estacionamiento.listadoVehiculos.Add(vehiculo);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento == vehiculo)
            {
                estacionamiento.listadoVehiculos.Remove(vehiculo);
                vehiculo.HoraEgreso = DateTime.Now;
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
