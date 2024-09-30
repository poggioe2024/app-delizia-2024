using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;

namespace CapaPresentacion
{
    public partial class Recepcion : Form
    {
        RecepcionMenu menu;
        RecepcionSeleccion seleccion;
        RecepcionDatos datos;
        RecepcionConfirmacion confirmacion;
        public Recepcion()
        {
            InitializeComponent();
            menu = new RecepcionMenu(this);
            seleccion = new RecepcionSeleccion(this);
            datos = new RecepcionDatos(this);
            confirmacion = new RecepcionConfirmacion(this);
            Controls.Remove(seleccion);
            Controls.Remove(datos);
            Controls.Remove(confirmacion);
            Controls.Add(menu);
        }

        public void agregar_seleccion()
        {
            Controls.Add(seleccion);
            Controls.Remove(menu);
            Controls.Remove(datos);
        }
        public void agregar_menu()
        {
            Controls.Add(menu);
            Controls.Remove(seleccion);
            Controls.Remove(confirmacion);
        }
        public void agregar_datos()
        {
            Controls.Add(datos);
            Controls.Remove(seleccion);
            Controls.Remove(confirmacion);
        }
        public void agregar_confirmacion()
        {
            Controls.Add(confirmacion);
            Controls.Remove(datos);
        }
        public void generar_pedido()
        {
           
        }

    }
}
