using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Pizza : Producto
    {
        private List<Ingrediente> ingredientes{ get; set; }

        public Pizza(int id, string nombre, string descripcion, float precio, TipoProducto tipo_de_producto, List<Ingrediente> ingredientes) : base(id, nombre, descripcion, precio, tipo_de_producto)
        {
            this.ingredientes = ingredientes;
        }
    }
}
