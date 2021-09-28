using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Vendedor
    {
        private string nombre;
        private List<Publicacion> ventas;

        private Vendedor()
        {
            this.ventas = new List<Publicacion>();
        }
        public Vendedor(string nombre):this()
        {
            this.nombre = nombre;
        }

        public static string ObtenerInformeDeVentas(Vendedor vendedor)
        {
            float acumulador=0;
            StringBuilder strB = new StringBuilder();
            strB.AppendLine($"{vendedor.nombre}");

            if(vendedor.ventas is not null)
            {
                foreach (Publicacion item in vendedor.ventas)
                            {
                                acumulador += item.Importe;
                                strB.AppendLine($"PUBLICACION: {item.ObtenerInformacion()}");
                            }
            }
            else
            {
                strB.AppendLine($"No realizo ventas");
            }
            
            strB.AppendLine($"GANANCIA=0{acumulador}");

            return strB.ToString();
        }

        public static bool operator +(Vendedor vendedor, Publicacion publicacion)
        {
            if (publicacion.HayStock)
            {
                vendedor.ventas.Add(publicacion);
                publicacion.Stock--;
                return true;
            }
            return false;
        }

    }
}
