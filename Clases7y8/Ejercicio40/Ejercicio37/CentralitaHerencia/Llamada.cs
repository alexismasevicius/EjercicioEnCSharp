using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        public enum TipoLlamada
            {
                Local,
                Provincial,
                Todas,
            }

        //CONSTRUCTORES

        public Llamada(float duracion, string nroDestino,string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
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

        public abstract float CostoLlamada
        {
            get;
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        //METODOS

        protected virtual string Mostrar()
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

        //SOBRECARGA


        public static bool operator ==(Llamada l1, Llamada l2)
        {
            if(l1.Equals(l2) && l1.NroDestino==l2.NroDestino && l1.NroOrigen == l2.NroOrigen)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1.Equals(l2));
        }

    }
}
