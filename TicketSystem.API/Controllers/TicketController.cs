using Microsoft.AspNetCore.Mvc;
using TicketSystem.API.Services;
using TicketSystem.Core.DTOs;
using TicketSystem.Core.DTOs.TicketSystem.Core.DTOs;

namespace TicketSystem.API.Controllers
{
    [Route("api/ticket")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly TicketService _service;

        public TicketController(TicketService service)
        {
            _service = service;
        }

        // CREATE TICKET
        [HttpPost]
        public async Task<IActionResult> Create(TicketDto dto, int userId)
        {
            await _service.CreateTicket(dto, userId);
            return Ok("Ticket Created");
        }

        //  GET ALL TICKETS
        [HttpGet]
        public async Task<IActionResult> GetTickets(int userId, string role)
        {
            var tickets = await _service.GetTickets(userId, role);
            return Ok(tickets);
        }

        //  GET SINGLE TICKET
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTicket(int id)
        {
            var ticket = await _service.GetTicketById(id);

            if (ticket == null)
                return NotFound("Ticket not found");

            return Ok(ticket);
        }

        //  ASSIGN TICKET (FIXED HERE)
        [HttpPut("assign")]
        public async Task<IActionResult> AssignTicket(int ticketId, int userId)
        {
            if (ticketId <= 0 || userId <= 0)
            {
                return BadRequest("Invalid ticketId or userId");
            }

            var result = await _service.AssignTicket(ticketId, userId); //  FIXED

            if (!result)
            {
                return NotFound("Ticket not found");
            }

            return Ok(new
            {
                message = "Ticket assigned successfully",
                ticketId = ticketId,
                assignedTo = userId
            });
        }

        //  UPDATE STATUS
        [HttpPut("status")]
        public async Task<IActionResult> UpdateStatus(int ticketId, string status)
        {
            try
            {
                await _service.UpdateStatus(ticketId, status);
                return Ok("Status Updated");
            } 
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //  ADD COMMENT
        [HttpPost("comment")]
        public async Task<IActionResult> AddComment(int ticketId, string message, int userId)
        {
            await _service.AddComment(ticketId, message, userId);
            return Ok("Comment added");
        }

        //  GET HISTORY
        [HttpGet("history/{ticketId}")]
        public async Task<IActionResult> GetHistory(int ticketId)
        {
            var history = await _service.GetHistory(ticketId);
            return Ok(history);
        }
    }
}