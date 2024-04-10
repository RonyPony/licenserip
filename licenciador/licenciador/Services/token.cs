using licenciador.Data;
using licenciador.Models;
using Microsoft.EntityFrameworkCore;

namespace licenciador.Services
{
    public interface ITokenService
    {
        Task<Token> GetTokenAsync(String hash);
    }

    public class TokenService : ITokenService
    {
        private readonly ApplicationDbContext _context;

        public TokenService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Token> GetTokenAsync(String hsh)
        {
            // Consulta el token desde la base de datos
            //var token = await _context.Tokens.FirstOrDefaultAsync();
            var token = _context.Tokens.Where(ee => ee.hash == hsh && ee.IsValidToken).FirstOrDefault();

            return token;
        }

        public interface ITokenService
        {
            Task<Token> GetTokenAsync();
        }
    }
}
