using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        //CONSTRUCTORES

        public Llamada(float duracion, string nroDestino,string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas,
        }
        //PROPIEDADES
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        //METODOS

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public string Mostrar()
        {
            StringBuilder strB = new StringBuilder();
            strB.AppendLine($"Duracion: {this.Duracion}");
            strB.AppendLine($"Numero de origen: {this.NroOrigen}");
            strB.AppendLine($"Numero de destino: {this.NroDestino}");

            return strB.ToString();
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Duracion > llamada2.Duracion)
            {
                return 1;
            }
            else
            {
                if (llamada1.Duracion == llamada2.Duracion)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
                
            }
        }






    }
}
