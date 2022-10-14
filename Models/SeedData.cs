using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SpoonsWorld.Data;

namespace SpoonsWorld.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SpoonsWorldContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SpoonsWorldContext>>()))
            {
                // Look for any movies.
                if (context.Spoon.Any())
                {
                    return;   // DB has been seeded
                }

                context.Spoon.AddRange(
                    new Spoon
                    {
                        Name = "Dinner Spoons",
                        Material = "Plastic",
                        Brand = "Winco",
                        weight = 300,
                        NumberOfPieces = 8,
                        Price = 18
                    },

                     new Spoon
                     {
                         Name = "Dinner Spoons",
                         Material = "Stainless Steel",
                         Brand = "Winco",
                         weight = 600,
                         NumberOfPieces = 8,
                         Price = 35
                     },

                     new Spoon
                     {
                         Name = "Soup Spoons",
                         Material = "Wooden",
                         Brand = "OXO",
                         weight = 300,
                         NumberOfPieces = 4,
                         Price = 18
                     },

                    new Spoon
                    {
                        Name = "Soup Spoons",
                        Material = "Plastic",
                        Brand = "Winco",
                        weight = 200,
                        NumberOfPieces = 4,
                        Price = 6
                    },
                     new Spoon
                     {
                         Name = "Soup Spoons",
                         Material = "Ceramic",
                         Brand = "Dowan",
                         weight = 800,
                         NumberOfPieces = 6,
                         Price = 45
                     },
                      new Spoon
                      {
                          Name = "Ice Cream Spoons",
                          Material = "Stainless Steel",
                          Brand = "Winco",
                          weight = 400,
                          NumberOfPieces = 8,
                          Price = 20
                      },
                       new Spoon
                       {
                           Name = "Dinner Spoons",
                           Material = "Plastic",
                           Brand = "Winco",
                           weight = 300,
                           NumberOfPieces = 8,
                           Price = 18
                       },
                        new Spoon
                        {
                            Name = "Disposable Spoons",
                            Material = "Wood",
                            Brand = "Txv",
                            weight = 300,
                            NumberOfPieces = 50,
                            Price = 20
                        },
                         new Spoon
                         {
                             Name = "Dessert Spoons",
                             Material = "Stainless Steel",
                             Brand = "Idomy",
                             weight = 500,
                             NumberOfPieces = 8,
                             Price = 30
                         },
                          new Spoon
                          {
                              Name = "Long Handle Spoons",
                              Material = "Plastic",
                              Brand = "ONLYKXY",
                              weight = 600,
                              NumberOfPieces = 4,
                              Price = 18
                          },
                           new Spoon
                           {
                               Name = "Black Soup Spoons",
                               Material = "plastic",
                               Brand = "Hiware",
                               weight = 300,
                               NumberOfPieces = 8,
                               Price = 22
                           }
                );
                context.SaveChanges();
            }
        }
    }
}

