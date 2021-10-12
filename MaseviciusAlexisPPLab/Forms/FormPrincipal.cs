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

namespace Forms
{


    public partial class FormPrincipal : Form
    {
         EjercitoImperial ejercitoImperial;
        
        Trooper trooper1 = new TrooperAsalto(Blaster.EC17);

        public FormPrincipal()
        {
            InitializeComponent();
            ejercitoImperial = new EjercitoImperial(30);
            ejercitoImperial += trooper1;
            cmbTipo.Items.Add("Arena");
            cmbTipo.Items.Add("Explorador");
            cmbTipo.Items.Add("Asalto");
            cmbBlaster.Items.Add(Blaster.E11);
            cmbBlaster.Items.Add(Blaster.EC17);
            cmbBlaster.Items.Add(Blaster.DLT19);

        }

        /// <summary>
        /// Carga el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_Load(object sender, EventArgs e)
        {

            RefrescarEjercito();
        }

        /// <summary>
        /// Refresca el listbox y muestra el ejercito
        /// </summary>
        private void RefrescarEjercito()
        {
            lstEjercito.Items.Clear();
            foreach (Trooper item in ejercitoImperial.Troopers)
            {
                lstEjercito.Items.Add(item.InfoTrooper());
            }
        }


        /// <summary>
        /// agrega un trooper del tipo elegido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Trooper miTrooper = null;

            switch (cmbTipo.Text)
            {
                case "Arena":
                    if (cmbBlaster.SelectedItem is Blaster.E11)
                    {
                        miTrooper = new TrooperArena(Blaster.E11);
                    }
                    else if (cmbBlaster.SelectedItem is Blaster.EC17)
                    {
                        miTrooper = new TrooperArena(Blaster.EC17);
                    }
                    else if (cmbBlaster.SelectedItem is Blaster.DLT19)
                    {
                        miTrooper = new TrooperArena(Blaster.DLT19);
                    }
                    break;

                case "Asalto":
                    if (cmbBlaster.SelectedItem is Blaster.E11)
                    {
                        miTrooper = new TrooperAsalto(Blaster.E11);
                    }
                    else if (cmbBlaster.SelectedItem is Blaster.EC17)
                    {
                        miTrooper = new TrooperAsalto(Blaster.EC17);
                    }
                    else if (cmbBlaster.SelectedItem is Blaster.DLT19)
                    {
                        miTrooper = new TrooperAsalto(Blaster.DLT19);
                    }
                    break;

                case "Explorador":
                    if (cmbBlaster.SelectedItem is Blaster.E11)
                    {
                        miTrooper = new TrooperExplorador("Deslizador", Blaster.E11);
                    }
                    else if (cmbBlaster.SelectedItem is Blaster.EC17)
                    {
                        miTrooper = new TrooperExplorador("", Blaster.EC17);
                    }
                    else if (cmbBlaster.SelectedItem is Blaster.DLT19)
                    {
                        miTrooper = new TrooperExplorador("Moto", Blaster.DLT19);
                    }
                    break;

            }

            if(miTrooper is not null)
            {
                if(ckbEsTrooper.Checked)
                {
                    miTrooper.EsClon = true;
                }
                else
                {
                    miTrooper.EsClon = false;
                }
                ejercitoImperial += miTrooper;
            }
            


            RefrescarEjercito();
        }

        /// <summary>
        /// quita un trooper
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == 0)
            {

               ejercitoImperial -= new TrooperArena(Blaster.EC17);

            }
            else if (cmbTipo.SelectedIndex == 1)
            {
                ejercitoImperial -= new TrooperExplorador("Moto");
            }
            else if (cmbTipo.SelectedIndex == 2)
            {
                ejercitoImperial -= new TrooperAsalto(Blaster.E11);
                
            }

            RefrescarEjercito();
        }
    }
}
