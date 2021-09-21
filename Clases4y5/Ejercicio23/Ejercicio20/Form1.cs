using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;


namespace Ejercicio20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxEuroCot.Text = Convert.ToString(Euro.GetCotizacion);
            textBoxDolarCot.Text = "1";
            //textBoxDolarCot.LostFocus();
            textBoxPesoCot.Text = Convert.ToString(Peso.GetCotizacion);
        }

       

        private void button4_Click(object sender, EventArgs e)
        {

            if (button4.Text == "Desbloqueada") 
            {
                button4.Text = "Bloqueada";
            }
            else
            {
                button4.Text = "Desbloqueada";
            }
        }

        private void buttonEuro_Click(object sender, EventArgs e)
        {
            
            string muestra;
            double moneda;
            Euro nuevoEuro;
            Peso nuevoPeso;
            Dolar nuevoDolar;

            muestra = InputEuro.Text;
            double.TryParse(muestra, out moneda);

            nuevoEuro=(Euro)moneda;
            nuevoDolar = (Dolar)nuevoEuro;
            nuevoPeso = (Peso)nuevoEuro;

            muestra = Convert.ToString(nuevoPeso.GetCantidad);
            EuroPeso.Text = muestra;

            muestra = Convert.ToString(nuevoDolar.GetCantidad);
            EuroDolar.Text = muestra;

            EuroEuro.Text = InputEuro.Text;
        }

        private void buttonDolar_Click(object sender, EventArgs e)
        {
            string muestra;
            double moneda;
            Euro nuevoEuro;
            Peso nuevoPeso;
            Dolar nuevoDolar;

            muestra = InputDolar.Text;
            double.TryParse(muestra, out moneda);

            nuevoDolar = (Dolar)moneda;
            nuevoEuro = (Euro)nuevoDolar;
            nuevoPeso = (Peso)nuevoDolar;

            muestra = Convert.ToString(nuevoPeso.GetCantidad);
            DolarPeso.Text = muestra;

            muestra = Convert.ToString(nuevoEuro.GetCantidad);
            DolarEuro.Text = muestra;

            DolarDolar.Text = InputDolar.Text;

        }

        private void buttonPeso_Click(object sender, EventArgs e)
        {
            string muestra;
            double moneda;
            Euro nuevoEuro;
            Peso nuevoPeso;
            Dolar nuevoDolar;

            muestra = InputPeso.Text;
            double.TryParse(muestra, out moneda);

            nuevoPeso = (Peso)moneda;
            nuevoDolar = (Dolar)nuevoPeso;
            nuevoEuro = (Euro)nuevoPeso;
            

            muestra = Convert.ToString(nuevoDolar.GetCantidad);
            PesoDolar.Text = muestra;

            muestra = Convert.ToString(nuevoEuro.GetCantidad);
            PesoEuro.Text = muestra;

            PesoPeso.Text = InputPeso.Text;

        }


        
    }
}
