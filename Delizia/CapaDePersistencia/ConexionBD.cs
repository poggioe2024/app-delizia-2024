using MySql.Data.MySqlClient;
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
        private string database = "prueba";
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
                    result = mySqlDataReader.GetString(columnas);
                }
            }
            return result;
        }

        public void cerrar_conexion()
        {
            conexion.Close();
        }
    }
}
