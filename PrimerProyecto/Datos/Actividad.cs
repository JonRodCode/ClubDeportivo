using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using PrimerProyecto.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto.Datos
{
    public class Actividad
    {
        public decimal consultarPrecio(string actividad)
        {
            decimal precio = 0;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConcexion();
                query = ("select precio from actividades where nombre like '" + actividad + "'");

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    precio = reader.GetDecimal(0);
                }
                return precio;
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

        public int verificarCupo(string actividad)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            int cupo;
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConcexion();
                query = ("select cupo from actividades where nombre like '" + actividad + "'");

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                reader.Read();
                cupo = reader.GetInt32(0);
                return cupo;

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

        internal void actualizarCupo(string nombreActividad)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                MySqlCommand comando = new MySqlCommand("ActualizarCupo", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("NombreActividad", MySqlDbType.VarChar).Value = nombreActividad;      
                sqlCon.Open();
                comando.ExecuteNonQuery();
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
