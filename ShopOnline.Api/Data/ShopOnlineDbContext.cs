using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Entities;

namespace ShopOnline.Api.Data
{
    public class ShopOnlineDbContext:DbContext
    {
        public ShopOnlineDbContext(DbContextOptions<ShopOnlineDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			//Products
			//Electronics Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 1,
				Name = "Air Pods",
				Description = "Air Pods - in-ear wireless headphones",
				ImageURL = "/Images/Electronic/Electronics1.png",
				Price = 100,
				Qty = 120,
				CategoryId = 2

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 2,
				Name = "On-ear Golden Headphones",
				Description = "On-ear Golden Headphones - these headphones are not wireless",
				ImageURL = "/Images/Electronic/Electronics2.png",
				Price = 40,
				Qty = 200,
				CategoryId = 2

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 3,
				Name = "On-ear Black Headphones",
				Description = "On-ear Black Headphones - these headphones are not wireless",
				ImageURL = "/Images/Electronic/Electronics3.png",
				Price = 40,
				Qty = 300,
				CategoryId = 2

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 4,
				Name = "Sennheiser Digital Camera with Tripod",
				Description = "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod",
				ImageURL = "/Images/Electronic/Electronic4.png",
				Price = 600,
				Qty = 20,
				CategoryId = 2

			});

			//Furniture Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 5,
				Name = "Black Leather Office Chair",
				Description = "Very comfortable black leather office chair",
				ImageURL = "/Images/Furniture/Furniture1.png",
				Price = 50,
				Qty = 212,
				CategoryId = 1
			});

			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 6,
				Name = "Pink Leather Office Chair",
				Description = "Very comfortable pink leather office chair",
				ImageURL = "/Images/Furniture/Furniture2.png",
				Price = 50,
				Qty = 112,
				CategoryId = 1
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 7,
				Name = "Lounge Chair",
				Description = "Very comfortable lounge chair",
				ImageURL = "/Images/Furniture/Furniture3.png",
				Price = 70,
				Qty = 90,
				CategoryId = 1
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 8,
				Name = "Silver Lounge Chair",
				Description = "Very comfortable Silver lounge chair",
				ImageURL = "/Images/Furniture/Furniture4.png",
				Price = 120,
				Qty = 95,
				CategoryId = 1
			});

			

			//Add users
			modelBuilder.Entity<User>().HasData(new User
			{
				Id = 1,
				UserName = "Marijus"

			});
			modelBuilder.Entity<User>().HasData(new User
			{
				Id = 2,
				UserName = "Sarah"

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
			
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 1,
				Name = "Furniture",
				IconCSS ="fas fa-couch"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 2,
				Name = "Electronics",
				IconCSS = "fas fa-headphones"
			});


		}

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
