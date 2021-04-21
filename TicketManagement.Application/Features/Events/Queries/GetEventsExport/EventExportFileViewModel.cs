using System;
using System.Collections.Generic;
using System.Text;

namespace TicketManagement.Application.Features.Events.Queries.GetEventsExport
{
    public class EventExportFileViewModel
    {
        public string EventExportFileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }
    }
}
