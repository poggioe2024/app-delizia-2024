using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Pedido
    {
        private int id;
        private Cliente cliente;
        private float precio_total;
        private int estado;
        private List<Producto> productos;
        private DateTime ahora = DateTime.Now;
        private string fecha; // = ahora.toString("dd/MM/yyyy");
        private string hora; // = ahora.ToString("HH:mm:ss");
    }
}
