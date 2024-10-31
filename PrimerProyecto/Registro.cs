using Mysqlx.Session;
using PrimerProyecto.Datos;
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
            chkRegistrarSocio.Checked = false;
            txtNombre.Focus();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            DataTable tabla = new DataTable();

            if (txtNombre.Text == "" || txtApellido.Text == "" || cboTipo.SelectedItem == null || txtDocumento.Text == "" || txtMail.Text == "" || txtCelular.Text == "")
                MessageBox.Show("Debe completar todos los campos!");

            else if (!(Validaciones.soloNumeros(txtDocumento.Text) && Validaciones.soloNumeros(txtCelular.Text)))
                MessageBox.Show("Los campos Documento y Celular solo deben llevar números");

            else if (!chkApto.Checked)
                MessageBox.Show("Por favor, ingrese el Apto Físico.");

            else
            {
                string? respuesta;
                bool esnumero;
                Datos.SociosNoSocios socioNoSocio = new Datos.SociosNoSocios();

                bool esSocio = chkRegistrarSocio.Checked;

                if (esSocio)
                {
                    Entidades.E_Socio socio = new Entidades.E_Socio();
                    socio.Nombre = txtNombre.Text;
                    socio.Apellido = txtApellido.Text;
                    socio.Tipo = cboTipo.SelectedItem.ToString();
                    socio.Documento = int.Parse(txtDocumento.Text);
                    socio.Mail = txtMail.Text;
                    socio.Celular = int.Parse(txtCelular.Text);
                    socio.AptoFisico = chkApto.Checked;

                    respuesta = socioNoSocio.RegistrarSocioONoSocio(socio, esSocio);
                }

                else
                {
                    Entidades.E_NoSocio noSocio = new Entidades.E_NoSocio();
                    noSocio.Nombre = txtNombre.Text;
                    noSocio.Apellido = txtApellido.Text;
                    noSocio.Tipo = cboTipo.SelectedItem.ToString();
                    noSocio.Documento = int.Parse(txtDocumento.Text);
                    noSocio.Mail = txtMail.Text;
                    noSocio.Celular = int.Parse(txtCelular.Text);
                    noSocio.AptoFisico = chkApto.Checked;

                    respuesta = socioNoSocio.RegistrarSocioONoSocio(noSocio, esSocio);
                }

                esnumero = int.TryParse(respuesta, out int codigo);

                if (esnumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("CLIENTE YA EXISTE", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (esSocio)
                        MessageBox.Show("Se almacenó con exito con el Nro de Socio: " + respuesta, "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Question);
                        else
                            MessageBox.Show("Se almacenó con exito.", "AVISO DEL SISTEMA",
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
            Datos.SociosNoSocios postulante = new Datos.SociosNoSocios();
            dtgvPrincipal.DataSource = postulante.verClientes();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
