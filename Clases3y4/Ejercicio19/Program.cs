using System;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sum = new Sumador();
            string stConsola;
            long lgConsola;
            int intConsola;

            stConsola = sum.Sumar("pepepee", "lallaa");
            lgConsola = sum.Sumar(10, 20);

            Console.WriteLine($"{stConsola}....{lgConsola}....");

            Console.WriteLine($"{(int)sum}"); 

        }
    }
}
