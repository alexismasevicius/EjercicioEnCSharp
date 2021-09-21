using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    public class Dolar
    {
        private double cantidad;

        //constructores
        private Dolar() : this(0)
        {
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        //getter
        public double GetCantidad
        {
            get
            {
                return this.cantidad;
            }
            
        }

        //sobrecarga implicita Dolar

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        //sobrecargas explicitas Euro y Peso

        public static explicit operator Euro(Dolar d)
        {

            return new Euro((d.cantidad* Euro.GetCotizacion)); 
        }
        public static explicit operator Peso(Dolar d)
        {

            return new Peso((d.cantidad * Peso.GetCotizacion));
        }

        //operadores de clase

        public static bool operator ==(Dolar d, Euro e)
        {
            if ((Euro)d == e)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            if((Euro)d == e)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool operator ==(Dolar d, Peso p)
        {
            return ((Peso)d == p);
        }
        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }
        public static bool operator ==(Dolar d, Dolar p)
        {
            return (d == p);
        }
        public static bool operator !=(Dolar d, Dolar p)
        {
            return !(d == p);
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar((d.GetCantidad - ((Dolar)e).GetCantidad));
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar((d.GetCantidad + ((Dolar)e).GetCantidad));
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar((d.GetCantidad - ((Dolar)p).GetCantidad));
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar((d.GetCantidad + ((Dolar)p).GetCantidad));
        }

    }
}
