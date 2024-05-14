
using Ecommerce.Domain.Entities;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastracture.Seeds
{
    public static class SeedCurrencies
    {
        private static readonly List<Currency> Currencies = new ()
        {
            new Currency { Id= 1, Code= "MDL"},
            new Currency { Id = 2, Code = "EUR", Symbol= "€" },
            new Currency { Id = 3, Code = "USD" , Symbol = "$"}
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().HasData(Currencies);
        }
    }
}
