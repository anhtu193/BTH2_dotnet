using BTH2_21521823_LyThanhTuAnh.Models;
using Microsoft.EntityFrameworkCore;

namespace BTH2_21521823_LyThanhTuAnh.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
