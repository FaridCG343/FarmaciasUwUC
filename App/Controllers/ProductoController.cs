using FarmaciasUwU.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciasUwU.App.Controllers
{
    public class ProductoController
    {
        public static List<Producto> Index()
        {
            Connection db = new();
            return db.Productos.ToList();
        }

        public static Producto Create(string nombre, string descripcion, float precio, byte[] imagen, int cantidad = 0)
        {
            Connection db = new();
            Producto producto = new()
            {
                Nombre = nombre,
                Descripcion = descripcion,
                Precio = precio,
                Imagen = imagen,
                Cantidad = cantidad
            };
            db.Productos.Add(producto);
            db.SaveChanges();
            return producto;
        }

        public static Producto? Get(int id)
        {
            Connection db = new();
            Producto ?producto = db.Productos.Find(id);
            return producto;
        }

        public static Producto? Update(int id, string? nombre, string? descripcion, float? precio, byte[]? imagen, int? cantidad)
        {
            Connection db = new();
            Producto? producto = db.Productos.Find(id);
            if (producto == null)
            {
                return null;
            }
            producto.Nombre = string.IsNullOrEmpty(nombre) ? producto.Nombre : nombre;
            producto.Descripcion = string.IsNullOrEmpty(descripcion) ? producto.Descripcion : descripcion;
            producto.Precio = precio ?? producto.Precio;
            producto.Imagen = imagen ?? producto.Imagen;
            producto.Cantidad = cantidad ?? producto.Cantidad;
            db.Productos.Update(producto);
            db.SaveChanges();
            return producto;
        }

        public static Producto? Update(int id, int cant)
        {
            Connection db = new();
            Producto? producto = db.Productos.Find(id);
            if (producto == null)
            {
                return null;
            }
            if (cant > producto.Cantidad)
            {
                throw new ArgumentException($"La cantidad no puede ser mayor a la disponible para el producto \"{producto.Nombre}\"");
            }
            producto.Cantidad -= cant;
            db.Productos.Update(producto);
            db.SaveChanges();
            return producto;
        }

        public static void Delete(int id)
        {
            Connection db = new();
            Producto? producto = db.Productos.Find(id);
            if (producto == null)
            {
                return;
            }
            db.Productos.Remove(producto);
            db.SaveChanges();
        }

        public static List<Producto> Filter(string nombre, string descripcion, float precioMin = 0, float precioMax = 0)
        {
            Connection db = new();
            var query = db.Productos.Select(x => x);
            query = string.IsNullOrEmpty(nombre) ? query : query.Where(x => x.Nombre.Contains(nombre));
            query = string.IsNullOrEmpty(descripcion) ? query : query.Where(x => x.Descripcion.Contains(descripcion));
            query = precioMin == 0 ? query : query.Where(x => x.Precio >= precioMin);
            query = precioMax == 0 ? query : query.Where(x => x.Precio <= precioMax);
            return query.ToList();
        }
    }
}
