using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Provincial:
g. El método Mostrar será protegido. Reutilizará el código escrito en la clase base 
    y agregará franjaHoraria y CostoLlamada, utilizando un StringBuilder.
h. Equals retornará true sólo si el objeto que recibe es de tipo Provincial.
i. ToString reutilizará el código del método Mostrar.*/
namespace CentralitaHerencia
{
    public class Provincial : Llamada,  IGuardar<Provincial>
    {
        Franja franjaHoraria;

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3,
        }

        //CONSTRUCTORES

        public Provincial( Franja miFranja,string origen,
            float duracion, string destino):
            base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(Franja miFranja, Llamada llamada):
            this(miFranja, llamada.NroOrigen, llamada.Duracion, llamada.NroDestino)
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

        public string RutaDeArchivo
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
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

        protected override string Mostrar()
        {
            StringBuilder strB = new StringBuilder();
            strB.Append($"{base.Mostrar()}");
            strB.AppendLine($"Franja Horarios: {this.franjaHoraria}");
            strB.AppendLine($"Costo de la llamada: {this.CostoLlamada}");

            return strB.ToString();

        }
        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public Provincial Leer()
        {
            throw new NotImplementedException();
        }
    }
}
