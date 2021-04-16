using MediatR;
using System;

namespace TicketManagement.Application.Features.Events.Queries.GetEventDetail
{
    public class GetEventDetailQuery : IRequest<EventDetailViewModel>
    {
        public Guid Id { get; set; }
    }
}
