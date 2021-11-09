using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FormReloj
{

    public delegate void EncargadoTiempo();
    sealed class Temporizador
    {
        private Task hilo;
        private int intervalo;
        CancellationToken cancellationToken;
        CancellationTokenSource cancellationTokenSource;

        public event EncargadoTiempo EventoTiempo;

        public bool Activo
        {
            get
            {
                return hilo is not null;
            }
            set
            {
                if (value && !this.Activo)
                {
                    this.cancellationTokenSource = new CancellationTokenSource();
                    this.cancellationToken = this.cancellationTokenSource.Token;
                    this.hilo = new Task(this.CorrerTiempo, this.cancellationToken);
                    this.hilo.Start();
                }
                else
                {
                    this.cancellationTokenSource.Cancel();
                }
            }
        }
        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }
            set
            {
                this.intervalo = value;
            }
        }


        public void CorrerTiempo()
        {
            do
            {
                if (this.EventoTiempo is not null)
                {
                    this.EventoTiempo.Invoke();
                }
                Thread.Sleep(this.Intervalo);
            } while (!cancellationToken.IsCancellationRequested);
        }

    }
}
