using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*1.Ingresar 5 números por consola, guardándolos en una variable escalar.
             * Luego calcular y mostrar: el valor máximo, el valormínimo y el promedio*/
            
            
            int numero;
            int mayorNumero = int.MinValue;
            int menorNumero = int.MaxValue;
            int acumulador = 0;
            int promedio;
            int[] myArray = new int[5];

            for(int i = 0; i<5; i++)
            {
                Console.Write("Introduce el número: ");
                int.TryParse(Console.ReadLine(), out numero);
                
                myArray[i] = numero;
                acumulador += numero;
                if(myArray[i]>mayorNumero)
                {
                    mayorNumero = myArray[i];
                }
                if(myArray[i]<menorNumero)
                {
                    menorNumero = myArray[i];
                }
            }

            promedio = acumulador/5;
            Console.WriteLine("El promedio de los numeros es : {0}", promedio);

            Console.WriteLine("El mayor numero  es : {0}", mayorNumero);

            Console.WriteLine("El menor numero  es : {0}", menorNumero);

            
        }
    }
}
