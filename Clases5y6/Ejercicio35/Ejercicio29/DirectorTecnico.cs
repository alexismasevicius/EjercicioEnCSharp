using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio32
{
    public class DirectorTecnico:Persona
    {
        private DateTime fechaDeNacimiento;

        //CONSTRUCTORES
        private DirectorTecnico(string nombre) : base(nombre)
        {
        }
        public DirectorTecnico(string nombre,DateTime fechaDeNacimiento) : this(nombre)        
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }
        //METODOS
        public static bool operator ==(DirectorTecnico j1, DirectorTecnico j2)
        {
            if( j1.fechaDeNacimiento == j2.fechaDeNacimiento &&
                j1.Nombre == j2.Nombre)
            {
                return true;
            }
            else { return false }
        }

        public static bool operator !=(DirectorTecnico j1, DirectorTecnico j2)
        {
            return !(j1 == j2);
        }

    }
}
