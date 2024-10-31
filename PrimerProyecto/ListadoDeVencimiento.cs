using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PrimerProyecto.Datos;

namespace PrimerProyecto
{
    public partial class fmrListadoDeVencimiento : Form
    {
        public fmrListadoDeVencimiento()
        {
            InitializeComponent();
        }

        private void ListadoDeVencimiento_Load(object sender, EventArgs e)
        {
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConcexion();
                query = ("select IdSocio, concat(nombre,' ', apellido), TDocC, DocC, mail, celular " +
                    "from pagos as p " +
                    "inner join clientes as c on p.NCliente = c.NCliente " +
                    "inner join socios as s on p.NCliente = s.NCliente " +
                    "where FechaVencimiento = CURDATE()");

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dgvListSocios.Rows.Add();
                        dgvListSocios.Rows[renglon].Cells[0].Value = (reader.GetInt32(0)).ToString();
                        dgvListSocios.Rows[renglon].Cells[1].Value = reader.GetString(1);
                        dgvListSocios.Rows[renglon].Cells[2].Value = reader.GetString(2);
                        dgvListSocios.Rows[renglon].Cells[3].Value = (reader.GetInt32(3)).ToString();
                        dgvListSocios.Rows[renglon].Cells[4].Value = reader.GetString(4);
                        dgvListSocios.Rows[renglon].Cells[5].Value = (reader.GetInt32(5)).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No hay socios con vencimiento de cuota en el dia de hoy.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); }
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
