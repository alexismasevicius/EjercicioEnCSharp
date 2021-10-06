using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public abstract class Trooper
    {
        private Blaster armamento;
        private bool esClon;


        //CONSTRUCTORES

        /// <summary>
        /// Constructor de Trooper
        /// </summary>
        /// <param name="armamento">armamento del trooper</param>
        protected Trooper(Blaster armamento):this(armamento,false)
        {
        }

        /// <summary>
        /// Constructor de Trooper
        /// </summary>
        /// <param name="armamento">armamento del trooper</param>
        /// <param name="esClon"> es clon o no</param>
        protected Trooper(Blaster armamento, bool esClon)
        {            
            this.esClon = esClon; 
            this.armamento = armamento;
        }




        //PROPIEDADES
        /// <summary>
        /// lectura de armamento
        /// </summary>
        protected Blaster Armamento
        {
            get
            {
                return this.armamento;
            }
        }

        /// <summary>
        /// lectura y escritura de esClon
        /// </summary>
        public bool EsClon
        {
            get { return this.esClon; }
            set
            {
                this.esClon = value;
            }
        }

        /// <summary>
        /// Tipo del trooper
        /// </summary>
        public abstract string Tipo
        {
            get;

        }


        //METODOS

        /// <summary>
        /// Devuelve la informacion del trooper
        /// </summary>
        /// <returns>string de info del trooper</returns>
        public virtual string InfoTrooper()
        {
            string esClon ="Es Clone";

            if(this.esClon==false)
            {
                esClon = "No es Clone";
            }

            StringBuilder strB = new StringBuilder();

            strB.AppendFormat("\n{0} armado con {1}, {2}  \n",
                this.Tipo, this.Armamento,esClon);


            return strB.ToString();

        }


        //SOBRECARGAS

        /// <summary>
        /// Compara si un objeto es del tipo Trooper
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true si es igual, false si no lo es</returns>
        public override bool Equals(object obj)
        {
            if(obj.GetType()==this.GetType())
            {
                return true;
            }
            return false;
        }


    }
}
