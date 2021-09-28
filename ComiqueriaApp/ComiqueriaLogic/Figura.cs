using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Figura:Producto
    {
        private double altura;

        //CONSTRCUTORES
        public Figura(int stock, double precio, double altura)
            :base($"Figura {altura} cm",stock,precio)
        {
            this.altura = altura;
        }

        public Figura(string descripcion, int stock, 
            double precio, double altura):this(stock,precio,altura)
        {
        }

        public override string ToString()
        {
            StringBuilder strB = new StringBuilder();

            strB.AppendLine($"{base.ToString()}");
            strB.AppendLine($"Altura : {this.altura}");

            return strB.ToString();
        }


    }
}
