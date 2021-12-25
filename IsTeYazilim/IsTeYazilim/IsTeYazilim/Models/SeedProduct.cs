using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IsTeYazilim.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace IsTeYazilim.Models
{
    public class SeedProduct
    {
        public static void Seed (IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                if (!context.Products.Any())
                {
                    context.Products.AddRange(
                        new Product() { Name = "POSPAD 101", CategoryID = 1, Price = 50 },
                        new Product() { Name = "İNGENİCO İWE 280", CategoryID = 2, Price = 40 },
                        new Product() { Name = "Yazar Kasa 220TR", CategoryID = 3, Price = 30 },
                        new Product() { Name = "OLİVETTİ PBT900", CategoryID = 4, Price = 35 },
                        new Product() { Name = "Verifone", CategoryID = 1, Price = 20 },
                        new Product() { Name = "İnfotek", CategoryID = 2, Price = 20 },
                        new Product() { Name = "VERA", CategoryID = 3, Price = 20 }

                        );
                    context.SaveChanges();
                }
            }
        }
    }
}
