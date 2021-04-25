using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TicketManagement.Identity.Models;

namespace TicketManagement.Identity
{
    public class TicketManagementIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public TicketManagementIdentityDbContext(DbContextOptions<TicketManagementIdentityDbContext> options) : base(options)
        {
        }
    }
}
