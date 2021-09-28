using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        //CONSTRUCTORES

        protected Producto(string descripcion, int stock, double precio)
        {
            this.codigo = Guid.NewGuid();
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;

        }

        //PROPIEDADES
        public string Descripcion
        {
            get { return this.descripcion; }
        }
        public double Precio
        {
            get
            {
                return this.precio;
            }
        }
        public int Stock
        {
            get { return this.stock; }
            set
            {
                if(this.stock>=0)
                {
                    this.stock = value;
                }
                
            }
        }

        //METODOS

        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }

        public override string ToString()
        {
            StringBuilder strB = new StringBuilder();


            strB.AppendLine($"Descripcion: {this.descripcion}");
            strB.AppendLine($"Codigo: {this.codigo}");
            strB.AppendLine($"Precio: {this.precio}");
            strB.AppendLine($"Stock: {this.stock}");

            return strB.ToString();
        }

    }
}
