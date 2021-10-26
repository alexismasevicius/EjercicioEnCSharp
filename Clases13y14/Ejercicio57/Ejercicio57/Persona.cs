using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Ejercicio57
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
       
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }


        public static void GuardarJsonOk(Persona miPersona)
        {
            string jsonString = JsonSerializer.Serialize(miPersona);


            using (StreamWriter archivo = new StreamWriter(@"C:\Users\alexi\Desktop\EjercicioEnCSharp\Clases13y14\Ejercicio57\serializacionJson.txt"))
            {
                archivo.WriteLine(jsonString);
            }

        }

        public static void GuardarJsonConExcepcion(Persona miPersona)
        {
            

            try
            {   
                string jsonString = JsonSerializer.Serialize(miPersona);
                using (StreamWriter archivo = new StreamWriter(""))
                {
                    archivo.WriteLine(jsonString);
                }
            }
            catch(System.ArgumentException)
            {
                Console.WriteLine("ERROR . La direccion para guardar el archivo está vacia");
            }
        }

        public static Persona LeerJsonOk(string path)
        {
            try
            {
                StreamReader sw = new StreamReader(path);
                string strAux = sw.ReadToEnd();
                sw.Close();

                Persona miPersona = JsonSerializer.Deserialize<Persona>(strAux);

                return miPersona;
            }
            catch(System.InvalidOperationException)
            {
                Console.WriteLine("ERROR . El archivo no contiene un objeto Persona valido");
                return null;
            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("ERROR . La direccion del archivo no puede estar vacia");
                return null;
            }
            catch(System.IO.DirectoryNotFoundException)
            {
                Console.WriteLine("ERROR . El directorio no existe");
                return null;
            }
            catch(System.IO.FileNotFoundException)
            {
                Console.WriteLine("ERROR . El archivo no existe");
                return null;
            }

        }

        /// <summary>
        /// devuelve datos del objeto Persona
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format($"{this.nombre} {this.apellido}");
        }
    }
}
