using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Biografia:Publicacion
    {
        private bool esColor;

        public Biografia(string nombre):base(nombre)
        {
           
        }
        public Biografia(string nombre, int stock):this(nombre)
        {
            this.stock = stock;
        }

        public Biografia(string nombre, int stock,float valor):this(nombre,stock)
        {
            this.importe = valor;
        }

        public override bool EsColor
        {
            get
            {
                return false;
            }
        }

        public override bool HayStock
        {
            get
            {
                if (this.stock > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }


        public static explicit operator Biografia(string nombre)
        {
            return new Biografia(nombre);
        }


    }
}
