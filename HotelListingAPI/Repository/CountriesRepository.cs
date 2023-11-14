using HotelListingAPI.Contracts;
using HotelListingAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListingAPI.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        HotelListingDbContext _context;
        public CountriesRepository(HotelListingDbContext hotelListingDbContext) : base(hotelListingDbContext)
        {
            _context = hotelListingDbContext;
        }

        public async Task<Country> GetDetails(int id)
        {
            return await _context.Countries.Include(q => q.Hotels)
                .FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}
