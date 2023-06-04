using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciasUwU.App.Models
{
    public class Connection : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketDetails> TicketDetails { get; set; }
        public Connection() : base(GetOptions())
        {
        }

        private static DbContextOptions<Connection> GetOptions()
        {
            var optionsBuilder = new DbContextOptionsBuilder<Connection>();
            optionsBuilder.UseMySql("server=localhost;port=3307;database=FarmaciasUwU;user=root;password=1234",
                new MySqlServerVersion(new Version(10, 5, 9)));
            return optionsBuilder.Options;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TicketDetails>()
                .HasKey(t => new { t.ProductId, t.TicketId });


            base.OnModelCreating(modelBuilder);
        }
    }
}
