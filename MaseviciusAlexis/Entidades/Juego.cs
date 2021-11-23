using Archivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void InformacionDeAvance(object sender, short movimiento);
    public class Juego
    {
        private static short velocidad;
        private short ubicacion;
        private object controlVisual;
        public event InformacionDeAvance InformarAvance;

        static Juego()
        {
            Juego.velocidad = 8;
        }
        public Juego(short ubicacion, object controlVisual)
        {
            this.ubicacion = ubicacion;
            this.controlVisual = controlVisual;
            
        }

        [System.Text.Json.Serialization.JsonIgnore]
        public object ControlVisual
        {
            get
            {
                return this.controlVisual;
            }
            set
            {
                this.controlVisual = value;
            }
        }

        public short Ubicacion { get => ubicacion; set => ubicacion = value; }

        public static short Velocidad { get => velocidad; set => velocidad = value; }

        public short Velocidad1  { get => velocidad; set => velocidad = value; }

        public short Avanzar()
        {
            this.ubicacion += velocidad;
            return this.ubicacion;
        }

        /// <summary>
        /// Simular la animación del Carrusel
        /// </summary>
        public void IniciarCarrusel(CancellationToken cancellationToken) ///AGREGAR CANCELATION TOKEN
        {
            do
            {
                
                
                if(this.InformarAvance is not null)
                {
                    this.InformarAvance.Invoke(this, this.Avanzar());                
                }
                System.Threading.Thread.Sleep(50 + Juego.velocidad);
                

            } while (!cancellationToken.IsCancellationRequested);
            //Agregar !cancell
        }
    }
}
