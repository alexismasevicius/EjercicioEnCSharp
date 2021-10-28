using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;

namespace MiPrimerCRUD
{
    public partial class Form1 : Form
    {
        PersonaDAO miConexion = new PersonaDAO();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string auxNombre = txtNombre.Text;
            string auxApellido = txtApellido.Text;
            Persona miPersona = new Persona(auxNombre, auxApellido);
            miConexion.Guardar(miPersona);


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Persona miPersona = (Persona)lstPersonas.SelectedItem;

            miConexion.Modificar(miPersona.Id, txtNombre.Text, txtApellido.Text);
            lstPersonas.Items.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Persona miPersona = (Persona)lstPersonas.SelectedItem;

            MessageBox.Show($"Ha eliminado a : --{miPersona.ToString()}--", "Aviso", MessageBoxButtons.OK);

            miConexion.Borrar(miPersona.Id);

            lstPersonas.Items.Clear();

        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            lstPersonas.Items.Clear();
            List<Persona> miLista = miConexion.Leer();

            foreach (Persona item in miLista)
            {
                lstPersonas.Items.Add(item);
            }
        }


        private void lstPersonas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Persona miPersona = (Persona)lstPersonas.SelectedItem;

            txtNombre.Text = miPersona.Nombre;
            txtApellido.Text = miPersona.Apellido;

        }
    }
}
