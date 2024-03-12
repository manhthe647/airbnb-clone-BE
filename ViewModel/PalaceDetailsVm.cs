using airbnb_clone_BE.Shared;
using System.ComponentModel.DataAnnotations;

namespace airbnb_clone_BE.ViewModel
{
    public class PalaceDetailsVm
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

        //
        public string AmenityName { get; set; }
        public string? Icon { get; set; }

        // 
        public int? PrivateClosedBathroom { get; set; } 
        public int? PrivateBathroom { get; set; }
        public int? sharedBathroom { get; set; }

        // 
        public int GuestCount { get; set; }
        public int BedCount { get; set; }

        public int BedroomCount { get; set; }
        //

        public bool hasCamera { get; set; }
        public bool hasSecurityStaff { get; set; }

        //
        public PalaceTagEnum? Tag { get; set; }
        //
        public int? Star { get; set; }
        public string? Comment { get; set; }
    }
}
