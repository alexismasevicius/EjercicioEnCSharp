using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Boligrafo
    {
        public static short cantidadTintaMaxima;
        private ConsoleColor color;
        private short tinta;

        static Boligrafo()
        {
            cantidadTintaMaxima = 100;
        }

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        private void SetTinta(short tinta)
        {
            short aux = (short)(this.tinta + tinta);

            if (aux > 0 && aux < cantidadTintaMaxima)
            {
                this.tinta += tinta;
            }
        }

        public void Recargar()
        {
            short tinta;

            tinta = (short)(this.tinta - cantidadTintaMaxima);

            this.SetTinta(tinta);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool todoOk=true;
            StringBuilder str = new StringBuilder();
            short tintaMenosGasto = (short)(this.tinta - gasto);
            

            if (tintaMenosGasto >= 0)
            {
                for (int i = 0; i < gasto; i++)
                {
                    str.Append("*");
                }
                this.SetTinta((short)-gasto);
            }
            else
            {
                for (int i = 0; i < this.tinta; i++)
                {
                    str.Append("*");
                }
                this.tinta = 0;
            }

            dibujo = str.ToString();

            return todoOk;
        }

    
    
    }
}
