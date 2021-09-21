using System;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*13. Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos): 
             * string DecimalBinario(int). Convierte un número de entero a binario. 
             * int BinarioDecimal(string). Convierte un número binario a entero.
                NOTA: no utilizar los atajos del lenguaje, hacerlo mediante estructuras repetitivas y de control.*/
            string numeroBin;
            int numero;
            string cadena;
            int resultado;
            //string auxStr;
      
            bool flag=true;

            //MENU
            Console.Write("Introduce:'\n -1 para convertir un decimal en binario \n -2 para convertir un binario en decimal\n");
            while (!int.TryParse(Console.ReadLine(), out numero) || numero<1 || numero>2)
            {
                Console.Write("Error. Introduce un número: ");
            }


            if(numero==1)
            {
                Console.Write("Introduce el número decimal a convertir: ");
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Write("Error. Introduce un número decimal: ");
                }

                numeroBin=Conversor.convertirDecimalABinario(numero);

                Console.WriteLine("El numero binario es {0}", numeroBin);
            }
            else
            {
                do
                {
                    Console.WriteLine("Ingrese el numero binario a convertir");
                    cadena = Console.ReadLine();
                    flag = true;

                    for (int i = 0; i < cadena.Length; i++)
                    {
                        if (cadena.Substring(i,1) == "0" || 
                            cadena.Substring(i,1) == "1")
                        {
                            flag = true;   
                        }
                        else
                        {   
                            Console.WriteLine($"{cadena.Substring(i,1)}");
                            flag = false;
                            Console.WriteLine("Error. No ha ingresado un numero binario");
                            break;
                        }
                    }
                } while (flag == false);

                resultado = Conversor.conversorBinarioADecimal(cadena);

                Console.WriteLine($"El numero en decimal es : {resultado}");




            }



        }
    }
}
