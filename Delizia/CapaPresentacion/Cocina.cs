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
    public partial class Cocina : Form
    {
        CocinaPedidos pedidos;
        CocinaMenu menu;
        
        public Cocina()
        {
            InitializeComponent();
            menu = new CocinaMenu(this);
            pedidos = new CocinaPedidos(this);
            Controls.Remove(pedidos);
            Controls.Add(menu);
        }

        public void mostrar_pedidos()
        {
            Controls.Remove(menu);
            Controls.Add(pedidos);
        }
        public void mostrar_menu()
        {
            Controls.Remove(pedidos);
            Controls.Add(menu);
        }
        public void cerrar()
        {
            Close();
        }
    }
}
