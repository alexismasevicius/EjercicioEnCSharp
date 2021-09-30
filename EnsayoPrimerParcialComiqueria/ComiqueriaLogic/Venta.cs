using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;


        //CONSTRUCTORES
        static Venta()
        {
            Venta.porcentajeIva = 21;
        }
        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.Vender(cantidad);

        }


        //PROPIEDADES
        internal DateTime Fecha
        {
            get
            {
                return fecha;
            }
        }

        //METODOS

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double retorno = precioUnidad*cantidad;

            double importeIva = (retorno * Venta.porcentajeIva) / 100;
            

            return (retorno-importeIva);
        }

        public string ObtenerDescripciobBreve()
        {
            return $"{this.fecha.ToString()} - {this.producto.Descripcion} - {(this.precioFinal)}";
        }

        private void Vender(int cantidad)
        {

            this.producto.Stock = (this.producto.Stock)-cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(this.producto.Precio,cantidad);

        }
    }
}
