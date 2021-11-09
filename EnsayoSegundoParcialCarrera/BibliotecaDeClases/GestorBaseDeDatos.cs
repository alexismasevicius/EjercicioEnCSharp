using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class GestorBaseDeDatos : IGuardar<AutoF1>
    {
        static string cadenaConexion;

        static GestorBaseDeDatos()
        {
            GestorBaseDeDatos.cadenaConexion = @"Data Source=.; Initial Catalog=20210717-RSP; Integrated Security=True";
        }

        public void Guardar(AutoF1 autof1)
        {
            SqlConnection conn = new SqlConnection(GestorBaseDeDatos.cadenaConexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = conn;
            command.CommandText = $"INSERT into resultados (escuderia,posicion,horaLlegada) VALUES ('{autof1.Escuderia}','{autof1.Posicion}','{DateTime.Now.ToString()}')";

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Error de conexión a la base de datos");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
