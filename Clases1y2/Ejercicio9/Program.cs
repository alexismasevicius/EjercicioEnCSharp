using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * 
            * 9) Escribir un programa que imprima por pantalla una pirámide comola siguiente:
            * *
            * **
            * ***
            * ****
            * *****
            * ******
            * El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. 
            * Para el ejemplo anterior la altura ingresada fue de 5.Nota: Utilizar estructuras repetitivas y selectivas
            */

            bool todoOk;
            int numero;
            //int contador = 0;
            char[] myArray = new char[50];




            Console.Write("Introduce el número: ");

            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Error . Introduce el número: ");
            }

            for (int i = 0; i < numero; i++)
            {
                myArray[i] = '*';

                for (int j = 0; j < myArray.Length; j++)
                {
                    Console.Write(myArray[j]);
                }
                Console.Write("\n");
            }
        }
    }
}
