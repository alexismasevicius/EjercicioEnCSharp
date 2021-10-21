using BiblioDeClases;
using System;

namespace Ejercicio48
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> c = new Contabilidad<Factura, Recibo>();

            Recibo recibo = new Recibo();
            Recibo reciboDos = new Recibo(211);
            Factura factura = new Factura(2124545);

            c += factura;
            c += recibo;
            c += reciboDos;

            Console.WriteLine(c.Mostrar());

        }
    }
}
