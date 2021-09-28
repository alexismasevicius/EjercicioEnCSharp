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

namespace Libreria
{
    public partial class Form1 : Form
    {
        Vendedor miVendedor = new Vendedor("Alexis");
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);

            lstStock.Items.Add(p1);
            lstStock.Items.Add(p2);
            lstStock.Items.Add(p3);
            lstStock.Items.Add(p4);
            lstStock.Items.Add(p5);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Publicacion miPublicacion = (Publicacion)lstStock.SelectedItem;

            if (miVendedor + miPublicacion)
            {
                MessageBox.Show("Venta exitosa","Info", MessageBoxButtons.OK);
                
            }

        }

        private void btnVerInforme_Click(object sender, EventArgs e)
        {
             rtbInforme.Text = Vendedor.ObtenerInformeDeVentas(miVendedor);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Esta seguro de salir?", "Salida", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
