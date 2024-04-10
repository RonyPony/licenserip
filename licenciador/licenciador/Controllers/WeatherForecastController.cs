using licenciador.Models;
using licenciador.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace licenciador.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TokenController : ControllerBase
    {
        private readonly ITokenService _tokenService;

        public TokenController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("{hash}")]
        public async Task<ActionResult<Token>> GetTokenAsync(String hash)
        {
            // Consulta el token desde la base de datos utilizando el servicio
            var token = await _tokenService.GetTokenAsync(hash);

            if (token == null)
            {
                return NotFound();
            }

            return Ok(token);
        }
    }
}
