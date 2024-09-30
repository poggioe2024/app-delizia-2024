using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login login = new Login();
            login.Show();
            Application.Run();
        }
        public static void mostrar_login()
        {
        }

        public static void mostrar_recepcion(Login login)
        {
            login.Close();
            VentanaRecepcion ventanaRecepcion = new VentanaRecepcion();
            ventanaRecepcion.Show();
        }

        public static void cerrar_programa()
        {
            Application.Exit();
        }
    }
}
