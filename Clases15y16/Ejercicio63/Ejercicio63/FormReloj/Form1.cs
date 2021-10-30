using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormReloj
{
    public partial class Form1 : Form
    {
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString();
            CancellationToken cancellationToken = cancellationTokenSource.Token;
            
            Task hiloUno = Task.Run(() => AsignarHora(cancellationToken));
            
            //Task hiloUno = new Task(AsignarHora);
            //hiloUno.Start();

        }

        /// <summary>
        /// Delegado para usar en el invoke
        /// </summary>
        delegate void Callback(CancellationToken e);

        /// <summary>
        /// Itera la funcion refrescar reloj
        /// </summary>
        /// <param name="t">si fue cancelado o no</param>
        public void AsignarHora(CancellationToken t)
        {
   

            while (true)
            {

                if (t.IsCancellationRequested)
                {
                    return;
                }

                this.RefrescarReloj(t);
                Thread.Sleep(1000);
            }      
        }

        /// <summary>
        /// Actualiza la info del reloj cada segundo
        /// </summary>
        public void RefrescarReloj(CancellationToken t)
        {
            if (this.label1.InvokeRequired)
            {
                //Task.Delay(1000);
                Callback d = new Callback(this.RefrescarReloj);
                object[] objs = new object[] { t };
                this.Invoke(d,objs);
            }
            else
            {
                if (t.IsCancellationRequested)
                {
                    return;
                }
                this.label1.Text = DateTime.Now.ToString();
            }

        }

    }
}
