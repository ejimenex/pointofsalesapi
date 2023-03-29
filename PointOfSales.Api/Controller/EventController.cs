//using PointOfSales.Application.Features.Events.Commands.CreateEvent;
//using PointOfSales.Application.Features.Events.Commands.DeleteEvent;
//using PointOfSales.Application.Features.Events.Commands.UpdateEvent;
//using PointOfSales.Application.Features.Events.Queries.GetEventDetail;
//using PointOfSales.Application.Features.Events.Queries.GetEventList;
//using MediatR;
//using Microsoft.AspNetCore.Mvc;

//namespace PointOfSales.Api.Controller
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class EventController : ControllerBase
//    {
//        private readonly IMediator _mediator;

//        public EventController(IMediator mediator)
//        {
//            _mediator = mediator;
//        }
//        [HttpGet("all", Name = "GetAllEvents")]
//        [ProducesDefaultResponseType]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        public async Task<ActionResult<List<EventListVm>>> GetAllEvents()
//        {
//            var dots = await _mediator.Send(new GetEventListQuery());
//            return Ok(dots);
//        }
//        [HttpGet("{id}")]
//        [ProducesDefaultResponseType]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        public async Task<ActionResult<List<EventDetailVm>>> GetEventById(Guid guid)
//        {
//            var detail = new GetEvenDetailQuery() { Id = guid };
//            var dto = await _mediator.Send(detail);
//            return Ok(dto);
//        }
//        [HttpPost]
//        public async Task<ActionResult<Guid>> Create(CreateEventCommand createEventCommand)
//        {
//            var response = await _mediator.Send(createEventCommand);
//            return Ok(response);
//        }
//        [HttpPut]
//        public async Task<ActionResult> Update(UpdateEventCommand updateeEventCommand)
//        {
//            await _mediator.Send(updateeEventCommand);
//            return NoContent();
//        }
//        [HttpDelete]
//        public async Task<ActionResult> Delete(Guid id)
//        {
//            var deleteEventCommand = new DeleteEventCommand() { EventId = id };
//            await _mediator.Send(deleteEventCommand);
//            return NoContent();
//        }

//    }
//}
