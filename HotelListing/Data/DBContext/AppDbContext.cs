using HotelListing.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data.DBContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options): base(options) { }
        
        public DbSet<Country> Countrys { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        
    }
}
