using airbnb_clone_BE.Shared;
using System.ComponentModel.DataAnnotations;

namespace airbnb_clone_BE.Data.Entity
{
    public class Palace
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? AddressLine { get; set; }
        public PalaceTypeEnum? PalaceType { get; set; }
        public AccommodationTypeEnum? AccommodationType { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
        public Guid? UserId { get; set; }
    }
}
