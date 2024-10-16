using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto.Datos
{
    internal class Postulante
    {
        internal string? RegistrarNuevoCliente(Entidades.E_Postulante postulante)
        {

            string? salida;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                MySqlCommand comando = new MySqlCommand("NuevoCliente", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = postulante.Nombre;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = postulante.Apellido;
                comando.Parameters.Add("Tip", MySqlDbType.VarChar).Value = postulante.Tipo;
                comando.Parameters.Add("Doc", MySqlDbType.Int32).Value = postulante.Documento;
                comando.Parameters.Add("Mail", MySqlDbType.VarChar).Value = postulante.Mail;
                comando.Parameters.Add("Celular", MySqlDbType.Int32).Value = postulante.Celular;
                comando.Parameters.Add("AptoFisico", MySqlDbType.Bit).Value = postulante.AptoFisico;
                comando.Parameters.Add("EsSocio", MySqlDbType.Bit).Value = postulante.EsSocio;

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

        internal DataTable verClientes()
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

    }
}
