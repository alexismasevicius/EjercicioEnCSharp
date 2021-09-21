using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    public class Peso
    {
        private double cantidad;
        private static double cotizRespectoDolar;


        //constructores
        static Peso()
        {
            cotizRespectoDolar = 160;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
            
        }

        public Peso(double cantidad, double cotizRespectoDolar):this(cantidad)
        {
            Peso.cotizRespectoDolar = cotizRespectoDolar;
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
                return Peso.cotizRespectoDolar;
            }
        }

        //sobrecarga implicita Peso
        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }

        //sobrecarga explicita

        public static explicit operator Dolar(Peso e)
        {

            return new Dolar(e.cantidad / Peso.cotizRespectoDolar);

        }

        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p);
        }


        ///sobrecarga de operadores de clase
        ///
        public static bool operator ==(Peso d, Euro e)
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
        public static bool operator !=(Peso d, Euro e)
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

        public static bool operator ==(Peso p , Dolar d)
        {
            return ((Peso)d == p);
        }

        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }


        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso((p.GetCantidad - ((Peso)e).GetCantidad));
        }

        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso((p.GetCantidad + ((Peso)e).GetCantidad));
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso((p.GetCantidad - ((Peso)d).GetCantidad));
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso((p.GetCantidad + ((Peso)d).GetCantidad));
        }


    }
}
