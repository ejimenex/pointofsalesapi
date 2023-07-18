

using MediatR;
using Microsoft.AspNetCore.Mvc;
using PointOfSales.Application.Features.MyDataCrud.Command.CreateCommand;
using PointOfSales.Application.Features.MyDataCrud.Command.UpdateCommand;
using PointOfSales.Application.Features.MyDataCrud.Queries.GetMyDataByEmail;

namespace PointOfSales.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyDataController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MyDataController(IMediator mediator)
        {
            _mediator = mediator;
        }
    
        [HttpPost]
        public async Task<ActionResult<Guid>> Create(CreateMyDataCommand createMyDataCommand)
        {
            var response = await _mediator.Send(createMyDataCommand);
            return Ok(response);
        }
       
        [HttpGet("GetById")]
        public async Task<ActionResult<GetByEmailVm>> GetById()
        {
            return Ok(await _mediator.Send(new MyDataByEmailQuery()));
        }

        [HttpPut]
        public async Task<ActionResult> Update(MyDataUpdateCommand updateMyDataCommand)
        {
            await _mediator.Send(updateMyDataCommand);
            return NoContent();
        }
     
    }
}
