using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        List<Producto> productos;
        List<Venta> ventas;

        //CONSTRUCTORES
        public Comiqueria() 
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();

        }

        //PROPIEDADS
        public Producto this[Guid codigo]
        {
            get 
            {
                foreach (Producto item in this.productos)
                {
                    if ((Guid)item == codigo)
                    {
                        return item;
                    }
                }
                return null;
            }
        }
        //METODOS

        public Dictionary<Guid,string> ListarProductos()
        {
            Dictionary<Guid, string> dict = new Dictionary<Guid, string>();

            foreach (Producto item in this.productos)
            {
                dict.Add((Guid)item, item.Descripcion);
            }

            return dict;
        }


        public string ListarVentas()
        {
            StringBuilder strB = new StringBuilder();

            foreach (Venta item in this.ventas)
            {
                strB.AppendLine($"{item.ObtenerDescripciobBreve()}");
            }

            return strB.ToString();
        }

        public void Vender(Producto producto)
        {
            Vender(producto, 1);
        }
        public  void Vender(Producto producto, int cantidad)
        {
            this.ventas.Add(new Venta(producto,cantidad));
        }


        //sobrecargass
        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            foreach (Producto item in comiqueria.productos)
            {
                if(String.Equals(item.Descripcion,producto.Descripcion))
                {
                    return true;
                }
            }
            return false;
            
        }
        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }

        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if(comiqueria!=producto)
            {
                comiqueria.productos.Add(producto);
                return comiqueria;
            }
            return comiqueria;

        }



    }
}
