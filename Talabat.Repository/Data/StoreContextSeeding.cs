﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Talabat.Core.Entities;
using Talabat.Core.Entities.Order_Aggregate;

namespace Talabat.Repository.Data
{
    public class StoreContextSeeding
    {
        public static async Task SeedAsync(StoreContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if (!context.ProductBrands.Any())
                {
                    var brandsData = File.ReadAllText("../Talabat.Repository/Data/DataSeed/brands.json");
                    var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);

                    foreach (var brand in brands)
                        await context.Set<ProductBrand>().AddAsync(brand);

                    context.SaveChanges();
                }

                if (!context.ProductTypes.Any())
                {
                    var typesData = File.ReadAllText("../Talabat.Repository/Data/DataSeed/types.json");
                    var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);

                    foreach (var type in types)
                        await context.Set<ProductType>().AddAsync(type);

                    context.SaveChanges();
                }

                if (!context.Products.Any())
                {
                    var productsData = File.ReadAllText("../Talabat.Repository/Data/DataSeed/products.json");
                    var products = JsonSerializer.Deserialize<List<Product>>(productsData);

                    foreach (var product in products)
                        await context.Set<Product>().AddAsync(product);

                    context.SaveChanges();
                }

                if (!context.DeliveryMethods.Any())
                {
                    var deliveryMethodsData = File.ReadAllText("../Talabat.Repository/Data/DataSeed/delivery.json");
                    var deliveryMethods = JsonSerializer.Deserialize<List<DeliveryMethod>>(deliveryMethodsData);

                    foreach (var method in deliveryMethods)
                        await context.Set<DeliveryMethod>().AddAsync(method);

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSeeding>();
                logger.LogError(ex, ex.Message);
            }

        }
    }
}

