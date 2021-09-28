using System;
using System.Text;

namespace BibliotecaDeClases
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;

        public Publicacion(string nombre)
        {
            this.nombre = nombre;
        }

        public Publicacion(string nombre, int stock):this(nombre)
        {
            this.stock = stock;
        }

        public Publicacion(float importe, string nombre, int stock):this(nombre,stock)
        {
            this.importe = importe;
        }

        public float Importe
        { 
            get 
            { 
                return this.importe; 
            } 
        }
        public int Stock
        {
            get
            {
                return this.stock;
            }

            set
            {
                if (value > 0)
                {
                    this.stock = value;
                }         
            }
        }

        public virtual bool HayStock
        {
            get
            {
                if(this.Stock>0 && this.Importe > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public abstract bool EsColor
        {
            get;
        }

        public string ObtenerInformacion()
        {
            StringBuilder strB = new StringBuilder();
            string valColor;
            if (this.EsColor)
            {
                valColor = "SI";
            }
            else
            {
                valColor = "NO";
            }
            strB.AppendFormat($"NOMBRE : {this.nombre}\n");
            strB.AppendLine($"STOCK : {this.Stock}");
            strB.AppendLine($"ES COLOR = {valColor}");
            strB.AppendLine($"VALOR : ${this.importe}");

            return strB.ToString();

        }

        public override string ToString()
        {
            return this.nombre;
        }

    
    
    }
}
