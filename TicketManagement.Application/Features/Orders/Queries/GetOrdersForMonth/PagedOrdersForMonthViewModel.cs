using System;
using System.Collections.Generic;
using System.Text;

namespace TicketManagement.Application.Features.Orders.Queries.GetOrdersForMonth
{
    public class PagedOrdersForMonthViewModel
    {
        public int Count { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
        public ICollection<OrdersForMonthDto> OrdersForMonth { get; set; }
    }
}
