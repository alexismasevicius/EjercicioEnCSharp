using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*2.Ingresar un número y mostrar: el cuadrado y el cubo del mismo. 
             * Sedebe validar que el número sea mayor que cero, caso contrario,mostrar el mensaje: 
             * "ERROR. ¡Reingresar número!".Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.*/


            
            double resultadoCuadrado;
            double resultadoCubo;



            Console.Write("Introduce el número: ");
            if(int.TryParse(Console.ReadLine(), out int numero) && numero>0)
            {
               

                resultadoCuadrado = Math.Pow(numero, 2);

                Console.WriteLine("El cuadrado del numero es: {0}", resultadoCuadrado);

                resultadoCubo = Math.Pow(numero, 3);

                Console.WriteLine("El cubo del numero es: {0}", resultadoCubo);

            }
            else
            {
                Console.WriteLine("ERROR.");
            }

        }
    }
}
