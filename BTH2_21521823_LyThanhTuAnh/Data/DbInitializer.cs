using BTH2_21521823_LyThanhTuAnh.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace BTH2_21521823_LyThanhTuAnh.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any categories.
                if (context.Categories.Any())
                {
                    return;   // DB has been seeded
                }

                var categories = new Category[]
                {
                    new Category{CategoryName="Electronics", Description="Electronic items"},
                    new Category{CategoryName="Books", Description="Various kinds of books"},
                    new Category{CategoryName="Clothing", Description="Men and Women clothing"}
                };

                foreach (var c in categories)
                {
                    context.Categories.Add(c);
                }
                context.SaveChanges();

                var products = new Product[]
                {
                    new Product{ProductName="Laptop", Description="High performance laptop", Price=1200.00M, StockQuantity=10, CategoryID=1, ImageURL="laptop.jpg"},
                    new Product{ProductName="Smartphone", Description="Latest model smartphone", Price=800.00M, StockQuantity=20, CategoryID=1, ImageURL="smartphone.jpg"},
                    new Product{ProductName="Novel", Description="Bestselling novel", Price=15.00M, StockQuantity=50, CategoryID=2, ImageURL="novel.jpg"},
                    new Product{ProductName="T-Shirt", Description="Comfortable cotton t-shirt", Price=20.00M, StockQuantity=100, CategoryID=3, ImageURL="tshirt.jpg"}
                };

                foreach (var p in products)
                {
                    context.Products.Add(p);
                }
                context.SaveChanges();
            }
        }
    }
}
