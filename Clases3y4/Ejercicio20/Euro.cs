using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    public class Euro
    {
        private double cantidad;
        static double cotizRespectoDolar;

        //constructores
        static Euro()
        {
            Euro.cotizRespectoDolar = 1.08;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        //getters

        public double GetCantidad
        {
            get
            {
                return this.cantidad;
            }

        }

        public static double GetCotizacion
        {
            get
            {
                return Euro.cotizRespectoDolar;
            }

        }

        //sobrecarga implicita Euro

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        //sobrecarga explicita
        public static explicit operator Dolar(Euro e)
        {

            return new Dolar(e.cantidad / Euro.cotizRespectoDolar);
        }

        public static explicit operator Peso(Euro e)
        {

            return (Peso)((Dolar)e);

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
            if ((Euro)d == e)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator ==(Euro e, Peso p)
        {
            return ((Peso)e == p);
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }
        public static bool operator ==(Euro d, Euro p)
        {
            return (d == p);
        }
        public static bool operator !=(Euro d, Euro p)
        {
            return !(d == p);
        }

        public static Euro operator -(Dolar d, Euro e)
        {
            return new Euro(((Dolar)d).GetCantidad - e.GetCantidad);
        }

        public static Euro operator +(Dolar d, Euro e)
        {
            return new Euro((e.GetCantidad + ((Euro)d).GetCantidad));
        }

        public static Euro operator -(Euro d, Peso p)
        {
            return new Euro((d.GetCantidad - ((Euro)p).GetCantidad));
        }

        public static Euro operator +(Euro d, Peso p)
        {
            return new Euro((d.GetCantidad + ((Euro)p).GetCantidad));
        }


    }
}
