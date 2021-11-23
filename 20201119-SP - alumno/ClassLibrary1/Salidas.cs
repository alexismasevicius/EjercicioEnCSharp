using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Salidas
    {
        DateTime fechaFin;
        DateTime fechaInicio;

        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }

        public int TiempoTotal
        {
            get
            {
                return fechaInicio.DiferenciaEnMinutos(fechaFin);
            }
        }

        public Salidas()
        {
            fechaInicio = DateTime.Now;
        }

        public void FinalizarSalida()
        {
            fechaFin = DateTime.Now;
        }



    }
}
