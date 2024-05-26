﻿using Microsoft.EntityFrameworkCore;

namespace CityTourist.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            TouristDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<TouristDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Admin.Any())
            {
                context.Admin.AddRange(
                new AdminModel
                {
                    UserName = "Admin",
                    Password = "Admin",
                    Name = "Kira",
            
                });
                context.SaveChanges();
            }
          
        }
    }
}