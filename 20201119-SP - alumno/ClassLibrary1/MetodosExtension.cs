using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class MetodosExtension
    {
        public static int DiferenciaEnMinutos(this DateTime inicio, DateTime fin)
        {
            return (int)(inicio - fin).TotalMinutes;
        }

    }
}
