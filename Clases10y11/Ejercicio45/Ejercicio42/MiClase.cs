using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class MiClase
    {
        public MiClase()
        {
            try
            {
                MetodoEstatico();
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }
        }

        public MiClase(bool lala)
        {
            try
            {
                new MiClase();
            }
            catch (DivideByZeroException e)
            {
                throw new UnaExcepcion("No se puede dividir por 0.UnaExcepcion", e);
            }
        }

        public static void MetodoEstatico()
        {
            try
            {
                int a = 10;
                int b = 0;

                a = a / b;

            }
            catch(DivideByZeroException e)
            {
                throw e;
            }



            
        }

    }
}
