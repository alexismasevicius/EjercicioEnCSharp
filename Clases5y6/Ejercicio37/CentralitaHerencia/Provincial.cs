using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        Franja franjaHoraria;

        public Provincial(Franja miFranja, Llamada llamada):
            base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial( Franja miFranja,string origen,
            float duracion, string destino):
            this(miFranja, new Llamada(duracion, destino, origen))
        {

        }

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3,
        }

        //METODOS

        private float CalcularCosto()
        {
            if(this.franjaHoraria==Franja.Franja_1)
            {
                return base.duracion * (float)0.99;
            }
            else
            {
                if (this.franjaHoraria == Franja.Franja_2)
                {
                    return base.duracion * (float)1.25;
                }
                else
                {
                    return base.duracion * (float)0.66;
                }
            }
        }

        public string Mostrar()
        {
            StringBuilder strB = new StringBuilder();
            strB.AppendLine($"{base.Mostrar()}");

            strB.AppendLine($"Franja Horarios: {this.franjaHoraria}");
            strB.AppendLine($"Costo de la llamada: {this.CostoLlamada}");

            return strB.ToString();

        }


    }
}
