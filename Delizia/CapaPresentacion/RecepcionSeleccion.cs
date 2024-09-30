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
    public partial class RecepcionSeleccion : UserControl
    {
        private Recepcion parent;
        public RecepcionSeleccion(Recepcion parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.panel_productos.AutoScroll = true;
        }

        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            parent.agregar_menu();
        }

        private void boton_avanzar_Click(object sender, EventArgs e)
        {
            parent.agregar_datos();
        }

        private void recepcionProducto1_Load(object sender, EventArgs e)
        {

        }
    }
}
