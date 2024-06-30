using Microsoft.EntityFrameworkCore;
using Shopping.Models;

namespace Shopping.Repository
{
    public class DataContext : DbContext
    {
        public DataContext() 
        {

        }

        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BrandModel> Brands { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ANHPHONGDZ;Initial Catalog=Shop1;Trusted_Connection=True;Trustservercertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
