using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class TrooperAsalto:Trooper
    {
        //CONSTRUCTORES

        /// <summary>
        /// Constructor de Trooper de asalto
        /// </summary>
        /// <param name="armamento">Armamento del tipo Blaster</param>
        public TrooperAsalto(Blaster armamento):base(armamento,true)
        {

        }

        //PROPIEDADES

        public override string Tipo
        {
            get
            {
                return "Comando para misiones de infiltracion";
            }

        }
        //METODOS

        //SOBRECARGAS

    }
}
