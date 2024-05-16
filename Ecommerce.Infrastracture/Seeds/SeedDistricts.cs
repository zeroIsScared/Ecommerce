using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Ecommerce.Infrastracture.Seeds
{
    public static class SeedDistricts
    {
        private static readonly List<District> Districts = new()
        {
            new District { Id = 1, Name = "Mun. Chișinău" },
            new District { Id = 2, Name = "Mun. Bălți" },
            new District { Id = 3, Name = "Mun. Bender" },
            new District { Id = 4, Name = "Anenii Noi" },
            new District { Id = 5, Name = "Basarabeasca" },
            new District { Id = 6, Name = "Briceni" },
            new District { Id = 7, Name = "Cahul" },
            new District { Id = 8, Name = "Camenca" },
            new District { Id = 9, Name = "Călărași" },
            new District { Id = 10, Name = "Cantemir" },
            new District { Id = 11, Name = "Căușeni" },
            new District { Id = 12, Name = "Cimișlia" },
            new District { Id = 13, Name = "Criuleni" },
            new District { Id = 14, Name = "Dondușeni" },
            new District { Id = 15, Name = "Drochia" },
            new District { Id = 16, Name = "Dubăsari" },
            new District { Id = 17, Name = "Edineț" },
            new District { Id = 18, Name = "Fălești" },
            new District { Id = 19, Name = "Florești" },
            new District { Id = 20, Name = "Glodeni" },
            new District { Id = 21, Name = "Hîncești" },
            new District { Id = 22, Name = "Ialoveni" },
            new District { Id = 23, Name = "Leova" },
            new District { Id = 24, Name = "Nisporeni" },
            new District { Id = 25, Name = "Ocnița" },
            new District { Id = 26, Name = "Orhei" },
            new District { Id = 27, Name = "Rezina" },
            new District { Id = 28, Name = "Rîșcani" },
            new District { Id = 29, Name = "Sîngerei" },
            new District { Id = 30, Name = "Soroca" },
            new District { Id = 31, Name = "Strășeni" },
            new District { Id = 32, Name = "Șoldănești" },
            new District { Id = 33, Name = "Ștefan Vodă" },
            new District { Id = 34, Name = "Taraclia" },
            new District { Id = 35, Name = "Telenești" },
            new District { Id = 36, Name = "Ungheni" }
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<District>().HasData(Districts);
        }
    }
}
