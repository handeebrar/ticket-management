using Moq;
using System;
using System.Collections.Generic;
using TicketManagement.Application.Contracts.Persistence;
using TicketManagement.Domain.Entities;

namespace TicketManagement.Application.UnitTests.Mocks
{
    public class RepositoryMocks
    {
        public static Mock<IAsyncRepository<Category>> GetCategoryRepository()
        {
            var concertGuid = Guid.Parse("{1DF4ACF8-3E7C-4D7F-AB09-00E57C216A64}");
            var musicalGuid = Guid.Parse("{A156114E-900D-4140-BFA8-8C6BC781785A}");
            var playGuid = Guid.Parse("{E7698125-BEE1-4B8C-BDDF-F05D6AD7019E}");
            var conferenceGuid = Guid.Parse("{977CB544-96F1-4EB2-96B4-CAF1402D4060}");

            var categories = new List<Category>
            {
                new Category
                {
                    CategoryId = concertGuid,
                    Name = "Concerts"
                },
                new Category
                {
                    CategoryId = musicalGuid,
                    Name = "Musicals"
                },
                new Category
                {
                    CategoryId = playGuid,
                    Name = "Plays"
                },
                new Category
                {
                    CategoryId = conferenceGuid,
                    Name = "Conferences"
                },
            };

            var mockCategoryRepository = new Mock<IAsyncRepository<Category>>();

            mockCategoryRepository.Setup(repo => repo.ListAllAsync()).ReturnsAsync(categories);
            mockCategoryRepository.Setup(repo => repo.AddAsync(It.IsAny<Category>())).ReturnsAsync(
                (Category category) =>
                {
                    categories.Add(category);
                    return category;
                });

            return mockCategoryRepository;
        }
    }
}
