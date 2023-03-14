using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data.DBContext
{
    public class AppDbContext : IdentityDbContext<ApiUser>
    {
        public AppDbContext(DbContextOptions options): base(options) { }
        
        public DbSet<Country> Countrys { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "Jamaica", ShortName = "JM" },
                new Country { Id = 2, Name = "Bahamas", ShortName = "BS" },
                new Country { Id = 3, Name = "Cayman Island", ShortName = "CI" }
                );
            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Resort And Spa",
                    Addres = "Negril",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Comfort Suites",
                    Addres = "George Town",
                    CountryId = 3,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Grand Palldium",
                    Addres = "Nassua",
                    CountryId = 2,
                    Rating = 4.8
                }
                );
        }
    }
}
