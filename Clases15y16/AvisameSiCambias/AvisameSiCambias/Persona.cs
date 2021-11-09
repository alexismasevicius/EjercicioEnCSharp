using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvisameSiCambias
{

    public delegate void DelegadoString(string msj);
    public class Persona
    {
        string apellido;
        string nombre;
        public event DelegadoString EventoString;

        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Persona()
        {
        }

        public string Mostrar()
        {
            return string.Format($"{this.nombre}{this.apellido}");
        }

    }
}
