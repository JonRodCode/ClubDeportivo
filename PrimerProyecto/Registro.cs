using System.Configuration;
using System.Data;
using System.Text.RegularExpressions;

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
            Regex regex = new Regex("^[0-9]*$");

            if (txtNombre.Text == "" || txtApellido.Text == "" || cboTipo.SelectedItem == null || txtDocumento.Text == "" || txtMail.Text == "" || txtCelular.Text == "")
                MessageBox.Show("Debe completar todos los campos!");

            else if (!(regex.IsMatch(txtDocumento.Text) && regex.IsMatch(txtCelular.Text)))
                MessageBox.Show("Los campos Documento y Celular solo deben llevar números");

            else
            {
                string? respuesta;

                Entidades.E_Postulante postulante = new Entidades.E_Postulante();
                postulante.Nombre = txtNombre.Text;
                postulante.Apellido = txtApellido.Text;
                postulante.Tipo = cboTipo.SelectedItem.ToString();
                postulante.Documento = int.Parse(txtDocumento.Text);
                postulante.Mail = txtMail.Text;
                postulante.Celular = int.Parse(txtCelular.Text);
                postulante.AptoFisico = chkApto.Checked;
                postulante.EsSocio = chkRegistrar.Checked;

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
                btnLimpiar_Click(sender, e);
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
