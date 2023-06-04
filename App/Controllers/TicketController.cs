using FarmaciasUwU.App.Models;
using FarmaciasUwU.App.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciasUwU.App.Controllers
{
    public class TicketController
    {
        public static List<object> Create(int userId, float total, Dictionary<string, ProductoStruct> productos)
        {
            Connection db = new Connection();
            Ticket ticket = new ()
            {
                UserId = userId,
                Total = total,
                CreatedAt = DateTime.Now,
            };
            
            List<TicketDetails> ticketDetails = new List<TicketDetails>();
            db.Tickets.Add(ticket);
            db.SaveChanges();
            foreach (var producto in productos)
            {
                Producto? p = db.Productos.Find(producto.Value.Id);
                if (producto.Value.Cantidad > p.Cantidad)
                {
                    db.Tickets.Remove(ticket);
                    db.SaveChanges ();
                    throw new ArgumentException($"La cantidad no puede ser mayor a la disponible para el producto \"{p.Nombre}\"");
                }
                p.Cantidad -= producto.Value.Cantidad;
                db.Productos.Update(p);
                TicketDetails details = new()
                {
                    TicketId = ticket.Id,
                    ProductId = producto.Value.Id,
                    Cantidad = producto.Value.Cantidad,
                    Subtotal = producto.Value.SubTotal,
                };
                ticketDetails.Add(details);
                db.TicketDetails.Add(details);
            }

            List<object> result = new()
            {
                ticket,
                ticketDetails
            };

            db.SaveChanges();
            return result;
        }

    }
}
