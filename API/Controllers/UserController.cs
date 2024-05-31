using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// Autenticação - Usuário
        /// </summary>
        /// <param name="username">Username do usuário</param>
        /// <param name="password">Password do usuário</param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Login(string username, string password)
        {
            return Ok(new { response = 2323});
        }
    }
}
