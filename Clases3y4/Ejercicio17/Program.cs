using System;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            string pintura;
            Boligrafo bolAzul = new Boligrafo(80,ConsoleColor.Blue);
            Boligrafo bolRojo = new Boligrafo(50, ConsoleColor.Red);

            bolAzul.Pintar(500, out pintura);
            Console.WriteLine($"{pintura}");

            bolRojo.Pintar(50, out pintura);

            Console.WriteLine($"{pintura}");
            Console.WriteLine($"{bolAzul.GetTinta()}");

        }
    }
}
