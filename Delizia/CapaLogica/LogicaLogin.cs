using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDePersistencia;

namespace CapaLogica
{
    public class LogicaLogin
    {
        public LogicaLogin() {
        }
        public bool check_usuario(string usuario, string contrasena)
        {
            ConexionBD conexion = new ConexionBD();
            conexion.getConexion();
            string consulta = "select * from funcionarios where cedula = " + usuario + ";";
            string cedula = conexion.consulta(consulta, "cedula");
            conexion.cerrar_conexion();
            if (cedula != null)
            {
                bool check_pass = check_contrasena(usuario, contrasena);
                return check_pass;
            }
            else
            {
                return false;
            }
        }
        public bool check_contrasena(string usuario, string contrasena)
        {
            ConexionBD conexion = new ConexionBD();
            conexion.getConexion();
            string consulta = "select * from funcionarios where cedula = " + usuario + ";";
            string contrasena_obtenida = conexion.consulta(consulta, "contrasena");
            conexion.cerrar_conexion();
            if (contrasena == contrasena_obtenida)
                {  return true;  }
            else
                {  return false; }
        }
    }
}
