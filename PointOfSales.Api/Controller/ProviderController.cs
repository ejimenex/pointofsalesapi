using MediatR;
using Microsoft.AspNetCore.Mvc;
using PointOfSales.Application.Features.Client.Command.CreateProvider;
using PointOfSales.Application.Features.Client.Command.DeleteProviderCommand;
using PointOfSales.Application.Features.Client.Command.UpdateProvider;
using PointOfSales.Application.Features.Client.Queries.GetProviderById;
using PointOfSales.Application.Features.Client.Queries.GetProviderPaged;

namespace PointOfSales.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProviderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<CreateProviderCommandResponse>> Create(CreateProviderCommand createCategoryCommand)
        {
            var response = await _mediator.Send(createCategoryCommand);
            return Ok(response);
        }
        [HttpGet("GetPaged")]
        public async Task<ActionResult<GetProviderPageVm>> GetPaged(int page = 1, int size = 10, string filter = "")
        {
            if (filter is null) filter = "";
            return Ok(await _mediator.Send(new GetProviderPagedQuery() { Filter = filter, Page = page, Size = size }));
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<GetProviderByIdVm>> GetById(Guid Id)
        {
            return Ok(await _mediator.Send(new GetProviderByIdQuery() { Id = Id }));
        }

        [HttpPut]
        public async Task<ActionResult> Update(UpdateProviderCommand updateProviderCommand)
        {
            await _mediator.Send(updateProviderCommand);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleteCommand = new DeleteProviderCommand() { Id = id };
            await _mediator.Send(deleteCommand);
            return NoContent();
        }

    }
}
