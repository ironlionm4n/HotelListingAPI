using System.ComponentModel.DataAnnotations;

namespace HotelListingAPI.Models.Country
{
    // Cannot instantiate an object, good for inheritance
    public abstract class BaseCountryDto
    {
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
