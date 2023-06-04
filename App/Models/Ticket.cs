using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciasUwU.App.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        public float Total { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [ForeignKey("UserId")]
        public virtual Usuario Usuario { get; set; }
    }
}
