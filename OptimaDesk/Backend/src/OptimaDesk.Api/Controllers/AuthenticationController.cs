using AspNetCoreHero.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OptimaDesk.Application.Authentication.Login;
using System.Net;

namespace OptimaDesk.Api.Controllers
{
    public class AuthenticationController : ApiController
    {
        [AllowAnonymous]
        [ProducesResponseType(typeof(Result), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(Result), (int)HttpStatusCode.BadRequest)]
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginCommand command)
        {
            return await Initiate(() => Mediator.Send(command));
        }
    }
}
