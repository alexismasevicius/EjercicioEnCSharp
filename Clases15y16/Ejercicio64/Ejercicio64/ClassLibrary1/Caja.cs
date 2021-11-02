using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace ClassLibrary1
{
    public class Caja
    {
        public delegate void DelegadoClienteAtendido(Caja laCaja, string elString);

        static Random rnd;
        private Queue<string> clientesALaEspera;
        private DelegadoClienteAtendido delegadoClienteAtendido;
        private string nombreCaja;

        static Caja()
        {
            Caja.rnd = new Random();
        }
        public Caja(string nombre, DelegadoClienteAtendido miDelegado)
        {
            clientesALaEspera = new Queue<string>();
            this.nombreCaja = nombre;
            this.delegadoClienteAtendido = miDelegado;
        }

        public string NombreCaja { get => nombreCaja; }
        public int CantidadClientesALaEspera
        {
            get
            {
                return this.clientesALaEspera.Count;
            }
        }

        internal void AgregarCliente(string miCliente)
        {
            this.clientesALaEspera.Enqueue(miCliente);
        }
        internal Task IniciarAtencion()
        {
            Task miTask = new Task(AtenderClientes);
            miTask.Start();
            return miTask;
        }

        private void AtenderClientes()
        {
            do
            {
                if (this.clientesALaEspera.Any())
                {
                    string cliente = this.clientesALaEspera.Dequeue();
                    this.delegadoClienteAtendido.Invoke(this, cliente);
                    Thread.Sleep(rnd.Next(1000, 5000));
                }

            } while (true);
        }

    }
}
