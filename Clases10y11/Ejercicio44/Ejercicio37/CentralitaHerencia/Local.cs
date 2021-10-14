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
        public Local(string origen, float duracion, string destino, float costo):base(duracion,destino,origen)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo):this(llamada.NroOrigen, llamada.Duracion,llamada.NroDestino,costo)
        {
        }


        //PROPIEDADES
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        //METODOS

        private float CalcularCosto()
        {
            return (float)(this.Duracion * this.costo);
        }
        protected override string Mostrar()
        {
            StringBuilder strB = new StringBuilder();
            strB.Append($"{base.Mostrar()}");
            strB.AppendLine($"Costo de la llamada: {this.CostoLlamada}");

            return strB.ToString();
        }
        public override bool Equals(object obj)
        {
            return obj is Local;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }


    }
}
