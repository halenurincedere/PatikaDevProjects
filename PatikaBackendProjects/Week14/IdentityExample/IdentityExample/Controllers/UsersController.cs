using Microsoft.AspNetCore.Mvc;
using IdentityExample.Models;
using IdentityExample.Data;
using Microsoft.AspNetCore.DataProtection;

namespace IdentityExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IDataProtector _protector;

        public UsersController(AppDbContext context, IDataProtectionProvider provider)
        {
            _context = context;
            _protector = provider.CreateProtector("user.password.protector");
        }

        [HttpPost]
        public IActionResult Register([FromBody] User user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            user.Password = _protector.Protect(user.Password);
            _context.Users.Add(user);
            _context.SaveChanges();

            return Ok("Kullanıcı kaydedildi.");
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _context.Users.ToList();
            return Ok(users);
        }
    }
}