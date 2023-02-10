using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.Data.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Addres { get; set; }
        public double Rating { get; set; }
        [ForeignKey(nameof(Country))]
        public Country Country { get; set; }
        public int CountryId { get; set; }
    }
}
