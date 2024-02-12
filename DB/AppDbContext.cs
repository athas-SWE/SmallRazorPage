using Microsoft.EntityFrameworkCore;
using Razor_pages1.Models;

namespace Razor_pages1.DB
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<Product> Products { get; set; }
    }
}
