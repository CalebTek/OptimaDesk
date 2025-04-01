using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OptimaDesk.Application.RetailStation.Pumps.Commands.AddPump;

namespace OptimaDesk.Api.Controllers
{
    public class PumpController : ApiController
    {
        [AllowAnonymous]
        [HttpPost("add-pump")]
        public async Task<IActionResult> AddPump([FromBody] AddPumpCommand command)
        {
            return await Initiate(() => Mediator.Send(command));
        }
    }
}
