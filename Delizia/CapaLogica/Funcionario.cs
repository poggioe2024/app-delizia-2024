using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Funcionario
    {
        protected int id;
        protected string nombre;
        protected string apellido;
        protected string cedula;
        protected string telefono;

        public Funcionario(int id, string nombre, string apellido, string cedula, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.telefono = telefono;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
    }
}