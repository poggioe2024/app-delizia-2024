using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Cocinero : Funcionario
    {
        public Cocinero(int id, string nombre, string apellido, string cedula, string telefono) : base(id, nombre, apellido, cedula, telefono) { }
    }
}
