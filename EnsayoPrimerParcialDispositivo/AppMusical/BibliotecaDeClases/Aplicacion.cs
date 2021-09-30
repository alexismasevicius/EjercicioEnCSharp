using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public abstract class Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;

        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMb;
        }

        public SistemaOperativo SistemaOperativo
        {
            get
            {
                return sistemaOperativo;
            }
        }
        protected abstract int Tamanio
        {
            get;
        }

        public virtual string ObtenerInformacionApp()
        {

            StringBuilder strB = new StringBuilder();
            strB.AppendLine($"NOMBRE: {this.ToString()}");
            strB.AppendLine($"SISTEMA OPERATIVO:{this.sistemaOperativo}");
            strB.AppendLine($"TAMANIO: {this.Tamanio}");


            return strB.ToString();

        }

        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            int tamMax = 0;
            Aplicacion app=null;

            foreach (Aplicacion item in listaApp)
            {
                if(item.tamanioMb> tamMax)
                {
                    tamMax = item.tamanioMb;
                    app = item;
                }
            }

            return app;
        }

        public static bool operator ==(List<Aplicacion> listaApp, Aplicacion app)
        {
            foreach (Aplicacion item in listaApp)
            {
                if (item.nombre == app.nombre)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }

        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {
            if (listaApp != app)
            {
                listaApp.Add(app);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return this.nombre;
        }

    }
}
