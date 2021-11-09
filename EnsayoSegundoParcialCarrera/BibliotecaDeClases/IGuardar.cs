using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public interface IGuardar<T>
    {
        public void Guardar(T tipo);
    }
}
