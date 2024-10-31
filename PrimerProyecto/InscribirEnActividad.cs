using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using PrimerProyecto.Datos;
using PrimerProyecto.Entidades;
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
    public partial class fmrInscribirEnActividad : Form
    {
        public int nCliente;
        public string nombreApellido;
        public string actividad;
        decimal precio;

        public frmComprobante doc;
        public fmrInscribirEnActividad()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtActividad.Text == "" || txtNoSocio.Text == "")
            {
                MessageBox.Show("Por favor complete ambos campos para continuar.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(Validaciones.soloNumeros(txtNoSocio.Text)))
            {
                MessageBox.Show("Ingrese un número de documento válido.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (btnVerificar.Text == "Cambiar")
            {
                txtNoSocio.Enabled = true;
                txtActividad.Enabled = true;
                btnVerificar.Text = "Verificar";
                btnIrAPagar.Enabled = false;
                pnFormaPago.Enabled = false;
            }
            else
            {
                MySqlConnection sqlCon = new MySqlConnection();
                try
                {
                    string query;
                    sqlCon = Conexion.getInstancia().CrearConcexion();
                    query = ("select c.nCliente, concat(nombre, ' ', apellido), " +
                        "if((select 1 from actividades where nombre like '" + txtActividad.Text + "') is not null, 1, 0) " +
                        "from NoSocios as ns " +
                        "inner join Clientes as c on ns.NCliente = c.NCliente where DocC = " + txtNoSocio.Text);

                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    comando.CommandType = CommandType.Text;

                    sqlCon.Open();

                    MySqlDataReader? reader;
                    reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        if (reader.GetInt32(2) == 1)
                        {
                            nCliente = reader.GetInt32(0);
                            nombreApellido = reader.GetString(1);
                            actividad = txtActividad.Text;

                            txtNoSocio.Enabled = false;
                            txtActividad.Enabled = false;
                            btnVerificar.Text = "Cambiar";
                            btnIrAPagar.Enabled = true;
                            pnFormaPago.Enabled = true;

                            MessageBox.Show("Datos verificados.", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                        {
                            MessageBox.Show("Actividad inexistente.", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                    else
                    {
                        MessageBox.Show("Documento inexistente.", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                    { sqlCon.Close(); };
                }
            }
        }

        private void btnIrAPagar_Click(object sender, EventArgs e)
        {
            doc = new frmComprobante();
            try
            {

                if (rbEfectivo.Checked == false && rbTarjeta.Checked == false)
                {
                    MessageBox.Show("Seleccione una forma de pago.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (rbEfectivo.Checked == true)
                    doc.formaDePago = "Efectivo";
                else
                    doc.formaDePago = "Tarjeta";
                // Cargamos estos datos en el Comprobante
                doc.numeroSocio = 0;
                doc.nombreCliente = nombreApellido;
                doc.nombreActividad = actividad;

                DateTime hoy = DateTime.UtcNow;
                doc.cuota.Fecha = hoy;
                doc.cuota.FechaVencimiento = hoy;
                doc.cuota.Tipo = "Actividad: " + actividad;
                doc.cuota.NCliente = nCliente;

                Actividad actividades = new Actividad();
                doc.cuota.Precio = actividades.consultarPrecio(actividad);

                doc.ShowDialog();
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
