using Clinic.Common;
using Clinic.Domain.Entities;
using Clinic.Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Clinic.Infrastructure.Data;

public static class DbInitializer
{
    public static async Task Initialize(IServiceProvider serviceProvider)
    {
        var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
        var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        var context = serviceProvider.GetRequiredService<ClinicDbContext>();

        // --- Seed Roles ---
        string[] roleNames = { "Admin", "Client", "Veterinarian", "Receptionist", "Surgeon" };
        foreach (var roleName in roleNames)
            if (!await roleManager.RoleExistsAsync(roleName))
                await roleManager.CreateAsync(new IdentityRole(roleName));

        // --- Seed Admin User ---
        if (await userManager.FindByEmailAsync("admin@clinic.com") == null)
        {
            var adminUser = new ApplicationUser
            {
                UserName = "admin@clinic.com",
                Email = "admin@clinic.com",
                FirstName = "Admin",
                LastName = "User",
                EmailConfirmed = true
            };

            var result = await userManager.CreateAsync(adminUser, "Admin123!");

            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(adminUser, "Admin");

                // Create a corresponding Staff record
                var staffRecord = new Staff
                {
                    FirstName = adminUser.FirstName,
                    LastName = adminUser.LastName,
                    Role = "Administrator",
                    ApplicationUserId = adminUser.Id
                };
                context.Staff.Add(staffRecord);
                await context.SaveChangesAsync();
            }
        }
    }
}