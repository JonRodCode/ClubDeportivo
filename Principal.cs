using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerProyecto
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Form registrar = new frmRegistro();
            registrar.ShowDialog();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCobrarCuota_Click(object sender, EventArgs e)
        {
            Form cobrar = new frmCobrarCuota();
            cobrar.ShowDialog();
        }

        private void btnInscribirAActividad_Click(object sender, EventArgs e)
        {
            Form inscribir = new fmrInscribirEnActividad();
            inscribir.ShowDialog();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Form listado = new fmrListadoDeVencimiento();
            listado.ShowDialog();
        }
    }
}
