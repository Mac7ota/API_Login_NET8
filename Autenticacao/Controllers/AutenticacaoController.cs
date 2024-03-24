using Microsoft.AspNetCore.Mvc;
using Service.Autenticacao.Interfaces;

namespace Autenticacao.Controllers
{
    [ApiController]
    [Route("api/autenticacao")]
    public class AutenticacaoController : ControllerBase
    {
        private readonly IUserService userService;

        [HttpPost]
        [Route("api/autenticacao/login")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public IActionResult Login([FromBody] DTOs.Autenticacao.UserLoginRequest userRequest)
        {
            var response = userService.Login(userRequest);
            return Ok(response);
        }

    }
}
