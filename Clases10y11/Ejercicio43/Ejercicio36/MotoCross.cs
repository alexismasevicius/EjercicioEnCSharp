using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    public class MotoCross: VehiculoDeCarrera
    {
        private short cilindrada;

        public MotoCross(short numero, string escuderia,short cilindrada):base(escuderia, numero)
        {
            this.cilindrada = cilindrada;
        }

        public short Cilindrada
        {
            get { return cilindrada; }
            set
            {
                this.cilindrada = value;
            }

        }


        //METODOS
        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            if (a1.Numero == a2.Numero &&
                a1.Escuderia == a2.Escuderia &&
                a1.Cilindrada == a2.Cilindrada)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }

        public string MostrarDatos()
        {
            return $"Moto numero: {this.Numero} \n " +
                $"Escuderia {this.Escuderia}, \n" +
                $"Competencia {this.EnCompetencia}\n" +
                $"Combustible: {this.CantidadCombustible}\n" +
                $"Cilindrada: {this.Cilindrada}\n" +
                $"Vueltas restantes: {this.VueltasRestantes} \n";
        }

    }
}
