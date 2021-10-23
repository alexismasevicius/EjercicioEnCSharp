using System;
using System.IO;

namespace IO
{
    public static class ArchivoTexto
    {
        /// <summary>
        /// guarda en un archivo la informacion
        /// </summary>
        /// <param name="path">direccion del archivo</param>
        /// <param name="info">informacion a guardar</param>
        public static void Guardar(string path, string info)
        {
            using (StreamWriter archivo = new StreamWriter(path, true))
            {
                archivo.WriteLine(info);
            }
        }

        /// <summary>
        /// Lee un archivo de texto
        /// </summary>
        /// <param name="path">direccion del archivo</param>
        /// <returns>si el path es valido String con los datos leidos, si no lo File not fundo exception</returns>
        public static string Leer(string path)
        {
            if(File.Exists(path))
            {
                string strAux = null;
                StreamReader sw = new StreamReader(path);
                strAux=sw.ReadToEnd();
                sw.Close();
                return strAux;
            }
            else
            {
                throw new FileNotFoundException();
            }
        }


    }
}
