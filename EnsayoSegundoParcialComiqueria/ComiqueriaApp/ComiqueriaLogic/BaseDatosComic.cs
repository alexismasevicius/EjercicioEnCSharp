using ComiqueriaLogic.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class BaseDatosComic
    {
        public delegate void MiDelegado(AccionesDB accion);
        public static event MiDelegado EventoDesconocido;

        SqlConnection conn;
        SqlCommand command;

        public BaseDatosComic()
        {
            string connString = @"Data Source=.; Initial Catalog=Comiqueria; Integrated Security=True";
            conn = new SqlConnection(connString);
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = conn;
        }

        public bool Agregar(string descripcion, double precio, int stock)
        {
            bool result = false;
            command.CommandText =
                $"INSERT INTO Productos (Descripcion,Precio,Stock) VALUES ('{descripcion}','{precio}','{stock}')";

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {
                throw new Exception("Error de conexión a la base de datos");
            }
            finally
            {
                conn.Close();
                EventoDesconocido.Invoke(AccionesDB.Insert);
            }

            return result;
        }

        public void Borrar(decimal id)
        {
            command.CommandText = "Delete From Productos Where Codigo = @ID";
            command.Parameters.Add(new SqlParameter("id", id));

            try
            {
                conn.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
                EventoDesconocido.Invoke(AccionesDB.Delete);
            }


        }

        public List<Producto> SelectAll()
        {
            List<Producto> productosList = new List<Producto>();

            try
            {
                command.CommandText = "SELECT * FROM dbo.Productos";

                conn.Open();
                SqlDataReader sqlReader = command.ExecuteReader();

                while (sqlReader.Read())
                {
                    int codigo = Convert.ToInt32(sqlReader["codigo"]);
                    string descripcion = sqlReader["descripcion"].ToString();
                    double precio = Convert.ToDouble(sqlReader["precio"]);
                    int stock = Convert.ToInt32(sqlReader["stock"]);
                    Producto producto = new Producto(codigo, descripcion, stock, precio);
                    productosList.Add(producto);
                }
            }
            catch (Exception ex)
            {
                throw new ComiqueriaException("Error al tratar de obtener los productos de la base de datos", ex);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
                
            }

            return productosList;
        }

    }
}
