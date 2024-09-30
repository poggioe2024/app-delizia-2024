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
    public partial class RepartoVer : UserControl
    {
        Reparto parent;
        public RepartoVer(Reparto parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void boton_retroceder_Click(object sender, EventArgs e)
        {
            this.parent.mostrar_menu();
        }
    }
}
