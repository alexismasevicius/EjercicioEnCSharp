using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CentralitaHerencia;

namespace CentralitaDAO
{
    public class ProvincialDAO
    {

        private static SqlConnection conn;
        private static SqlCommand command;

        public ProvincialDAO()
        {
            string connString = @"Data Source=.; Initial Catalog=Centralita; Integrated Security=True";
            ProvincialDAO.conn = new SqlConnection(connString);
            ProvincialDAO.command = new SqlCommand();
            ProvincialDAO.command.CommandType = System.Data.CommandType.Text;
            ProvincialDAO.command.Connection = ProvincialDAO.conn;

        }

        public bool Guardar(Provincial p)
        {
            bool retorno = false;

            try
            {

                command.CommandText = "INSERT INTO Llamadas (duracion,origen,destino,costo,tipo) VALUES (@DURACION, @ORIGEN, @DESTINO, @COSTO, @TIPO)";
                command.Parameters.Add(new SqlParameter("DURACION", p.Duracion));
                command.Parameters.Add(new SqlParameter("ORIGEN ", p.NroOrigen));
                command.Parameters.Add(new SqlParameter("DESTINO", p.NroDestino));
                command.Parameters.Add(new SqlParameter("COSTO", p.CostoLlamada));
                command.Parameters.Add(new SqlParameter("TIPO", true));
            }
            catch (Exception e)
            {
                throw new Exception("No se pudo guardar en la Base de Datos", e);
            }
            finally
            {
                conn.Close();
            }

            return retorno;
        }

    

        public Centralita Leer(Centralita miCentralita)
        {
            List<Provincial> miLista = new List<Provincial>();
            try
            {    
                command.CommandText =
                    $"SELECT * FROM Personas WHERE tipo = 1";

                conn.Open();
                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {

                        Provincial miLlamada = new Provincial( Provincial.Franja.Franja_1,
                                                               reader["origen"].ToString(),
                                                               int.Parse(reader["duracion"].ToString()),
                                                               reader["destino"].ToString() );
                        miCentralita += miLlamada;

                }

            }
            catch (Exception e)
            {
                throw new Exception("No se pudo leer en la Base de Datos", e);
            }
            finally
            {
                conn.Close();
            }

            return miCentralita;
        }
    }
}
