
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using ComiqueriaLogic.Entidades;

namespace ComiqueriaLogic
{
    public static class Serializador<T> where T: class, new()
    {

        public static void Guardar(T elemento, string path)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(path, true))
                {
                    string json = JsonSerializer.Serialize(elemento);
                    streamWriter.Write(json);
                }
            }
            catch (DirectoryNotFoundException e)
            {
                throw new ComiqueriaException("No se el directorio", e);
            }
            catch (Exception e)
            {
                throw new ComiqueriaException("Error al guardar la base de datos", e);
            }

        }

        public static List<T> Leer(string path)
        {
            try
            {
                List<T> miLista = new List<T>();

                StreamReader sw = new StreamReader(path);
                string strAux = sw.ReadToEnd();
                sw.Close();
                miLista = JsonSerializer.Deserialize<List<T>>(strAux);
                return miLista;
            }
            catch (FileNotFoundException e)
            {
                throw new ComiqueriaException("No se encontro el archivo", e);
            }
            catch (Exception e)
            {
                throw new Exception("Error en la lectura del archivo", e);
            }

        }


    }
}
