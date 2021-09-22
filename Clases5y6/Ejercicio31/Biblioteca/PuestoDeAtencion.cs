using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PuestoDeAtencion
    {
        private static int numeroActual;
        private Puesto puesto;
        public enum Puesto {Caja1, Caja2}        
        
        
        //CONSTRUCTORES

        static PuestoDeAtencion()
        {
            PuestoDeAtencion.numeroActual = 0;
        }
        public PuestoDeAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        //PROPIEDADES
        public static int NumeroActual 
        { 
            get 
            { 
               return PuestoDeAtencion.numeroActual++; 
            } 
        }

        //METODOS
        public bool Atender(Cliente cli)
        {
            Thread.Sleep(2000);
            return true;
        }

    }
}
