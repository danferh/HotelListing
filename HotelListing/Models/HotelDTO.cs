using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Models
{
    public class CreateHotelDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Hotel name too long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "Hotel address too long")]
        public string Address { get; set; }
        [Required]
        [Range(1, 5)]
        public decimal Rating { get; set; }
        [Required]
        public int CountryId { get; set; }
    }

    public class HotelDTO: CreateHotelDTO
    {
        public int Id { get; set; }
        public CountryDTO Country { get; set; }
    }
}
