using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class PersonaDAO
    {
        private static SqlConnection conn;
        private static SqlCommand command;

        public PersonaDAO()
        {
            string connString = @"Data Source=.; Initial Catalog=MiPrimerCRUD; Integrated Security=True";
            PersonaDAO.conn = new SqlConnection(connString);
            PersonaDAO.command = new SqlCommand();
            PersonaDAO.command.CommandType = System.Data.CommandType.Text;
            PersonaDAO.command.Connection = PersonaDAO.conn;
        }

        public bool Guardar(Persona miPersona)
        {
            bool result = false;
            PersonaDAO.command.CommandText = 
                $"INSERT INTO Personas (nombre,apellido) VALUES ('{miPersona.Nombre}','{miPersona.Apellido}')";

            try
            {
                PersonaDAO.conn.Open();
                PersonaDAO.command.ExecuteNonQuery();
                result = true;
            }
            catch(Exception)
            {
                throw new Exception("Error de conexión a la base de datos");
            }
            finally
            {
                PersonaDAO.conn.Close(); 
            }

            return result;
        }

        public List<Persona> Leer()
        {
            List<Persona> personas = new List<Persona>();
            PersonaDAO.command.CommandText =
                $"SELECT * FROM Personas";

            try
            {
                PersonaDAO.conn.Open();
                SqlDataReader reader = PersonaDAO.command.ExecuteReader();

                while (reader.Read())
                {
                    Persona p = new Persona(reader["nombre"].ToString(), reader["apellido"].ToString(), int.Parse(reader["id"].ToString()));

                    personas.Add(p);
                }

            }
            catch (Exception)
            {
                throw new Exception("Error de conexión a la base de datos");
            }
            finally
            {
                conn.Close();
            }

            return personas;
        }
        public void LeerPorId()
        {

        }
        public void Modificar(decimal id, string nombre, string apellido)
        {
            PersonaDAO.command.CommandText = $"UPDATE Personas SET nombre = @NOMBRE, apellido = @APELLIDO  WHERE id = @ID";
            PersonaDAO.command.Parameters.Add(new SqlParameter("ID", id));
            PersonaDAO.command.Parameters.Add(new SqlParameter("NOMBRE", nombre));
            PersonaDAO.command.Parameters.Add(new SqlParameter("APELLIDO", apellido));

            try
            {
                PersonaDAO.conn.Open();

                PersonaDAO.command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                PersonaDAO.conn.Close();
            }


        }

        public void Borrar(decimal id)
        {
            PersonaDAO.command.CommandText = "Delete From Personas Where id = @ID";
            PersonaDAO.command.Parameters.Add(new SqlParameter("id", id));

            try
            {
                PersonaDAO.conn.Open();

                PersonaDAO.command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                PersonaDAO.conn.Close();
            }


        }


    }
}
