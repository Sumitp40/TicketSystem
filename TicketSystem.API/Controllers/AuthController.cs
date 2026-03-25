using Microsoft.AspNetCore.Mvc;
using TicketSystem.Infrastructure.Data;
using TicketSystem.Core.DTOs;
using System.Linq;
using TicketSystem.Core.DTOs.TicketSystem.Core.DTOs;

namespace TicketSystem.API.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDto request)
        {
            if (string.IsNullOrEmpty(request.Email) || string.IsNullOrEmpty(request.Password))
                return BadRequest("Email and password required");

            var user = _context.Users
                .FirstOrDefault(u => u.Email == request.Email && u.Password == request.Password);

            if (user == null)
                return Unauthorized("Invalid credentials");

            return Ok(new
            {
                user.Id,
                user.Name,
                user.Role
            });
        }
    }
}