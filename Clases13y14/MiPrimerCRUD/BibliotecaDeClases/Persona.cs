using System;
using System.Data.SqlClient;

namespace BibliotecaDeClases
{
    public class Persona
    {
        string nombre;
        string apellido;
        int id;


        public Persona(string nombre, string apellido)
        {
            

            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public Persona(string nombre, string apellido, int id):this(nombre,apellido)
        {
            this.Id = id;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Id { get => id; set => id = value; }
    }
}
