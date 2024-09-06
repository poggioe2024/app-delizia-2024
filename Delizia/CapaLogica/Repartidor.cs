using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Repartidor : Funcionario
    {
        protected List<Pedido> mis_pedidos { get; set; }

        public Repartidor(int id, string nombre, string apellido, string cedula, string telefono, List<Pedido> mis_pedidos) : base(id, nombre, apellido, cedula, telefono)
        {
            this.mis_pedidos = mis_pedidos;
        }
    }
}
