using AutoMapper;
using TicketManagement.Application.Features.Events;
using TicketManagement.Domain.Entities;

namespace TicketManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListViewModel>().ReverseMap();
            CreateMap<Event, EventDetailViewModel>().ReverseMap();
            CreateMap<Category, CategoryDto>();
        }
    }
}
