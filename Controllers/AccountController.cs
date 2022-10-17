using Biblioteca.Domain.Models;
using Biblioteca.Infra.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class AccountController
    {
        [ApiController]
        [Route("v1")]
        public class LoginController : ControllerBase
        {
            [HttpPost]
            [Route("login")]
            public async Task<ActionResult<dynamic>> AuthenticateAsync([FromBody] Usuario usuario)
            {
                var user = UsuarioRepository.Get(usuario.Username, usuario.Password);
                if (user == null)
                    return NotFound(new { message = "Usuário ou senha inválidos." });

                //Gera o Token
                var token = TokenService.GenerateToken(user);

                //oculta senha
                user.Password = "";

                //Retorna os dados
                return new
                {
                    user = user,
                    token = token,
                };

            }

        }
    }
}
