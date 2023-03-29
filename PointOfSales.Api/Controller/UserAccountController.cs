

using PointOfSales.Application.Features.Client.Queries.GetClientPaged;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PointOfSales.Application.Features.Client.Command.CreateClient;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using PointOfSales.Application.Features.Client.Queries.GetClientList;
using PointOfSales.Application.Features.Client.Command.UpdateCommand;
using System;
using PointOfSales.Application.Features.Client.Command.DeleteCommand;
using PointOfSales.Application.Features.Account.Command.CreateAccountCommand;
using PointOfSales.Application.Features.Account.Command.ChangePasswordCommand;

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
