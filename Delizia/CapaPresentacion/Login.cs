using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void boton_ingresar_Click(object sender, EventArgs e)
        {
            //comandos para comprobar las credenciales
            if (txt_cedula.Text != string.Empty)
            {
                int rol = int.Parse(txt_cedula.Text); //temporalmente para comprobar su funcionamiento
                if (rol == 1)
                {
                    //si rol = 1
                    Recepcion recepcion = new Recepcion();
                    recepcion.Show();
                }
                else if (rol == 2)
                {
                    //si rol = 2
                    Cocina cocina = new Cocina();
                    cocina.Show();
                }
                else if (rol == 3)
                {
                    //si rol = 3
                    Reparto reparto = new Reparto();
                    reparto.Show();
                }
                else if (rol == 4)
                {
                    Seguimiento segumiento = new Seguimiento();
                    segumiento.Show();
                }
            }
            txt_cedula.Text = string.Empty;
            txt_contrasena.Text = string.Empty;
        }

        private void txt_cedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_cedula_Click(object sender, EventArgs e)
        {

        }

        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            txt_cedula.Text = string.Empty;
            txt_contrasena.Text = string.Empty;
        }
    }
}
