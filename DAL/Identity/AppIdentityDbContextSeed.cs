﻿
using DAL.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace DAL.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if(!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Abanoub",
                    Email = "abanoub@gmail.com",
                    UserName = "abanoub@gmail.com",
                    Address = new Address
                    {
                        FirstName = "Abanoub",
                        LastName = "Nabil",
                        Street = "Gomhorya",
                        City = "Assiut",
                        State = "EG",
                        ZipCode = "71111"

                    }
                };
                await userManager.CreateAsync(user, "P@ssw0rd");
            }
        }
    }
}
