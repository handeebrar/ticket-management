using System.Threading.Tasks;
using TicketManagement.Application.Models.Mail;

namespace TicketManagement.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
