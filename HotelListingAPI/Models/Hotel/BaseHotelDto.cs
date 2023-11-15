using System.ComponentModel.DataAnnotations;

namespace HotelListingAPI.Models.Hotel
{
    public class BaseHotelDto
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Address { get; set; }
        
        // Nullable
        public double? Rating { get; set; }
        
        [Required]
        [Range(1, int.MaxValue)]
        public int CountryId { get; set; } // Foreign Key
    }
}
