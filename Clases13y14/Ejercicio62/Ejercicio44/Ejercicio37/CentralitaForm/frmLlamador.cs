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
using CentralitaDAO;

namespace CentralitaForm
{
    public partial class frmLlamador : Form
    {
        private Centralita centralita;
        private LocalDAO baseLocal;
        private ProvincialDAO baseProv;

        public frmLlamador(Centralita centralita, LocalDAO baseLocal,ProvincialDAO baseProv)
        {
            InitializeComponent();
            this.centralita = centralita;
            this.baseLocal = baseLocal;
            this.baseProv = baseProv;

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
            this.txtNroDestino.Text = "Nro Destino";
            this.txtNroOrigen.Text = "Nro Origen";
        }


        /// <summary>
        /// Genera una llamada a partir de los numeros marcados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLlamar_Click(object sender, EventArgs e)
        {

            if(this.txtNroDestino.Text != "Nro Destino" && this.txtNroOrigen.Text != "Nro Origen")
            {


                Random random = new Random();
                float duracion = (float)random.Next(1, 50);

                Llamada llamada;

                if (this.txtNroDestino.Text[0] == '#')
                {
                    llamada = new Provincial((Provincial.Franja)this.cmbFranja.SelectedItem,this.txtNroOrigen.Text,  duracion, this.txtNroDestino.Text);
                    this.baseProv.Guardar((Provincial)llamada);
                }
                else
                {
                    float costo = (float)random.Next(1,5);
                    llamada = new Local(this.txtNroOrigen.Text, duracion, this.txtNroDestino.Text, costo);
                    this.baseLocal.Guardar((Local)llamada);
                }

                try
                {
                    this.centralita += llamada;
                }
                catch (CentralitaException centralEx)
                {

                    MessageBox.Show($"Se producto un error: {centralEx.Message}, " +
                        $" {centralEx.NombreClase}, " +
                        $"  {centralEx.NombreMetodo}", "ERROR",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                        );
                }
                
                this.Close();
            }
            else
            {
                MessageBox.Show("No ingresa numeros de telefono", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }

        /// <summary>
        /// Limpia lo ingresado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text = "Nro Destino";
            this.txtNroOrigen.Text = "Nro Origen";
        }

        /// <summary>
        /// Sale del form llamadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// carfa un numero de destino
        /// </summary>
        /// <param name="digitoPresionado"></param>
        private void CargarNumero(string digitoPresionado)
        {
            if (this.txtNroDestino.Text == "Nro Destino")
            {
                this.txtNroDestino.Text = string.Empty;
            }
            this.txtNroDestino.Text += digitoPresionado;
        }


        /// <summary>
        /// Deshabilita el combobox de franja horaria al  ingresar un numero que no empiece con #
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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



        //CARGA DE NUMEROS
        private void btn1_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.CargarNumero("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.CargarNumero("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.CargarNumero("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.CargarNumero("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.CargarNumero("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.CargarNumero("0");
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            this.CargarNumero("*");
        }
        private void btnNumeral_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.btnNumeral.Text);
        }

        private void txtNroOrigen_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtNroOrigen.Clear();
        }

        private void cmbFranja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNroOrigen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
