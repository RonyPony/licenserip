using licenciador.Data;
using licenciador.Models;
using Microsoft.EntityFrameworkCore;

namespace licenciador.Services
{
    public interface ITokenService
    {
        Task<Token> GetTokenAsync();
    }

    public class TokenService : ITokenService
    {
        private readonly ApplicationDbContext _context;

        public TokenService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Token> GetTokenAsync()
        {
            // Consulta el token desde la base de datos
            var token = await _context.Tokens.FirstOrDefaultAsync();

            return token;
        }

        public interface ITokenService
        {
            Task<Token> GetTokenAsync();
        }
    }
}
