using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada, IGuardar<Local>
    {
        protected float costo;
        private string rutaDeArchivo;

        //CONSTRUCTOR
        public Local(string origen, float duracion, string destino, float costo):base(duracion,destino,origen)
        {
            this.costo = costo;
            this.RutaDeArchivo =  @"C:\Users\alexi\Desktop\EjercicioEnCSharp\Clases13y14\Ejercicio59\serializacionJson.txt";
        }

        public Local(Llamada llamada, float costo):this(llamada.NroOrigen, llamada.Duracion,llamada.NroDestino,costo)
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
                return rutaDeArchivo;
            }

            set
            {
                rutaDeArchivo = value;
            }
        }

        //METODOS

        private float CalcularCosto()
        {
            return (float)(this.Duracion * this.costo);
        }
        protected override string Mostrar()
        {
            StringBuilder strB = new StringBuilder();
            strB.Append($"{base.Mostrar()}");
            strB.AppendLine($"Costo de la llamada: {this.CostoLlamada}");

            return strB.ToString();
        }
        public override bool Equals(object obj)
        {
            return obj is Local;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

        public bool Guardar()
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(this);
                using (StreamWriter archivo = new StreamWriter(this.RutaDeArchivo, true))
                {
                    archivo.WriteLine(jsonString);
                }
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Error al guardar JSON", e);
            }

        }

        public Local Leer()
        {
            try
            {
                StreamReader sw = new StreamReader(@"C:\Users\alexi\Desktop\EjercicioEnCSharp\Clases13y14\Ejercicio59\serializacionJson.txt");
                string strAux = sw.ReadToEnd();
                sw.Close();
                Local miLlamada = JsonSerializer.Deserialize<Local>(strAux);

                return miLlamada;
            }
            catch (Exception e)
            {
                throw new Exception("Error al leer JSON", e);
            }
        }
    }
}
