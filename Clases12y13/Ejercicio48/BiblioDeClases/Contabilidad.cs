using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioDeClases
{
    public class Contabilidad<T,U> 
        where T:Documento 
        where U:Documento,  new()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();

        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> conta, T egreso)
        {
            conta.egresos.Add(egreso);
            return conta;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> conta, U egreso)
        {
            conta.ingresos.Add(egreso);
            return conta;
        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("EGRESOS");
            foreach (T item in this.egresos)
            {
                sb.AppendLine(item.Numero.ToString());
            }

            sb.AppendLine();
            sb.AppendLine("INGRESOS");
            foreach (U item in this.ingresos)
            {
                sb.AppendLine(item.Numero.ToString());
            }

            return sb.ToString();
        }


    }
}
