using FarmaciasUwU.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciasUwU.App.Structs
{
    public class ProductoStruct
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
        private int _cantidad;
        public int Cantidad
        {
            get { return _cantidad; }
            set 
            { 
                if(value < 0)
                {
                    throw new ArgumentException("La cantidad no puede ser menor a 0");
                }
                else
                {
                    _cantidad = value;
                }
            } 
        }
        public ProductoStruct(Producto producto, int cantidad) 
        {
            Cantidad = cantidad;
            Id = producto.Id;
            Nombre = producto.Nombre;
            Descripcion = producto.Descripcion;
            Precio = producto.Precio;
        }

        public float SubTotal
        {
            get { return Cantidad * Precio; }
        }
    }
}
