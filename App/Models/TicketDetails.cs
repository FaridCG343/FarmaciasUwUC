using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciasUwU.App.Models
{
    [Table("ticket_details")]
    public class TicketDetails
    {
        [Column("product_id")]
        public int ProductId { get; set; }
        [Column("ticket_id")]
        public int TicketId { get; set; }
        public int Cantidad { get; set; }
        public float Subtotal { get; set; }

        [ForeignKey("ProductId")]
        public virtual Producto Producto { get; set; }

        [ForeignKey("TicketId")]
        public virtual Ticket Ticket { get; set; }
    }
}
