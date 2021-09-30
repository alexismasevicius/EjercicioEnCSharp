using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class AppMusical:Aplicacion
    {
        private List<string> listaCanciones;

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanio)
        : this(nombre, sistemaOperativo, tamanio,new List<string>())
        {
        }

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanio,List<string> listaCanciones)
            :base(nombre, sistemaOperativo, tamanio)
        {
            this.listaCanciones = listaCanciones;
        }

        protected override int Tamanio
        {
            get
            {
                return this.tamanioMb + (2 * listaCanciones.Count); ;
            }
        }
        public override string ObtenerInformacionApp()
        {

            StringBuilder strB = new StringBuilder();

            strB.AppendLine($"{base.ObtenerInformacionApp()}");
            foreach (string item in listaCanciones)
            {
                strB.AppendLine($"{item}");
            }
            


            return strB.ToString();
        }

    }
}
