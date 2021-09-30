using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class Dispositivo
    {

        private static List<Aplicacion> appsInstaladas;
        private static SistemaOperativo sistemaOperativo;

        static Dispositivo()
        {
            Dispositivo.sistemaOperativo = SistemaOperativo.ANDROID;
            Dispositivo.appsInstaladas = new List<Aplicacion>();
        }

        public static bool InstalarApp(Aplicacion app)
        {
            if (app.SistemaOperativo == SistemaOperativo.ANDROID)
            {
                if(Dispositivo.appsInstaladas + app)
                {
                    return true;
                }             
            }
            return false;
        }

        public static string ObtenerInformacionDispositivo()
        {

            StringBuilder strB = new StringBuilder();

            strB.AppendLine($"Sistema operativo :{Dispositivo.sistemaOperativo}");
            foreach (Aplicacion item in Dispositivo.appsInstaladas)
            {
                strB.AppendLine($"{item.ObtenerInformacionApp()}");
            }
            


            return strB.ToString();
        }
    }
}
