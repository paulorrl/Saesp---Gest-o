using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SAESP.Gestao.API.Controllers.Base;
using SAESP.Gestao.Usuario.Application.Interfaces;
using SAESP.Gestao.Usuario.Domain.DomainEvent.Inputs;
using System.Threading.Tasks;

namespace SAESP.Gestao.API.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/Usuario")]
    public class UsuarioController : BaseController
    {
        private readonly IUsuarioApplication _userApp;

        public UsuarioController(IUsuarioApplication userApp)
        {
            _userApp = userApp;
        }

        [HttpPost]
        // [AllowAnonymous]
        public async Task<IActionResult> Post([FromBody] UsuarioRegisterCommand command)
        {
            _userApp.RegistrarUsuario(command);
            return null; // await Response();
        }
    }
}