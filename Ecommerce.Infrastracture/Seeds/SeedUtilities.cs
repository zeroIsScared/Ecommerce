

using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastracture.Seeds
{
    public static class SeedUtilities
    {
        private static readonly List<Utility> Utilities = new()
        {
            new Utility { Id = 1, Name = "Ready for entry", ForAppartment = true, ForHouse = true },
            new Utility { Id = 2, Name = "Furnished", ForAppartment = true, ForHouse = true },
            new Utility { Id = 3, Name = "Air conditioning", ForAppartment = true, ForHouse = true },
            new Utility { Id = 4, Name = "Internet", ForAppartment = true, ForHouse = true },
            new Utility { Id = 5, Name = "Video surveillance", ForAppartment = true, ForHouse = true },
            new Utility { Id = 6, Name = "Autonomous heating", ForAppartment = true, ForHouse = true },
            new Utility { Id = 7, Name = "Double-glazed windows", ForAppartment = true, ForHouse = true },
            new Utility { Id = 8, Name = "Sauna", ForHouse = true },
            new Utility { Id = 9, Name = "Swimming pool", ForHouse = true },
            new Utility { Id = 10, Name = "Elevator", ForAppartment = true },
            new Utility { Id = 11, Name = "Gas", ForHouse = true, ForLand = true },
            new Utility { Id = 12, Name = "Electricity", ForHouse = true, ForLand = true },
            new Utility { Id = 13, Name = "Water", ForHouse = true, ForLand = true },
            new Utility { Id = 14, Name = "Sewerage", ForHouse = true, ForLand = true },
            new Utility { Id = 15, Name = "Asphalt road", ForHouse = true, ForLand = true }
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Utility>().HasData(Utilities);
        }
    }
}
