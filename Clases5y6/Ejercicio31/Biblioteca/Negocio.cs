using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Biblioteca.PuestoDeAtencion;

namespace Biblioteca
{
    public class Negocio
    {
        private PuestoDeAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;
        //PROPIEDADES

        public Cliente Cliente
        {
            get { return this.clientes.Dequeue(); }
            set
            {
                if (this + value) { }
            }
        }
        //CONTRUCTORES
        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoDeAtencion(Puesto.Caja1);
        }
        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if(n==c)
            {
                return false;
            }
            n.clientes.Enqueue(c);
            return true;

        }
        public static bool operator ~(Negocio n)
        {
            if (n.clientes.Count > 0)
            {
                return n.caja.Atender(n.Cliente);
            }
            return false;
            
        }
        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente item in n.clientes)
            {
                if (c == item)
                {
                    return true;
                }
            }
            return false;

        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public int ClientesPendientes
        {
            get { return this.clientes.Count; }
        }


    }
}
