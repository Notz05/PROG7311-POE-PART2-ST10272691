using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using AgriEnergyConnect.Models;
using AgriEnergyConnect.Data;

public static class DbInitializer
{
    public static void Seed(IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        if (!context.Farmers.Any())
        {
            var farmers = new[]
            {
                new Farmer { FullName = "Tariq Maharaj", Location = "Durban" },
                new Farmer { FullName = "Aryan Lutchminarin", Location = "Turkey" },
                new Farmer { FullName = "Letahbo Mashilo", Location = "Pretoria" }
            };

            context.Farmers.AddRange(farmers);
            context.SaveChanges();
        }

        if (!context.Products.Any())
        {
            var tariqId = context.Farmers.First(f => f.FullName == "Tariq Maharaj").Id;
            var aryanId = context.Farmers.First(f => f.FullName == "Aryan Lutchminarin").Id;

            var products = new[]
            {
                new Product { Name = "Beans", Category = "Vegatable", ProductionDate = DateTime.Now.AddDays(-30), FarmerId = tariqId },
                new Product { Name = "Tomatoes", Category = "Vegetable", ProductionDate = DateTime.Now.AddDays(-15), FarmerId = aryanId },
                new Product { Name = "Wheat", Category = "Grain", ProductionDate = DateTime.Now.AddDays(-60), FarmerId = tariqId }
            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}
