using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Ejercicio64
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Caja.DelegadoClienteAtendido delegado = (caja, cliente) =>
            {
                Console.WriteLine($"{DateTime.Now:HH:MM:ss} - Hilo {Task.CurrentId} - {caja.NombreCaja} - Atendiendo a {cliente}. Quedan {caja.CantidadClientesALaEspera} clientes en esta caja.");
            };


            Caja caja1 = new Caja("Caja 1", delegado);
            Caja caja2 = new Caja("Caja 2", delegado);

            List<Caja> cajas = new List<Caja>();
            cajas.Add(caja1);
            cajas.Add(caja2);

            Negocio negocio = new Negocio(cajas);

            Console.WriteLine("Asignando cajas...");

            List<Task> hilos = negocio.ComenzarAtencion();
            Task.WaitAll(hilos.ToArray());
        }
    }
}
