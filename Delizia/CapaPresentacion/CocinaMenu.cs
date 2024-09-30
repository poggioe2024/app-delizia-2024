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
    public partial class CocinaMenu : UserControl
    {
        private Cocina parent;
        public CocinaMenu(Cocina parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void boton_pedidos_Click(object sender, EventArgs e)
        {
            parent.mostrar_pedidos();
        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            parent.Dispose();
        }
    }
}
