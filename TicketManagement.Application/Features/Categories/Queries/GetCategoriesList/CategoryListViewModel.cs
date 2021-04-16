using System;
using System.Collections.Generic;
using System.Text;

namespace TicketManagement.Application.Features.Categories.Queries.GetCategoriesList
{
    public class CategoryListViewModel
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
    }
}
