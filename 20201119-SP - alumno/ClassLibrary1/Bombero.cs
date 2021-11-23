using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text.Json;
using System.Threading;

namespace ClassLibrary1
{
    public delegate void FinSalida(int bomberoIndex);

    public class Bombero: Iarchivos<string>, Iarchivos<Bombero>
    {
        private string nombre;
        private List<Salidas> salidas;
        public event FinSalida MarcarFin;

        public Bombero(string nombre)
        {
            this.nombre = nombre;
            this.salidas = new List<Salidas>();
        }

        public void AtenderSalida(object bomberoIndex)
        {
 
            Salidas salida = new Salidas();
            this.salidas.Add(salida);

            Thread.Sleep(3000);

            salida.FinalizarSalida();
            ((Iarchivos<string>)this).Guardar($"bombero: {this.nombre}, Salida: {salida.FechaInicio.ToString()}, Llegada {salida.FechaFin.ToString()}");
            this.MarcarFin.Invoke((int)bomberoIndex);

        }

        public void  Guardar(Bombero info)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter("bombero.txt"))
                {
                    string json = JsonSerializer.Serialize(info);
                    streamWriter.Write(json);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al guardar la base de datos", e);
            }


        }
        public Bombero Leer()
        {
            try
            {
                StreamReader sw = new StreamReader("bombero.txt");
                string strAux = sw.ReadToEnd();
                sw.Close();
                Bombero bomb = JsonSerializer.Deserialize<Bombero>(strAux);
                return bomb;
            }
            catch (Exception e)
            {

                throw new Exception("Error en la lectura del archivo", e);
            }
        }

        void Iarchivos<string>.Guardar(string info)
        {
            string connString = @"Data Source=.; Initial Catalog=20201119-sp; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = conn;

            command.CommandText =
                $"INSERT INTO log (entrada, alumno) VALUES ('{info}','{"Alexis"}')";

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

        string Iarchivos<string>.Leer()
        {
            string connString = @"Data Source=.; Initial Catalog=20201119-sp; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = conn;
            string descripcion = null;

            try
            {
                command.CommandText = "SELECT * FROM log";

                conn.Open();
                SqlDataReader sqlReader = command.ExecuteReader();

                while (sqlReader.Read())
                {
                    descripcion = sqlReader["entrada"].ToString();
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de obtener los productos de la base de datos", ex);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
                
            }

            
             return descripcion;

        }



    }
}
