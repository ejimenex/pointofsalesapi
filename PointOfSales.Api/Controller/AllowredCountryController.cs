using MediatR;
using Microsoft.AspNetCore.Mvc;
using PointOfSales.Application.Features.AllowedCountries.Queries;

namespace PointOfSales.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllowredCountryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AllowredCountryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<AllowedCountryVm>>> GetAllCountries()
        {
            var dots = await _mediator.Send(new GetAllowedCountryQuery());
            return Ok(dots);
        }

    }
}
