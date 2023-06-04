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
            Ticket ticket = new Ticket
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
                TicketDetails details = new TicketDetails
                {
                    TicketId = ticket.Id,
                    ProductId = producto.Value.Id,
                    Cantidad = producto.Value.Cantidad,
                    Subtotal = producto.Value.SubTotal,
                };
                ticketDetails.Add(details);
                db.TicketDetails.Add(details);
            }

            List<object> result = new List<object>
            {
                ticket,
                ticketDetails
            };

            db.SaveChanges();
            return result;
        }

    }
}
