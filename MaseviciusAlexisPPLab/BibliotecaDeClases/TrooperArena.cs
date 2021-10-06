using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BibliotecaDeClases
{
    public class TrooperArena : Trooper
    {

        //CONSTRUCTORES
        /// <summary>
        /// Constructor de Trooper
        /// </summary>
        /// <param name="armamento"></param>
        public TrooperArena(Blaster armamento) : base(armamento)
        {

        }

        //PROPIEDADES
        /// <summary>
        /// lectura tipo
        /// </summary>
        public override string Tipo
        {
            get
            {
                return "Soldado de asalto de terrenos deserticos";
            }

        }


    }
}
