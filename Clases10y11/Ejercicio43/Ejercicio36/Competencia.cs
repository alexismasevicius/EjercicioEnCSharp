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
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        //CONSTRUCTORES
        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.CantidadCompetidores = cantidadCompetidores;
            this.tipo = tipo;
        }
        //ENUMERADO
        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }

        //PROPIEDADES

        

        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }
        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        public short CantidadCompetidores
        {
            get { return cantidadCompetidores; }
            set
            {
                cantidadCompetidores = value;
            }
        }

        public VehiculoDeCarrera this[int i]
        {
            get 
            {
                if(!Object.ReferenceEquals(this.competidores,null) && i >= 0 && i<=this.competidores.Count)
                {
                    return this.competidores[i];
                }
                return null;
            }
         
        }

        public string MostarDatosComp()
        {
            StringBuilder strB = new StringBuilder();
            strB.AppendLine($"Cantidad de Competidores maximos: {this.CantidadCompetidores}");
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

        public static bool operator -(Competencia c, AutoF1 a)
        {
            if (c.competidores.Count == 0 || c != a)
            {
                Console.WriteLine("No se pudo eliminar;");
                return false;
            }
            c.competidores.Remove(a);
            a.EnCompetencia = false;

            return true;

        }
        public static bool operator +(Competencia c, AutoF1 a)
        {

            if (c.CantidadCompetidores <= c.competidores.Count ||
                c == a  )
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
            if(c.Tipo == TipoCompetencia.F1)
            {

                foreach (AutoF1 item in c.competidores)
                {
                    if (item == a)
                    {
                        return true;
                    }
                }
            }

            return false;

            

        }

        public static bool operator ==(Competencia c, MotoCross a)
        {
            if (c.Tipo == TipoCompetencia.MotoCross)
            {
                foreach (MotoCross item in c.competidores)
                {
                    if (item == a)
                    {
                        return true;
                    }
                }
            }


            return false;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator !=(Competencia c, MotoCross a)
        {
            return !(c == a);
        }




    }
}