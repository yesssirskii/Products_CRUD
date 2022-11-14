﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductsData.Entities;

#nullable disable

namespace ProductsData.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20221108183547_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProductsData.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeForeignKey")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("ProductTypeForeignKey");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Country = "COLOMBIA",
                            Name = "Spoon",
                            Price = 32,
                            ProductTypeForeignKey = 1
                        },
                        new
                        {
                            ProductId = 2,
                            Country = "CROATIA",
                            Name = "Bycicle",
                            Price = 569,
                            ProductTypeForeignKey = 2
                        },
                        new
                        {
                            ProductId = 3,
                            Country = "ITALY",
                            Name = "Necklace",
                            Price = 1600,
                            ProductTypeForeignKey = 3
                        },
                        new
                        {
                            ProductId = 4,
                            Country = "FRANCE",
                            Name = "Water",
                            Price = 5,
                            ProductTypeForeignKey = 4
                        },
                        new
                        {
                            ProductId = 5,
                            Country = "ITALY",
                            Name = "Chair",
                            Price = 260,
                            ProductTypeForeignKey = 5
                        });
                });

            modelBuilder.Entity("ProductsData.Entities.ProductType", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeId"), 1L, 1);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeId");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            TypeId = 1,
                            Type = "Kitchen Utensils"
                        },
                        new
                        {
                            TypeId = 2,
                            Type = "Transportation"
                        },
                        new
                        {
                            TypeId = 3,
                            Type = "Jewlery"
                        },
                        new
                        {
                            TypeId = 4,
                            Type = "Consumables"
                        },
                        new
                        {
                            TypeId = 5,
                            Type = "Furniture"
                        });
                });

            modelBuilder.Entity("ProductsData.Entities.Product", b =>
                {
                    b.HasOne("ProductsData.Entities.ProductType", "ProductType")
                        .WithMany("Products")
                        .HasForeignKey("ProductTypeForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("ProductsData.Entities.ProductType", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}