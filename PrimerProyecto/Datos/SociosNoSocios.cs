using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimerProyecto.Entidades;

namespace PrimerProyecto.Datos
{
    public class SociosNoSocios
    {
        public string? RegistrarSocioONoSocio(Entidades.E_Cliente cliente, bool esSocio)
        {
            //Recibimos como parametro si un cliente quiere registrarse como socio o no socio

            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                MySqlCommand comando = new MySqlCommand("NuevoCliente", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = cliente.Nombre;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = cliente.Apellido;
                comando.Parameters.Add("Tip", MySqlDbType.VarChar).Value = cliente.Tipo;
                comando.Parameters.Add("Doc", MySqlDbType.Int32).Value = cliente.Documento;
                comando.Parameters.Add("Mail", MySqlDbType.VarChar).Value = cliente.Mail;
                comando.Parameters.Add("Celular", MySqlDbType.Int32).Value = cliente.Celular;
                comando.Parameters.Add("AptoFisico", MySqlDbType.Bit).Value = cliente.AptoFisico;

                // este parametro que le mandamos al store procedure es para determinar en que tabla guardamos al cliente
                comando.Parameters.Add("EsSocio", MySqlDbType.Bit).Value = esSocio;

                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);


                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {

                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
            return salida;
        }

        public DataTable verClientes()
        {
            MySqlDataReader? resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                MySqlCommand comando = new MySqlCommand("VerClientes", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }

        }

        public E_Cuota verDeudaDeSocio(int nCliente, decimal precio)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            E_Cuota cuota = new E_Cuota();
            try
            {
                DateTime hoy = DateTime.UtcNow;
                string query;
                sqlCon = Conexion.getInstancia().CrearConcexion();
                query = ("select CodPago, FechaVencimiento from Pagos where CodPago = (select max(CodPago) from Pagos where NCliente = "+ nCliente.ToString() +")");

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    DateTime fechaVencimiento = Convert.ToDateTime(reader.GetDateTime(1));

                    TimeSpan diasDeVencimiento = hoy - fechaVencimiento;
                    if (diasDeVencimiento.Days < 0)
                    {
                        MessageBox.Show("Cuota mensual en término, no necesita pagar ahora.", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return cuota;
                    }
                    else
                    {
                        int Cantcuotas = 0;
                        while (fechaVencimiento <= hoy)
                        {
                            Cantcuotas += 1;
                            fechaVencimiento = fechaVencimiento.AddMonths(1);
                        }

                        precio = Cantcuotas * precio;
                        // Cargamos el precio total y la fecha de vencimiento
                        cuota.Precio = precio;
                        cuota.FechaVencimiento = fechaVencimiento;
                    }
                }

                else
                {
                    // Cargamos el precio y la fecha de vencimiento para la 1er cuota
                    cuota.Precio = precio;
                    cuota.FechaVencimiento = hoy.AddMonths(1);
                }
                cuota.Fecha = hoy;

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
            return cuota;
        }

    }
}
