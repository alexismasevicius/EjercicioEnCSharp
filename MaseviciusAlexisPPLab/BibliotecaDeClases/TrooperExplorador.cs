using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class TrooperExplorador : Trooper
    {
        private string vehiculo;

        //CONSTRUCTORES

        /// <summary>
        /// Constructor de Explorador
        /// </summary>
        /// <param name="vehiculo">vehiculo del trooper Explorador</param>
        public TrooperExplorador(string vehiculo):this(vehiculo,Blaster.EC17)
        {
        }

        public TrooperExplorador(string vehiculo, Blaster blaster) : base(blaster)
        {
            this.Vehiculo = vehiculo;
        }

        //PROPIEDADES

        public override string Tipo
        {
            get
            {
                return "Soldado de Exploracion";
            }
        }


        /// <summary>
        /// Lectura y escritura de Vehiculo
        /// </summary>
        public string Vehiculo
        {
            get
            {
                if(vehiculo!="")
                {
                    return this.vehiculo;
                }
                else
                {
                    this.vehiculo = "indefinido";
                    return this.vehiculo;
                }
                
            }

            set
            {
                this.vehiculo = value;
            }
        }

        //METODOS

        /// <summary>
        /// Muestra info del trooperexplorador
        /// </summary>
        /// <returns>un string con la info</returns>
        public override string InfoTrooper()
        {

            StringBuilder strB = new StringBuilder();

            strB.AppendLine($"{base.InfoTrooper()}");
            strB.AppendLine($"Vehiculo:{this.Vehiculo}");


            return strB.ToString();

        }

        //SOBRECARGAS

    }
}
