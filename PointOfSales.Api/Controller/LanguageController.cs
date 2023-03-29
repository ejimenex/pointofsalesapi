

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
using PointOfSales.Application.Features.AllowedCountries.Queries;
using PointOfSales.Application.Features.LanguagePr.Queries.GetAllLanguage;

namespace PointOfSales.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LanguageController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<LanguageVm>>> GetAll()
        {
            var dots = await _mediator.Send(new AllLanguageQuery());
            return Ok(dots);
        }

    }
}
