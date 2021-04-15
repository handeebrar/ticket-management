using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TicketManagement.Application.Features.Events
{
    public class GetEventDetailQuery : IRequest<EventDetailViewModel>
    {
        public Guid Id { get; set; }
    }
}
