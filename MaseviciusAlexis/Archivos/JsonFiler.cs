using System;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Archivos
{
    public class JsonFiler<T> : IMetodosArchivos<T>
    {
        public string GenerarRutaCompleta
        {
            get
            {
                StringBuilder str = new StringBuilder();
                str.Append(Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString());
                str.Append(@"\");
                return str.ToString();
            }
        }

        public bool ExisteArchivo(string nombreArchivo)
        {
            if (File.Exists(String.Format($@"{this.GenerarRutaCompleta}{nombreArchivo}")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Guarda en un archivo formato json
        /// </summary>
        /// <param name="nombreArchivo">nombre del archivo</param>
        /// <param name="objeto">objeto a serializar</param>
        public void Guardar(string nombreArchivo, T objeto)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter($"{this.GenerarRutaCompleta}{nombreArchivo}"))
                {
                    string json = JsonSerializer.Serialize(objeto);
                    streamWriter.Write(json);
                }
            }
            catch (Exception e)
            {
                throw new ErrorArchivosException("Error al guardar la base de datos", e);
            }

        }

        /// <summary>
        /// Lee un archivo formato json
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <param name="objeto"></param>
        public void Leer(string nombreArchivo, out T objeto)
        {
            try
            {
                StreamReader sw = new StreamReader($"{this.GenerarRutaCompleta}{nombreArchivo}");
                string strAux = sw.ReadToEnd();
                sw.Close();
                objeto = JsonSerializer.Deserialize<T>(strAux);
            }
            catch (Exception e)
            {
                throw new ErrorArchivosException("Error al guardar la base de datos", e);
            }


        }
    }
}
