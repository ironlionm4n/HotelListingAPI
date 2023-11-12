using AutoMapper;
using HotelListingAPI.Models.Hotel;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListingAPI.Models.Country
{
    public class GetCountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
    }

    public class CountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public List<HotelDto> HotelDto { get; set; }
    }
}
