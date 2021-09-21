using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public string MostarDatosComp()
        {
            StringBuilder strB = new StringBuilder();
            strB.AppendLine($"Cantidad de Competidores maximos: {this.cantidadCompetidores}");
            strB.AppendLine($"Cantidad de Competidores actuales: {this.competidores.Count}");
            strB.AppendLine($"Cantidad de Vueltas : {this.cantidadVueltas}");
            strB.AppendLine("-------------------------------- \n");
            strB.AppendLine("-------------------------------- \n");
            foreach (AutoF1 item in this.competidores)
            {
                strB.AppendLine($"{item.MostrarDatos()}");
            }

            return strB.ToString();
        
                 
        }

       /* public bool operator -(Competencia c, AutoF1 a)
        {

        }*/
        public static bool operator +(Competencia c, AutoF1 a)
        {

            if (c.cantidadCompetidores <= c.competidores.Count || c==a)
            {
                Console.WriteLine("No se pudo agregar;");
                return false;
            }


            Random rnd = new Random();


            c.competidores.Add(a);
            a.EnCompetencia = true;
            a.VueltasRestantes = c.cantidadVueltas;

            a.CantidadCombustible = (short)(rnd.Next(15, 100));

            return true; 

        }
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 item in c.competidores)
            {
                if (item == a)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }


    }
}