using Microsoft.EntityFrameworkCore;
using ProductsAPI.Models;

namespace ProductsAPI.Context
{
	public class ProductContext :DbContext
	{
		public ProductContext(DbContextOptions<ProductContext> options) : base(options) {}


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Product>().HasData(new Product { ProductId = 1, ProductName = "Iphone 14", Price = 30000, IsActive = true });
			modelBuilder.Entity<Product>().HasData(new Product { ProductId = 2, ProductName = "Iphone 15", Price = 40000, IsActive = true });
			modelBuilder.Entity<Product>().HasData(new Product { ProductId = 3, ProductName = "Iphone 16", Price = 50000, IsActive = false });
			modelBuilder.Entity<Product>().HasData(new Product { ProductId = 4, ProductName = "Iphone 17", Price = 60000, IsActive = true });
		}

		public DbSet<Product> Products { get; set; }
	}
}
