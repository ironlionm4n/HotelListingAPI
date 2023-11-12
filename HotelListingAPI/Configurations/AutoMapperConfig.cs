using AutoMapper;
using HotelListingAPI.Data;
using HotelListingAPI.Models.Country;

namespace HotelListingAPI.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();    
        }
    }
}
