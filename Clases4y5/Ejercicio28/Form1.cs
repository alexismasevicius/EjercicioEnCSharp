using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            string textoComplete;
            char[] separators = new char[] { ' ', '.', ',' };




            textoComplete = richTextBox1.Text;
            string[] arrayTexto =  textoComplete.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < arrayTexto.Length; i++)
            {
                if(myDictionary.ContainsKey(arrayTexto[i]))
                {
                    int cantRepeticiones = myDictionary[arrayTexto[i]];
                    cantRepeticiones++;
                    myDictionary[arrayTexto[i]] = cantRepeticiones;
                }
                else
                {
                    myDictionary.Add(arrayTexto[i],1);
                }
            }

            List<KeyValuePair<string, int>> podio = myDictionary.ToList();
            podio.Sort(CompararCantidadRepe);

            StringBuilder strBuilder = new StringBuilder();


            for (int i = 0; i < 3; i++)
            {
                strBuilder.AppendLine($"Palabra: {podio[i].Key}, Cantidad {podio[i].Value} \n");
            }
            

            MessageBox.Show($"{strBuilder.ToString()}");


        }

        private int CompararCantidadRepe (KeyValuePair<string, int> primerElemento, KeyValuePair<string, int> segundoElemento )
        {
            if(primerElemento.Value < segundoElemento.Value)
            {
                return 1;
            }
            if (primerElemento.Value > segundoElemento.Value)
            {
                return -1;
            }
            return 0;
        }

        /*private void mostrarPodio(List <KeyValuePair<string, int>> podio)
        {

        }*/

    }
}
