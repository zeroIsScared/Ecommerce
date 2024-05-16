

using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastracture.Seeds
{
    public static class SeedLocalities
    {
        private static readonly List<Locality> Localities = new()
        {
           new Locality { Id = 1, Name = "Băcioi", DistrictId = 1 },
            new Locality { Id = 2, Name = "Bîc", DistrictId = 1 },
            new Locality { Id = 3, Name = "Brăila", DistrictId = 1 },
            new Locality { Id = 4, Name = "Bubuieci", DistrictId = 1 },
            new Locality { Id = 5, Name = "Budești", DistrictId = 1 },
            new Locality { Id = 6, Name = "Buneți", DistrictId = 1 },
            new Locality { Id = 7, Name = "Ceroborta", DistrictId = 1 },
            new Locality { Id = 8, Name = "Cheltuitori", DistrictId = 1 },
            new Locality { Id = 9, Name = "Chișinău", DistrictId = 1 },
            new Locality { Id = 10, Name = "Ciorescu", DistrictId = 1 },
            new Locality { Id = 11, Name = "Codru", DistrictId = 1 },
            new Locality { Id = 12, Name = "Colonița", DistrictId = 1 },
            new Locality { Id = 13, Name = "Condrița", DistrictId = 1 },
            new Locality { Id = 14, Name = "Cricova", DistrictId = 1 },
            new Locality { Id = 15, Name = "Cruzești", DistrictId = 1 },
            new Locality { Id = 16, Name = "Dobrogea", DistrictId = 1 },
            new Locality { Id = 17, Name = "Dumbrava", DistrictId = 1 },
            new Locality { Id = 18, Name = "Durlești", DistrictId = 1 },
            new Locality { Id = 19, Name = "Făurești", DistrictId = 1 },
            new Locality { Id = 20, Name = "Frumușica", DistrictId = 1 },
            new Locality { Id = 21, Name = "Ghidighici", DistrictId = 1 },
            new Locality { Id = 22, Name = "Goian", DistrictId = 1 },
            new Locality { Id = 23, Name = "Goianul Nou", DistrictId = 1 },
            new Locality { Id = 24, Name = "Grătiești", DistrictId = 1 },
            new Locality { Id = 25, Name = "Hulboaca", DistrictId = 1 },
            new Locality { Id = 26, Name = "Humulești", DistrictId = 1 },
            new Locality { Id = 27, Name = "Revaca", DistrictId = 1 },
            new Locality { Id = 28, Name = "Stăuceni", DistrictId = 1 },
            new Locality { Id = 29, Name = "Străisteni", DistrictId = 1 },
            new Locality { Id = 30, Name = "Sîngera", DistrictId = 1 },
            new Locality { Id = 31, Name = "Tohatin", DistrictId = 1 },
            new Locality { Id = 32, Name = "Trușeni", DistrictId = 1 },
            new Locality { Id = 33, Name = "Vadul lui Vodă", DistrictId = 1 },
            new Locality { Id = 34, Name = "Vatra", DistrictId = 1 },
            new Locality { Id = 35, Name = "Văduleni", DistrictId = 1 },
            new Locality { Id = 36, Name = "Bălți", DistrictId = 2 },
            new Locality { Id = 37, Name = "Elizaveta", DistrictId = 2 },
            new Locality { Id = 38, Name = "Sadovoe", DistrictId = 2 },
            new Locality { Id = 39, Name = "Bender", DistrictId = 3 },
            new Locality { Id = 40, Name = "Proteagailovca", DistrictId = 3 },
            new Locality { Id = 41, Name = "Albinița", DistrictId = 4 },
            new Locality { Id = 42, Name = "Anenii Noi", DistrictId = 4 },
            new Locality { Id = 43, Name = "Balmaz", DistrictId = 4 },
            new Locality { Id = 44, Name = "Batîc", DistrictId = 4 },
            new Locality { Id = 45, Name = "Beriozchi", DistrictId = 4 },
            new Locality { Id = 46, Name = "Botnărești", DistrictId = 4 },
            new Locality { Id = 47, Name = "Botnăreștii Noi", DistrictId = 4 },
            new Locality { Id = 48, Name = "Bulboaca", DistrictId = 4 },
            new Locality { Id = 49, Name = "Calfa", DistrictId = 4 },
            new Locality { Id = 50, Name = "Calfa Nouă", DistrictId = 4 },
            new Locality { Id = 51, Name = "Chetrosu", DistrictId = 4 },
            new Locality { Id = 52, Name = "Chirca", DistrictId = 4 },
            new Locality { Id = 53, Name = "Ciobanovca", DistrictId = 4 },
            new Locality { Id = 54, Name = "Cobusca Nouă", DistrictId = 4 },
            new Locality { Id = 55, Name = "Cobusca Veche", DistrictId = 4 },
            new Locality { Id = 56, Name = "Crețoaia", DistrictId = 4 },
            new Locality { Id = 57, Name = "Delacău", DistrictId = 4 },
            new Locality { Id = 58, Name = "Floreni", DistrictId = 4 },
            new Locality { Id = 59, Name = "Florești", DistrictId = 4 },
            new Locality { Id = 60, Name = "Geamăna", DistrictId = 4 },
            new Locality { Id = 61, Name = "Gura Bîcului", DistrictId = 4 },
            new Locality { Id = 62, Name = "Hîrbovăț", DistrictId = 4 },
            new Locality { Id = 63, Name = "Hîrbovățul Nou", DistrictId = 4 },
            new Locality { Id = 64, Name = "Larga", DistrictId = 4 },
            new Locality { Id = 65, Name = "Maximovca", DistrictId = 4 },
            new Locality { Id = 66, Name = "Mereni", DistrictId = 4 },
            new Locality { Id = 67, Name = "Merenii Noi", DistrictId = 4 },
            new Locality { Id = 68, Name = "Mirnoe", DistrictId = 4 },
            new Locality { Id = 69, Name = "Nicolaevca", DistrictId = 4 },
            new Locality { Id = 70, Name = "Ochiul Roș", DistrictId = 4 },
            new Locality { Id = 71, Name = "Picus", DistrictId = 4 },
            new Locality { Id = 72, Name = "Puhăceni", DistrictId = 4 },
            new Locality { Id = 73, Name = "Roșcani", DistrictId = 4 },
            new Locality { Id = 74, Name = "Ruseni", DistrictId = 4 },
            new Locality { Id = 75, Name = "Salcia", DistrictId = 4 },
            new Locality { Id = 76, Name = "Socoleni", DistrictId = 4 },
            new Locality { Id = 77, Name = "Speia", DistrictId = 4 },
            new Locality { Id = 78, Name = "Șerpeni", DistrictId = 4 },
            new Locality { Id = 79, Name = "Telița", DistrictId = 4 },
            new Locality { Id = 80, Name = "Telița Nouă", DistrictId = 4 },
            new Locality { Id = 81, Name = "Todirești", DistrictId = 4 },
            new Locality { Id = 82, Name = "Troița Nouă", DistrictId = 4 },
            new Locality { Id = 83, Name = "Țînțăreni", DistrictId = 4 },
            new Locality { Id = 84, Name = "Varnița", DistrictId = 4 },
            new Locality { Id = 85, Name = "Zolotievca", DistrictId = 4 }
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Locality>().HasData(Localities);
        }
    }
}
