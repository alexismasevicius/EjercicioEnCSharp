using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    public static class Conversor
    {
        /// <summary>
        /// Convierte un numero decimal en un string binario
        /// </summary>
        /// <param name="dec">El numero decimal a convertir</param>
        /// <returns>Un string de binario</returns>
        public static string convertirDecimalABinario(int dec)
        {
            string bin;
            StringBuilder auxStringBuilder = new StringBuilder();


            do
            {
                if(dec%2==0)
                {
                    auxStringBuilder.Insert(0,"0");
                }
                else
                {
                    auxStringBuilder.Insert(0,"1");
                }
                dec = dec / 2;
            } while (dec > 0);

            bin=auxStringBuilder.ToString();
            
            return bin;
        }

        /// <summary>
        /// Convierte un numero binario en uno decimal
        /// </summary>
        /// <param name="cadena">String de numero binario</param>
        /// <returns>Numero decimal</returns>
        public static int conversorBinarioADecimal(string cadena)
        {
            int acumulador = 0;

            for(int i = 0; i<cadena.Length; i++ )
            {
                if(cadena.Substring(i)=="1")
                {
                    acumulador = acumulador + (20 + i);
                }

            }
            return acumulador;
        }

    }
}
