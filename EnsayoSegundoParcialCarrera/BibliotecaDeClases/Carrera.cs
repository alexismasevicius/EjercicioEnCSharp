using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public delegate void InformacionDeAvance();

    public delegate void InformacionLlegada(string mensaje);

    public class Carrera
    {
        private List<AutoF1> autos;
        private int kms;

        public event InformacionLlegada InformarLlegada;
        public event InformacionDeAvance InformarAvance;


        public Carrera()
        {
            this.autos = new List<AutoF1>(); 
        }
        public Carrera(int kms):this()
        {
            this.kms = kms;
        }

        public List<AutoF1> Autos { get => autos; set => autos = value; }
        public int Kms { get => kms; set => kms = value; }

        public void IniciarCarrera()
        {
            GestorBaseDeDatos gestorDB = new GestorBaseDeDatos();
            GestorDeArchivos gestorArchivos = new GestorDeArchivos("llegada.txt");
            int autoEnMeta = 0;
            for (int i = 0; i < autos.Count-1; i++)
            {
                autos[i].UbicacionEnPista = i + 1;
            }

            do
            {
                
                foreach (AutoF1 item in this.autos)
                {
                    item.Acelerar();
                    this.InformarAvance.Invoke();
                    Thread.Sleep(10);
                    if (item.UbicacionEnPista > this.kms && item.Posicion==0)
                    {
                        autoEnMeta++;
                        int ultimaPosicion = 0;
                        foreach (AutoF1 autito in this.autos)
                        {
                            if (autito.Posicion > ultimaPosicion)
                            {
                                ultimaPosicion = autito.Posicion;
                            }
                        }
                        item.Posicion = ultimaPosicion + 1;
                        this.InformarLlegada.Invoke(item.ToString());
                        gestorDB.Guardar(item);
                        gestorArchivos.Guardar(item);                       
                    }
                }
               
            } while (autoEnMeta < this.autos.Count);
        }

        public static Carrera operator +(Carrera carrera, AutoF1 autoF1)
        {
            carrera.autos.Add(autoF1);
            return carrera;
        }


    }
}
