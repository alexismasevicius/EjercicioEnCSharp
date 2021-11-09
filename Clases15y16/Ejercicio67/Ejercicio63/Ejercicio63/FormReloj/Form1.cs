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

        Temporizador temporizador;

        public Form1()
        {
            InitializeComponent();
            this.temporizador = new Temporizador();
            this.temporizador.EventoTiempo += ActualizarHora;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            temporizador.Intervalo = 1000;
            temporizador.Activo = true;

        }

        private void ActualizarHora()
        {
            if (this.label1.InvokeRequired)
            {
                EncargadoTiempo callback = new EncargadoTiempo(ActualizarHora);
                this.Invoke(callback);
            }
            else
            {


                this.label1.Text = DateTime.Now.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.temporizador.Activo = false;
        }
    }
}
