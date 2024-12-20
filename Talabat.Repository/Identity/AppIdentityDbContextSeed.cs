﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entities.Identity;

namespace Talabat.Repository.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser()
                {
                    UserName = "Adham.Mohamed",
                    DisplayName = "Adham Mohamed",
                    Email = "adham@gmail.com",
                    PhoneNumber = "01122334455"
                };

                await userManager.CreateAsync(user,"P@ssw0rd");
            }
        }
    }
}
