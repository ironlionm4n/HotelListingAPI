using Microsoft.EntityFrameworkCore;
namespace HotelListingAPI.Data;

// Contract between the application and the database
public class HotelListingDbContext : DbContext
{
    
    public HotelListingDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {

    }

    public DbSet<Hotel> Hotels {  get; set; }
    public DbSet<Country> Countries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Country>().HasData(
            new Country
            {
                Id = 1,
                Name = "United States",
                ShortName = "USA",
            },
            new Country
            {
                Id = 2,
                Name = "Brazil",
                ShortName = "BR"
            },
            new Country
            {
                Id = 3,
                Name = "Canada",
                ShortName = "CA"
            }
            );

        modelBuilder.Entity<Hotel>().HasData(
            new Hotel
            {
                Id = 1,
                Name = "Holiday Inn",
                Address = "123 Fake Address",
                CountryId = 1,
                Rating = 4.25
            },
            new Hotel
            {
                Id = 2,
                Name = "Motel 8",
                Address = "321 Fake Address",
                CountryId = 1,
                Rating = 3.5
            },
            new Hotel
            {
                Id = 3,
                Name = "Hotel de Brazil",
                Address = "111 Fake Address",
                CountryId = 2,
                Rating = 4.7
            },
            new Hotel
            {
                Id = 4,
                Name = "Wyndam",
                Address = "345 Fake Address",
                CountryId = 3,
                Rating = 3.33
            }
            );
    }
}