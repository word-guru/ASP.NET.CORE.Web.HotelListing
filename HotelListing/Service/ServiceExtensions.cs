using HotelListing.Data;
using HotelListing.Data.DBContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace HotelListing.Service
{
    public static class ServiceExtensions
    {
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var bulder = services.AddIdentityCore<ApiUser>(q => q.User.RequireUniqueEmail = true);
            bulder = new IdentityBuilder(bulder.UserType, typeof(IdentityRole), services);
            bulder.AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
        }
    }
}
