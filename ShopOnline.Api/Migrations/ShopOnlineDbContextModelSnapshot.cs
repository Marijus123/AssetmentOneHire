﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopOnline.Api.Data;

#nullable disable

namespace ShopOnline.Api.Migrations
{
    [DbContext(typeof(ShopOnlineDbContext))]
    partial class ShopOnlineDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShopOnline.Api.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            Description = "Air Pods - in-ear wireless headphones",
                            ImageURL = "/Images/Electronic/Electronics1.png",
                            Name = "Air Pods",
                            Price = 100m,
                            Qty = 120
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "On-ear Golden Headphones - these headphones are not wireless",
                            ImageURL = "/Images/Electronic/Electronics2.png",
                            Name = "On-ear Golden Headphones",
                            Price = 40m,
                            Qty = 200
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Description = "On-ear Black Headphones - these headphones are not wireless",
                            ImageURL = "/Images/Electronic/Electronics3.png",
                            Name = "On-ear Black Headphones",
                            Price = 40m,
                            Qty = 300
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod",
                            ImageURL = "/Images/Electronic/Electronic4.png",
                            Name = "Sennheiser Digital Camera with Tripod",
                            Price = 600m,
                            Qty = 20
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Very comfortable black leather office chair",
                            ImageURL = "/Images/Furniture/Furniture1.png",
                            Name = "Black Leather Office Chair",
                            Price = 50m,
                            Qty = 212
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Description = "Very comfortable pink leather office chair",
                            ImageURL = "/Images/Furniture/Furniture2.png",
                            Name = "Pink Leather Office Chair",
                            Price = 50m,
                            Qty = 112
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            Description = "Very comfortable lounge chair",
                            ImageURL = "/Images/Furniture/Furniture3.png",
                            Name = "Lounge Chair",
                            Price = 70m,
                            Qty = 90
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 1,
                            Description = "Very comfortable Silver lounge chair",
                            ImageURL = "/Images/Furniture/Furniture4.png",
                            Name = "Silver Lounge Chair",
                            Price = 120m,
                            Qty = 95
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("IconCSS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IconCSS = "fas fa-couch",
                            Name = "Furniture"
                        },
                        new
                        {
                            Id = 2,
                            IconCSS = "fas fa-headphones",
                            Name = "Electronics"
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserName = "Marijus"
                        },
                        new
                        {
                            Id = 2,
                            UserName = "Sarah"
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.Product", b =>
                {
                    b.HasOne("ShopOnline.Api.Entities.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
