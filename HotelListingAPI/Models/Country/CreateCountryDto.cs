using System.ComponentModel.DataAnnotations;

namespace HotelListingAPI.Models.Country
{
    // Handles creation requests for Countries
    public class CreateCountryDto
    {
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }
    }


}
