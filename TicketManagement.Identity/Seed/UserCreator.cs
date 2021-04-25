using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using TicketManagement.Identity.Models;

namespace TicketManagement.Identity.Seed
{
    public static class UserCreator
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager)
        {
            var applicationUser = new ApplicationUser
            {
                FirstName = "Hande",
                LastName = "Gunesdogdu",
                UserName = "handeg",
                Email = "hande@test.com",
                EmailConfirmed = true
            };

            var user = await userManager.FindByEmailAsync(applicationUser.Email);
            if (user == null)
            {
                await userManager.CreateAsync(applicationUser, "He123.");
            }
        }
    }
}
