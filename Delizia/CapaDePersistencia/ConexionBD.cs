using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDePersistencia
{
    public class ConexionBD
    {
        private MySqlConnection conexion;
        private string server = "localhost";
        private string database = "delizia_bd";
        private string user = "root";
        private string password = "";
        private string cadena_conexion;
        
        public ConexionBD() {
            cadena_conexion = "Database=" + database +
                "; DataSource=" + server +
                "; User Id=" + user +
                "; Password=" + password;
        }

        public MySqlConnection getConexion()
        {
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadena_conexion);
                conexion.Open();
            }
            return conexion;
        }

        public string consulta(string consulta, string columnas) {
            string result = null;
            MySqlDataReader mySqlDataReader = null;
            if (conexion != null) {
                MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                mySqlCommand.Connection = getConexion();
                mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read()) {
                    result = mySqlDataReader[columnas].ToString();
                }
            }
            return result;
        }
        public void insercion(string cadena) {
            if (conexion != null)
            {
                MySqlCommand mySqlCommand = new MySqlCommand(cadena);
                mySqlCommand.Connection = getConexion();
                int filas_afectadas = mySqlCommand.ExecuteNonQuery();
            }
        }

        public void cerrar_conexion()
        {
            conexion.Close();
        }
    }
}