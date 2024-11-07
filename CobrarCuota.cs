using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrimerProyecto
{
    public partial class frmCobrarCuota : Form
    {
        public int nCliente;
        public int idSocio;
        public string nombreApellido;
        decimal precio;

        public frmComprobante doc;
        public frmCobrarCuota()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtNumSocio.Text == "" || !(Validaciones.soloNumeros(txtNumSocio.Text)))
            {
                MessageBox.Show("Ingrese un número de socio válido", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else
            {
                MySqlConnection sqlCon = new MySqlConnection();
                try
                {
                    string query;
                    sqlCon = Conexion.getInstancia().CrearConcexion();
                    query = ("select c.NCliente, IdSocio, concat(nombre, ' ', apellido), (select precio from cuotamensual) from Socios as s inner join Clientes as c on s.NCliente = c.NCliente where IdSocio = " + txtNumSocio.Text);

                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    comando.CommandType = CommandType.Text;

                    sqlCon.Open();

                    MySqlDataReader reader;
                    reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        nCliente = reader.GetInt32(0);
                        idSocio = reader.GetInt32(1);
                        nombreApellido = reader.GetString(2);
                        precio = reader.GetDecimal(3);

                        txtNumSocio.Enabled = false;
                        btnVerificar.Visible = false;
                        btnCambiar.Visible = true;
                        btnIrAPagar.Enabled = true;
                        pnFormaPago.Enabled = true;

                        MessageBox.Show("Socio verificado.", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Número de Socio inexistente", "AVISO DEL SISTEMA",
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
        private void btnPagar_Click(object sender, EventArgs e)
        {
            doc = new frmComprobante();
            try
            {
                // Cargamos estos datos en el Comprobante
                doc.numeroSocio = idSocio;
                doc.nombreCliente = nombreApellido;

                string cuotaMensual = "Cuota mensual";
                SociosNoSocios socio = new SociosNoSocios();

                // Aca cargamos en la cuota la Fecha, Fecha de vencimiento y Precio final
                doc.cuota = socio.verDeudaDeSocio(nCliente, precio);
                if (doc.cuota.Precio == 0)
                    return;
                else
                {
                    if (doc.cuota.Precio > precio)
                        cuotaMensual += " + Deuda";
                    doc.cuota.Tipo = cuotaMensual;
                    doc.cuota.NCliente = nCliente;

                    if (rbEfectivo.Checked == false && rbTarjeta.Checked == false)
                    {
                        MessageBox.Show("Seleccione una forma de pago.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (rbEfectivo.Checked == true)
                        doc.formaDePago = "Efectivo";
                    else
                        doc.formaDePago = "Tarjeta";

                    doc.cuota.Tipo = cuotaMensual;
                    doc.cuota.NCliente = nCliente;

                    doc.ShowDialog();
                    this.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            txtNumSocio.Enabled = true;
            btnVerificar.Visible = true;
            btnCambiar.Visible = false;
            btnIrAPagar.Enabled = false;
            pnFormaPago.Enabled = false;

        }
    }
}
