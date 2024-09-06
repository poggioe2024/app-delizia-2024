using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private string telefono;
        private string direccion;
        private string detalle;

        public Cliente(int id, string nombre, string telefono, string direccion, string detalle)
        {
            this.id = id;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            this.detalle = detalle;
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
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
    }
}
