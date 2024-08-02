using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Entities;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;

namespace ShopOnline.Api.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Cart>? Carts { get; set; }
        public DbSet<CartItem>? CartItems { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<User>? Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Products
            //Beauty Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Glossier - Beauty Kit",
                Description = "A kit provided by Natura, containing skincare products",
                ImageUrl = "/Imagens/Beleza/Beleza1.png",
                Price = 100,
                Qty = 100,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Curology - Skin Care Kit",
                Description = "A kit provided by Curology, containing skincare products",
                ImageUrl = "/Imagens/Beleza/Beleza2.png",
                Price = 50,
                Qty = 45,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Organic Coconut Oil",
                Description = "A kit provided by Glossier, containing skincare products",
                ImageUrl = "/Imagens/Beleza/Beleza3.png",
                Price = 20,
                Qty = 30,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Schwarzkopf - Skin and Hair Care Kit",
                Description = "A kit provided by Curology, containing skincare products",
                ImageUrl = "/Imagens/Beleza/Beleza4.png",
                Price = 50,
                Qty = 60,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Skin Care Kit",
                Description = "Skin care kit, containing skincare and haircare products",
                ImageUrl = "/Imagens/Beleza/Beleza5.png",
                Price = 30,
                Qty = 85,
                CategoryId = 1

            });
            //electronics Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Earbuds",
                Description = "Air Pods - wireless in-ear earbuds",
                ImageUrl = "/Imagens/Eletronicos/eletronico1.png",
                Price = 100,
                Qty = 120,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Golden Headphones",
                Description = "Golden over-ear headphones - these headphones are not wireless",
                ImageUrl = "/Imagens/Eletronicos/eletronico2.png",
                Price = 40,
                Qty = 200,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Black Headphones",
                Description = "Black over-ear headphones - these headphones are not wireless",
                ImageUrl = "/Imagens/Eletronicos/eletronico3.png",
                Price = 40,
                Qty = 300,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Sennheiser Digital Camera with Tripod",
                Description = "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod",
                ImageUrl = "/Imagens/Eletronicos/eletronico4.png",
                Price = 600,
                Qty = 20,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Canon Digital Camera",
                Description = "Canon Digital Camera - High quality digital camera provided by Canon",
                ImageUrl = "/Imagens/Eletronicos/eletronico5.png",
                Price = 500,
                Qty = 15,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Nintendo Gameboy",
                Description = "Gameboy - Provided by Nintendo",
                ImageUrl = "/Imagens/Eletronicos/tecnologia6.png",
                Price = 100,
                Qty = 60,
                CategoryId = 3
            });
            //Furniture Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Black Leather Office Chair",
                Description = "Very comfortable black leather office chair",
                ImageUrl = "/Imagens/Moveis/moveis1.png",
                Price = 50,
                Qty = 212,
                CategoryId = 2
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Pink Leather Office Chair",
                Description = "Very comfortable pink leather office chair",
                ImageUrl = "/Imagens/Moveis/moveis2.png",
                Price = 50,
                Qty = 112,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "Recliner Chair",
                Description = "Very comfortable recliner chair",
                ImageUrl = "/Imagens/Moveis/moveis3.png",
                Price = 70,
                Qty = 90,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "Silver Lounge Chair",
                Description = "Very comfortable silver lounge chair",
                ImageUrl = "/Imagens/Moveis/moveis4.png",
                Price = 120,
                Qty = 95,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "Porcelain Table Lamp",
                Description = "White and blue porcelain table lamp",
                ImageUrl = "/Imagens/Moveis/moveis6.png",
                Price = 15,
                Qty = 100,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 17,
                Name = "Office Table Lamp",
                Description = "Office table lamp",
                ImageUrl = "/Imagens/Moveis/moveis7.png",
                Price = 20,
                Qty = 73,
                CategoryId = 2
            });
            //Footwear Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 18,
                Name = "Puma Sneakers",
                Description = "Comfortable Puma sneakers in most sizes",
                ImageUrl = "/Imagens/Calcados/calcado1.png",
                Price = 100,
                Qty = 50,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 19,
                Name = "Colorful Sneakers",
                Description = "Colorful sneakers - available in most sizes",
                ImageUrl = "/Imagens/Calcados/calcado2.png",
                Price = 150,
                Qty = 60,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 20,
                Name = "Blue Nike Sneakers",
                Description = "Blue Nike sneakers - available in most sizes",
                ImageUrl = "/Imagens/Calcados/calcado3.png",
                Price = 200,
                Qty = 70,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 21,
                Name = "Colorful Hummel Trainers",
                Description = "Colorful Hummel trainers - available in most sizes",
                ImageUrl = "/Imagens/Calcados/calcado4.png",
                Price = 120,
                Qty = 120,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 22,
                Name = "Red Nike Sneakers",
                Description = "Red Nike sneakers - available in most sizes",
                ImageUrl = "/Imagens/Calcados/calcado5.png",
                Price = 200,
                Qty = 100,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 23,
                Name = "Birkenstock Sandals",
                Description = "Birkenstock sandals - available in most sizes",
                ImageUrl = "/Imagens/Calcados/calcado6.png",
                Price = 50,
                Qty = 150,
                CategoryId = 4
            });

            //Add users
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Name = "Macoratti"

            });


            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                Name = "Janice"

            });

            //Create Shopping Cart for Users
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserId = 1

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserId = 2

            });
            //Add Product Categories
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 1,
                Name = "Beauty",
                IconCSS = "fas fa-spa"
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 2,
                Name = "Furniture",
                IconCSS = "fas fa-couch"
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 3,
                Name = "Electronics",
                IconCSS = "fas fa-headphones"
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 4,
                Name = "Footwear",
                IconCSS = "fas fa-shoe-prints"
            });
        }
    }
}
