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
    public partial class RecepcionConfirmacion : UserControl
    {
        private Recepcion parent;
        public RecepcionConfirmacion(Recepcion parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void boton_retroceder_Click(object sender, EventArgs e)
        {
            parent.agregar_datos();
        }

        private void boton_confirmar_Click(object sender, EventArgs e)
        {
            parent.generar_pedido();
            parent.agregar_menu();
        }

        private void label_telefono_Click(object sender, EventArgs e)
        {

        }

        private void label_nombre_Click(object sender, EventArgs e)
        {

        }
    }
}
