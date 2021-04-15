using System;
using System.Collections.Generic;
using System.Text;

namespace TicketManagement.Application.Features.Events
{
    public class EventListViewModel
    {
        public Guid EventId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string ImageUrl { get; set; }
    }
}
