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
using CentralitaHerencia;

namespace CentralitaForm
{
    public partial class frmLlamador : Form
    {
        private Centralita centralita;

        public frmLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;

        }

        public Centralita Centralita
        {
            get
            {
                return this.centralita;
            }
        }


        private void frmLlamador_Load(object sender, EventArgs e)
        {
            this.cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            this.cmbFranja.Enabled = false;
        }
        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            float duracion = (float)random.Next(1, 3600);
            Llamada llamada;
            if (this.txtNroDestino.Text[0] == '#')
            {
                llamada = new Provincial((Provincial.Franja)this.cmbFranja.SelectedItem,this.txtNroOrigen.Text,  duracion, this.txtNroDestino.Text);
            }
            else
            {
                Thread.Sleep(2000);
                float costo = (float)random.Next(1, 100);
                llamada = new Local(this.txtNroOrigen.Text, duracion, this.txtNroDestino.Text, costo);
            }
            this.centralita += llamada;

        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text = "Nro Destino";
            this.txtNroOrigen.Text = "Nro Origen";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarNumero(string digitoPresionado)
        {
            if (this.txtNroDestino.Text == "Nro Destino")
            {
                this.txtNroDestino.Text = string.Empty;
            }
            this.txtNroDestino.Text += digitoPresionado;
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if (this.txtNroDestino.Text.IndexOf('#') == 0)
            {
                this.cmbFranja.Enabled = true;
            }
            else
            {
                this.cmbFranja.Enabled = false;
            }

        }

        private void txtNroOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btn1.Text);
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btnNumeral.Text);
        }
    }
}
