

using Ecommerce.Domain.Entities;
using Ecommerce.Infrastracture.Seeds;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Ecommerce.Infrastructure
{
    public class EcommerceDBContext : DbContext
    {       
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Currency> Currencies { get; set; } = default!;       
        public DbSet<Utility> Utilities { get; set; } = default!;
        public DbSet<Property> Properties { get; set; } = default!;        
        public DbSet<PropertyDetail> PropertyDetails { get; set; } = default!;
        public DbSet<PropertyUtility> PropertyUtilities { get; set; } = default!;
        public DbSet<User> Users { get; set; } = default!;
        public DbSet<UserFavorite> UserFavorites { get; set; } = default!;
        public DbSet<Address> Addresses { get; set; } = default!;
        public DbSet<Locality> Localities { get; set; } = default!;
        public DbSet<District> Districts { get; set; } = default!;

        public EcommerceDBContext(DbContextOptions<EcommerceDBContext> options) :
            base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.Restrict;

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            SeedCurrencies.Seed(modelBuilder);
            SeedDistricts.Seed(modelBuilder);
            SeedLocalities.Seed(modelBuilder);
            SeedUtilities.Seed(modelBuilder);
        }     
    }
}
