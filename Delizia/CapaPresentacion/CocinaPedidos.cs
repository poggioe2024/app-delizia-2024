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
    public partial class CocinaPedidos : UserControl
    {
        private Cocina parent;
        public CocinaPedidos(Cocina parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            parent.mostrar_menu();
        }
    }
}
