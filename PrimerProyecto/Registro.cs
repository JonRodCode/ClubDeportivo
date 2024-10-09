using System.Configuration;
using System.Data;

namespace PrimerProyecto
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Blanqueo formulario
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            txtMail.Text = "";
            txtCelular.Text = "";
            cboTipo.SelectedIndex = -1;
            chkApto.Checked = false;
            chkRegistrar.Checked = false;
            txtNombre.Focus();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            DataTable tabla = new DataTable();

            if (txtNombre.Text == "" || txtApellido.Text == "" || cboTipo.SelectedItem == null || txtDocumento.Text == "" || txtMail.Text == "" || txtCelular.Text == "")
                MessageBox.Show("Debe completar todos los campos!");
            else
            {
                string? respuesta;

                Entidades.E_Postulante postulante = new Entidades.E_Postulante();
                postulante.nombre = txtNombre.Text;
                postulante.apellido = txtApellido.Text;
                postulante.tipo = cboTipo.SelectedItem.ToString();
                postulante.documento = int.Parse(txtDocumento.Text);
                postulante.mail = txtMail.Text;
                postulante.celular = int.Parse(txtCelular.Text);
                postulante.aptoFisico = chkApto.Checked;
                postulante.esSocio = chkRegistrar.Checked;

                Datos.Postulante postulantes = new Datos.Postulante();

                respuesta = postulantes.RegistrarNuevoCliente(postulante);

                bool esnumero = int.TryParse(respuesta, out int codigo);

                if (esnumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("POSTULANTE YA EXISTE", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("se almaceno con exito con el codigo Nro " + respuesta, "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Question);
                    }
                }

                frmRegistro_Load(sender, e);
            }
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            Datos.Postulante postulante = new Datos.Postulante();

            dtgvPrincipal.DataSource = postulante.verClientes();
        }
    }
}
