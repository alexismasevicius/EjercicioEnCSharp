using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface Iarchivos<X>
    {
        void Guardar(X info);
        X Leer();


    }
}
