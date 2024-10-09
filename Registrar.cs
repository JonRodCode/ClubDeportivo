namespace PrimerProyecto
{
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            if (txtNombre.Text == "" || txtNombre.Text == "" || cboTipo.SelectedItem == null || txtDocumento.Text == "")
                MessageBox.Show("Debe completar todos los campos!");
            else
            {
                string respuesta;
                Entidades.E_Cliente nuevo = new Entidades.E_Cliente();
                nuevo.NombreC = txtNombre.Text;
                nuevo.ApellidoC = txtApellido.Text;
                nuevo.DocC = Convert.ToInt32(txtDocumento.Text);
                nuevo.TDocC = cboTipo.Text;
                // instanciamos para usar el metodo dentro de postulantes
                Datos.Cliente clientes = new Datos.Cliente();
                respuesta = clientes.Nuevo_Cliente(nuevo);
                bool esnumero = int.TryParse(respuesta, out int codigo);
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
                        MessageBox.Show("se almaceno con exito con el codigo Nro " + respuesta, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }


                // Blanqueo formulario
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDocumento.Text = "";
                txtNombre.Focus();

            }



        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
