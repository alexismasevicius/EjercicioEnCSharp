using System;
using System.Text;
using IO;

namespace Ejercicio42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase oc = new OtraClase();
                oc.metodoInstancia();
            }
            catch (MiExcepcion e)
            {
                StringBuilder strB = new StringBuilder();
                strB.AppendLine(e.Message);
                strB.AppendLine(e.InnerException.Message);
                strB.AppendLine(e.InnerException.InnerException.Message);

                //Console.WriteLine($"{e.Message}");
                //Console.WriteLine($"{e.InnerException.Message}");
                //Console.WriteLine($"{e.InnerException.InnerException.Message}");
                //C:\Users\alexi\Desktop\EjercicioEnCSharp\Clases13y14\Ejercicio54
                //C:\Users\alexi\Desktop\EjercicioEnCSharp\Clases13y14\Ejercicio54\prueba.txt


                ArchivoTexto.Guardar(@"C:\Users\alexi\Desktop\EjercicioEnCSharp\Clases13y14\Ejercicio54\errores.txt", strB.ToString());
            }
            string srta = ArchivoTexto.Leer(@"C:\Users\alexi\Desktop\EjercicioEnCSharp\Clases13y14\Ejercicio54\errores.txt");
            Console.WriteLine(srta);

        }
    }
}
