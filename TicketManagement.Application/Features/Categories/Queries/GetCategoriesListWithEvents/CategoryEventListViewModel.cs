using System;
using System.Collections.Generic;

namespace TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class CategoryEventListViewModel
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<CategoryEventDto> Events { get; set; }
    }
}
