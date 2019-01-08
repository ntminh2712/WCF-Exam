using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CurrencyChange.Models
{
    public class CurrencyChangeContext : DbContext
    {
        public CurrencyChangeContext (DbContextOptions<CurrencyChangeContext> options)
            : base(options)
        {
        }

        public DbSet<CurrencyChange.Models.Currency> Currency { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().HasData(
                new Currency { Id = "USD", Ratio = 23260 },
                new Currency { Id = "EUR", Ratio = 27061 },
                new Currency { Id = "AUD", Ratio = 16798 },
                new Currency { Id = "JPY", Ratio = 20704 }
            );
        }
    }
}
