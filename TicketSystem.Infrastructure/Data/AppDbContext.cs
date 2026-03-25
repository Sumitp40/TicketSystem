using Microsoft.EntityFrameworkCore;
using TicketSystem.Core.Entities;
using TicketSystem.Core.Entities.TicketSystem.Core.Entities;

namespace TicketSystem.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketHistory> TicketHistories { get; set; }
    }
}