using System;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*15. Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).
             * Para ello se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (pulsando el caracter +, -, * o /).
             * El usuario decidirá cuándo finalizar el programa. 
             * Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
             * a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la operación matemática.
             * El método devolverá el resultado de la operación.
             * b. Validar (privado): Recibirá como parámetro el segundo número. 
             * Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. 
             * Este método devolverá TRUE si el número es distinto de CERO.
            */
            int numeroUno;
            int numeroDos;
            Console.WriteLine("Ingrese el primer numero: ");
            while (!int.TryParse(Console.ReadLine(), out numeroUno))
            {
                Console.WriteLine("Error. Ingrese el primer numero: ");
            }
            Console.WriteLine("Ingrese el segundo numero: ");
            while (!int.TryParse(Console.ReadLine(), out numeroDos))
            {
                Console.WriteLine("Error. Ingrese el segundo numero: ");
            }

        }
    }
}
