using MediatR;
using Microsoft.AspNetCore.Mvc;
using PointOfSales.Application.Features.Login.Query.GetExistingUser;

namespace PointOfSales.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthenticationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Login")]
        public async Task<ActionResult<TokenResult>> Login(LoginQuery loginQuery)
        {
            return Ok(await _mediator.Send(loginQuery));
        }

    }
}
