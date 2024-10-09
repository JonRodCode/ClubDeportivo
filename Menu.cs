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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        internal string? usuario;
        internal string? rol;
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblMenu.Text = "USUARIO: " + usuario + " (" + rol + ")";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistrar registrar = new frmRegistrar();
            registrar.Show();
            this.Hide();
        }
    }
}
