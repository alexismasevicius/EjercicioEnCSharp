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
        public Centralita(string nombreEmpresa):this()
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
            float acumuladorLocal=0;
            float acumuladorProv=0;

            foreach(Llamada llamada in this.Llamadas)
            {
                if(llamada is Local)
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

        public string Mostrar()
        {
            StringBuilder strB = new StringBuilder();
            strB.AppendLine($"La razon social es : {this.razonSocial}");
            strB.AppendLine($"La ganancia total es es : {this.GananciasPorTotal}");
            strB.AppendLine($"La ganancia por local es : {this.GananciasPorLocal}");
            strB.AppendLine($"La ganancia por provincial es : {this.GananciasPorProvincial}");
            strB.AppendLine($"------------------------------------------\n\n  ------Lista de llamadas---- : ");
            foreach (Llamada llamada in this.Llamadas)
            {
                strB.AppendLine(llamada.Mostrar());
            }


            return strB.ToString();
        }
        /*
        public void OrdenarLlamadas()
        {
            this.listaDeLlamada.Sort(Llamada.OrdenarPorDuracion());
        }*/


    }
}
