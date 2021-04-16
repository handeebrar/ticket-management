using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TicketManagement.Application.Contracts.Persistence;
using TicketManagement.Domain.Entities;

namespace TicketManagement.Application.Features.Events.Queries.GetEventDetail
{
    public class GetEventDetailQueryHandler : IRequestHandler<GetEventDetailQuery, EventDetailViewModel>
    {
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public GetEventDetailQueryHandler(IAsyncRepository<Event> eventRepository, IAsyncRepository<Category> categoryRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<EventDetailViewModel> Handle(GetEventDetailQuery request, CancellationToken cancellationToken)
        {
            var @event = await _eventRepository.GetByIdAsync(request.Id);
            var eventDetailDto = _mapper.Map<EventDetailViewModel>(@event);

            var category = await _categoryRepository.GetByIdAsync(@event.CategoryId);
            eventDetailDto.Category = _mapper.Map<CategoryDto>(category);

            return eventDetailDto;
        }
    }
}
