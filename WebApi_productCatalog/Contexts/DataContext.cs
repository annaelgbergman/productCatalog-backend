using Microsoft.EntityFrameworkCore;
using WebApi_productCatalog.Models;

namespace WebApi_productCatalog.Contexts
{
    public class DataContext: DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<ProductModel> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>().ToContainer("Products").HasPartitionKey(x => x.PartionKey);
        }
    }
}
