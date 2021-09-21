using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*11.Realizar una clase llamada Validación que posea un método estático llamado Validar, que posea la
            siguiente firma: bool Validar(int valor, int min, int max):
            a.valor: dato a validar
            b.min y max: rango en el cual deberá estar la variable valor.
            Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
            anteriormente que estén dentro del rango - 100 y 100.
            Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
            Nota: Utilizar variables escalares, NO utilizar vectores.*/


            int contador = 0;
            int valorMin = int.MaxValue;
            int valorMax = int.MinValue;
            int numero;

            do
            {
                Console.Write("Introduce el número: ");
                while (!int.TryParse(Console.ReadLine(), out numero) || !Validacion.Validar(numero, -100, 100))
                {
                    Console.Write("Error. Introduce el número: ");
                }
                contador++;
                if (valorMin > numero)
                {
                    valorMin = numero;
                }
                if (valorMax < numero)
                {
                    valorMax = numero;
                }

                

            } while (contador < 5);
            Console.WriteLine("El numero mayor es: {0}", valorMax);
               Console.WriteLine("El numero menor es: {0}", valorMin);
        }
    }
}
