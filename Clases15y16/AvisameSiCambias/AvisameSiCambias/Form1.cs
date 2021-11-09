using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvisameSiCambias
{
    public partial class Form1 : Form
    {
        private Persona miPersona;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(miPersona is null)
            {
                this.miPersona = new Persona();
                miPersona.Nombre = txtNombre.Text;
                miPersona.Apellido = txtApellido.Text;
                miPersona.EventoString += NotificarCambio;
                this.btnCrear.Text = "Actualizar";
            }
            else
            {
                miPersona.Nombre = txtNombre.Text;
                miPersona.Apellido = txtApellido.Text;

            }
        }

        public void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio);
        }
    }
}
