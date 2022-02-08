using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.NET_Angular.Core.DbModels.Identity;
using Microsoft.AspNetCore.Identity;

namespace ECommerce.NET_Angular.Infrastructure.DataContext
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Berkay",
                    Email = "kulakberkay15@gmail.com",
                    UserName = "kulakberkay15",
                    Address = new Address
                    {
                        FirstName = "Berkay",
                        LastName = "Kulak",
                        Street = "Fevziçakmak",
                        City = "Burdur",
                        State = "TR",
                        ZipCode = "15000",
                    }
                };

                await userManager.CreateAsync(user,"A123456");
            }
        }
    }
}
