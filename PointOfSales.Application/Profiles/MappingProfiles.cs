using PointOfSales.Application.Features.Events.Commands.CreateEvent;
using PointOfSales.Application.Features.Events.Commands.DeleteEvent;
using PointOfSales.Application.Features.Events.Commands.UpdateEvent;
using PointOfSales.Application.Features.Events.Queries.GetEventDetail;
using PointOfSales.Application.Features.Events.Queries.GetEventList;

namespace PointOfSales.Application.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();

            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, DeleteEventCommand>().ReverseMap();
        }

    }
}
