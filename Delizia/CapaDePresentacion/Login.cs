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
        private LogicaLogin logica = new LogicaLogin();
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            string documento = txt_documento.Text;
            string contrasena = txt_contrasena.Text;
            try
            {
                bool check = logica.check_usuario(documento, contrasena);
                if (check)
                {
                    string rol = logica.check_permisos(documento);
                    if (rol == "2")
                    {
                        Program.mostrar_recepcion(this);
                    }
                    else {
                        MessageBox.Show("Error 1003. Permisos mal declarados o nulos.", "E1003");
                    }
                    txt_documento.Text = "";
                    txt_contrasena.Text = "";
                }
                else
                {
                    MessageBox.Show("Error 1001. Usuario o contraseña incorrectos.", "E1001");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error 0000. Excepcion no controlada.", "0000");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_documento.Text = "";
            txt_contrasena.Text = "";
        }
    }
}
