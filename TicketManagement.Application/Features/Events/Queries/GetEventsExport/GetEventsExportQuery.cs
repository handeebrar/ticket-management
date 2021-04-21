using MediatR;

namespace TicketManagement.Application.Features.Events.Queries.GetEventsExport
{
    public class GetEventsExportQuery : IRequest<EventExportFileViewModel>
    {
    }
}
