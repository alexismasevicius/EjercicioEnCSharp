using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class CompetenciaNoDisponibleExcepcion : Exception
    {
        private string nombreDeClase;
        private string nombreDeMetodo;

        public string NombreDeClase
        {
            get
            {
                return this.nombreDeClase;
            }
        }
            
        public string NombreDeMetodo
        {
            get
            {
                return this.nombreDeMetodo;
            }
        }

        public CompetenciaNoDisponibleExcepcion(string mensaje, string clase, string metodo) 
            : this(mensaje, clase, metodo, null)
        {
             
        }
        public CompetenciaNoDisponibleExcepcion(string mensaje, string clase, string metodo, Exception inner)
            :base(mensaje,inner)
        {
            this.nombreDeClase = clase;
            this.nombreDeMetodo = metodo;
        }


        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat($"\nExcepcion en el meotod {0}, de la clase {1}\n", this.NombreDeMetodo,this.NombreDeClase);
            str.AppendLine($"{this.Message}");

            if(this.InnerException is not null)
            {
                str.AppendLine($"{this.InnerException}");
                Exception auxE = this.InnerException;
                while (auxE.InnerException is not null)
                {
                    str.AppendLine($"{auxE.InnerException}");
                    auxE = auxE.InnerException;
                }
            }
            

            return str.ToString();
        }


    }
}
