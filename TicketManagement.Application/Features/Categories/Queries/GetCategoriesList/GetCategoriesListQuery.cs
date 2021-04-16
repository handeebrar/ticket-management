using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TicketManagement.Application.Features.Categories.Queries.GetCategoriesList
{
    public class GetCategoriesListQuery : IRequest<List<CategoryListViewModel>>
    {
    }
}
