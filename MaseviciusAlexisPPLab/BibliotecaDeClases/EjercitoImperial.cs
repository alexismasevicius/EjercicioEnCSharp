using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class EjercitoImperial
    {
        private int capacidad;
        private List<Trooper> troopers;

        

        //CONSTRUCTORES
        /// <summary>
        /// constrructor privado
        /// </summary>
        private EjercitoImperial()
        {
            this.troopers = new List<Trooper>();
        }
        /// <summary>
        /// constructor publico
        /// </summary>
        /// <param name="capacidad">capacidad</param>
         public EjercitoImperial(int capacidad):this()
         {
            this.capacidad = capacidad;
         }


        //PROPIEDADES
        public List<Trooper> Troopers
        {
            get
            {
                return this.troopers;
            }
        }


        //SOBRECARGAS

        /// <summary>
        /// Agrega un soldado al ejercito
        /// </summary>
        /// <param name="ejercito">lista ejercito</param>
        /// <param name="soldado">soldado a agregar</param>
        /// <returns></returns>
        public static EjercitoImperial operator +(EjercitoImperial ejercito, Trooper soldado)
        {
            if(ejercito.capacidad > ejercito.troopers.Count)
            {
                ejercito.troopers.Add(soldado);
                return ejercito;
            }
            else
            {
                return ejercito;
            }
        }


        /// <summary>
        /// Quita un soldado de ese tipo del ejercito
        /// </summary>
        /// <param name="ejercito">ejercito imperial lista</param>
        /// <param name="soldado">tipo de soldado a quita</param>
        /// <returns></returns>
        public static EjercitoImperial operator -(EjercitoImperial ejercito, Trooper soldado)
        {
            foreach (Trooper item in ejercito.troopers)
            {
                if (item.Equals(soldado))
                {
                    ejercito.troopers.Remove(item);
                    return ejercito;
                }
            }
            return ejercito;
        }


    }
}
