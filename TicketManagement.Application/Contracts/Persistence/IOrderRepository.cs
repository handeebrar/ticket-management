using System;
using System.Collections.Generic;
using System.Text;
using TicketManagement.Domain.Entities;

namespace TicketManagement.Application.Contracts.Persistence
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
    }
}
