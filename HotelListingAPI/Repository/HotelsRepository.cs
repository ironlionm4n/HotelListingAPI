using HotelListingAPI.Contracts;
using HotelListingAPI.Data;

namespace HotelListingAPI.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        private HotelListingDbContext _context;

        public HotelsRepository(HotelListingDbContext hotelListingDbContext) : base(hotelListingDbContext)
        {
            _context = hotelListingDbContext;
        }
    }
}
