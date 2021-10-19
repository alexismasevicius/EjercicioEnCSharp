using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class OtraClase
    {

        public void metodoInstancia()
        {
            try
            {
                new MiClase(true);
            }
            catch(UnaExcepcion e)
            {
                throw new MiExcepcion("No se puede dividir por 0. Mi excepcion", e);
            }
            
        }
    }
}
