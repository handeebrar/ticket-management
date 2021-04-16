using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TicketManagement.Domain.Entities;

namespace TicketManagement.Application.Contracts.Persistence
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
        Task<List<Category>> GetCategoriesWithEvents(bool includeHistory);
    }
}
