using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CentralitaHerencia;

namespace CentralitaDAO
{
    public class LocalDAO
    {
        private static SqlConnection conn;
        private static SqlCommand command;

        public LocalDAO()
        {
            string connString = @"Data Source=.; Initial Catalog=Centralita; Integrated Security=True";
            LocalDAO.conn = new SqlConnection(connString);
            LocalDAO.command = new SqlCommand();
            LocalDAO.command.CommandType = System.Data.CommandType.Text;
            LocalDAO.command.Connection = LocalDAO.conn;
        }

        public bool Guardar(Local l)
        {
            bool retorno = false;

            try
            {
                LocalDAO.command.CommandText = "INSERT INTO Llamadas (duracion,origen,destino,costo,tipo) VALUES (@DURACION, @ORIGEN, @DESTINO, @COSTO, @TIPO)";
                LocalDAO.command.Parameters.Add(new SqlParameter("DURACION", l.Duracion));
                LocalDAO.command.Parameters.Add(new SqlParameter("ORIGEN ", l.NroOrigen));
                LocalDAO.command.Parameters.Add(new SqlParameter("DESTINO", l.NroDestino));
                LocalDAO.command.Parameters.Add(new SqlParameter("COSTO", l.CostoLlamada));
                LocalDAO.command.Parameters.Add(new SqlParameter("TIPO", false));
            }
            catch(Exception e)
            {
                throw new Exception("No se pudo guardar en la Base de Datos",e);
            }
            finally
            {
                LocalDAO.conn.Close();
            }

            return retorno;
        }

        public Centralita Leer(Centralita miCentralita)
        {
            command.CommandText =
                $"SELECT * FROM Personas WHERE tipo = 0";

            conn.Open();
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                Local miLlamada = new Local(reader["origen"].ToString(),
                                            int.Parse(reader["duracion"].ToString()),
                                            reader["destino"].ToString(),
                                            float.Parse(reader["costo"].ToString()) );
                miCentralita += miLlamada;

            }
            return miCentralita;
        }
    }
}
