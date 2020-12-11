﻿using Catalog.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Catalog.API.Infrastructure
{
    public class CatalogContext : DbContext
    {
        public CatalogContext(DbContextOptions<CatalogContext> options) : base(options)
        {
        }
        public DbSet<CatalogItem> CatalogItems { get; set; }
        public DbSet<CatalogBrand> CatalogBrands { get; set; }
        public DbSet<CatalogType> CatalogTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatalogBrand>().HasData(new CatalogBrand { Id = 1, Brand = "Default Brand" });

            modelBuilder.Entity<CatalogType>().HasData(new CatalogType { Id = 1, Type = "Default Type" });

            modelBuilder.Entity<CatalogItem>().HasData(    
                new CatalogItem { Id = 1, CatalogTypeId = 1, CatalogBrandId = 1, AvailableStock = 100, Description = ".NET Bot Black Hoodie", Name = ".NET Bot Black Hoodie", Price = 19.5M, PictureFileName = "1.png" },
                new CatalogItem { Id = 2, CatalogTypeId = 1, CatalogBrandId = 1, AvailableStock = 100, Description = ".NET Black & White Mug", Name = ".NET Black & White Mug", Price = 8.50M, PictureFileName = "2.png" },
                new CatalogItem { Id = 3, CatalogTypeId = 1, CatalogBrandId = 1, AvailableStock = 100, Description = "Prism White T-Shirt", Name = "Prism White T-Shirt", Price = 12, PictureFileName = "3.png" },
                new CatalogItem { Id = 4, CatalogTypeId = 1, CatalogBrandId = 1, AvailableStock = 100, Description = ".NET Foundation T-shirt", Name = ".NET Foundation T-shirt", Price = 12, PictureFileName = "4.png" },
                new CatalogItem { Id = 5, CatalogTypeId = 1, CatalogBrandId = 1, AvailableStock = 100, Description = "Roslyn Red Sheet", Name = "Roslyn Red Sheet", Price = 8.5M, PictureFileName = "5.png" },
                new CatalogItem { Id = 6, CatalogTypeId = 1, CatalogBrandId = 1, AvailableStock = 100, Description = ".NET Blue Hoodie", Name = ".NET Blue Hoodie", Price = 12, PictureFileName = "6.png" },
                new CatalogItem { Id = 7, CatalogTypeId = 1, CatalogBrandId = 1, AvailableStock = 100, Description = "Roslyn Red T-Shirt", Name = "Roslyn Red T-Shirt", Price = 12, PictureFileName = "7.png" },
                new CatalogItem { Id = 8, CatalogTypeId = 1, CatalogBrandId = 1, AvailableStock = 100, Description = "Kudu Purple Hoodie", Name = "Kudu Purple Hoodie", Price = 8.5M, PictureFileName = "8.png" },
                new CatalogItem { Id = 9, CatalogTypeId = 1, CatalogBrandId = 1, AvailableStock = 100, Description = "Cup<T> White Mug", Name = "Cup<T> White Mug", Price = 12, PictureFileName = "9.png" },
                new CatalogItem { Id = 10, CatalogTypeId = 1, CatalogBrandId = 1, AvailableStock = 100, Description = ".NET Foundation Sheet", Name = ".NET Foundation Sheet", Price = 12, PictureFileName = "10.png" },
                new CatalogItem { Id = 11, CatalogTypeId = 1, CatalogBrandId = 1, AvailableStock = 100, Description = "Cup<T> Sheet", Name = "Cup<T> Sheet", Price = 8.5M, PictureFileName = "11.png" },
                new CatalogItem { Id = 12, CatalogTypeId = 1, CatalogBrandId = 1, AvailableStock = 100, Description = "Prism White TShirt", Name = "Prism White TShirt", Price = 12, PictureFileName = "12.png" }
            );
        }
    }
}
