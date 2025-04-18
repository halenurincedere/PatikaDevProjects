using JwtAuthExample.Models;

namespace JwtAuthExample.Services
{
    public interface ITokenService
    {
        string? CreateToken(User user);
    }
}
