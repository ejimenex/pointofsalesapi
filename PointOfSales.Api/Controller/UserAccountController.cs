using MediatR;
using Microsoft.AspNetCore.Mvc;
using PointOfSales.Application.Features.Account.Command.ChangePasswordCommand;
using PointOfSales.Application.Features.Account.Command.CreateAccountCommand;

namespace PointOfSales.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAccountController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserAccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<CreateAccountResponse>> Create(CreateAccountCommand createAccountCommand)
        {
            var response = await _mediator.Send(createAccountCommand);
            return Ok(response);
        }
        [HttpPut("ChangePassword")]
        public async Task<ActionResult<bool>> ChangePassword(ChangePasswordAccountCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

    }
}
