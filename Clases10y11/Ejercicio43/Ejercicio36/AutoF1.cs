using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    public class AutoF1:VehiculoDeCarrera
    {
        private short caballosDeFuerza;


        //CONSTRUCTORES

        public AutoF1(short numero, string escuderia, short caballosDeFuerza):base(escuderia, numero)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        //PROPIEDADES
        public short CaballosDeFuerza
        {
            get { return caballosDeFuerza; }
            set
            {
                this.caballosDeFuerza = value;
            }
        }

        //METODOS
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if (a1.Numero == a2.Numero &&
                a1.Escuderia == a2.Escuderia &&
                a1.CaballosDeFuerza == a2.CaballosDeFuerza)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        public string MostrarDatos()
        {
            return $"Auto numero: {this.Numero} \n " +
                $"Escuderia {this.Escuderia}, \n" +
                $"Competencia {this.EnCompetencia}\n" +
                $"Combustible: {this.CantidadCombustible}\n" +
                $"Caballos de fuerza: {this.CaballosDeFuerza}\n" +
                $"Vueltas restantes: {this.VueltasRestantes} \n";
        }

    }
}
