using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CentralitaHerencia
{
    public class Centralita
    {
        List<Llamada> listaDeLlamada;
        string razonSocial;

        //CONSTRUCTORES

        public Centralita()
        {
            this.listaDeLlamada = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        //PROPIEDADES
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamada;
            }
        }

        //METODOS

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float acumuladorLocal = 0;
            float acumuladorProv = 0;

            foreach (Llamada llamada in this.Llamadas)
            {
                if (llamada is Local)
                {
                    acumuladorLocal = acumuladorLocal + ((Local)llamada).CostoLlamada;
                }
                else
                {
                    if (llamada is Provincial)
                    {
                        acumuladorProv = acumuladorProv + ((Provincial)llamada).CostoLlamada;

                    }
                }
            }

            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    {
                        return acumuladorLocal;
                    }
                case Llamada.TipoLlamada.Provincial:
                    {
                        return acumuladorProv;
                    }
                default:
                    {
                        return acumuladorLocal + acumuladorProv;
                    }

            }


        }

        private string Mostrar()
        {
            StringBuilder strB = new StringBuilder();
            strB.AppendLine($"La razon social es : {this.razonSocial}");
            strB.AppendLine($"La ganancia total es es : {this.GananciasPorTotal}");
            strB.AppendLine($"La ganancia por local es : {this.GananciasPorLocal}");
            strB.AppendLine($"La ganancia por provincial es : {this.GananciasPorProvincial}");
            strB.AppendLine($"*****************************************************\n\n  ------Lista de llamadas---- : ");
            foreach (Llamada llamada in this.Llamadas)
            {
                strB.AppendLine(llamada.ToString());
            }


            return strB.ToString();
        }

        /// <summary>
        /// Recibe una llamada y la agrega a la lista
        /// </summary>
        /// <param name="nuevaLlamada">llamada a agregar</param>
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.Llamadas.Add(nuevaLlamada);
        }

        //SOBRECARGAS


        public override string ToString()
        {
            return this.Mostrar();
        }
        /*l. El operador == retornará true si la Centralita contiene la Llamada en su lista genérica.
         * Utilizar sobrecarga == de Llamada.*/

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            foreach (Llamada item in c.Llamadas)
            {
                if(item==llamada)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c==llamada);
        }

        /*m. El operador + invocará al método AgregarLlamada sólo si la llamada no está registrada en la Centralita 
         * (utilizar la sobrecarga del operador == de Centralita).*/

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada) 
        {
            if (c != nuevaLlamada)
            { 
                c.AgregarLlamada(nuevaLlamada); 
            }
            else
            {
                throw new CentralitaException("Llamada ya existente", "En clase Centralita", "Metodo +");
            }
            return c;
        }


        /*
        public void OrdenarLlamadas()
        {
            this.listaDeLlamada.Sort(Llamada.OrdenarPorDuracion());
        }*/


    }
}
