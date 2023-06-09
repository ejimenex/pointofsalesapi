﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using PointOfSales.Application.Features.UnitOfMeasure.Queries.All;

namespace PointOfSales.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitOfMeasureController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UnitOfMeasureController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<UnitOfMeasureVm>>> GetAllUnitOfMeasure()
        {
            var dots = await _mediator.Send(new UnitOfMeasureQuery());
            return Ok(dots);
        }

    }
}
