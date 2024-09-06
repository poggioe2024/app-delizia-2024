using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Producto
    {
        private int id;
        private string nombre;
        private string descripcion;
        private float precio;
        private TipoProducto tipo_de_producto;

        public Producto(int id, string nombre, string descripcion, float precio, TipoProducto tipo_de_producto)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.tipo_de_producto = tipo_de_producto;
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
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private TipoProducto Tipo_De_Producto
        {
            get { return tipo_de_producto; }
            set { tipo_de_producto = value; }
        }
    }
}