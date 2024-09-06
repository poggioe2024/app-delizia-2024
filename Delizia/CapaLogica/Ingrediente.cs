using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Ingrediente
    {
        private int id {  get; set; }
        private int nombre { get; set; }

        public Ingrediente(int id, int nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }
}
