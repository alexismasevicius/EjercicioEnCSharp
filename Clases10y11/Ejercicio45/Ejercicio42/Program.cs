using System;

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
                Console.WriteLine($"{e.Message}");
                Console.WriteLine($"{e.InnerException.Message}");
                Console.WriteLine($"{e.InnerException.InnerException.Message}");
            }
        

        }
    }
}
