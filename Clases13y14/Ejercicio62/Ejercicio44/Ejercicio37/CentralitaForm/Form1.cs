using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;
using CentralitaDAO;


namespace CentralitaForm
{
    public partial class FormMenu : Form
    {
        Centralita miCentralita = new Centralita("miCentralita");
        LocalDAO miBaseLocal = new LocalDAO();
        ProvincialDAO miBaseProv = new ProvincialDAO();

        public FormMenu()
        {
            InitializeComponent();
        }


        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            frmLlamador llamador = new frmLlamador(miCentralita,miBaseLocal,miBaseProv);
            llamador.ShowDialog();

        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(Llamada.TipoLlamada.Todas);
            frmMostrar.Centralita = miCentralita;
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(Llamada.TipoLlamada.Local);
            frmMostrar.Centralita = miCentralita;
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(Llamada.TipoLlamada.Provincial);
            frmMostrar.Centralita = miCentralita;
            frmMostrar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
