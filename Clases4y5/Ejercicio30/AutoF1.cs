using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private short vueltasRestantes;
        private string escuderia;
        private short numero;


        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.EnCompetencia = false;
            this.CantidadCombustible = 0;
            this.VueltasRestantes = 0;
        }

        public short CantidadCombustible { get => cantidadCombustible; set => cantidadCombustible = value; }
        public bool EnCompetencia { get => enCompetencia; set => enCompetencia = value; }
        public short VueltasRestantes { get => vueltasRestantes; set => vueltasRestantes = value; }

        public string MostrarDatos()
        {
            return $"Auto numero: {this.numero} \n " +
                $"Escuderia {this.escuderia}, \n" +
                $"Competencia {this.EnCompetencia}\n" +
                $"Combustible: {this.CantidadCombustible}\n" +
                $"Vueltas restantes: {this.VueltasRestantes} \n";
        }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if (a1.numero == a2.numero &&
                a1.escuderia == a2.escuderia)
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


    }
}
