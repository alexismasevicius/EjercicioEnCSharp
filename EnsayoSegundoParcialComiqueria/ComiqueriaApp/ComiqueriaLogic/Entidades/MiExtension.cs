using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public static class MiExtension
    {
        public static string FormatearPrecio(this double dbl)
        {
            dbl = Math.Round(dbl, 2);
            return $"${dbl}";
        }
    }
}
