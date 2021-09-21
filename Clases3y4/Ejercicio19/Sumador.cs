using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Sumador
    {
        private int cantidadSumas;

       

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        } 
        public Sumador():this(0)
        {
        }

        public long Sumar(long opUno, long opDos)
        {
            long retorno = opUno + opDos;
            this.cantidadSumas++;
            return retorno;
        }

        public string Sumar (string stUno, string stDos)
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat(stUno);
            retorno.AppendFormat(stDos);
            this.cantidadSumas++;

            return retorno.ToString();
        }

        public static  explicit operator int(Sumador s1)
        {
            return s1.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool retorno=false;
            if(s1.cantidadSumas==s2.cantidadSumas)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
