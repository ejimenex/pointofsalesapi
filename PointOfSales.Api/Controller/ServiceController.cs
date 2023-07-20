

using MediatR;
using Microsoft.AspNetCore.Mvc;
using PointOfSales.Application.Features.Client.Command.CreateClient;
using PointOfSales.Application.Features.Client.Command.DeleteCommand;
using PointOfSales.Application.Features.Client.Command.UpdateCommand;
using PointOfSales.Application.Features.Client.Queries.GetClientById;
using PointOfSales.Application.Features.Client.Queries.GetClientList;
using PointOfSales.Application.Features.Client.Queries.GetClientPaged;
using PointOfSales.Application.Features.Service.Command.CreateService;

namespace PointOfSales.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ServiceController(IMediator mediator)
        {
            _mediator = mediator;
        }
        //[HttpGet("all", Name = "GetAllCategories")]
        //[ProducesDefaultResponseType]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //public async Task<ActionResult<List<GetClientListVm>>> GetAllCategories()
        //{
        //    var dots = await _mediator.Send(new GetClientQuery());
        //    return Ok(dots);
        //}
      
        [HttpPost]
        public async Task<ActionResult<CreateServiceCommandResponse>> Create(CreateServiceCommand createServiceCommand)
        {
            var response = await _mediator.Send(createServiceCommand);
            return Ok(response);
        }
        //[HttpGet("GetPaged")]
        //public async Task<ActionResult<GetClintPageVm>> GetPaged(int page = 1, int size = 10, string filter = "")
        //{
        //    if (filter is null) filter = "";
        //    return Ok(await _mediator.Send(new GetClientPagedQuery() { Filter = filter, Page = page, Size = size }));
        //}
        //[HttpGet("{Id}")]
        //public async Task<ActionResult<GetClientByIdVm>> GetById(Guid Id)
        //{
        //    return Ok(await _mediator.Send(new GetClientByIdQuery() { Id = Id }));
        //}

        //[HttpPut]
        //public async Task<ActionResult> Update(UpdateClientCommand updateClientCommand)
        //{
        //    await _mediator.Send(updateClientCommand);
        //    return NoContent();
        //}
        //[HttpDelete]
        //public async Task<ActionResult> Delete(Guid id)
        //{
        //    var deleteEventCommand = new DeleteClientCommand() { Id = id };
        //    await _mediator.Send(deleteEventCommand);
        //    return NoContent();
        //}

    }
}
