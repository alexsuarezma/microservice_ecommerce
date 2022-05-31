using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Catalog.Presitence.Database.Configuration
{
    public class ProductConfiguration
    {
        public ProductConfiguration(EntityTypeBuilder<Product> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.ProductId);
            entityBuilder.Property(x => x.Code).IsRequired().HasMaxLength(100);
            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            //entityBuilder.Property(x => x.ProductType).IsRequired().HasMaxLength(200);
            //entityBuilder.Property(x => x.UnitOfMeasure).IsRequired().HasMaxLength(500);
            //entityBuilder.Property(x => x.PhotoPath).IsRequired().HasMaxLength(500);
            entityBuilder.Property(x => x.PriceOne).IsRequired();
            entityBuilder.Property(x => x.PriceTwo);
            entityBuilder.Property(x => x.PriceThree);
            entityBuilder.Property(x => x.Iva).IsRequired();
            entityBuilder.Property(x => x.Ice).IsRequired();

            //Seeds

            var products = new List<Product>();
            var random = new Random();

            for (var i = 1; i <100; i++)
            {
                products.Add(new Product
                {
                    ProductId = i,
                    Code = $"P00{i}",
                    Name = $"Product {i}",
                    Description = $"Description for product {i}",
                    PriceOne = random.Next(100,1000),
                    Iva = true,
                    Ice = false
                });
            }

            entityBuilder.HasData(products);
        }
    }
}
