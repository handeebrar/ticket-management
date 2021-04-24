using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TicketManagement.Application.Contracts.Persistence;

namespace TicketManagement.Application.Features.Orders.Queries.GetOrdersForMonth
{
    public class GetOrdersForMonthQueryHandler : IRequestHandler<GetOrdersForMonthQuery, PagedOrdersForMonthViewModel>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public GetOrdersForMonthQueryHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<PagedOrdersForMonthViewModel> Handle(GetOrdersForMonthQuery request, CancellationToken cancellationToken)
        {
            var list = await _orderRepository.GetPagedOrdersForMonth(request.Date, request.Page, request.Size);
            var orders = _mapper.Map<List<OrdersForMonthDto>>(list);

            var count = await _orderRepository.GetTotalCountOfOrdersForMonth(request.Date);
            return new PagedOrdersForMonthViewModel() { Count = count, OrdersForMonth = orders, Page = request.Page, Size = request.Size };
        }
    }
}
