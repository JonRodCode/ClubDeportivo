using PrimerProyecto.Datos;
using PrimerProyecto.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerProyecto
{
    public partial class frmComprobante : Form
    {
        public int? numeroSocio;
        public string? nombreCliente;
        public string? nombreActividad;
        public string? formaDePago;
        public E_Cuota? cuota = new E_Cuota();
        public frmComprobante()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;
            btnPagar.Visible = false;
            btnCancelar.Visible = false;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
            pd.Print();
            btnImprimir.Visible = true;
            btnPagar.Visible = true;
            btnCancelar.Visible = true;

            MessageBox.Show("Operación existosa", "AVISO DEL SISTEMA",
           MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }

        private void frmComprobante_Load(object sender, EventArgs e)
        {
            lblFechaActual.Text = cuota.Fecha.ToShortDateString();
            lblCliente.Text = nombreCliente;

            // Si es un Pago de Actividad cambiamos algunos labels
            if (numeroSocio == 0)
            {
                lblSocioNumero.Visible = false;
                lblNumeroDeSocio.Visible = false;
                lblTemaAPagar.Text = "Actividad";
                lblProximoVenc.Text = "Nombre de actividad:";
                lblVencimiento.Text = nombreActividad;
            }
            //Si no dejamos por determinado el Pago de Cuota para el Socio
            else
            {
                lblNumeroDeSocio.Text = numeroSocio.ToString();
                lblVencimiento.Text = cuota.FechaVencimiento.ToShortDateString();
                lblTemaAPagar.Text = cuota.Tipo;
            }
            lblEfectivoOTarjeta.Text = formaDePago;
            lblPrecio.Text = cuota.Precio.ToString();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                Cuota cuotas = new Cuota();
                string? numeroDeCuota = cuotas.registrarCuota(cuota);

                if (numeroDeCuota != null)
                {
                    MessageBox.Show("Pago n° " + numeroDeCuota + " confirmado. Imprima el comprobante", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Question);
                }
                btnCancelar.Enabled = false;
                btnPagar.Enabled = false;
                btnImprimir.Enabled = true;
                Actividad actividad = new Actividad();
                actividad.actualizarCupo(nombreActividad);
            }

            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
