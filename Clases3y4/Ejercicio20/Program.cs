using System;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            double primerNumero;
            double opcion;

            Console.WriteLine("Ingrese el monto: ");
            while (!double.TryParse(Console.ReadLine(), out primerNumero))
            {
                Console.WriteLine("Error. Ingrese numero vaildo: ");
            }
            Console.WriteLine("Ingrese el tipo de conversión:\n 1- Peso a Dolar \n 2- Peso a Euro \n 3- Euro a Dolar \n 4- Euro a peso \n 5- Dolar a Peso \n 6- Dolar a Euro");
            while (!double.TryParse(Console.ReadLine(), out opcion) || opcion>6 || opcion<1)
            {
                Console.WriteLine("Error. Ingrese una opcion Valida: ");
                Console.WriteLine("Ingrese el tipo de conversión:\n 1- Peso a Dolar \n 2- Peso a Euro \n 3- Euro a Dolar \n 4- Euro a peso \n 5- Dolar a Peso \n 6- Dolar a Euro");

            }

            switch (opcion)
            {
                case 1:

                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
            }



        }
    }
}
