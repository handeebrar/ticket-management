using MediatR;
using System.Collections.Generic;

namespace TicketManagement.Application.Features.Events.Queries.GetEventsList
{
    public class GetEventsListQuery : IRequest<List<EventListViewModel>>
    {
    }
}
