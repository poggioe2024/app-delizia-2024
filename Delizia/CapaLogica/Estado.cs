using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Estado
    {
        private int id {  get; set; }
        private string nombre { get; set; }

        public Estado(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }
}
