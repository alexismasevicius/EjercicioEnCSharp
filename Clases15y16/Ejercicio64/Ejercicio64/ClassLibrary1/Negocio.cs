using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NameGenerator.Generators;

namespace ClassLibrary1
{
    public class Negocio
    {
        static RealNameGenerator myNameGenerator;
        private ConcurrentQueue<string> clientes;
        private List<Caja> cajas;

        static Negocio()
        {
            Negocio.myNameGenerator = new RealNameGenerator();
        }

        public Negocio(List<Caja> listaCajas)
        {
            this.cajas = listaCajas;
            this.clientes = new ConcurrentQueue<string>();
        }

        public List<Task> ComenzarAtencion()
        {

            List<Task> miListaDeHilos =  this.AbrirCajas();
            //Todas las cajas corriendo en hilos separados

            Task hiloSimulacionClientes = new Task(SimulacionClientes);
            miListaDeHilos.Add(hiloSimulacionClientes);

            hiloSimulacionClientes.Start();

            Task hiloAsignacionDeCajas = new Task(AsignarCajas);
            miListaDeHilos.Add(hiloAsignacionDeCajas);
            hiloAsignacionDeCajas.Start();

            return miListaDeHilos;

        }

        public List<Task> AbrirCajas()
        {
            List<Task> miListaDeCajas = new List<Task>();
            foreach (Caja item in this.cajas)
            {
                miListaDeCajas.Add(item.IniciarAtencion());
            }
            return miListaDeCajas;
        }

        public void SimulacionClientes()
        {
            do
            {
                this.clientes.Enqueue(myNameGenerator.Generate());
                Thread.Sleep(1000);
            } while (true);
        }

        public void AsignarCajas()
        {
            do
            {
                //Ordeno la lista de cajas segun su cantidad de clientes a la espera
                //empleo para ello un metodo escrito a traves del operador lambda.
                //Extraigo la primer caja de la lista con el metodo First() de la biblioteca LINQ

                Caja cajaConMenosClientes = 
                    cajas.OrderBy(cajita => cajita.CantidadClientesALaEspera).First();

                this.clientes.TryDequeue(out string miCliente);
                if (!string.IsNullOrWhiteSpace(miCliente))
                {
                    cajaConMenosClientes.AgregarCliente(miCliente);
                }


            } while (true);
        }

    }
}
