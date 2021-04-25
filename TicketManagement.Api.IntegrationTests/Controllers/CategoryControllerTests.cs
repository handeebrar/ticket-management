using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using TicketManagement.Api.IntegrationTests.Base;
using TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using Xunit;

namespace TicketManagement.Api.IntegrationTests.Controllers
{
    public class CategoryControllerTests : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly CustomWebApplicationFactory<Startup> _factory;

        public CategoryControllerTests(CustomWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task ReturnsSuccessResult()
        {
            var client = _factory.GetAnonymousClient();
            var response = await client.GetAsync("/api/category/all");

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<CategoryListViewModel>>(responseString);

            Assert.IsType<List<CategoryListViewModel>>(result);
            Assert.NotEmpty(result);
        }
    }
}
