using TicketSystem.Infrastructure.Data;
using TicketSystem.Core.Entities;
using TicketSystem.Core.DTOs;
using TicketSystem.Core.DTOs.TicketSystem.Core.DTOs;
using TicketSystem.Core.Entities.TicketSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace TicketSystem.API.Services
{
    public class TicketService
    {
        private readonly AppDbContext _context;

        public TicketService(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateTicket(TicketDto dto, int userId)
        {
            var ticket = new Ticket
            {
                TicketNumber = "TKT-" + DateTime.Now.Ticks,
                Title = dto.Title,
                Description = dto.Description,
                Priority = dto.Priority,
                Status = "Open",
                CreatedBy = userId,
                CreatedAt = DateTime.Now
            };

            await _context.Tickets.AddAsync(ticket);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Ticket>> GetTickets(int userId, string role)
        {
            if (role == "Admin")
            {
                return _context.Tickets.ToList();
            }

            return _context.Tickets
                .Where(t => t.CreatedBy == userId)
                .ToList();
        }

        public async Task<Ticket?> GetTicketById(int id)
        {
            return _context.Tickets.FirstOrDefault(t => t.Id == id);
        }

        public async Task<bool> AssignTicket(int ticketId, int userId)
        {
            var ticket = await _context.Tickets.FirstOrDefaultAsync(t => t.Id == ticketId);

            if (ticket == null)
                return false;

            // 🔥 MAIN FIX
            ticket.AssignedTo = userId;

            
            _context.Tickets.Update(ticket);

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task UpdateStatus(int ticketId, string status)
        {
            var ticket = await _context.Tickets.FindAsync(ticketId);

            if (ticket == null)
                throw new Exception("Ticket not found");

           
            ticket.Status = status;

            _context.TicketHistories.Add(new TicketHistory
            {
                TicketId = ticketId,
                Action = "Status Updated",
                Description = $"Changed to {status}",
                CreatedAt = DateTime.Now
            });

            await _context.SaveChangesAsync();
        }

        public async Task AddComment(int ticketId, string message, int userId)
        {
            var ticket = _context.Tickets.FirstOrDefault(t => t.Id == ticketId);

            if (ticket == null)
                throw new Exception("Ticket not found");

            var history = new TicketHistory
            {
                TicketId = ticketId,
                Action = "Comment",
                Description = message,
                UpdatedBy = userId,
                CreatedAt = DateTime.Now
            };

            await _context.TicketHistories.AddAsync(history);
            await _context.SaveChangesAsync();
        }

        public async Task<List<TicketHistory>> GetHistory(int ticketId)
        {
            return _context.TicketHistories
                .Where(h => h.TicketId == ticketId)
                .OrderByDescending(h => h.CreatedAt)
                .ToList();
        }
    }
}