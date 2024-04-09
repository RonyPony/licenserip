using licenciador.Models;
using licenciador.Services;
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

        [HttpGet("get_token")]
        public async Task<ActionResult<Token>> GetTokenAsync()
        {
            // Consulta el token desde la base de datos utilizando el servicio
            var token = await _tokenService.GetTokenAsync();

            if (token == null)
            {
                return NotFound();
            }

            return Ok(token);
        }
    }
}
