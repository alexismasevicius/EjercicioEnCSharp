using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


/*Provincial:
g. El método Mostrar será protegido. Reutilizará el código escrito en la clase base 
    y agregará franjaHoraria y CostoLlamada, utilizando un StringBuilder.
h. Equals retornará true sólo si el objeto que recibe es de tipo Provincial.
i. ToString reutilizará el código del método Mostrar.*/
namespace CentralitaHerencia
{
    public class Provincial : Llamada,  IGuardar<Provincial>
    {
        Franja franjaHoraria;
        string rutaDeArchivo;

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3,
        }

        //CONSTRUCTORES

        public Provincial( Franja miFranja,string origen,
            float duracion, string destino):
            base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
            this.RutaDeArchivo = @"C:\Users\alexi\Desktop\EjercicioEnCSharp\Clases13y14\Ejercicio59\serializacionJson.txt";
        }
        public Provincial(Franja miFranja, Llamada llamada):
            this(miFranja, llamada.NroOrigen, llamada.Duracion, llamada.NroDestino)
        {
            
        }
        //PROPIEDADES
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public string RutaDeArchivo
        {
            get
            {
                return this.rutaDeArchivo;
            }

            set
            {
                this.rutaDeArchivo = value;
            }
        }


        //METODOS

        private float CalcularCosto()
        {
            if(this.franjaHoraria==Franja.Franja_1)
            {
                return base.duracion * (float)0.99;
            }
            else
            {
                if (this.franjaHoraria == Franja.Franja_2)
                {
                    return base.duracion * (float)1.25;
                }
                else
                {
                    return base.duracion * (float)0.66;
                }
            }
        }

        protected override string Mostrar()
        {
            StringBuilder strB = new StringBuilder();
            strB.Append($"{base.Mostrar()}");
            strB.AppendLine($"Franja Horarios: {this.franjaHoraria}");
            strB.AppendLine($"Costo de la llamada: {this.CostoLlamada}");

            return strB.ToString();

        }
        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

        public bool Guardar()
        {
            //try
           // {
                string jsonString = JsonSerializer.Serialize(this);
                using (StreamWriter archivo = new StreamWriter(this.RutaDeArchivo, true))
                {
                    archivo.WriteLine(jsonString);
                }
                return true;
          //  }
          //  catch (Exception e)
           // {
            //    throw new Exception("Error al guardar JSON", e);
           // }


        }

        public Provincial Leer()
        {
            try
            {
                StreamReader sw = new StreamReader(@"C:\Users\alexi\Desktop\EjercicioEnCSharp\Clases13y14\Ejercicio59\serializacionJson.txt");
                string strAux = sw.ReadToEnd();
                sw.Close();

                Provincial miLlamada = JsonSerializer.Deserialize<Provincial>(strAux);

                return miLlamada;
            }
            catch(Exception e)
            {
                throw new Exception("Error al leer JSON", e);
            }
        }
    }
}
