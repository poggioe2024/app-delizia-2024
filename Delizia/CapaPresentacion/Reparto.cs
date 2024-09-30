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
    public partial class Reparto : Form
    {
        private RepartoMenu menu;
        private RepartoSeleccion seleccion;
        private RepartoVer ver;
        public Reparto()
        {
            InitializeComponent();
            menu = new RepartoMenu(this);
            seleccion = new RepartoSeleccion(this);
            ver = new RepartoVer(this);
            mostrar_menu();
        }

        public void mostrar_menu()
        {
            Controls.Remove(seleccion);
            Controls.Remove(ver);
            Controls.Add(menu);
        }
        public void mostrar_seleccion()
        {
            Controls.Remove(menu);
            Controls.Remove(ver);
            Controls.Add(seleccion);
        }
        public void mostrar_ver()
        {
            Controls.Remove(menu);
            Controls.Remove(seleccion);
            Controls.Add(ver);
        }
    }
}
