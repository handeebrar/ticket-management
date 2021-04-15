using MediatR;
using System.Collections.Generic;

namespace TicketManagement.Application.Features.Events
{
    public class GetEventsListQuery : IRequest<List<EventListViewModel>>
    {
    }
}
