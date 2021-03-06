﻿// <auto-generated />
using Catalog.API.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Catalog.API.Migrations
{
    [DbContext(typeof(CatalogContext))]
    [Migration("20201211174324_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Catalog.API.Models.CatalogBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CatalogBrands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Default Brand"
                        });
                });

            modelBuilder.Entity("Catalog.API.Models.CatalogItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AvailableStock")
                        .HasColumnType("int");

                    b.Property<int>("CatalogBrandId")
                        .HasColumnType("int");

                    b.Property<int>("CatalogTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxStockThreshold")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OnReorder")
                        .HasColumnType("bit");

                    b.Property<string>("PictureFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureUri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RestockThreshold")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CatalogBrandId");

                    b.HasIndex("CatalogTypeId");

                    b.ToTable("CatalogItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AvailableStock = 100,
                            CatalogBrandId = 1,
                            CatalogTypeId = 1,
                            Description = ".NET Bot Black Hoodie",
                            MaxStockThreshold = 0,
                            Name = ".NET Bot Black Hoodie",
                            OnReorder = false,
                            PictureFileName = "1.png",
                            Price = 19.5m,
                            RestockThreshold = 0
                        },
                        new
                        {
                            Id = 2,
                            AvailableStock = 100,
                            CatalogBrandId = 1,
                            CatalogTypeId = 1,
                            Description = ".NET Black & White Mug",
                            MaxStockThreshold = 0,
                            Name = ".NET Black & White Mug",
                            OnReorder = false,
                            PictureFileName = "2.png",
                            Price = 8.50m,
                            RestockThreshold = 0
                        },
                        new
                        {
                            Id = 3,
                            AvailableStock = 100,
                            CatalogBrandId = 1,
                            CatalogTypeId = 1,
                            Description = "Prism White T-Shirt",
                            MaxStockThreshold = 0,
                            Name = "Prism White T-Shirt",
                            OnReorder = false,
                            PictureFileName = "3.png",
                            Price = 12m,
                            RestockThreshold = 0
                        },
                        new
                        {
                            Id = 4,
                            AvailableStock = 100,
                            CatalogBrandId = 1,
                            CatalogTypeId = 1,
                            Description = ".NET Foundation T-shirt",
                            MaxStockThreshold = 0,
                            Name = ".NET Foundation T-shirt",
                            OnReorder = false,
                            PictureFileName = "4.png",
                            Price = 12m,
                            RestockThreshold = 0
                        },
                        new
                        {
                            Id = 5,
                            AvailableStock = 100,
                            CatalogBrandId = 1,
                            CatalogTypeId = 1,
                            Description = "Roslyn Red Sheet",
                            MaxStockThreshold = 0,
                            Name = "Roslyn Red Sheet",
                            OnReorder = false,
                            PictureFileName = "5.png",
                            Price = 8.5m,
                            RestockThreshold = 0
                        },
                        new
                        {
                            Id = 6,
                            AvailableStock = 100,
                            CatalogBrandId = 1,
                            CatalogTypeId = 1,
                            Description = ".NET Blue Hoodie",
                            MaxStockThreshold = 0,
                            Name = ".NET Blue Hoodie",
                            OnReorder = false,
                            PictureFileName = "6.png",
                            Price = 12m,
                            RestockThreshold = 0
                        },
                        new
                        {
                            Id = 7,
                            AvailableStock = 100,
                            CatalogBrandId = 1,
                            CatalogTypeId = 1,
                            Description = "Roslyn Red T-Shirt",
                            MaxStockThreshold = 0,
                            Name = "Roslyn Red T-Shirt",
                            OnReorder = false,
                            PictureFileName = "7.png",
                            Price = 12m,
                            RestockThreshold = 0
                        },
                        new
                        {
                            Id = 8,
                            AvailableStock = 100,
                            CatalogBrandId = 1,
                            CatalogTypeId = 1,
                            Description = "Kudu Purple Hoodie",
                            MaxStockThreshold = 0,
                            Name = "Kudu Purple Hoodie",
                            OnReorder = false,
                            PictureFileName = "8.png",
                            Price = 8.5m,
                            RestockThreshold = 0
                        },
                        new
                        {
                            Id = 9,
                            AvailableStock = 100,
                            CatalogBrandId = 1,
                            CatalogTypeId = 1,
                            Description = "Cup<T> White Mug",
                            MaxStockThreshold = 0,
                            Name = "Cup<T> White Mug",
                            OnReorder = false,
                            PictureFileName = "9.png",
                            Price = 12m,
                            RestockThreshold = 0
                        },
                        new
                        {
                            Id = 10,
                            AvailableStock = 100,
                            CatalogBrandId = 1,
                            CatalogTypeId = 1,
                            Description = ".NET Foundation Sheet",
                            MaxStockThreshold = 0,
                            Name = ".NET Foundation Sheet",
                            OnReorder = false,
                            PictureFileName = "10.png",
                            Price = 12m,
                            RestockThreshold = 0
                        },
                        new
                        {
                            Id = 11,
                            AvailableStock = 100,
                            CatalogBrandId = 1,
                            CatalogTypeId = 1,
                            Description = "Cup<T> Sheet",
                            MaxStockThreshold = 0,
                            Name = "Cup<T> Sheet",
                            OnReorder = false,
                            PictureFileName = "11.png",
                            Price = 8.5m,
                            RestockThreshold = 0
                        },
                        new
                        {
                            Id = 12,
                            AvailableStock = 100,
                            CatalogBrandId = 1,
                            CatalogTypeId = 1,
                            Description = "Prism White TShirt",
                            MaxStockThreshold = 0,
                            Name = "Prism White TShirt",
                            OnReorder = false,
                            PictureFileName = "12.png",
                            Price = 12m,
                            RestockThreshold = 0
                        });
                });

            modelBuilder.Entity("Catalog.API.Models.CatalogType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CatalogTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Default Type"
                        });
                });

            modelBuilder.Entity("Catalog.API.Models.CatalogItem", b =>
                {
                    b.HasOne("Catalog.API.Models.CatalogBrand", "CatalogBrand")
                        .WithMany()
                        .HasForeignKey("CatalogBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Catalog.API.Models.CatalogType", "CatalogType")
                        .WithMany()
                        .HasForeignKey("CatalogTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CatalogBrand");

                    b.Navigation("CatalogType");
                });
#pragma warning restore 612, 618
        }
    }
}
