using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDePresentacion;

namespace CapaDePresentacion
{
    public partial class VentanaRecepcion : Form
    {
        public VentanaRecepcion()
        {
            InitializeComponent();
            pan_pedido1.Visible = false;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Program.cerrar_programa();
        }

        private void btn_pedido_Click(object sender, EventArgs e)
        {
            pan_menu.Visible = false;
            pan_pedido1.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void agregar_Click(object sender, EventArgs e)
        {

        }
    }
}
