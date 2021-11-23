using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    interface IMetodosArchivos<T>
    {
        public bool ExisteArchivo(string nombreArchivo);
        public void Guardar(string nombreArchivo, T objeto);
        public void Leer(string nombreArchivo, out T objeto);
    }
}
