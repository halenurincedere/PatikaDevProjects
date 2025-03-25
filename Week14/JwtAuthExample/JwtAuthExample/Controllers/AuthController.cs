using JwtAuthExample.Data;
using JwtAuthExample.Models;
using JwtAuthExample.Services;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthExample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ITokenService _tokenService;

        public AuthController(AppDbContext context, ITokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User userInput)
        {
            var user = _context.Users.SingleOrDefault(u =>
                u.Email == userInput.Email && u.Password == userInput.Password);

            if (user == null) return Unauthorized("Geçersiz kullanıcı");

            var token = _tokenService.CreateToken(user);
            return Ok(new { token });
        }
    }
}