using AutoMapper;
using HotelListingAPI.Data;
using HotelListingAPI.Models.Country;
using HotelListingAPI.Models.Hotel;

namespace HotelListingAPI.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();    
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();

            CreateMap<Hotel, HotelDto>().ReverseMap();
        }
    }
}
