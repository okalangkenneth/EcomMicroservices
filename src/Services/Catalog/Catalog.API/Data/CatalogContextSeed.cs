using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {

            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }

        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "iPhone 12 Pro Max",
                    Category = "Smart phone",
                    Summary = "The latest iPhone with advanced features and technology.",
                    Description = "The iPhone 12 Pro Max features a 6.7-inch OLED Super Retina XDR display, A14 Bionic chip, and 12 MP ultra-wide, wide, and telephoto cameras.",
                    ImageFile = "iphone12promax.jpg",
                    Price = 1179.00m
                },
                new Product
                {
                    Id = "602d2149e773f2a3990b47f6",
                    Name = "Samsung Galaxy S21 Ultra",
                    Category = "Smart phone",
                    Summary = "The latest Samsung smartphone with advanced features and technology.",
                    Description = "The Samsung Galaxy S21 Ultra features a 6.8-inch Dynamic AMOLED 2X display, Exynos 2100 or Snapdragon 888 chip, and four rear cameras.",
                    ImageFile = "samsunggalaxys21ultra.jpg",
                    Price = 1299.99m
                },
                new Product
                {
                    Id = "602d2149e773f2a3990b47f7",
                    Name = "Google Pixel 6 Pro",
                    Category = "White Appliance",
                    Summary = "The latest Google smartphone with advanced features and technology.",
                    Description = "The Google Pixel 6 Pro features a 6.4-inch AMOLED display, Dimensity 1200 chip, and three rear cameras.",
                    ImageFile = "googlepixel6pro.jpg",
                    Price = 999.00m
                },
                new Product
                {
                    Id = "602d2149e773f2a3990b47f8",
                    Name = "OnePlus 9 Pro",
                    Category = "White Appliance",
                    Summary = "The latest OnePlus smartphone with advanced features and technology.",
                    Description = "The OnePlus 9 Pro features a 6.7-inch Fluid AMOLED display, Snapdragon 888 chip, and three rear cameras.",
                    ImageFile = "oneplus9pro.jpg",
                    Price = 799.00m
                },
                new Product
                {
                    Id = "602d2149e773f2a3990b47f9",
                    Name = "Huawei Mate 40 Pro",
                    Category = "Smart phone",
                    Summary = "The latest Huawei smartphone with advanced features and technology.",
                    Description = "The Huawei Mate 40 Pro features a 6.76-inch OLED display, Kirin 9000 chip, and three rear cameras.",
                    ImageFile = "huaweimate40pro.jpg",
                    Price = 999.00m
                },
                new Product
                {
                    Id = "602d2149e773f2a3990b47fa",
                    Name = "Xiaomi Mi 11",
                    Category = "Home Kitchen",
                    Summary = "The latest Xiaomi smartphone with advanced features and technology.",
                    Description = "The Xiaomi Mi 11 features a 6.81-inch AMOLED display, Snapdragon 888 chip, and three rear cameras.",
                    ImageFile = "xiaomimi11.jpg",
                    Price = 699.00m
                }
            };
        }
    }
}
