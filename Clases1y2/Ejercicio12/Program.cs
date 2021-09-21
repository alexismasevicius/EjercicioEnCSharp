using System;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {

            /*12. Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
            un mensaje "¿Continuar? (S/N)".
            En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de
            opciones.
            El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
            cualquier otro valor.*/
            int numero;
            int acumulador = 0;
            char continuar;

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                while(!int.TryParse(Console.ReadLine(),out numero))
                {
                    Console.WriteLine("Error. Ingrese un numero: ");
                }
                acumulador += numero;
                Console.WriteLine("Ingrese /s/ si desea continuar sumando...");
                char.TryParse(Console.ReadLine(), out continuar);
            
            } while (ValidarRespuesta.ValidaS_N(continuar));

            Console.WriteLine("La suma total es: {0}", acumulador);

        }
    }
}
