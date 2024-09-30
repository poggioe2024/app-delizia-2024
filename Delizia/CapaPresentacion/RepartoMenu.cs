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
    public partial class RepartoMenu : UserControl
    {
        Reparto parent;
        public RepartoMenu(Reparto parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void boton_ver_Click(object sender, EventArgs e)
        {
            parent.mostrar_ver();
        }

        private void boton_seleccion_Click(object sender, EventArgs e)
        {
            parent.mostrar_seleccion();
        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            parent.Dispose();
        }
    }
}
