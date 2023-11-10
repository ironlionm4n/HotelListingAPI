using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListingAPI.Data;

// Defining a table called Hotel (Entity models a table)
public class Hotel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address {  get; set; }
    public double Rating  { get; set; }

    [ForeignKey(nameof(CountryId))] // Strongly type the name of the foreign key to the property CountryId
    public int CountryId {  get; set; } // foreign key to a table called Country
    public Country Country { get; set; }
}
