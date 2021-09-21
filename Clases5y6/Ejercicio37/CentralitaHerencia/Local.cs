using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        //CONSTRUCTOR
        private Local(Llamada llamada, float costo) :
            base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(float duracion, string nroDestino, string nroOrigen,
            float costo) :
            this(new Llamada(duracion, nroDestino, nroOrigen), costo)
        {
        }

        //PROPIEDADES
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        //METODOS

        private float CalcularCosto()
        {
            float retorno;
            retorno=this.duracion * this.costo;
            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder strB = new StringBuilder();
            strB.AppendLine($"{base.Mostrar()}");
            strB.AppendLine($"Costo de la llamada: {this.CostoLlamada}");

            return strB.ToString();
            
        }

    }
}
