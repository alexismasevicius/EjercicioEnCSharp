using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BibliotecaDeClases
{
    public class GestorDeArchivos: IGuardar<Carrera>, IGuardar<AutoF1>
    {
        private string archivo;

        public GestorDeArchivos(string ruta)
        {
            this.archivo = ruta;
        }


        public void Guardar(AutoF1 auto)
        {
            using (StreamWriter streamWriter = new StreamWriter(this.archivo, true))
            {
                streamWriter.Write(auto.Escuderia, true);
                streamWriter.Write($". Posicion: {auto.Posicion.ToString()} . ", true);
                streamWriter.WriteLine(DateTime.Now.ToString(), true);
            }
        }

        void IGuardar<Carrera>.Guardar(Carrera tipo)
        {
            throw new NotImplementedException();
        }

    } 
}
