using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OptimaDesk.Common;
using OptimaDesk.Common.Enums;
using OptimaDesk.Domain.Context;
using OptimaDesk.Domain.Users;

namespace OptimaDesk.Infrastructure.Seeder
{
    public static class SeederClass
    {
        public static async Task SeedData(IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            await RunSeed(
                serviceScope.ServiceProvider.GetService<UserManager<AppUser>>(),
                serviceScope.ServiceProvider.GetService<ApplicationContext>(),
                serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>());
        }

        private static async Task RunSeed(UserManager<AppUser> userManager, ApplicationContext context,
            RoleManager<IdentityRole> roleManager)
        {
            try
            {
                if (context != null && userManager != null && roleManager != null)
                {
                    //await context.Database.EnsureCreatedAsync();
                    if ((await context.Database.GetPendingMigrationsAsync()).Any())
                    {
                        await context.Database.MigrateAsync();
                    }


                    if (!context.Users.Any())
                    {
                        await roleManager.CreateAsync(new IdentityRole { Name = Policies.Admin });
                        await roleManager.CreateAsync(new IdentityRole { Name = Policies.SuperAdmin });
                        await roleManager.CreateAsync(new IdentityRole { Name = Policies.StationManager });

                        var controlUser = new AppUser
                        {
                            Id = Guid.NewGuid().ToString(),
                            FirstName = "John",
                            LastName = "Doe",
                            UserName = "SuperAdmin",
                            Email = "optimadesktester@gmail.com",
                            PhoneNumber = "07025783611",
                            PhoneNumberConfirmed = true,
                            Gender = Gender.Male,
                            IsActive = true,
                            Avatar = "http://placehold.it/32x32",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                            Status = Status.Active,
                            EmailConfirmed = true,
                            UserType = UserType.Control
                        };
                        await userManager.CreateAsync(controlUser, "Password@123");
                        await userManager.AddToRoleAsync(controlUser, Policies.SuperAdmin);


                        var stationManager = new AppUser
                        {
                            Id = Guid.NewGuid().ToString(),
                            FirstName = "Mark",
                            LastName = "Piercen",
                            UserName = "StationManager",
                            Email = "optimadeskstationmanager@gmail.com",
                            PhoneNumber = "08160851363",
                            PhoneNumberConfirmed = true,
                            Gender = Gender.Male,
                            IsActive = true,
                            Avatar = "http://placehold.it/32x32",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                            Status = Status.Active,
                            EmailConfirmed = true,
                            UserType = UserType.StationManager
                        };
                        await userManager.CreateAsync(stationManager, "Password@123");
                        await userManager.AddToRoleAsync(stationManager, Policies.StationManager);

                        var driver = new StationManager
                        {
                            Id = Guid.NewGuid().ToString(),
                            AppUserId = stationManager.Id,
                        };
                        await context.StationManagers.AddAsync(driver);

                        await context.SaveChangesAsync();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
