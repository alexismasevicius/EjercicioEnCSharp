using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*6.Escribir un programa que determine si un año es bisiesto.
             * Un año es bisiesto si es múltiplo de 4. 
             * Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. 
             * Por ejemplo: el año 2000 es bisiesto pero 1900 no.
             * Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
             * Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%)*/
            
            bool todoOk;
            int numero;


            do
            {
                Console.Write("Introduce el número: ");
                todoOk = int.TryParse(Console.ReadLine(), out numero);
            } while (todoOk == false || numero < 0);

            if((numero%4 == 0 && numero%100 !=0) || (numero % 100 == 0 && numero % 400 == 0))
            {
                Console.WriteLine("El anio {0} es bisiesto", numero);
            }
            else
            {
                Console.WriteLine("El anio {0} NO es bisiesto", numero);
            }
        }
    }
}
