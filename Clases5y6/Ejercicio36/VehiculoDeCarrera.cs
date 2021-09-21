using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private short vueltasRestantes;
        private string escuderia;
        private short numero;
        
        //CONSTRUCTORES
        public VehiculoDeCarrera(string escuderia, short numero)
        {
            this.EnCompetencia = false;
            this.CantidadCombustible = 0;
            this.VueltasRestantes = 0;
            this.Escuderia = escuderia;
            this.Numero = numero;
        }


        //PROPIEDADES
        public short CantidadCombustible 
        { 
            get 
            {
                return cantidadCombustible;
            }
            set 
            {
                this.cantidadCombustible = value;
            } 
        }
        public bool EnCompetencia
        {
            get
            {
                return enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }
        public short VueltasRestantes 
        { 
            get
            {
                return vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }
        public string Escuderia 
        { get
            {
                return escuderia;
            }
            set
            {
                this.escuderia = value;
            } 
        }
        public short Numero 
        { get
            {
                return numero;
            }
            set
            {
                this.numero = value;
            }
        }


        //METODOS
        public string MostrarDatos()
        {
            return $"Auto numero: {this.Numero} \n " +
                $"Escuderia {this.Escuderia}, \n" +
                $"Competencia {this.EnCompetencia}\n" +
                $"Combustible: {this.CantidadCombustible}\n" +
                $"Vueltas restantes: {this.VueltasRestantes} \n";
        }
    }
}
