using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        Producto producto;
        Comiqueria comiqueria;
        double precioFinal;
        public VentasForm(Producto producto, Comiqueria comiqueria)
        {
            InitializeComponent();
            this.producto = producto;
            this.precioFinal = producto.Precio;
            this.comiqueria = comiqueria;
            lblDescripcion.Text = this.producto.Descripcion;
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            lblPrecio.Text = $"Precio Final:{this.precioFinal}";
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (this.producto.Stock > 0 && this.producto.Stock>= numericUpDown1.Value)
            {
                this.comiqueria.Vender(this.producto, (int)numericUpDown1.Value);
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("No hay stock","Informacion", MessageBoxButtons.OK);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.precioFinal = this.producto.Precio*(double)numericUpDown1.Value;
            lblPrecio.Text = $"Precio Final:{this.precioFinal}";
        }
    }
}
