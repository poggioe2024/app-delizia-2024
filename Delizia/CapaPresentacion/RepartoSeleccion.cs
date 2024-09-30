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
    public partial class RepartoSeleccion : UserControl
    {
        Reparto parent;
        public RepartoSeleccion(Reparto parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void boton_retroceder_Click(object sender, EventArgs e)
        {
            parent.mostrar_menu();
        }
    }
}
