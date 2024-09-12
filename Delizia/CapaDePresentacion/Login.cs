using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaDePresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            LogicaLogin logica = new LogicaLogin();
            string documento = txt_documento.Text;
            string contrasena = txt_contrasena.Text;
            try
            {
                bool check = logica.check_usuario(documento, contrasena);
                if (check == true)
                {
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Error 1001. Usuario o contraseña incorrectos.", "E1001");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error 1002. No se insertó ningún dato del usuario.", "E1002");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_documento.Text = "";
            txt_contrasena.Text = "";
        }
    }
}
