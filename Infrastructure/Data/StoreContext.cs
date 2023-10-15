
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductBrand> productBrands { get; set; }
        public DbSet<ProductType> productTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modeBuilder)
        {
            base.OnModelCreating(modeBuilder);
            modeBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}