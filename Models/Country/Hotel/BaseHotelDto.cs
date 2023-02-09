using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.Country.Model
{
    public abstract class BaseHotelDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        public double? Rating { get; set; }  //If nothing provice by default it will be zero so with question mark it becames Nullable

        [Required]
        [Range(1, int.MaxValue)]
        public int CountryId { get; set; }
    }
}
