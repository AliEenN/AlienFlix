using AlienFlix.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlienFlix.Models
{
    public class SeedingData
    {
        private ApplicationDbContext _context;

        public SeedingData(ApplicationDbContext context)
        {
            _context = context;
        }

        public async void SeedAdminUser()
        {
            var user = new IdentityUser
            {
                Id = "86f344cd-5168-4c2f-8dfb-0eef5bebc743",
                UserName = "ali.nasser.9.1997@gmail.com",
                NormalizedUserName = "ALI.NASSER.9.1997@GMAIL.COM",
                Email = "ali.nasser.9.1997@gmail.com",
                NormalizedEmail = "ALI.NASSER.9.1997@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAELH/5/Lc/L9C2NRodOWyyacXumgzwWHnqBCkzsboQ52TtT2j5SgpbkYt+Cx6QrvbCw==",
                SecurityStamp = "FBX4JWID5VXCSPGFVFRGG2X7KZC2OFND",
                ConcurrencyStamp = "8d8d1c60-048d-484e-9e9a-4e46a87d3a6f",
                LockoutEnabled = true
            };

            var roleStore = new RoleStore<IdentityRole>(_context);

            if (!_context.Roles.Any(e => e.Name == "Admin"))
            {
                await roleStore.CreateAsync(new IdentityRole { Name = "Admin", NormalizedName = "Admin".ToUpper() });
            }

            if (!_context.Roles.Any(e => e.Name == "Manager"))
            {
                await roleStore.CreateAsync(new IdentityRole { Name = "Manager", NormalizedName = "Manager".ToUpper() });
            }

            if (!_context.Roles.Any(e => e.Name == "DataEntry"))
            {
                await roleStore.CreateAsync(new IdentityRole { Name = "DataEntry", NormalizedName = "DataEntry".ToUpper() });
            }

            if (!_context.Users.Any(e => e.UserName == user.UserName))
            {
                var userStore = new UserStore<IdentityUser>(_context);
                await userStore.CreateAsync(user);
                await userStore.AddToRoleAsync(user, "Admin");
            }

            await _context.SaveChangesAsync();
        }
    }
}
