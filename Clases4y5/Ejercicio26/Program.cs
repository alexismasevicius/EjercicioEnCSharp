using System;


/*26. Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) 
 * distintos de cero de forma aleatoria utilizando la clase Random.
a. Mostrar el vector tal como fue ingresado
b. Luego mostrar los positivos ordenados en forma decreciente.
c. Por último, mostrar los negativos ordenados en forma creciente.*/
namespace Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] myArray = new int[20];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i]=rand.Next((-byte.MaxValue), byte.MaxValue);
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($" {myArray[i]} ");
            }
            Console.WriteLine("----------------------");

            Array.Sort(myArray);
            Array.Reverse(myArray);
            for (int i = 0; i < myArray.Length; i++)
            {
                if(myArray[i]>0)
                {
                    Console.Write($" {myArray[i]} ");
                }
                
            }
            Array.Sort(myArray);
            Console.WriteLine("----------------------");
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < 0)
                {
                    Console.Write($" {myArray[i]} ");
                }

            }

        }

       
    }
}
