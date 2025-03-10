﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopOnline.Api.Context;

#nullable disable

namespace ShopOnline.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240802022522_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
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

                    b.HasIndex("UserId")
                        .IsUnique();

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

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.Category", b =>
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
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IconCSS = "fas fa-spa",
                            Name = "Beauty"
                        },
                        new
                        {
                            Id = 2,
                            IconCSS = "fas fa-couch",
                            Name = "Furniture"
                        },
                        new
                        {
                            Id = 3,
                            IconCSS = "fas fa-headphones",
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 4,
                            IconCSS = "fas fa-shoe-prints",
                            Name = "Footwear"
                        });
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
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "A kit provided by Natura, containing skincare products",
                            ImageUrl = "/Imagens/Beleza/Beleza1.png",
                            Name = "Glossier - Beauty Kit",
                            Price = 100m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "A kit provided by Curology, containing skincare products",
                            ImageUrl = "/Imagens/Beleza/Beleza2.png",
                            Name = "Curology - Skin Care Kit",
                            Price = 50m,
                            Qty = 45
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "A kit provided by Glossier, containing skincare products",
                            ImageUrl = "/Imagens/Beleza/Beleza3.png",
                            Name = "Organic Coconut Oil",
                            Price = 20m,
                            Qty = 30
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "A kit provided by Curology, containing skincare products",
                            ImageUrl = "/Imagens/Beleza/Beleza4.png",
                            Name = "Schwarzkopf - Skin and Hair Care Kit",
                            Price = 50m,
                            Qty = 60
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Skin care kit, containing skincare and haircare products",
                            ImageUrl = "/Imagens/Beleza/Beleza5.png",
                            Name = "Skin Care Kit",
                            Price = 30m,
                            Qty = 85
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Description = "Air Pods - wireless in-ear earbuds",
                            ImageUrl = "/Imagens/Eletronicos/eletronico1.png",
                            Name = "Earbuds",
                            Price = 100m,
                            Qty = 120
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "Golden over-ear headphones - these headphones are not wireless",
                            ImageUrl = "/Imagens/Eletronicos/eletronico2.png",
                            Name = "Golden Headphones",
                            Price = 40m,
                            Qty = 200
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "Black over-ear headphones - these headphones are not wireless",
                            ImageUrl = "/Imagens/Eletronicos/eletronico3.png",
                            Name = "Black Headphones",
                            Price = 40m,
                            Qty = 300
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Description = "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod",
                            ImageUrl = "/Imagens/Eletronicos/eletronico4.png",
                            Name = "Sennheiser Digital Camera with Tripod",
                            Price = 600m,
                            Qty = 20
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Description = "Canon Digital Camera - High quality digital camera provided by Canon",
                            ImageUrl = "/Imagens/Eletronicos/eletronico5.png",
                            Name = "Canon Digital Camera",
                            Price = 500m,
                            Qty = 15
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = "Gameboy - Provided by Nintendo",
                            ImageUrl = "/Imagens/Eletronicos/tecnologia6.png",
                            Name = "Nintendo Gameboy",
                            Price = 100m,
                            Qty = 60
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Description = "Very comfortable black leather office chair",
                            ImageUrl = "/Imagens/Moveis/moveis1.png",
                            Name = "Black Leather Office Chair",
                            Price = 50m,
                            Qty = 212
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Description = "Very comfortable pink leather office chair",
                            ImageUrl = "/Imagens/Moveis/moveis2.png",
                            Name = "Pink Leather Office Chair",
                            Price = 50m,
                            Qty = 112
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 2,
                            Description = "Very comfortable recliner chair",
                            ImageUrl = "/Imagens/Moveis/moveis3.png",
                            Name = "Recliner Chair",
                            Price = 70m,
                            Qty = 90
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 2,
                            Description = "Very comfortable silver lounge chair",
                            ImageUrl = "/Imagens/Moveis/moveis4.png",
                            Name = "Silver Lounge Chair",
                            Price = 120m,
                            Qty = 95
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 2,
                            Description = "White and blue porcelain table lamp",
                            ImageUrl = "/Imagens/Moveis/moveis6.png",
                            Name = "Porcelain Table Lamp",
                            Price = 15m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 2,
                            Description = "Office table lamp",
                            ImageUrl = "/Imagens/Moveis/moveis7.png",
                            Name = "Office Table Lamp",
                            Price = 20m,
                            Qty = 73
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 4,
                            Description = "Comfortable Puma sneakers in most sizes",
                            ImageUrl = "/Imagens/Calcados/calcado1.png",
                            Name = "Puma Sneakers",
                            Price = 100m,
                            Qty = 50
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            Description = "Colorful sneakers - available in most sizes",
                            ImageUrl = "/Imagens/Calcados/calcado2.png",
                            Name = "Colorful Sneakers",
                            Price = 150m,
                            Qty = 60
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            Description = "Blue Nike sneakers - available in most sizes",
                            ImageUrl = "/Imagens/Calcados/calcado3.png",
                            Name = "Blue Nike Sneakers",
                            Price = 200m,
                            Qty = 70
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 4,
                            Description = "Colorful Hummel trainers - available in most sizes",
                            ImageUrl = "/Imagens/Calcados/calcado4.png",
                            Name = "Colorful Hummel Trainers",
                            Price = 120m,
                            Qty = 120
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 4,
                            Description = "Red Nike sneakers - available in most sizes",
                            ImageUrl = "/Imagens/Calcados/calcado5.png",
                            Name = "Red Nike Sneakers",
                            Price = 200m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 4,
                            Description = "Birkenstock sandals - available in most sizes",
                            ImageUrl = "/Imagens/Calcados/calcado6.png",
                            Name = "Birkenstock Sandals",
                            Price = 50m,
                            Qty = 150
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Macoratti"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Janice"
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.Cart", b =>
                {
                    b.HasOne("ShopOnline.Api.Entities.User", null)
                        .WithOne("Cart")
                        .HasForeignKey("ShopOnline.Api.Entities.Cart", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.CartItem", b =>
                {
                    b.HasOne("ShopOnline.Api.Entities.Cart", "Cart")
                        .WithMany("Items")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopOnline.Api.Entities.Product", "Product")
                        .WithMany("Items")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.Product", b =>
                {
                    b.HasOne("ShopOnline.Api.Entities.Category", "Category")
                        .WithMany("Procuts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.Cart", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.Category", b =>
                {
                    b.Navigation("Procuts");
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.Product", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.User", b =>
                {
                    b.Navigation("Cart")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
